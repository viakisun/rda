namespace Alturos.Yolo.TestUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelYoloInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSendImage = new System.Windows.Forms.Button();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.ColumnHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_cfg = new System.Windows.Forms.ComboBox();
            this.comboBox_name = new System.Windows.Forms.ComboBox();
            this.comboBox_weight = new System.Windows.Forms.ComboBox();
            this.label_status = new System.Windows.Forms.Label();
            this.checkBox_auto = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(261, 52);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(260, 48);
            this.openFolderToolStripMenuItem.Text = "&Open folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelYoloInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1215);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 42, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2547, 54);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelYoloInfo
            // 
            this.toolStripStatusLabelYoloInfo.Name = "toolStripStatusLabelYoloInfo";
            this.toolStripStatusLabelYoloInfo.Size = new System.Drawing.Size(237, 41);
            this.toolStripStatusLabelYoloInfo.Text = "change by code";
            // 
            // buttonSendImage
            // 
            this.buttonSendImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendImage.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonSendImage.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendImage.ForeColor = System.Drawing.Color.White;
            this.buttonSendImage.Location = new System.Drawing.Point(2171, 14);
            this.buttonSendImage.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.buttonSendImage.Name = "buttonSendImage";
            this.buttonSendImage.Size = new System.Drawing.Size(363, 77);
            this.buttonSendImage.TabIndex = 0;
            this.buttonSendImage.Text = "Process Image";
            this.buttonSendImage.UseVisualStyleBackColor = false;
            this.buttonSendImage.Click += new System.EventHandler(this.buttonSendImage_Click);
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowUserToAddRows = false;
            this.dataGridViewFiles.AllowUserToDeleteRows = false;
            this.dataGridViewFiles.AllowUserToResizeColumns = false;
            this.dataGridViewFiles.AllowUserToResizeRows = false;
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFileName,
            this.ColumnWidth,
            this.ColumnHeight});
            this.dataGridViewFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFiles.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFiles.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.dataGridViewFiles.MultiSelect = false;
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.ReadOnly = true;
            this.dataGridViewFiles.RowHeadersVisible = false;
            this.dataGridViewFiles.RowHeadersWidth = 102;
            this.dataGridViewFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFiles.Size = new System.Drawing.Size(619, 1115);
            this.dataGridViewFiles.TabIndex = 3;
            this.dataGridViewFiles.SelectionChanged += new System.EventHandler(this.dataGridViewFiles_SelectionChanged);
            this.dataGridViewFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewFiles_KeyDown);
            // 
            // ColumnHeight
            // 
            this.ColumnHeight.DataPropertyName = "Height";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnHeight.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnHeight.HeaderText = "Height";
            this.ColumnHeight.MinimumWidth = 12;
            this.ColumnHeight.Name = "ColumnHeight";
            this.ColumnHeight.ReadOnly = true;
            this.ColumnHeight.Width = 70;
            // 
            // ColumnWidth
            // 
            this.ColumnWidth.DataPropertyName = "Width";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnWidth.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnWidth.HeaderText = "Width";
            this.ColumnWidth.MinimumWidth = 12;
            this.ColumnWidth.Name = "ColumnWidth";
            this.ColumnWidth.ReadOnly = true;
            this.ColumnWidth.Width = 70;
            // 
            // ColumnFileName
            // 
            this.ColumnFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFileName.DataPropertyName = "Name";
            this.ColumnFileName.HeaderText = "FileName";
            this.ColumnFileName.MinimumWidth = 12;
            this.ColumnFileName.Name = "ColumnFileName";
            this.ColumnFileName.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1888, 1075);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Black;
            this.panel_top.Controls.Add(this.checkBox_auto);
            this.panel_top.Controls.Add(this.label_status);
            this.panel_top.Controls.Add(this.comboBox_weight);
            this.panel_top.Controls.Add(this.comboBox_name);
            this.panel_top.Controls.Add(this.comboBox_cfg);
            this.panel_top.Controls.Add(this.buttonSendImage);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(2547, 100);
            this.panel_top.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewFiles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1928, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 1115);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1928, 1115);
            this.panel2.TabIndex = 9;
            // 
            // comboBox_cfg
            // 
            this.comboBox_cfg.Font = new System.Drawing.Font("Arial", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cfg.FormattingEnabled = true;
            this.comboBox_cfg.Items.AddRange(new object[] {
            "FireBlight.cfg"});
            this.comboBox_cfg.Location = new System.Drawing.Point(53, 27);
            this.comboBox_cfg.Name = "comboBox_cfg";
            this.comboBox_cfg.Size = new System.Drawing.Size(464, 50);
            this.comboBox_cfg.TabIndex = 1;
            // 
            // comboBox_name
            // 
            this.comboBox_name.Font = new System.Drawing.Font("Arial", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_name.FormattingEnabled = true;
            this.comboBox_name.Items.AddRange(new object[] {
            "FireBlight.cfg"});
            this.comboBox_name.Location = new System.Drawing.Point(546, 27);
            this.comboBox_name.Name = "comboBox_name";
            this.comboBox_name.Size = new System.Drawing.Size(466, 50);
            this.comboBox_name.TabIndex = 2;
            // 
            // comboBox_weight
            // 
            this.comboBox_weight.Font = new System.Drawing.Font("Arial", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_weight.FormattingEnabled = true;
            this.comboBox_weight.Items.AddRange(new object[] {
            "FireBlight.cfg"});
            this.comboBox_weight.Location = new System.Drawing.Point(1041, 27);
            this.comboBox_weight.Name = "comboBox_weight";
            this.comboBox_weight.Size = new System.Drawing.Size(474, 50);
            this.comboBox_weight.TabIndex = 3;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.White;
            this.label_status.Location = new System.Drawing.Point(1536, 33);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(161, 39);
            this.label_status.TabIndex = 4;
            this.label_status.Text = "Initialize...";
            // 
            // checkBox_auto
            // 
            this.checkBox_auto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_auto.AutoSize = true;
            this.checkBox_auto.ForeColor = System.Drawing.Color.White;
            this.checkBox_auto.Location = new System.Drawing.Point(1923, 38);
            this.checkBox_auto.Name = "checkBox_auto";
            this.checkBox_auto.Size = new System.Drawing.Size(236, 34);
            this.checkBox_auto.TabIndex = 5;
            this.checkBox_auto.Text = "Auto process";
            this.checkBox_auto.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2547, 1269);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "Main";
            this.Text = "change by code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelYoloInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeight;
        private System.Windows.Forms.Button buttonSendImage;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_cfg;
        private System.Windows.Forms.ComboBox comboBox_weight;
        private System.Windows.Forms.ComboBox comboBox_name;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.CheckBox checkBox_auto;
    }
}

