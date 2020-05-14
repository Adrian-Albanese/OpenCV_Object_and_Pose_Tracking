namespace OpenCV_Object_and_Pose_Tracking
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConnectionLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InputDeviceList = new System.Windows.Forms.ComboBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RunStopBtn = new System.Windows.Forms.Button();
            this.SingleShotBtn = new System.Windows.Forms.Button();
            this.previewPanel = new AForge.Controls.VideoSourcePlayer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ModelSizeLbl = new System.Windows.Forms.Label();
            this.ModelPreview = new AForge.Controls.VideoSourcePlayer();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.XOffset = new System.Windows.Forms.NumericUpDown();
            this.YOffset = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CaptureWidth = new System.Windows.Forms.NumericUpDown();
            this.CaptureHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CaptureModelBtn = new System.Windows.Forms.Button();
            this.ShowHideBoundsBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Accuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X_Pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_Pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTrackingBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accuracyThreshold = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureHeight)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accuracyThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectionLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InputDeviceList);
            this.groupBox1.Controls.Add(this.ConnectBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera Settings";
            // 
            // ConnectionLbl
            // 
            this.ConnectionLbl.AutoSize = true;
            this.ConnectionLbl.ForeColor = System.Drawing.Color.Red;
            this.ConnectionLbl.Location = new System.Drawing.Point(6, 105);
            this.ConnectionLbl.Name = "ConnectionLbl";
            this.ConnectionLbl.Size = new System.Drawing.Size(173, 17);
            this.ConnectionLbl.TabIndex = 3;
            this.ConnectionLbl.Text = "Connection: Disconnected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Device";
            // 
            // InputDeviceList
            // 
            this.InputDeviceList.FormattingEnabled = true;
            this.InputDeviceList.Location = new System.Drawing.Point(9, 53);
            this.InputDeviceList.Name = "InputDeviceList";
            this.InputDeviceList.Size = new System.Drawing.Size(266, 24);
            this.InputDeviceList.TabIndex = 1;
            this.InputDeviceList.Text = "Select Input Device...";
            this.InputDeviceList.SelectedIndexChanged += new System.EventHandler(this.InputDeviceList_SelectedIndexChanged);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(181, 85);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(94, 37);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RunStopBtn);
            this.groupBox2.Controls.Add(this.SingleShotBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera Controls";
            // 
            // RunStopBtn
            // 
            this.RunStopBtn.Location = new System.Drawing.Point(70, 90);
            this.RunStopBtn.Name = "RunStopBtn";
            this.RunStopBtn.Size = new System.Drawing.Size(120, 40);
            this.RunStopBtn.TabIndex = 1;
            this.RunStopBtn.Text = "Run";
            this.RunStopBtn.UseVisualStyleBackColor = true;
            this.RunStopBtn.Click += new System.EventHandler(this.RunStopBtn_Click);
            // 
            // SingleShotBtn
            // 
            this.SingleShotBtn.Location = new System.Drawing.Point(70, 35);
            this.SingleShotBtn.Name = "SingleShotBtn";
            this.SingleShotBtn.Size = new System.Drawing.Size(120, 40);
            this.SingleShotBtn.TabIndex = 0;
            this.SingleShotBtn.Text = "Single Shot";
            this.SingleShotBtn.UseVisualStyleBackColor = true;
            this.SingleShotBtn.Click += new System.EventHandler(this.SingleShotBtn_Click);
            // 
            // previewPanel
            // 
            this.previewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previewPanel.Location = new System.Drawing.Point(298, 12);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(667, 437);
            this.previewPanel.TabIndex = 3;
            this.previewPanel.Text = "videoSourcePlayer1";
            this.previewPanel.VideoSource = null;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ModelSizeLbl);
            this.groupBox3.Controls.Add(this.ModelPreview);
            this.groupBox3.Location = new System.Drawing.Point(971, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 266);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Model Preview";
            // 
            // ModelSizeLbl
            // 
            this.ModelSizeLbl.AutoSize = true;
            this.ModelSizeLbl.Location = new System.Drawing.Point(6, 227);
            this.ModelSizeLbl.Name = "ModelSizeLbl";
            this.ModelSizeLbl.Size = new System.Drawing.Size(161, 17);
            this.ModelSizeLbl.TabIndex = 1;
            this.ModelSizeLbl.Text = "Model Size: 350 x 250px";
            // 
            // ModelPreview
            // 
            this.ModelPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ModelPreview.Location = new System.Drawing.Point(6, 27);
            this.ModelPreview.Name = "ModelPreview";
            this.ModelPreview.Size = new System.Drawing.Size(341, 197);
            this.ModelPreview.TabIndex = 0;
            this.ModelPreview.Text = "videoSourcePlayer1";
            this.ModelPreview.VideoSource = null;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.accuracyThreshold);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Location = new System.Drawing.Point(971, 284);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(353, 356);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Object Matching Settings";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.XOffset);
            this.groupBox5.Controls.Add(this.YOffset);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.CaptureWidth);
            this.groupBox5.Controls.Add(this.CaptureHeight);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.CaptureModelBtn);
            this.groupBox5.Controls.Add(this.ShowHideBoundsBtn);
            this.groupBox5.Location = new System.Drawing.Point(12, 304);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(280, 336);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Model Capture";
            // 
            // XOffset
            // 
            this.XOffset.Location = new System.Drawing.Point(70, 234);
            this.XOffset.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.XOffset.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            -2147483648});
            this.XOffset.Name = "XOffset";
            this.XOffset.Size = new System.Drawing.Size(120, 22);
            this.XOffset.TabIndex = 9;
            // 
            // YOffset
            // 
            this.YOffset.Location = new System.Drawing.Point(70, 273);
            this.YOffset.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.YOffset.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            -2147483648});
            this.YOffset.Name = "YOffset";
            this.YOffset.Size = new System.Drawing.Size(120, 22);
            this.YOffset.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "X Offset:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Y Offset:";
            // 
            // CaptureWidth
            // 
            this.CaptureWidth.Location = new System.Drawing.Point(70, 155);
            this.CaptureWidth.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.CaptureWidth.Name = "CaptureWidth";
            this.CaptureWidth.Size = new System.Drawing.Size(120, 22);
            this.CaptureWidth.TabIndex = 5;
            this.CaptureWidth.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.CaptureWidth.ValueChanged += new System.EventHandler(this.UpdateModelSizeLbl);
            // 
            // CaptureHeight
            // 
            this.CaptureHeight.Location = new System.Drawing.Point(70, 194);
            this.CaptureHeight.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.CaptureHeight.Name = "CaptureHeight";
            this.CaptureHeight.Size = new System.Drawing.Size(120, 22);
            this.CaptureHeight.TabIndex = 4;
            this.CaptureHeight.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.CaptureHeight.ValueChanged += new System.EventHandler(this.UpdateModelSizeLbl);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height:";
            // 
            // CaptureModelBtn
            // 
            this.CaptureModelBtn.Location = new System.Drawing.Point(70, 85);
            this.CaptureModelBtn.Name = "CaptureModelBtn";
            this.CaptureModelBtn.Size = new System.Drawing.Size(120, 40);
            this.CaptureModelBtn.TabIndex = 1;
            this.CaptureModelBtn.Text = "Capture Model";
            this.CaptureModelBtn.UseVisualStyleBackColor = true;
            this.CaptureModelBtn.Click += new System.EventHandler(this.CaptureModelBtn_Click);
            // 
            // ShowHideBoundsBtn
            // 
            this.ShowHideBoundsBtn.Location = new System.Drawing.Point(70, 30);
            this.ShowHideBoundsBtn.Name = "ShowHideBoundsBtn";
            this.ShowHideBoundsBtn.Size = new System.Drawing.Size(120, 40);
            this.ShowHideBoundsBtn.TabIndex = 0;
            this.ShowHideBoundsBtn.Text = "Show Bounds";
            this.ShowHideBoundsBtn.UseVisualStyleBackColor = true;
            this.ShowHideBoundsBtn.Click += new System.EventHandler(this.ShowHideBoundsBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Location = new System.Drawing.Point(298, 461);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(667, 112);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Calculated Transformation";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accuracy,
            this.X_Pos,
            this.Y_Pos,
            this.Angle,
            this.Scale});
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(655, 85);
            this.dataGridView1.TabIndex = 2;
            // 
            // Accuracy
            // 
            this.Accuracy.HeaderText = "Accuracy";
            this.Accuracy.Name = "Accuracy";
            // 
            // X_Pos
            // 
            this.X_Pos.HeaderText = "X Pos";
            this.X_Pos.Name = "X_Pos";
            // 
            // Y_Pos
            // 
            this.Y_Pos.HeaderText = "Y Pos";
            this.Y_Pos.Name = "Y_Pos";
            // 
            // Angle
            // 
            this.Angle.HeaderText = "Angle";
            this.Angle.Name = "Angle";
            // 
            // Scale
            // 
            this.Scale.HeaderText = "Scale";
            this.Scale.Name = "Scale";
            // 
            // StartTrackingBtn
            // 
            this.StartTrackingBtn.Location = new System.Drawing.Point(830, 579);
            this.StartTrackingBtn.Name = "StartTrackingBtn";
            this.StartTrackingBtn.Size = new System.Drawing.Size(135, 61);
            this.StartTrackingBtn.TabIndex = 7;
            this.StartTrackingBtn.Text = "Start Tracking";
            this.StartTrackingBtn.UseVisualStyleBackColor = true;
            this.StartTrackingBtn.Click += new System.EventHandler(this.StartTrackingBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Accuracy Threshold:";
            // 
            // accuracyThreshold
            // 
            this.accuracyThreshold.Location = new System.Drawing.Point(164, 35);
            this.accuracyThreshold.Name = "accuracyThreshold";
            this.accuracyThreshold.Size = new System.Drawing.Size(61, 22);
            this.accuracyThreshold.TabIndex = 9;
            this.accuracyThreshold.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "%";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 653);
            this.Controls.Add(this.StartTrackingBtn);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "OpenCV Object and Pose Tracking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureHeight)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accuracyThreshold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox InputDeviceList;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button RunStopBtn;
        private System.Windows.Forms.Button SingleShotBtn;
        private AForge.Controls.VideoSourcePlayer previewPanel;
        private System.Windows.Forms.Label ConnectionLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ModelSizeLbl;
        private AForge.Controls.VideoSourcePlayer ModelPreview;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button CaptureModelBtn;
        private System.Windows.Forms.Button ShowHideBoundsBtn;
        private System.Windows.Forms.NumericUpDown CaptureWidth;
        private System.Windows.Forms.NumericUpDown CaptureHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown XOffset;
        private System.Windows.Forms.NumericUpDown YOffset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button StartTrackingBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accuracy;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_Pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_Pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Angle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown accuracyThreshold;
    }
}

