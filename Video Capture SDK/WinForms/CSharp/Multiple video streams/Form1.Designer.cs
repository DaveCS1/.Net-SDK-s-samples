﻿using VisioForge.Types;

namespace multiple_video_streams
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbCamera1 = new System.Windows.Forms.ComboBox();
            this.cbCamera2 = new System.Windows.Forms.ComboBox();
            this.cbVideoFormat1 = new System.Windows.Forms.ComboBox();
            this.cbVideoFrameRate1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVideoFrameRate2 = new System.Windows.Forms.ComboBox();
            this.cbVideoFormat2 = new System.Windows.Forms.ComboBox();
            this.edLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDebugMode = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edFilename = new System.Windows.Forms.TextBox();
            this.videoCapture1 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.videoScreen2 = new System.Windows.Forms.PictureBox();
            this.cbLicensing = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoScreen2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbCamera1
            // 
            this.cbCamera1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamera1.FormattingEnabled = true;
            this.cbCamera1.Location = new System.Drawing.Point(12, 245);
            this.cbCamera1.Name = "cbCamera1";
            this.cbCamera1.Size = new System.Drawing.Size(295, 21);
            this.cbCamera1.TabIndex = 6;
            this.cbCamera1.SelectedIndexChanged += new System.EventHandler(this.cbCamera1_SelectedIndexChanged);
            // 
            // cbCamera2
            // 
            this.cbCamera2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamera2.FormattingEnabled = true;
            this.cbCamera2.Location = new System.Drawing.Point(331, 245);
            this.cbCamera2.Name = "cbCamera2";
            this.cbCamera2.Size = new System.Drawing.Size(295, 21);
            this.cbCamera2.TabIndex = 7;
            this.cbCamera2.SelectedIndexChanged += new System.EventHandler(this.cbCamera2_SelectedIndexChanged);
            // 
            // cbVideoFormat1
            // 
            this.cbVideoFormat1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoFormat1.FormattingEnabled = true;
            this.cbVideoFormat1.Location = new System.Drawing.Point(12, 277);
            this.cbVideoFormat1.Name = "cbVideoFormat1";
            this.cbVideoFormat1.Size = new System.Drawing.Size(186, 21);
            this.cbVideoFormat1.TabIndex = 9;
            // 
            // cbVideoFrameRate1
            // 
            this.cbVideoFrameRate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoFrameRate1.FormattingEnabled = true;
            this.cbVideoFrameRate1.Location = new System.Drawing.Point(204, 277);
            this.cbVideoFrameRate1.Name = "cbVideoFrameRate1";
            this.cbVideoFrameRate1.Size = new System.Drawing.Size(76, 21);
            this.cbVideoFrameRate1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "fps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "fps";
            // 
            // cbVideoFrameRate2
            // 
            this.cbVideoFrameRate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoFrameRate2.FormattingEnabled = true;
            this.cbVideoFrameRate2.Location = new System.Drawing.Point(523, 277);
            this.cbVideoFrameRate2.Name = "cbVideoFrameRate2";
            this.cbVideoFrameRate2.Size = new System.Drawing.Size(76, 21);
            this.cbVideoFrameRate2.TabIndex = 13;
            // 
            // cbVideoFormat2
            // 
            this.cbVideoFormat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoFormat2.FormattingEnabled = true;
            this.cbVideoFormat2.Location = new System.Drawing.Point(331, 277);
            this.cbVideoFormat2.Name = "cbVideoFormat2";
            this.cbVideoFormat2.Size = new System.Drawing.Size(186, 21);
            this.cbVideoFormat2.TabIndex = 12;
            // 
            // edLog
            // 
            this.edLog.Location = new System.Drawing.Point(644, 32);
            this.edLog.Multiline = true;
            this.edLog.Name = "edLog";
            this.edLog.Size = new System.Drawing.Size(263, 134);
            this.edLog.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Log";
            // 
            // cbDebugMode
            // 
            this.cbDebugMode.AutoSize = true;
            this.cbDebugMode.Location = new System.Drawing.Point(820, 12);
            this.cbDebugMode.Name = "cbDebugMode";
            this.cbDebugMode.Size = new System.Drawing.Size(87, 17);
            this.cbDebugMode.TabIndex = 17;
            this.cbDebugMode.Text = "Debug mode";
            this.cbDebugMode.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Output file";
            // 
            // edFilename
            // 
            this.edFilename.Location = new System.Drawing.Point(644, 194);
            this.edFilename.Name = "edFilename";
            this.edFilename.Size = new System.Drawing.Size(263, 20);
            this.edFilename.TabIndex = 19;
            // 
            // videoCapture1
            // 
            this.videoCapture1.Additional_Audio_CaptureDevice_MixChannels = false;
            this.videoCapture1.Audio_CaptureDevice = "";
            this.videoCapture1.Audio_CaptureDevice_CustomLatency = 0;
            this.videoCapture1.Audio_CaptureDevice_Format = "";
            this.videoCapture1.Audio_CaptureDevice_Format_UseBest = true;
            this.videoCapture1.Audio_CaptureDevice_Line = "";
            this.videoCapture1.Audio_CaptureDevice_Path = null;
            this.videoCapture1.Audio_Decoder = null;
            this.videoCapture1.Audio_Effects_Enabled = false;
            this.videoCapture1.Audio_Enhancer_Enabled = false;
            this.videoCapture1.Audio_OutputDevice = "Default DirectSound Device";
            this.videoCapture1.Audio_PlayAudio = true;
            this.videoCapture1.Audio_RecordAudio = true;
            this.videoCapture1.Audio_Sample_Grabber_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Pro_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Pro_Volume = 100;
            this.videoCapture1.BackColor = System.Drawing.Color.Black;
            this.videoCapture1.Barcode_Reader_Enabled = false;
            this.videoCapture1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.videoCapture1.Debug_Dir = "";
            this.videoCapture1.Debug_Mode = false;
            this.videoCapture1.Decklink_Input = VisioForge.Types.DecklinkInput.Auto;
            this.videoCapture1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.videoCapture1.Decklink_Input_IREUSA = false;
            this.videoCapture1.Decklink_Input_SMPTE = false;
            this.videoCapture1.DirectCapture_Muxer = null;
            this.videoCapture1.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full;
            this.videoCapture1.Location = new System.Drawing.Point(12, 12);
            this.videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoCapture;
            this.videoCapture1.MPEG_Audio_Decoder = "";
            this.videoCapture1.MPEG_Video_Decoder = "";
            this.videoCapture1.MultiScreen_Enabled = false;
            this.videoCapture1.Name = "videoCapture1";
            this.videoCapture1.Network_Streaming_Audio_Enabled = false;
            this.videoCapture1.Network_Streaming_Enabled = false;
            this.videoCapture1.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV;
            this.videoCapture1.Network_Streaming_Network_Port = 100;
            this.videoCapture1.Network_Streaming_URL = "";
            this.videoCapture1.Network_Streaming_WMV_Maximum_Clients = 10;
            this.videoCapture1.Output_Filename = "";
            this.videoCapture1.PIP_AddSampleGrabbers = false;
            this.videoCapture1.PIP_Mode = VisioForge.Types.VFPIPMode.Custom;
            this.videoCapture1.SeparateCapture_AutostartCapture = false;
            this.videoCapture1.SeparateCapture_Enabled = false;
            this.videoCapture1.SeparateCapture_FileSizeThreshold = ((long)(0));
            this.videoCapture1.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal;
            this.videoCapture1.SeparateCapture_TimeThreshold = ((long)(0));
            this.videoCapture1.Size = new System.Drawing.Size(295, 228);
            this.videoCapture1.TabIndex = 0;
            this.videoCapture1.TVTuner_Channel = 0;
            this.videoCapture1.TVTuner_Country = "";
            this.videoCapture1.TVTuner_FM_Tuning_StartFrequency = 80000000;
            this.videoCapture1.TVTuner_FM_Tuning_Step = 160000000;
            this.videoCapture1.TVTuner_FM_Tuning_StopFrequency = 0;
            this.videoCapture1.TVTuner_Frequency = 0;
            this.videoCapture1.TVTuner_InputType = "";
            this.videoCapture1.TVTuner_Name = "";
            this.videoCapture1.TVTuner_TVFormat = VisioForge.Types.VFTVTunerVideoFormat.PAL_D;
            this.videoCapture1.Video_CaptureDevice = "";
            this.videoCapture1.Video_CaptureDevice_Format = "";
            this.videoCapture1.Video_CaptureDevice_Format_UseBest = true;
            this.videoCapture1.Video_CaptureDevice_FrameRate = 25D;
            this.videoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = "";
            this.videoCapture1.Video_CaptureDevice_IsAudioSource = false;
            this.videoCapture1.Video_CaptureDevice_Path = null;
            this.videoCapture1.Video_CaptureDevice_UseClosedCaptions = false;
            this.videoCapture1.Video_Decoder = null;
            this.videoCapture1.Video_Effects_Enabled = false;
            this.videoCapture1.Video_ResizeOrCrop_Enabled = false;
            this.videoCapture1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.videoCapture1.Video_Sample_Grabber_Enabled = false;
            this.videoCapture1.Video_Sample_Grabber_UseForVideoEffects = false;
            this.videoCapture1.Video_Still_Frames_Grabber_Enabled = false;
            this.videoCapture1.Virtual_Camera_Output_Enabled = false;
            this.videoCapture1.Virtual_Camera_Output_LicenseKey = null;
            this.videoCapture1.VLC_Path = null;
            this.videoCapture1.OnLicenseRequired += new System.EventHandler<VisioForge.Types.LicenseEventArgs>(this.videoCapture1_OnLicenseRequired);
            this.videoCapture1.OnVideoFrameBitmap += new System.EventHandler<VisioForge.Types.VideoFrameBitmapEventArgs>(this.videoCapture1_OnVideoFrameBitmap);
            // 
            // videoScreen2
            // 
            this.videoScreen2.BackColor = System.Drawing.Color.Black;
            this.videoScreen2.Location = new System.Drawing.Point(331, 12);
            this.videoScreen2.Name = "videoScreen2";
            this.videoScreen2.Size = new System.Drawing.Size(295, 228);
            this.videoScreen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.videoScreen2.TabIndex = 20;
            this.videoScreen2.TabStop = false;
            // 
            // cbLicensing
            // 
            this.cbLicensing.AutoSize = true;
            this.cbLicensing.Location = new System.Drawing.Point(723, 12);
            this.cbLicensing.Name = "cbLicensing";
            this.cbLicensing.Size = new System.Drawing.Size(91, 17);
            this.cbLicensing.TabIndex = 21;
            this.cbLicensing.Text = "Licensing info";
            this.cbLicensing.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 340);
            this.Controls.Add(this.cbLicensing);
            this.Controls.Add(this.videoScreen2);
            this.Controls.Add(this.edFilename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDebugMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVideoFrameRate2);
            this.Controls.Add(this.cbVideoFormat2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVideoFrameRate1);
            this.Controls.Add(this.cbVideoFormat1);
            this.Controls.Add(this.cbCamera2);
            this.Controls.Add(this.cbCamera1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.videoCapture1);
            this.Name = "Form1";
            this.Text = "Video Capture SDK .Net - Multiple video streams captured into one file";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoScreen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisioForge.Controls.UI.WinForms.VideoCapture videoCapture1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbCamera1;
        private System.Windows.Forms.ComboBox cbCamera2;
        private System.Windows.Forms.ComboBox cbVideoFormat1;
        private System.Windows.Forms.ComboBox cbVideoFrameRate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVideoFrameRate2;
        private System.Windows.Forms.ComboBox cbVideoFormat2;
        private System.Windows.Forms.TextBox edLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edFilename;
        private System.Windows.Forms.PictureBox videoScreen2;
        private System.Windows.Forms.CheckBox cbLicensing;
    }
}

