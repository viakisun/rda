# Fire-blight detection by RDA
### (neural network for object detection) - Tensor Cores can be used on [Linux](https://github.com/AlexeyAB/darknet#how-to-compile-on-linux) and [Windows](https://github.com/AlexeyAB/darknet#how-to-compile-on-windows-using-vcpkg)

More details: http://pjreddie.com/darknet/yolo/

### Training system
1.  Darknet (Windows/Ubuntu)
    * Training
    * Marking
    * Detecting
    
2.  Alturos Yolo (Windows)
    * Marking
    * Detecting
![Detect](https://github.com/viakisun/rda/blob/master/Tools/Alturos/TestUI.png)
    
### Pre-trained models
1.  Fire blight data
    * fireblight.cfg - bird, blight
    * hd250.weight - trained 1-250
    * hd150.weight - trained 1-150

### Best trained model
1.  Training result
    * mAP(mean Average Precision) = 98.4
![Training chart](https://github.com/viakisun/rda/blob/master/Datas/HD250/2.%20weight/chart.png)

### Done
1.  Training system (RTX2080, Ubuntu)
    * 1000 iterations / 25 mins
    * 45,000 iterations / 18.75 hours
2.  Detection system (Jetson TX2, Ubuntu)
3.  250 HD Datas

### To Do
1.  Marking system (Windows)
2.  Detection system (Windows)
3.  Other training models
4.  Data
    * Training data
    * Drone video data
