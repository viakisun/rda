using Alturos.Yolo.Model;
using Alturos.Yolo.TestUI.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alturos.Yolo.TestUI
{
    public partial class Main : Form
    {
        private YoloWrapper _yoloWrapper;

        FontStyle _fontStyle = FontStyle.Bold;
        private Font _font;

        public Main()
        {
            this.InitializeComponent();

            this.buttonSendImage.Enabled = false;

            this.toolStripStatusLabelYoloInfo.Text = string.Empty;

            this.Text = $"RDA Fireblight detection {Application.ProductVersion}";
            this.dataGridViewFiles.AutoGenerateColumns = false;

            var imageInfos = new DirectoryImageReader().Analyze(@".\Images");
            this.dataGridViewFiles.DataSource = imageInfos.ToList();

            Task.Run(() => this.Initialize("."));
            this.LoadAvailableConfigurations();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._yoloWrapper?.Dispose();
        }

        private void LoadAvailableConfigurations()
        {
            var configPath = "config";

            if (!Directory.Exists(configPath))
            {
                return;
            }

            var configs = Directory.GetDirectories(configPath);
            if (configs.Length == 0)
            {
                return;
            }


            foreach (var config in configs)
            {
                var menuItem = new ToolStripMenuItem();
                menuItem.Text = config;
                menuItem.Click += (object sender, EventArgs e) => { this.Initialize(config); };
            }
        }

        private ImageInfo GetCurrentImage()
        {
            var item = this.dataGridViewFiles.CurrentRow?.DataBoundItem as ImageInfo;
            return item;
        }

        private void dataGridViewFiles_SelectionChanged(object sender, EventArgs e)
        {
            var oldImage = this.pictureBox1.Image;
            var imageInfo = this.GetCurrentImage();           
            this.pictureBox1.Image = Image.FromFile(imageInfo.Path);            
            oldImage?.Dispose();
        }

        private void dataGridViewFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.Detect();
            }
        }

        private void dataGridViewResult_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = this.folderBrowserDialog1.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            var imageInfos = new DirectoryImageReader().Analyze(this.folderBrowserDialog1.SelectedPath);
            this.dataGridViewFiles.DataSource = imageInfos.ToList();
        }

        private void buttonSendImage_Click(object sender, EventArgs e)
        {
            this.Detect();
        }

        private void DrawBorder2Image(List<YoloItem> items, YoloItem selectedItem = null)
        {
            var imageInfo = this.GetCurrentImage();
            //Load the image(probably from your stream)
            var image = Image.FromFile(imageInfo.Path);

            using (var canvas = Graphics.FromImage(image))
            {
                // Modify the image using g here... 
                // Create a brush with an alpha value and use the g.FillRectangle function
                foreach (var item in items)
                {
                    var x = item.X;
                    var y = item.Y;
                    var width = item.Width;
                    var height = item.Height;

                    using (var overlayBrush = new SolidBrush(Color.FromArgb(150, 255, 255, 102)))
                    using (var pen = this.GetBrush(item.Confidence, image.Width))
                    {
                        if (item.Equals(selectedItem))
                        {
                            canvas.FillRectangle(overlayBrush, x, y, width, height);
                        }

                        string conf_value = Math.Floor(item.Confidence * 100).ToString() + "%";
                        System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                        float emSize = 20 * image.Height / 600.0f;
                        _font = new Font("Arial", emSize, _fontStyle);
                        canvas.DrawString(conf_value, _font, drawBrush, x + 10, y + 18);
                        canvas.DrawRectangle(pen, x, y, width, height);
                        canvas.Flush();
                    }
                }
            }

            var oldImage = this.pictureBox1.Image;
            this.pictureBox1.Image = image;
            oldImage?.Dispose();
        }

        private Pen GetBrush(double confidence, int width)
        {
            var size = width / 100;

            if (confidence > 0.5)
            {
                return new Pen(Brushes.GreenYellow, size);
            }
            else if (confidence > 0.2 && confidence <= 0.5)
            {
                return new Pen(Brushes.Orange, size);
            }

            return new Pen(Brushes.DarkRed, size);
        }

        private void Initialize(string path)
        {
            string[] files_name = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly).Where(o => o.EndsWith(".names")).ToArray();
            string[] files_cfg = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly).Where(o => o.EndsWith(".cfg")).ToArray();
            string[] files_weights = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly).Where(o => o.EndsWith(".weights")).ToArray();

            if (files_name.Length == 0)
            {
                MessageBox.Show("Cannot find name file");
                Application.Exit();
                return;
            }

            if (files_cfg.Length == 0)
            {
                MessageBox.Show("Cannot find cfg file");
                Application.Exit();
                return;
            }

            if (files_weights.Length == 0)
            {
                MessageBox.Show("Cannot find weights file");
                Application.Exit();
            }
            comboBox_name.Items.Clear();
            comboBox_name.Items.AddRange(files_name);
            comboBox_name.SelectedIndex = 0;

            comboBox_cfg.Items.Clear();
            comboBox_cfg.Items.AddRange(files_cfg);
            comboBox_cfg.SelectedIndex = 0;

            comboBox_weight.Items.Clear();
            comboBox_weight.Items.AddRange(files_weights);
            comboBox_weight.SelectedIndex = 0;

            InitializeYolo();
        }

        private void InitializeYolo()
        {
            try
            {
                if (this._yoloWrapper != null)
                {
                    this._yoloWrapper.Dispose();
                }

                var sw = new Stopwatch();
                sw.Start();
                this._yoloWrapper = new YoloWrapper(comboBox_cfg.SelectedItem.ToString(),
                    comboBox_weight.SelectedItem.ToString(), comboBox_name.SelectedItem.ToString(), 0);
                sw.Stop();

                var action = new MethodInvoker(delegate ()
                {
                    var detectionSystemDetail = string.Empty;
                    if (!string.IsNullOrEmpty(this._yoloWrapper.EnvironmentReport.GraphicDeviceName))
                    {
                        detectionSystemDetail = $"({this._yoloWrapper.EnvironmentReport.GraphicDeviceName})";
                    }
                    this.toolStripStatusLabelYoloInfo.Text = $"Initialize Yolo in {sw.Elapsed.TotalMilliseconds:0} ms - Detection System:{this._yoloWrapper.DetectionSystem} {detectionSystemDetail}";
                });

                this.statusStrip1.Invoke(action);
                this.buttonSendImage.Invoke(new MethodInvoker(delegate () { this.buttonSendImage.Enabled = true; }));
                this.label_status.Invoke(new MethodInvoker(delegate () { this.label_status.Text = "Ready to detect!"; }));
                this.panel_top.Invoke(new MethodInvoker(delegate () { this.panel_top.BackColor = Color.DarkOliveGreen; }));
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{nameof(Initialize)} - {exception}", "Error Initialize", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void Detect()
        {
            if (this._yoloWrapper == null)
            {
                return;
            }

            var memoryTransfer = true;

            var imageInfo = this.GetCurrentImage();
            var imageData = File.ReadAllBytes(imageInfo.Path);

            var sw = new Stopwatch();
            sw.Start();
            List<YoloItem> items;
            if (memoryTransfer)
            {
                items = this._yoloWrapper.Detect(imageData).ToList();
            }
            else
            {
                items = this._yoloWrapper.Detect(imageInfo.Path).ToList();
            }
            sw.Stop();
            this.DrawBorder2Image(items);
        }

        private void gpuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
