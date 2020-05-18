using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace OpenCV_Object_and_Pose_Tracking
{
    public partial class MainForm : Form
    {
        SelectedCamera selectedCamera = new SelectedCamera();
        FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        string previewPanelImg;
        string modelPanelImg;

        public MainForm()
        {
            InitializeComponent();
        }

        // This function is called when the form is first loaded
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadInputDevices();
        }

        // This exits the application when the form is closed
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            Environment.Exit(0);
        }

        // Loads names of input devices into dropdown list
        private void loadInputDevices()
        {
            // Loops through each device and adds the name to the device list dropdown box.
            for (int i = 0; i < videoDevices.Count; i++)
            {
                InputDeviceList.Items.Add(videoDevices[i].Name);
            }
        }

        // Connects to the selected camera
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputDeviceList.SelectedIndex < 0) { return; }
                // Create video source
                selectedCamera.videoSource = new VideoCaptureDevice(videoDevices[InputDeviceList.SelectedIndex].MonikerString);
                // Start the video source
                selectedCamera.videoSource.Start();
                // Checks if camera is connected
                if (selectedCamera.videoSource.IsRunning) { ConnectionLbl.ForeColor = Color.Green; ConnectionLbl.Text = "Connection: Connected!"; } else { ConnectionLbl.ForeColor = Color.Red; ConnectionLbl.Text = "Connection: Disconnected"; }

            }
            catch (Exception connectionError)
            {

                throw connectionError;
            }
        }

        // This function connects the camera and sets the selected camera's video source
        public void ConnectToCamera()
        {
            if (previewPanel.IsRunning) { previewPanel.Stop(); previewPanel.SignalToStop(); previewPanel.WaitForStop(); }

            try
            {
                if (InputDeviceList.SelectedIndex >= 0)
                {
                    selectedCamera.videoSource.Stop();
                    // Create video source
                    selectedCamera.videoSource = new VideoCaptureDevice(videoDevices[InputDeviceList.SelectedIndex].MonikerString);
                    // Start the video source
                    selectedCamera.videoSource.Start();
                    previewPanel.VideoSource = selectedCamera.videoSource;
                    previewPanel.Start();
                }
            }
            catch (Exception ConnectToCamError)
            {
                throw ConnectToCamError;
            }
        }

        // Run or stops the preview in the preview panel
        private void RunStopBtn_Click(object sender, EventArgs e)
        {
            if (selectedCamera.videoSource == null) { return; }
            if (!selectedCamera.videoSource.IsRunning) { return; }

            selectedCamera.videoSource.NewFrame -= new NewFrameEventHandler(ShowBounds_NewFrame);

            switch (RunStopBtn.Text)
            {
                case "Run":
                    ConnectToCamera();
                    RunStopBtn.ForeColor = Color.Red;
                    RunStopBtn.Text = "Stop";
                    break;
                case "Stop":
                    RunStopBtn.ForeColor = Color.Black;
                    RunStopBtn.Text = "Run";
                    previewPanel.VideoSource = null;
                    break;
            }
        }

        // This function stops the preview in the preview panel and
        // disconnects the current camera
        private void InputDeviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedCamera.videoSource == null) { return; }
            stopVideoPreview();
            previewPanel.BackgroundImage = null;
            ShowHideBoundsBtn.Text = "Show Bounds";
            selectedCamera.videoSource.SignalToStop();
            ConnectionLbl.ForeColor = Color.Red;
            ConnectionLbl.Text = "Connection: Disconnected";
        }

        // Stops the video preview on the preview panel
        private void stopVideoPreview()
        {
            // Resets the preview panel video source

            previewPanel.VideoSource = null;

            // Reset form back to defaults
            RunStopBtn.ForeColor = Color.Black;
            RunStopBtn.Text = "Run";
        }

        // Captures a single shot from the selected camera
        private void SingleShotBtn_Click(object sender, EventArgs e)
        {
            if (InputDeviceList.SelectedIndex < 0) { return; }
            stopVideoPreview();
            selectedCamera.videoSource.Start();
            selectedCamera.videoSource.NewFrame += new NewFrameEventHandler(SingleShot_NewFrame);
        }

        // Updates the preview panel with the single shot image
        private void SingleShot_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var newFrame = (Bitmap)eventArgs.Frame.Clone();
            this.Invoke(new MethodInvoker(delegate ()
            {
                if (previewPanel.BackgroundImage != null)
                {
                    previewPanel.BackgroundImage.Dispose();
                }
                previewPanel.BackgroundImage = newFrame;
            }));

            selectedCamera.videoSource.NewFrame -= new NewFrameEventHandler(SingleShot_NewFrame);
        }

        // Updates the model Preview Panel with the current model image
        private void ModelPreview_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            int boundsThickness = 2;
            var newFrame = (Bitmap)eventArgs.Frame.Clone();
            Rectangle rect = new Rectangle((newFrame.Width / 2) - ((int)CaptureWidth.Value / 2) - (int)XOffset.Value + boundsThickness, (newFrame.Height / 2) - ((int)CaptureHeight.Value / 2) - (int)YOffset.Value + boundsThickness, (int)CaptureWidth.Value - boundsThickness, (int)CaptureHeight.Value - boundsThickness);
            newFrame = newFrame.Clone(rect, System.Drawing.Imaging.PixelFormat.DontCare);

            this.Invoke(new MethodInvoker(delegate ()
            {
                if (ModelPreview.BackgroundImage != null)
                {
                    ModelPreview.BackgroundImage.Dispose();
                }
                ModelPreview.BackgroundImage = newFrame;
            }));
            selectedCamera.videoSource.NewFrame -= new NewFrameEventHandler(ModelPreview_NewFrame);
        }

        // This calls the function to capture a snapshot of the model
        private void CaptureModelBtn_Click(object sender, EventArgs e)
        {
            if (previewPanel.VideoSource != null) { selectedCamera.videoSource.NewFrame += new NewFrameEventHandler(ModelPreview_NewFrame); }
            else
            {
                Bitmap modelImg = (Bitmap)previewPanel.BackgroundImage.Clone();
                Rectangle rect = new Rectangle((modelImg.Width / 2) - ((int)CaptureWidth.Value / 2) + (int)XOffset.Value, (modelImg.Height / 2) - ((int)CaptureHeight.Value / 2) + (int)YOffset.Value, (int)CaptureWidth.Value, (int)CaptureHeight.Value);
                modelImg = modelImg.Clone(rect, System.Drawing.Imaging.PixelFormat.DontCare);
                ModelPreview.BackgroundImage = modelImg;
            }
        }

        // Updates the model Preview Panel with the current model image
        private void ShowBounds_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var newFrame = (Bitmap)eventArgs.Frame.Clone();
            Rectangle rect = new Rectangle((newFrame.Width / 2) - ((int)CaptureWidth.Value / 2) + (int)XOffset.Value, (newFrame.Height / 2) - ((int)CaptureHeight.Value / 2) + (int)YOffset.Value, (int)CaptureWidth.Value, (int)CaptureHeight.Value);
            Graphics graphic = Graphics.FromImage(newFrame);
            Pen pen = new Pen(Color.Red, 2);

            graphic.DrawRectangle(pen, rect);

            this.Invoke(new MethodInvoker(delegate ()
            {
                if (previewPanel.BackgroundImage != null)
                {
                    previewPanel.BackgroundImage.Dispose();
                }
                previewPanel.BackgroundImage = newFrame;
            }));
        }

        private void ShowHideBoundsBtn_Click(object sender, EventArgs e)
        {

            if (ShowHideBoundsBtn.Text == "Hide Bounds")
            {
                // Hide the bounds
                ShowHideBoundsBtn.Text = "Show Bounds";
                selectedCamera.videoSource.NewFrame -= new NewFrameEventHandler(ShowBounds_NewFrame);
                ConnectToCamera();
            }
            else
            {
                // Show the bounds
                ShowHideBoundsBtn.Text = "Hide Bounds";
                stopVideoPreview();
                selectedCamera.videoSource.NewFrame += new NewFrameEventHandler(ShowBounds_NewFrame);

            }
        }

        private void UpdateModelSizeLbl(object sender, EventArgs e)
        {
            ModelSizeLbl.Text = "Model Size: " + CaptureWidth.Value.ToString() + " x " + CaptureHeight.Value.ToString() + "px";
        }

        private void TrackObject_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            long matchTime = 0;
            float X_center, Y_center;
            float theta;
            Image<Gray, byte> modelImg;
            Image<Gray, byte> observedImg;
            //VectorOfKeyPoint modelKeyPoints = new VectorOfKeyPoint(), observedKeyPoints = new VectorOfKeyPoint();
            //VectorOfVectorOfDMatch matches = new VectorOfVectorOfDMatch();
            //Mat mask = new Mat(), homography = new Mat();

            modelImg = new Image<Gray, byte>((Bitmap)ModelPreview.BackgroundImage);
            observedImg = new Image<Gray, byte>((Bitmap)eventArgs.Frame.Clone());


            Mat result = SURFFeatureExample.DrawMatches.Draw(modelImg.Mat, observedImg.Mat, out matchTime, out X_center, out Y_center, out theta);
            previewPanel.BackgroundImage = (Bitmap)result.Bitmap;

            this.Invoke(new MethodInvoker(delegate ()
            {
                if (previewPanel.BackgroundImage != null)
                {
                    dataGridView1.Rows[0].Cells[0].Value = matchTime.ToString("F") + "ms";
                    dataGridView1.Rows[0].Cells[1].Value = X_center.ToString();
                    dataGridView1.Rows[0].Cells[2].Value = Y_center.ToString();
                    dataGridView1.Rows[0].Cells[3].Value = theta.ToString();
                }
            }));
            selectedCamera.videoSource.NewFrame -= new NewFrameEventHandler(TrackObject_NewFrame);

            /*
            System.Drawing.Image SRCimage = (Bitmap)eventArgs.Frame.Clone();
            Bitmap SRCbmpImage = new Bitmap(SRCimage);
            Image<Bgr, byte> source = new Image<Bgr, byte>(SRCbmpImage);

            System.Drawing.Image TMPimage = (Bitmap)ModelPreview.BackgroundImage;
            Bitmap TMPbmpImage = new Bitmap(TMPimage);
            Image<Bgr, byte> template = new Image<Bgr, byte>(TMPbmpImage);

            Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);

            double[] minValues, maxValues;
            Point[] minLocations, maxLocations;
            result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

            if ((maxValues[0] * 100) >= (double)accuracyThreshold.Value)
            {
                Rectangle rect = new Rectangle(maxLocations[0], template.Size);
                Graphics graphic = Graphics.FromImage(SRCimage);
                Pen pen = new Pen(Color.Green, 2);

                graphic.DrawRectangle(pen, rect);

                this.Invoke(new MethodInvoker(delegate ()
                {
                    if (previewPanel.BackgroundImage != null)
                    {
                        previewPanel.BackgroundImage.Dispose();
                    }

                // Update the form with relevant data
                previewPanel.BackgroundImage = SRCimage;
                    dataGridView1.Rows[0].Cells[0].Value = (maxValues[0] * 100).ToString("F") + "%";
                }));
            }else

            if ((maxValues[0] * 100) >= (double)accuracyThreshold.Value - 10)
            {
                Rectangle rect = new Rectangle(maxLocations[0], template.Size);
                Graphics graphic = Graphics.FromImage(SRCimage);
                Pen pen = new Pen(Color.Blue, 2);

                graphic.DrawRectangle(pen, rect);

                this.Invoke(new MethodInvoker(delegate ()
                {
                    if (previewPanel.BackgroundImage != null)
                    {
                        previewPanel.BackgroundImage.Dispose();
                    }

                    // Update the form with relevant data
                    previewPanel.BackgroundImage = SRCimage;
                    dataGridView1.Rows[0].Cells[0].Value = (maxValues[0] * 100).ToString("F") + "%";
                }));
            }
            else
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    if (previewPanel.BackgroundImage != null)
                    {
                        previewPanel.BackgroundImage.Dispose();
                    }

                    // Update the form with relevant data
                    previewPanel.BackgroundImage = SRCimage;
                    dataGridView1.Rows[0].Cells[0].Value = (maxValues[0] * 100).ToString("F") + "%";
                }));
            }
            */
        }

        public void trackImgs()
        {
            long matchTime = 0;
            float X_center, Y_center;
            float theta;
            Image<Gray, byte> modelImg;
            Image<Gray, byte> observedImg;
            
            modelImg = new Image<Gray, byte>((Bitmap)Image.FromFile(modelPanelImg));
            observedImg = new Image<Gray, byte>((Bitmap)Image.FromFile(previewPanelImg));


            Mat result = SURFFeatureExample.DrawMatches.Draw(modelImg.Mat, observedImg.Mat, out matchTime, out X_center, out Y_center, out theta);
            previewPanel.BackgroundImage = (Bitmap)result.Bitmap;

            this.Invoke(new MethodInvoker(delegate ()
            {
                if (previewPanel.BackgroundImage != null)
                {
                    dataGridView1.Rows[0].Cells[0].Value = matchTime.ToString("F") + "ms";
                    dataGridView1.Rows[0].Cells[1].Value = X_center.ToString();
                    dataGridView1.Rows[0].Cells[2].Value = Y_center.ToString();
                    dataGridView1.Rows[0].Cells[3].Value = theta.ToString();
                }
            }));
        }

        private void StartTrackingBtn_Click(object sender, EventArgs e)
        {
            switch (StartTrackingBtn.Text)
            {
                case "Start Tracking":
                    // Start tracking button clicked
                    StartTrackingBtn.ForeColor = Color.Red;
                    StartTrackingBtn.Text = "Stop Tracking";
                    previewPanel.VideoSource = null;
                    //previewPanel.BackgroundImage = null;
                    if (selectedCamera.videoSource != null)
                    {
                        selectedCamera.videoSource.NewFrame -= new NewFrameEventHandler(ShowBounds_NewFrame);
                        selectedCamera.videoSource.NewFrame += new NewFrameEventHandler(TrackObject_NewFrame);
                    }
                    else
                    {
                        trackImgs();
                    }

                    break;
                case "Stop Tracking":
                    // Stop tracking button clicked
                    StartTrackingBtn.ForeColor = Color.Black;
                    StartTrackingBtn.Text = "Start Tracking";
                    previewPanel.VideoSource = selectedCamera.videoSource;
                    if (selectedCamera.videoSource != null)
                    {
                        selectedCamera.videoSource.NewFrame -= new NewFrameEventHandler(TrackObject_NewFrame);
                    }
                    break;
            }

        }

        private void OpenModel_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ModelPreview.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                modelPanelImg = openFileDialog1.FileName;

            }
        }

        private void LoadCamImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                previewPanel.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                previewPanelImg = openFileDialog1.FileName;
            }
        }
    }
}
