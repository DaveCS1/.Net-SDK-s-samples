Imports VisioForge.Types

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cbImageType = New System.Windows.Forms.ComboBox()
        Me.lbJPEGQuality = New System.Windows.Forms.Label()
        Me.btStop = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label38 = New System.Windows.Forms.Label()
        Me.btSaveScreenshot = New System.Windows.Forms.Button()
        Me.label63 = New System.Windows.Forms.Label()
        Me.edScreenshotsFolder = New System.Windows.Forms.TextBox()
        Me.tbJPEGQuality = New System.Windows.Forms.TrackBar()
        Me.btStart = New System.Windows.Forms.Button()
        Me.btSelectOutput = New System.Windows.Forms.Button()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.edImageLogoTop = New System.Windows.Forms.TextBox()
        Me.cbImageLogo = New System.Windows.Forms.CheckBox()
        Me.label155 = New System.Windows.Forms.Label()
        Me.tbImageLogoTransp = New System.Windows.Forms.TrackBar()
        Me.edImageLogoLeft = New System.Windows.Forms.TextBox()
        Me.label156 = New System.Windows.Forms.Label()
        Me.label154 = New System.Windows.Forms.Label()
        Me.btSelectImage = New System.Windows.Forms.Button()
        Me.label157 = New System.Windows.Forms.Label()
        Me.edImageLogoFilename = New System.Windows.Forms.TextBox()
        Me.label32 = New System.Windows.Forms.Label()
        Me.tbTextLogoTransp = New System.Windows.Forms.TrackBar()
        Me.edTextLogoTop = New System.Windows.Forms.TextBox()
        Me.label139 = New System.Windows.Forms.Label()
        Me.edTextLogoLeft = New System.Windows.Forms.TextBox()
        Me.label140 = New System.Windows.Forms.Label()
        Me.btFont = New System.Windows.Forms.Button()
        Me.edTextLogo = New System.Windows.Forms.TextBox()
        Me.cbTextLogo = New System.Windows.Forms.CheckBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbLicensing = New System.Windows.Forms.CheckBox()
        Me.cbDebugMode = New System.Windows.Forms.CheckBox()
        Me.mmLog = New System.Windows.Forms.TextBox()
        Me.tabPage4 = New System.Windows.Forms.TabPage()
        Me.edOutput = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.cbUseBestAudioInputFormat = New System.Windows.Forms.CheckBox()
        Me.btAudioInputDeviceSettings = New System.Windows.Forms.Button()
        Me.cbAudioInputLine = New System.Windows.Forms.ComboBox()
        Me.cbAudioInputFormat = New System.Windows.Forms.ComboBox()
        Me.cbAudioInputDevice = New System.Windows.Forms.ComboBox()
        Me.label22 = New System.Windows.Forms.Label()
        Me.label23 = New System.Windows.Forms.Label()
        Me.label25 = New System.Windows.Forms.Label()
        Me.cbRecordAudio = New System.Windows.Forms.CheckBox()
        Me.btScreenCaptureUpdate = New System.Windows.Forms.Button()
        Me.label124 = New System.Windows.Forms.Label()
        Me.label123 = New System.Windows.Forms.Label()
        Me.label122 = New System.Windows.Forms.Label()
        Me.cbScreenCapture_GrabMouseCursor = New System.Windows.Forms.CheckBox()
        Me.label79 = New System.Windows.Forms.Label()
        Me.edScreenFrameRate = New System.Windows.Forms.TextBox()
        Me.label43 = New System.Windows.Forms.Label()
        Me.edScreenBottom = New System.Windows.Forms.TextBox()
        Me.label42 = New System.Windows.Forms.Label()
        Me.edScreenTop = New System.Windows.Forms.TextBox()
        Me.label26 = New System.Windows.Forms.Label()
        Me.edScreenRight = New System.Windows.Forms.TextBox()
        Me.label40 = New System.Windows.Forms.Label()
        Me.fontDialog1 = New System.Windows.Forms.FontDialog()
        Me.edScreenLeft = New System.Windows.Forms.TextBox()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.cbScreenCapture_DesktopDuplication = New System.Windows.Forms.CheckBox()
        Me.label294 = New System.Windows.Forms.Label()
        Me.edScreenCaptureWindowName = New System.Windows.Forms.TextBox()
        Me.rbScreenCaptureWindow = New System.Windows.Forms.RadioButton()
        Me.cbScreenCaptureDisplayIndex = New System.Windows.Forms.ComboBox()
        Me.label93 = New System.Windows.Forms.Label()
        Me.label24 = New System.Windows.Forms.Label()
        Me.rbScreenCustomArea = New System.Windows.Forms.RadioButton()
        Me.rbScreenFullScreen = New System.Windows.Forms.RadioButton()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.tabControl2 = New System.Windows.Forms.TabControl()
        Me.tabPage5 = New System.Windows.Forms.TabPage()
        Me.label27 = New System.Windows.Forms.Label()
        Me.btAudioSettings = New System.Windows.Forms.Button()
        Me.btVideoSettings = New System.Windows.Forms.Button()
        Me.label28 = New System.Windows.Forms.Label()
        Me.label29 = New System.Windows.Forms.Label()
        Me.label30 = New System.Windows.Forms.Label()
        Me.label31 = New System.Windows.Forms.Label()
        Me.cbChannels = New System.Windows.Forms.ComboBox()
        Me.cbBPS = New System.Windows.Forms.ComboBox()
        Me.cbAudioCodecs = New System.Windows.Forms.ComboBox()
        Me.cbSampleRate = New System.Windows.Forms.ComboBox()
        Me.cbVideoCodecs = New System.Windows.Forms.ComboBox()
        Me.tabPage6 = New System.Windows.Forms.TabPage()
        Me.label33 = New System.Windows.Forms.Label()
        Me.cbWMVInternalProfile9 = New System.Windows.Forms.ComboBox()
        Me.tabPage7 = New System.Windows.Forms.TabPage()
        Me.tabControl3 = New System.Windows.Forms.TabControl()
        Me.tabPage9 = New System.Windows.Forms.TabPage()
        Me.groupBox29 = New System.Windows.Forms.GroupBox()
        Me.cbH264GOP = New System.Windows.Forms.CheckBox()
        Me.cbH264AutoBitrate = New System.Windows.Forms.CheckBox()
        Me.label350 = New System.Windows.Forms.Label()
        Me.edH264Bitrate = New System.Windows.Forms.TextBox()
        Me.label351 = New System.Windows.Forms.Label()
        Me.cbH264RateControl = New System.Windows.Forms.ComboBox()
        Me.groupBox46 = New System.Windows.Forms.GroupBox()
        Me.cbH264TargetUsage = New System.Windows.Forms.ComboBox()
        Me.label359 = New System.Windows.Forms.Label()
        Me.label352 = New System.Windows.Forms.Label()
        Me.label353 = New System.Windows.Forms.Label()
        Me.cbH264Level = New System.Windows.Forms.ComboBox()
        Me.cbH264Profile = New System.Windows.Forms.ComboBox()
        Me.tabPage10 = New System.Windows.Forms.TabPage()
        Me.label354 = New System.Windows.Forms.Label()
        Me.cbAACOutput = New System.Windows.Forms.ComboBox()
        Me.label355 = New System.Windows.Forms.Label()
        Me.cbAACBitrate = New System.Windows.Forms.ComboBox()
        Me.label356 = New System.Windows.Forms.Label()
        Me.cbAACObjectType = New System.Windows.Forms.ComboBox()
        Me.label357 = New System.Windows.Forms.Label()
        Me.cbAACVersion = New System.Windows.Forms.ComboBox()
        Me.label358 = New System.Windows.Forms.Label()
        Me.openFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.llVideoTutorials = New System.Windows.Forms.LinkLabel()
        Me.VideoCapture1 = New VisioForge.Controls.UI.WinForms.VideoCapture()
        Me.cbMode = New System.Windows.Forms.ComboBox()
        Me.label35 = New System.Windows.Forms.Label()
        Me.label34 = New System.Windows.Forms.Label()
        Me.groupBox2.SuspendLayout
        CType(Me.tbJPEGQuality,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage3.SuspendLayout
        CType(Me.tbImageLogoTransp,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbTextLogoTransp,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBox1.SuspendLayout
        Me.tabPage4.SuspendLayout
        Me.tabControl1.SuspendLayout
        Me.tabPage1.SuspendLayout
        Me.tabPage2.SuspendLayout
        Me.tabControl2.SuspendLayout
        Me.tabPage5.SuspendLayout
        Me.tabPage6.SuspendLayout
        Me.tabPage7.SuspendLayout
        Me.tabControl3.SuspendLayout
        Me.tabPage9.SuspendLayout
        Me.groupBox29.SuspendLayout
        Me.groupBox46.SuspendLayout
        Me.tabPage10.SuspendLayout
        Me.SuspendLayout
        '
        'cbImageType
        '
        Me.cbImageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbImageType.FormattingEnabled = true
        Me.cbImageType.Items.AddRange(New Object() {"BMP", "JPEG", "GIF", "PNG", "TIFF"})
        Me.cbImageType.Location = New System.Drawing.Point(12, 45)
        Me.cbImageType.Name = "cbImageType"
        Me.cbImageType.Size = New System.Drawing.Size(73, 21)
        Me.cbImageType.TabIndex = 41
        '
        'lbJPEGQuality
        '
        Me.lbJPEGQuality.AutoSize = true
        Me.lbJPEGQuality.Location = New System.Drawing.Point(263, 48)
        Me.lbJPEGQuality.Name = "lbJPEGQuality"
        Me.lbJPEGQuality.Size = New System.Drawing.Size(19, 13)
        Me.lbJPEGQuality.TabIndex = 40
        Me.lbJPEGQuality.Text = "85"
        '
        'btStop
        '
        Me.btStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btStop.Location = New System.Drawing.Point(756, 410)
        Me.btStop.Name = "btStop"
        Me.btStop.Size = New System.Drawing.Size(62, 23)
        Me.btStop.TabIndex = 54
        Me.btStop.Text = "Stop"
        Me.btStop.UseVisualStyleBackColor = true
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.cbImageType)
        Me.groupBox2.Controls.Add(Me.lbJPEGQuality)
        Me.groupBox2.Controls.Add(Me.label38)
        Me.groupBox2.Controls.Add(Me.btSaveScreenshot)
        Me.groupBox2.Controls.Add(Me.label63)
        Me.groupBox2.Controls.Add(Me.edScreenshotsFolder)
        Me.groupBox2.Controls.Add(Me.tbJPEGQuality)
        Me.groupBox2.Location = New System.Drawing.Point(5, 3)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(358, 81)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = false
        Me.groupBox2.Text = "Screenshot"
        '
        'label38
        '
        Me.label38.AutoSize = true
        Me.label38.Location = New System.Drawing.Point(120, 48)
        Me.label38.Name = "label38"
        Me.label38.Size = New System.Drawing.Size(67, 13)
        Me.label38.TabIndex = 39
        Me.label38.Text = "JPEG quality"
        '
        'btSaveScreenshot
        '
        Me.btSaveScreenshot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btSaveScreenshot.Location = New System.Drawing.Point(296, 43)
        Me.btSaveScreenshot.Name = "btSaveScreenshot"
        Me.btSaveScreenshot.Size = New System.Drawing.Size(56, 23)
        Me.btSaveScreenshot.TabIndex = 37
        Me.btSaveScreenshot.Text = "Save"
        Me.btSaveScreenshot.UseVisualStyleBackColor = true
        '
        'label63
        '
        Me.label63.AutoSize = true
        Me.label63.Location = New System.Drawing.Point(9, 22)
        Me.label63.Name = "label63"
        Me.label63.Size = New System.Drawing.Size(36, 13)
        Me.label63.TabIndex = 35
        Me.label63.Text = "Folder"
        '
        'edScreenshotsFolder
        '
        Me.edScreenshotsFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.edScreenshotsFolder.Location = New System.Drawing.Point(54, 19)
        Me.edScreenshotsFolder.Name = "edScreenshotsFolder"
        Me.edScreenshotsFolder.Size = New System.Drawing.Size(298, 20)
        Me.edScreenshotsFolder.TabIndex = 34
        Me.edScreenshotsFolder.Text = "c:\"
        '
        'tbJPEGQuality
        '
        Me.tbJPEGQuality.BackColor = System.Drawing.SystemColors.Window
        Me.tbJPEGQuality.Location = New System.Drawing.Point(193, 43)
        Me.tbJPEGQuality.Maximum = 100
        Me.tbJPEGQuality.Name = "tbJPEGQuality"
        Me.tbJPEGQuality.Size = New System.Drawing.Size(64, 45)
        Me.tbJPEGQuality.TabIndex = 38
        Me.tbJPEGQuality.TickFrequency = 5
        Me.tbJPEGQuality.Value = 85
        '
        'btStart
        '
        Me.btStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btStart.Location = New System.Drawing.Point(691, 410)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(62, 23)
        Me.btStart.TabIndex = 53
        Me.btStart.Text = "Start"
        Me.btStart.UseVisualStyleBackColor = true
        '
        'btSelectOutput
        '
        Me.btSelectOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btSelectOutput.Location = New System.Drawing.Point(353, 410)
        Me.btSelectOutput.Name = "btSelectOutput"
        Me.btSelectOutput.Size = New System.Drawing.Size(24, 23)
        Me.btSelectOutput.TabIndex = 52
        Me.btSelectOutput.Text = "..."
        Me.btSelectOutput.UseVisualStyleBackColor = true
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.edImageLogoTop)
        Me.tabPage3.Controls.Add(Me.cbImageLogo)
        Me.tabPage3.Controls.Add(Me.label155)
        Me.tabPage3.Controls.Add(Me.tbImageLogoTransp)
        Me.tabPage3.Controls.Add(Me.edImageLogoLeft)
        Me.tabPage3.Controls.Add(Me.label156)
        Me.tabPage3.Controls.Add(Me.label154)
        Me.tabPage3.Controls.Add(Me.btSelectImage)
        Me.tabPage3.Controls.Add(Me.label157)
        Me.tabPage3.Controls.Add(Me.edImageLogoFilename)
        Me.tabPage3.Controls.Add(Me.label32)
        Me.tabPage3.Controls.Add(Me.tbTextLogoTransp)
        Me.tabPage3.Controls.Add(Me.edTextLogoTop)
        Me.tabPage3.Controls.Add(Me.label139)
        Me.tabPage3.Controls.Add(Me.edTextLogoLeft)
        Me.tabPage3.Controls.Add(Me.label140)
        Me.tabPage3.Controls.Add(Me.btFont)
        Me.tabPage3.Controls.Add(Me.edTextLogo)
        Me.tabPage3.Controls.Add(Me.cbTextLogo)
        Me.tabPage3.Location = New System.Drawing.Point(4, 22)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage3.Size = New System.Drawing.Size(370, 374)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Video effects"
        Me.tabPage3.UseVisualStyleBackColor = true
        '
        'edImageLogoTop
        '
        Me.edImageLogoTop.Location = New System.Drawing.Point(65, 278)
        Me.edImageLogoTop.Name = "edImageLogoTop"
        Me.edImageLogoTop.Size = New System.Drawing.Size(39, 20)
        Me.edImageLogoTop.TabIndex = 56
        Me.edImageLogoTop.Text = "50"
        Me.edImageLogoTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbImageLogo
        '
        Me.cbImageLogo.AutoSize = true
        Me.cbImageLogo.Location = New System.Drawing.Point(19, 191)
        Me.cbImageLogo.Name = "cbImageLogo"
        Me.cbImageLogo.Size = New System.Drawing.Size(78, 17)
        Me.cbImageLogo.TabIndex = 57
        Me.cbImageLogo.Text = "Image logo"
        Me.cbImageLogo.UseVisualStyleBackColor = true
        '
        'label155
        '
        Me.label155.AutoSize = true
        Me.label155.Location = New System.Drawing.Point(32, 281)
        Me.label155.Name = "label155"
        Me.label155.Size = New System.Drawing.Size(26, 13)
        Me.label155.TabIndex = 55
        Me.label155.Text = "Top"
        '
        'tbImageLogoTransp
        '
        Me.tbImageLogoTransp.BackColor = System.Drawing.SystemColors.Window
        Me.tbImageLogoTransp.Location = New System.Drawing.Point(141, 271)
        Me.tbImageLogoTransp.Maximum = 255
        Me.tbImageLogoTransp.Name = "tbImageLogoTransp"
        Me.tbImageLogoTransp.Size = New System.Drawing.Size(104, 45)
        Me.tbImageLogoTransp.TabIndex = 61
        '
        'edImageLogoLeft
        '
        Me.edImageLogoLeft.Location = New System.Drawing.Point(65, 252)
        Me.edImageLogoLeft.Name = "edImageLogoLeft"
        Me.edImageLogoLeft.Size = New System.Drawing.Size(39, 20)
        Me.edImageLogoLeft.TabIndex = 54
        Me.edImageLogoLeft.Text = "50"
        Me.edImageLogoLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label156
        '
        Me.label156.AutoSize = true
        Me.label156.Location = New System.Drawing.Point(32, 255)
        Me.label156.Name = "label156"
        Me.label156.Size = New System.Drawing.Size(25, 13)
        Me.label156.TabIndex = 53
        Me.label156.Text = "Left"
        '
        'label154
        '
        Me.label154.AutoSize = true
        Me.label154.Location = New System.Drawing.Point(142, 255)
        Me.label154.Name = "label154"
        Me.label154.Size = New System.Drawing.Size(72, 13)
        Me.label154.TabIndex = 62
        Me.label154.Text = "Transparency"
        '
        'btSelectImage
        '
        Me.btSelectImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btSelectImage.Location = New System.Drawing.Point(330, 212)
        Me.btSelectImage.Name = "btSelectImage"
        Me.btSelectImage.Size = New System.Drawing.Size(24, 23)
        Me.btSelectImage.TabIndex = 60
        Me.btSelectImage.Text = "..."
        Me.btSelectImage.UseVisualStyleBackColor = true
        '
        'label157
        '
        Me.label157.AutoSize = true
        Me.label157.Location = New System.Drawing.Point(32, 217)
        Me.label157.Name = "label157"
        Me.label157.Size = New System.Drawing.Size(52, 13)
        Me.label157.TabIndex = 59
        Me.label157.Text = "File name"
        '
        'edImageLogoFilename
        '
        Me.edImageLogoFilename.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.edImageLogoFilename.Location = New System.Drawing.Point(90, 214)
        Me.edImageLogoFilename.Name = "edImageLogoFilename"
        Me.edImageLogoFilename.Size = New System.Drawing.Size(234, 20)
        Me.edImageLogoFilename.TabIndex = 58
        Me.edImageLogoFilename.Text = "c:\1.png"
        '
        'label32
        '
        Me.label32.AutoSize = true
        Me.label32.Location = New System.Drawing.Point(142, 81)
        Me.label32.Name = "label32"
        Me.label32.Size = New System.Drawing.Size(103, 13)
        Me.label32.TabIndex = 28
        Me.label32.Text = "Transparency (layer)"
        '
        'tbTextLogoTransp
        '
        Me.tbTextLogoTransp.BackColor = System.Drawing.SystemColors.Window
        Me.tbTextLogoTransp.Location = New System.Drawing.Point(142, 97)
        Me.tbTextLogoTransp.Maximum = 255
        Me.tbTextLogoTransp.Name = "tbTextLogoTransp"
        Me.tbTextLogoTransp.Size = New System.Drawing.Size(103, 45)
        Me.tbTextLogoTransp.TabIndex = 27
        Me.tbTextLogoTransp.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbTextLogoTransp.Value = 127
        '
        'edTextLogoTop
        '
        Me.edTextLogoTop.Location = New System.Drawing.Point(65, 104)
        Me.edTextLogoTop.Name = "edTextLogoTop"
        Me.edTextLogoTop.Size = New System.Drawing.Size(33, 20)
        Me.edTextLogoTop.TabIndex = 23
        Me.edTextLogoTop.Text = "50"
        '
        'label139
        '
        Me.label139.AutoSize = true
        Me.label139.Location = New System.Drawing.Point(29, 107)
        Me.label139.Name = "label139"
        Me.label139.Size = New System.Drawing.Size(26, 13)
        Me.label139.TabIndex = 22
        Me.label139.Text = "Top"
        '
        'edTextLogoLeft
        '
        Me.edTextLogoLeft.Location = New System.Drawing.Point(65, 78)
        Me.edTextLogoLeft.Name = "edTextLogoLeft"
        Me.edTextLogoLeft.Size = New System.Drawing.Size(33, 20)
        Me.edTextLogoLeft.TabIndex = 21
        Me.edTextLogoLeft.Text = "50"
        '
        'label140
        '
        Me.label140.AutoSize = true
        Me.label140.Location = New System.Drawing.Point(29, 81)
        Me.label140.Name = "label140"
        Me.label140.Size = New System.Drawing.Size(25, 13)
        Me.label140.TabIndex = 20
        Me.label140.Text = "Left"
        '
        'btFont
        '
        Me.btFont.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btFont.Location = New System.Drawing.Point(307, 44)
        Me.btFont.Name = "btFont"
        Me.btFont.Size = New System.Drawing.Size(47, 23)
        Me.btFont.TabIndex = 19
        Me.btFont.Text = "Font"
        Me.btFont.UseVisualStyleBackColor = true
        '
        'edTextLogo
        '
        Me.edTextLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.edTextLogo.Location = New System.Drawing.Point(32, 46)
        Me.edTextLogo.Name = "edTextLogo"
        Me.edTextLogo.Size = New System.Drawing.Size(266, 20)
        Me.edTextLogo.TabIndex = 18
        Me.edTextLogo.Text = "Hello!!!"
        '
        'cbTextLogo
        '
        Me.cbTextLogo.AutoSize = true
        Me.cbTextLogo.Location = New System.Drawing.Point(19, 23)
        Me.cbTextLogo.Name = "cbTextLogo"
        Me.cbTextLogo.Size = New System.Drawing.Size(70, 17)
        Me.cbTextLogo.TabIndex = 17
        Me.cbTextLogo.Text = "Text logo"
        Me.cbTextLogo.UseVisualStyleBackColor = true
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cbLicensing)
        Me.groupBox1.Controls.Add(Me.cbDebugMode)
        Me.groupBox1.Controls.Add(Me.mmLog)
        Me.groupBox1.Location = New System.Drawing.Point(6, 90)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(358, 278)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = false
        Me.groupBox1.Text = "Errors/Warnings"
        '
        'cbLicensing
        '
        Me.cbLicensing.AutoSize = true
        Me.cbLicensing.Location = New System.Drawing.Point(165, 19)
        Me.cbLicensing.Name = "cbLicensing"
        Me.cbLicensing.Size = New System.Drawing.Size(91, 17)
        Me.cbLicensing.TabIndex = 76
        Me.cbLicensing.Text = "Licensing info"
        Me.cbLicensing.UseVisualStyleBackColor = true
        '
        'cbDebugMode
        '
        Me.cbDebugMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbDebugMode.AutoSize = true
        Me.cbDebugMode.Location = New System.Drawing.Point(265, 19)
        Me.cbDebugMode.Name = "cbDebugMode"
        Me.cbDebugMode.Size = New System.Drawing.Size(87, 17)
        Me.cbDebugMode.TabIndex = 75
        Me.cbDebugMode.Text = "Debug mode"
        Me.cbDebugMode.UseVisualStyleBackColor = true
        '
        'mmLog
        '
        Me.mmLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.mmLog.Location = New System.Drawing.Point(6, 42)
        Me.mmLog.Multiline = true
        Me.mmLog.Name = "mmLog"
        Me.mmLog.Size = New System.Drawing.Size(346, 230)
        Me.mmLog.TabIndex = 74
        '
        'tabPage4
        '
        Me.tabPage4.Controls.Add(Me.groupBox2)
        Me.tabPage4.Controls.Add(Me.groupBox1)
        Me.tabPage4.Location = New System.Drawing.Point(4, 22)
        Me.tabPage4.Name = "tabPage4"
        Me.tabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage4.Size = New System.Drawing.Size(370, 374)
        Me.tabPage4.TabIndex = 3
        Me.tabPage4.Text = "More"
        Me.tabPage4.UseVisualStyleBackColor = true
        '
        'edOutput
        '
        Me.edOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.edOutput.Location = New System.Drawing.Point(66, 412)
        Me.edOutput.Name = "edOutput"
        Me.edOutput.Size = New System.Drawing.Size(281, 20)
        Me.edOutput.TabIndex = 51
        Me.edOutput.Text = "c:\capture.avi"
        '
        'label9
        '
        Me.label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.label9.AutoSize = true
        Me.label9.Location = New System.Drawing.Point(9, 415)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(52, 13)
        Me.label9.TabIndex = 50
        Me.label9.Text = "File name"
        '
        'cbUseBestAudioInputFormat
        '
        Me.cbUseBestAudioInputFormat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbUseBestAudioInputFormat.AutoSize = true
        Me.cbUseBestAudioInputFormat.Location = New System.Drawing.Point(296, 309)
        Me.cbUseBestAudioInputFormat.Name = "cbUseBestAudioInputFormat"
        Me.cbUseBestAudioInputFormat.Size = New System.Drawing.Size(68, 17)
        Me.cbUseBestAudioInputFormat.TabIndex = 83
        Me.cbUseBestAudioInputFormat.Text = "Use best"
        Me.cbUseBestAudioInputFormat.UseVisualStyleBackColor = true
        '
        'btAudioInputDeviceSettings
        '
        Me.btAudioInputDeviceSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btAudioInputDeviceSettings.Location = New System.Drawing.Point(288, 277)
        Me.btAudioInputDeviceSettings.Name = "btAudioInputDeviceSettings"
        Me.btAudioInputDeviceSettings.Size = New System.Drawing.Size(76, 23)
        Me.btAudioInputDeviceSettings.TabIndex = 82
        Me.btAudioInputDeviceSettings.Text = "Settings"
        Me.btAudioInputDeviceSettings.UseVisualStyleBackColor = true
        '
        'cbAudioInputLine
        '
        Me.cbAudioInputLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAudioInputLine.FormattingEnabled = true
        Me.cbAudioInputLine.Location = New System.Drawing.Point(10, 327)
        Me.cbAudioInputLine.Name = "cbAudioInputLine"
        Me.cbAudioInputLine.Size = New System.Drawing.Size(161, 21)
        Me.cbAudioInputLine.TabIndex = 81
        '
        'cbAudioInputFormat
        '
        Me.cbAudioInputFormat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbAudioInputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAudioInputFormat.FormattingEnabled = true
        Me.cbAudioInputFormat.Location = New System.Drawing.Point(184, 326)
        Me.cbAudioInputFormat.Name = "cbAudioInputFormat"
        Me.cbAudioInputFormat.Size = New System.Drawing.Size(180, 21)
        Me.cbAudioInputFormat.TabIndex = 80
        '
        'cbAudioInputDevice
        '
        Me.cbAudioInputDevice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbAudioInputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAudioInputDevice.FormattingEnabled = true
        Me.cbAudioInputDevice.Location = New System.Drawing.Point(10, 279)
        Me.cbAudioInputDevice.Name = "cbAudioInputDevice"
        Me.cbAudioInputDevice.Size = New System.Drawing.Size(272, 21)
        Me.cbAudioInputDevice.TabIndex = 79
        '
        'label22
        '
        Me.label22.AutoSize = true
        Me.label22.Location = New System.Drawing.Point(7, 311)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(50, 13)
        Me.label22.TabIndex = 78
        Me.label22.Text = "Input line"
        '
        'label23
        '
        Me.label23.AutoSize = true
        Me.label23.Location = New System.Drawing.Point(7, 261)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(66, 13)
        Me.label23.TabIndex = 77
        Me.label23.Text = "Input device"
        '
        'label25
        '
        Me.label25.AutoSize = true
        Me.label25.Location = New System.Drawing.Point(181, 309)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(63, 13)
        Me.label25.TabIndex = 76
        Me.label25.Text = "Input format"
        '
        'cbRecordAudio
        '
        Me.cbRecordAudio.AutoSize = true
        Me.cbRecordAudio.Location = New System.Drawing.Point(10, 234)
        Me.cbRecordAudio.Name = "cbRecordAudio"
        Me.cbRecordAudio.Size = New System.Drawing.Size(90, 17)
        Me.cbRecordAudio.TabIndex = 66
        Me.cbRecordAudio.Text = "Record audio"
        Me.cbRecordAudio.UseVisualStyleBackColor = true
        '
        'btScreenCaptureUpdate
        '
        Me.btScreenCaptureUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btScreenCaptureUpdate.Location = New System.Drawing.Point(252, 61)
        Me.btScreenCaptureUpdate.Name = "btScreenCaptureUpdate"
        Me.btScreenCaptureUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btScreenCaptureUpdate.TabIndex = 65
        Me.btScreenCaptureUpdate.Text = "Update"
        Me.btScreenCaptureUpdate.UseVisualStyleBackColor = true
        '
        'label124
        '
        Me.label124.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.label124.AutoSize = true
        Me.label124.Location = New System.Drawing.Point(205, 34)
        Me.label124.Name = "label124"
        Me.label124.Size = New System.Drawing.Size(50, 13)
        Me.label124.TabIndex = 64
        Me.label124.Text = "on-the-fly"
        '
        'label123
        '
        Me.label123.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.label123.AutoSize = true
        Me.label123.Location = New System.Drawing.Point(205, 21)
        Me.label123.Name = "label123"
        Me.label123.Size = New System.Drawing.Size(141, 13)
        Me.label123.TabIndex = 63
        Me.label123.Text = "and mouse cursor  capturing"
        '
        'label122
        '
        Me.label122.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.label122.AutoSize = true
        Me.label122.Location = New System.Drawing.Point(205, 8)
        Me.label122.Name = "label122"
        Me.label122.Size = New System.Drawing.Size(159, 13)
        Me.label122.TabIndex = 62
        Me.label122.Text = "You can update left/top position"
        '
        'cbScreenCapture_GrabMouseCursor
        '
        Me.cbScreenCapture_GrabMouseCursor.AutoSize = true
        Me.cbScreenCapture_GrabMouseCursor.Location = New System.Drawing.Point(10, 180)
        Me.cbScreenCapture_GrabMouseCursor.Name = "cbScreenCapture_GrabMouseCursor"
        Me.cbScreenCapture_GrabMouseCursor.Size = New System.Drawing.Size(129, 17)
        Me.cbScreenCapture_GrabMouseCursor.TabIndex = 61
        Me.cbScreenCapture_GrabMouseCursor.Text = "Capture mouse cursor"
        Me.cbScreenCapture_GrabMouseCursor.UseVisualStyleBackColor = true
        '
        'label79
        '
        Me.label79.AutoSize = true
        Me.label79.Location = New System.Drawing.Point(131, 131)
        Me.label79.Name = "label79"
        Me.label79.Size = New System.Drawing.Size(21, 13)
        Me.label79.TabIndex = 60
        Me.label79.Text = "fps"
        '
        'edScreenFrameRate
        '
        Me.edScreenFrameRate.Location = New System.Drawing.Point(80, 128)
        Me.edScreenFrameRate.Name = "edScreenFrameRate"
        Me.edScreenFrameRate.Size = New System.Drawing.Size(45, 20)
        Me.edScreenFrameRate.TabIndex = 59
        Me.edScreenFrameRate.Text = "5"
        '
        'label43
        '
        Me.label43.AutoSize = true
        Me.label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.label43.Location = New System.Drawing.Point(7, 131)
        Me.label43.Name = "label43"
        Me.label43.Size = New System.Drawing.Size(67, 13)
        Me.label43.TabIndex = 58
        Me.label43.Text = "Frame rate"
        '
        'edScreenBottom
        '
        Me.edScreenBottom.Location = New System.Drawing.Point(174, 89)
        Me.edScreenBottom.Name = "edScreenBottom"
        Me.edScreenBottom.Size = New System.Drawing.Size(44, 20)
        Me.edScreenBottom.TabIndex = 57
        Me.edScreenBottom.Text = "480"
        '
        'label42
        '
        Me.label42.AutoSize = true
        Me.label42.Location = New System.Drawing.Point(131, 92)
        Me.label42.Name = "label42"
        Me.label42.Size = New System.Drawing.Size(40, 13)
        Me.label42.TabIndex = 56
        Me.label42.Text = "Bottom"
        '
        'edScreenTop
        '
        Me.edScreenTop.Location = New System.Drawing.Point(174, 63)
        Me.edScreenTop.Name = "edScreenTop"
        Me.edScreenTop.Size = New System.Drawing.Size(44, 20)
        Me.edScreenTop.TabIndex = 53
        Me.edScreenTop.Text = "0"
        '
        'label26
        '
        Me.label26.AutoSize = true
        Me.label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.label26.Location = New System.Drawing.Point(131, 66)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(29, 13)
        Me.label26.TabIndex = 52
        Me.label26.Text = "Top"
        '
        'edScreenRight
        '
        Me.edScreenRight.Location = New System.Drawing.Point(70, 89)
        Me.edScreenRight.Name = "edScreenRight"
        Me.edScreenRight.Size = New System.Drawing.Size(44, 20)
        Me.edScreenRight.TabIndex = 55
        Me.edScreenRight.Text = "640"
        '
        'label40
        '
        Me.label40.AutoSize = true
        Me.label40.Location = New System.Drawing.Point(29, 92)
        Me.label40.Name = "label40"
        Me.label40.Size = New System.Drawing.Size(32, 13)
        Me.label40.TabIndex = 54
        Me.label40.Text = "Right"
        '
        'fontDialog1
        '
        Me.fontDialog1.Color = System.Drawing.Color.White
        Me.fontDialog1.Font = New System.Drawing.Font("Microsoft Sans Serif", 32!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.fontDialog1.FontMustExist = true
        Me.fontDialog1.ShowColor = true
        '
        'edScreenLeft
        '
        Me.edScreenLeft.Location = New System.Drawing.Point(70, 63)
        Me.edScreenLeft.Name = "edScreenLeft"
        Me.edScreenLeft.Size = New System.Drawing.Size(44, 20)
        Me.edScreenLeft.TabIndex = 51
        Me.edScreenLeft.Text = "0"
        '
        'tabControl1
        '
        Me.tabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Controls.Add(Me.tabPage4)
        Me.tabControl1.Location = New System.Drawing.Point(3, 4)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(378, 400)
        Me.tabControl1.TabIndex = 49
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.cbScreenCapture_DesktopDuplication)
        Me.tabPage1.Controls.Add(Me.label294)
        Me.tabPage1.Controls.Add(Me.edScreenCaptureWindowName)
        Me.tabPage1.Controls.Add(Me.rbScreenCaptureWindow)
        Me.tabPage1.Controls.Add(Me.cbScreenCaptureDisplayIndex)
        Me.tabPage1.Controls.Add(Me.label93)
        Me.tabPage1.Controls.Add(Me.cbUseBestAudioInputFormat)
        Me.tabPage1.Controls.Add(Me.btAudioInputDeviceSettings)
        Me.tabPage1.Controls.Add(Me.cbAudioInputLine)
        Me.tabPage1.Controls.Add(Me.cbAudioInputFormat)
        Me.tabPage1.Controls.Add(Me.cbAudioInputDevice)
        Me.tabPage1.Controls.Add(Me.label22)
        Me.tabPage1.Controls.Add(Me.label23)
        Me.tabPage1.Controls.Add(Me.label25)
        Me.tabPage1.Controls.Add(Me.cbRecordAudio)
        Me.tabPage1.Controls.Add(Me.btScreenCaptureUpdate)
        Me.tabPage1.Controls.Add(Me.label124)
        Me.tabPage1.Controls.Add(Me.label123)
        Me.tabPage1.Controls.Add(Me.label122)
        Me.tabPage1.Controls.Add(Me.cbScreenCapture_GrabMouseCursor)
        Me.tabPage1.Controls.Add(Me.label79)
        Me.tabPage1.Controls.Add(Me.edScreenFrameRate)
        Me.tabPage1.Controls.Add(Me.label43)
        Me.tabPage1.Controls.Add(Me.edScreenBottom)
        Me.tabPage1.Controls.Add(Me.label42)
        Me.tabPage1.Controls.Add(Me.edScreenRight)
        Me.tabPage1.Controls.Add(Me.label40)
        Me.tabPage1.Controls.Add(Me.edScreenTop)
        Me.tabPage1.Controls.Add(Me.label26)
        Me.tabPage1.Controls.Add(Me.edScreenLeft)
        Me.tabPage1.Controls.Add(Me.label24)
        Me.tabPage1.Controls.Add(Me.rbScreenCustomArea)
        Me.tabPage1.Controls.Add(Me.rbScreenFullScreen)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(370, 374)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Input"
        Me.tabPage1.UseVisualStyleBackColor = true
        '
        'cbScreenCapture_DesktopDuplication
        '
        Me.cbScreenCapture_DesktopDuplication.AutoSize = true
        Me.cbScreenCapture_DesktopDuplication.Location = New System.Drawing.Point(10, 203)
        Me.cbScreenCapture_DesktopDuplication.Name = "cbScreenCapture_DesktopDuplication"
        Me.cbScreenCapture_DesktopDuplication.Size = New System.Drawing.Size(210, 17)
        Me.cbScreenCapture_DesktopDuplication.TabIndex = 89
        Me.cbScreenCapture_DesktopDuplication.Text = "Allow Win8 Desktop Duplication usage"
        Me.cbScreenCapture_DesktopDuplication.UseVisualStyleBackColor = true
        '
        'label294
        '
        Me.label294.AutoSize = true
        Me.label294.Location = New System.Drawing.Point(193, 147)
        Me.label294.Name = "label294"
        Me.label294.Size = New System.Drawing.Size(135, 13)
        Me.label294.TabIndex = 88
        Me.label294.Text = "class, Notepad an example"
        '
        'edScreenCaptureWindowName
        '
        Me.edScreenCaptureWindowName.Location = New System.Drawing.Point(174, 177)
        Me.edScreenCaptureWindowName.Name = "edScreenCaptureWindowName"
        Me.edScreenCaptureWindowName.Size = New System.Drawing.Size(162, 20)
        Me.edScreenCaptureWindowName.TabIndex = 87
        Me.edScreenCaptureWindowName.Text = "Notepad"
        '
        'rbScreenCaptureWindow
        '
        Me.rbScreenCaptureWindow.AutoSize = true
        Me.rbScreenCaptureWindow.Location = New System.Drawing.Point(174, 127)
        Me.rbScreenCaptureWindow.Name = "rbScreenCaptureWindow"
        Me.rbScreenCaptureWindow.Size = New System.Drawing.Size(179, 17)
        Me.rbScreenCaptureWindow.TabIndex = 86
        Me.rbScreenCaptureWindow.TabStop = true
        Me.rbScreenCaptureWindow.Text = "Capture window (specify window"
        Me.rbScreenCaptureWindow.UseVisualStyleBackColor = true
        '
        'cbScreenCaptureDisplayIndex
        '
        Me.cbScreenCaptureDisplayIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbScreenCaptureDisplayIndex.FormattingEnabled = true
        Me.cbScreenCaptureDisplayIndex.Location = New System.Drawing.Point(80, 153)
        Me.cbScreenCaptureDisplayIndex.Name = "cbScreenCaptureDisplayIndex"
        Me.cbScreenCaptureDisplayIndex.Size = New System.Drawing.Size(44, 21)
        Me.cbScreenCaptureDisplayIndex.TabIndex = 85
        '
        'label93
        '
        Me.label93.AutoSize = true
        Me.label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.label93.Location = New System.Drawing.Point(7, 156)
        Me.label93.Name = "label93"
        Me.label93.Size = New System.Drawing.Size(65, 13)
        Me.label93.TabIndex = 84
        Me.label93.Text = "Display ID"
        '
        'label24
        '
        Me.label24.AutoSize = true
        Me.label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.label24.Location = New System.Drawing.Point(29, 66)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(29, 13)
        Me.label24.TabIndex = 50
        Me.label24.Text = "Left"
        '
        'rbScreenCustomArea
        '
        Me.rbScreenCustomArea.AutoSize = true
        Me.rbScreenCustomArea.Location = New System.Drawing.Point(10, 36)
        Me.rbScreenCustomArea.Name = "rbScreenCustomArea"
        Me.rbScreenCustomArea.Size = New System.Drawing.Size(84, 17)
        Me.rbScreenCustomArea.TabIndex = 49
        Me.rbScreenCustomArea.Text = "Custom area"
        Me.rbScreenCustomArea.UseVisualStyleBackColor = true
        '
        'rbScreenFullScreen
        '
        Me.rbScreenFullScreen.AutoSize = true
        Me.rbScreenFullScreen.Checked = true
        Me.rbScreenFullScreen.Location = New System.Drawing.Point(10, 12)
        Me.rbScreenFullScreen.Name = "rbScreenFullScreen"
        Me.rbScreenFullScreen.Size = New System.Drawing.Size(76, 17)
        Me.rbScreenFullScreen.TabIndex = 48
        Me.rbScreenFullScreen.TabStop = true
        Me.rbScreenFullScreen.Text = "Full screen"
        Me.rbScreenFullScreen.UseVisualStyleBackColor = true
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.tabControl2)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(370, 374)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Output"
        Me.tabPage2.UseVisualStyleBackColor = true
        '
        'tabControl2
        '
        Me.tabControl2.Controls.Add(Me.tabPage5)
        Me.tabControl2.Controls.Add(Me.tabPage6)
        Me.tabControl2.Controls.Add(Me.tabPage7)
        Me.tabControl2.Location = New System.Drawing.Point(6, 6)
        Me.tabControl2.Name = "tabControl2"
        Me.tabControl2.SelectedIndex = 0
        Me.tabControl2.Size = New System.Drawing.Size(358, 362)
        Me.tabControl2.TabIndex = 45
        '
        'tabPage5
        '
        Me.tabPage5.Controls.Add(Me.label27)
        Me.tabPage5.Controls.Add(Me.btAudioSettings)
        Me.tabPage5.Controls.Add(Me.btVideoSettings)
        Me.tabPage5.Controls.Add(Me.label28)
        Me.tabPage5.Controls.Add(Me.label29)
        Me.tabPage5.Controls.Add(Me.label30)
        Me.tabPage5.Controls.Add(Me.label31)
        Me.tabPage5.Controls.Add(Me.cbChannels)
        Me.tabPage5.Controls.Add(Me.cbBPS)
        Me.tabPage5.Controls.Add(Me.cbAudioCodecs)
        Me.tabPage5.Controls.Add(Me.cbSampleRate)
        Me.tabPage5.Controls.Add(Me.cbVideoCodecs)
        Me.tabPage5.Location = New System.Drawing.Point(4, 22)
        Me.tabPage5.Name = "tabPage5"
        Me.tabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage5.Size = New System.Drawing.Size(350, 336)
        Me.tabPage5.TabIndex = 0
        Me.tabPage5.Text = "AVI"
        Me.tabPage5.UseVisualStyleBackColor = true
        '
        'label27
        '
        Me.label27.AutoSize = true
        Me.label27.Location = New System.Drawing.Point(11, 45)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(67, 13)
        Me.label27.TabIndex = 51
        Me.label27.Text = "Audio codec"
        '
        'btAudioSettings
        '
        Me.btAudioSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btAudioSettings.Location = New System.Drawing.Point(278, 42)
        Me.btAudioSettings.Name = "btAudioSettings"
        Me.btAudioSettings.Size = New System.Drawing.Size(64, 23)
        Me.btAudioSettings.TabIndex = 50
        Me.btAudioSettings.Text = "Settings"
        Me.btAudioSettings.UseVisualStyleBackColor = true
        '
        'btVideoSettings
        '
        Me.btVideoSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btVideoSettings.Location = New System.Drawing.Point(278, 15)
        Me.btVideoSettings.Name = "btVideoSettings"
        Me.btVideoSettings.Size = New System.Drawing.Size(64, 23)
        Me.btVideoSettings.TabIndex = 49
        Me.btVideoSettings.Text = "Settings"
        Me.btVideoSettings.UseVisualStyleBackColor = true
        '
        'label28
        '
        Me.label28.AutoSize = true
        Me.label28.Location = New System.Drawing.Point(27, 99)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(63, 13)
        Me.label28.TabIndex = 48
        Me.label28.Text = "Sample rate"
        '
        'label29
        '
        Me.label29.AutoSize = true
        Me.label29.Location = New System.Drawing.Point(179, 72)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(28, 13)
        Me.label29.TabIndex = 47
        Me.label29.Text = "BPS"
        '
        'label30
        '
        Me.label30.AutoSize = true
        Me.label30.Location = New System.Drawing.Point(27, 72)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(51, 13)
        Me.label30.TabIndex = 46
        Me.label30.Text = "Channels"
        '
        'label31
        '
        Me.label31.AutoSize = true
        Me.label31.Location = New System.Drawing.Point(12, 18)
        Me.label31.Name = "label31"
        Me.label31.Size = New System.Drawing.Size(67, 13)
        Me.label31.TabIndex = 45
        Me.label31.Text = "Video codec"
        '
        'cbChannels
        '
        Me.cbChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbChannels.FormattingEnabled = true
        Me.cbChannels.Items.AddRange(New Object() {"1", "2"})
        Me.cbChannels.Location = New System.Drawing.Point(104, 69)
        Me.cbChannels.Name = "cbChannels"
        Me.cbChannels.Size = New System.Drawing.Size(65, 21)
        Me.cbChannels.TabIndex = 44
        '
        'cbBPS
        '
        Me.cbBPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBPS.FormattingEnabled = true
        Me.cbBPS.Items.AddRange(New Object() {"8", "16"})
        Me.cbBPS.Location = New System.Drawing.Point(213, 69)
        Me.cbBPS.Name = "cbBPS"
        Me.cbBPS.Size = New System.Drawing.Size(59, 21)
        Me.cbBPS.TabIndex = 43
        '
        'cbAudioCodecs
        '
        Me.cbAudioCodecs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAudioCodecs.FormattingEnabled = true
        Me.cbAudioCodecs.Location = New System.Drawing.Point(104, 42)
        Me.cbAudioCodecs.Name = "cbAudioCodecs"
        Me.cbAudioCodecs.Size = New System.Drawing.Size(168, 21)
        Me.cbAudioCodecs.TabIndex = 42
        '
        'cbSampleRate
        '
        Me.cbSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSampleRate.FormattingEnabled = true
        Me.cbSampleRate.Items.AddRange(New Object() {"48000", "44100", "32000", "24000", "22050", "16000", "12000", "11025", "8000"})
        Me.cbSampleRate.Location = New System.Drawing.Point(104, 96)
        Me.cbSampleRate.Name = "cbSampleRate"
        Me.cbSampleRate.Size = New System.Drawing.Size(65, 21)
        Me.cbSampleRate.TabIndex = 41
        '
        'cbVideoCodecs
        '
        Me.cbVideoCodecs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbVideoCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVideoCodecs.FormattingEnabled = true
        Me.cbVideoCodecs.Location = New System.Drawing.Point(104, 15)
        Me.cbVideoCodecs.Name = "cbVideoCodecs"
        Me.cbVideoCodecs.Size = New System.Drawing.Size(168, 21)
        Me.cbVideoCodecs.TabIndex = 40
        '
        'tabPage6
        '
        Me.tabPage6.Controls.Add(Me.label33)
        Me.tabPage6.Controls.Add(Me.cbWMVInternalProfile9)
        Me.tabPage6.Location = New System.Drawing.Point(4, 22)
        Me.tabPage6.Name = "tabPage6"
        Me.tabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage6.Size = New System.Drawing.Size(350, 336)
        Me.tabPage6.TabIndex = 1
        Me.tabPage6.Text = "WMV"
        Me.tabPage6.UseVisualStyleBackColor = true
        '
        'label33
        '
        Me.label33.AutoSize = true
        Me.label33.Location = New System.Drawing.Point(12, 15)
        Me.label33.Name = "label33"
        Me.label33.Size = New System.Drawing.Size(36, 13)
        Me.label33.TabIndex = 45
        Me.label33.Text = "Profile"
        '
        'cbWMVInternalProfile9
        '
        Me.cbWMVInternalProfile9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbWMVInternalProfile9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWMVInternalProfile9.FormattingEnabled = true
        Me.cbWMVInternalProfile9.Location = New System.Drawing.Point(15, 31)
        Me.cbWMVInternalProfile9.Name = "cbWMVInternalProfile9"
        Me.cbWMVInternalProfile9.Size = New System.Drawing.Size(321, 21)
        Me.cbWMVInternalProfile9.TabIndex = 44
        '
        'tabPage7
        '
        Me.tabPage7.Controls.Add(Me.tabControl3)
        Me.tabPage7.Location = New System.Drawing.Point(4, 22)
        Me.tabPage7.Name = "tabPage7"
        Me.tabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage7.Size = New System.Drawing.Size(350, 336)
        Me.tabPage7.TabIndex = 2
        Me.tabPage7.Text = "MP4"
        Me.tabPage7.UseVisualStyleBackColor = true
        '
        'tabControl3
        '
        Me.tabControl3.Controls.Add(Me.tabPage9)
        Me.tabControl3.Controls.Add(Me.tabPage10)
        Me.tabControl3.Location = New System.Drawing.Point(7, 6)
        Me.tabControl3.Name = "tabControl3"
        Me.tabControl3.SelectedIndex = 0
        Me.tabControl3.Size = New System.Drawing.Size(337, 324)
        Me.tabControl3.TabIndex = 1
        '
        'tabPage9
        '
        Me.tabPage9.Controls.Add(Me.groupBox29)
        Me.tabPage9.Controls.Add(Me.groupBox46)
        Me.tabPage9.Location = New System.Drawing.Point(4, 22)
        Me.tabPage9.Name = "tabPage9"
        Me.tabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage9.Size = New System.Drawing.Size(329, 298)
        Me.tabPage9.TabIndex = 1
        Me.tabPage9.Text = "Video"
        Me.tabPage9.UseVisualStyleBackColor = true
        '
        'groupBox29
        '
        Me.groupBox29.Controls.Add(Me.cbH264GOP)
        Me.groupBox29.Controls.Add(Me.cbH264AutoBitrate)
        Me.groupBox29.Controls.Add(Me.label350)
        Me.groupBox29.Controls.Add(Me.edH264Bitrate)
        Me.groupBox29.Controls.Add(Me.label351)
        Me.groupBox29.Controls.Add(Me.cbH264RateControl)
        Me.groupBox29.Location = New System.Drawing.Point(18, 120)
        Me.groupBox29.Name = "groupBox29"
        Me.groupBox29.Size = New System.Drawing.Size(223, 98)
        Me.groupBox29.TabIndex = 7
        Me.groupBox29.TabStop = false
        Me.groupBox29.Text = "Bitrate"
        '
        'cbH264GOP
        '
        Me.cbH264GOP.AutoSize = true
        Me.cbH264GOP.Location = New System.Drawing.Point(166, 78)
        Me.cbH264GOP.Name = "cbH264GOP"
        Me.cbH264GOP.Size = New System.Drawing.Size(49, 17)
        Me.cbH264GOP.TabIndex = 12
        Me.cbH264GOP.Text = "GOP"
        Me.cbH264GOP.UseVisualStyleBackColor = true
        '
        'cbH264AutoBitrate
        '
        Me.cbH264AutoBitrate.AutoSize = true
        Me.cbH264AutoBitrate.Location = New System.Drawing.Point(10, 78)
        Me.cbH264AutoBitrate.Name = "cbH264AutoBitrate"
        Me.cbH264AutoBitrate.Size = New System.Drawing.Size(127, 17)
        Me.cbH264AutoBitrate.TabIndex = 7
        Me.cbH264AutoBitrate.Text = "Auto configure bitrate"
        Me.cbH264AutoBitrate.UseVisualStyleBackColor = true
        '
        'label350
        '
        Me.label350.AutoSize = true
        Me.label350.Location = New System.Drawing.Point(6, 53)
        Me.label350.Name = "label350"
        Me.label350.Size = New System.Drawing.Size(69, 13)
        Me.label350.TabIndex = 6
        Me.label350.Text = "Bitrate (kbps)"
        '
        'edH264Bitrate
        '
        Me.edH264Bitrate.Location = New System.Drawing.Point(94, 52)
        Me.edH264Bitrate.Name = "edH264Bitrate"
        Me.edH264Bitrate.Size = New System.Drawing.Size(121, 20)
        Me.edH264Bitrate.TabIndex = 5
        Me.edH264Bitrate.Text = "2000"
        Me.edH264Bitrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label351
        '
        Me.label351.AutoSize = true
        Me.label351.Location = New System.Drawing.Point(6, 21)
        Me.label351.Name = "label351"
        Me.label351.Size = New System.Drawing.Size(65, 13)
        Me.label351.TabIndex = 4
        Me.label351.Text = "Rate �ontrol"
        '
        'cbH264RateControl
        '
        Me.cbH264RateControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbH264RateControl.FormattingEnabled = true
        Me.cbH264RateControl.Items.AddRange(New Object() {"CBR", "VBR"})
        Me.cbH264RateControl.Location = New System.Drawing.Point(94, 19)
        Me.cbH264RateControl.Name = "cbH264RateControl"
        Me.cbH264RateControl.Size = New System.Drawing.Size(121, 21)
        Me.cbH264RateControl.TabIndex = 3
        '
        'groupBox46
        '
        Me.groupBox46.Controls.Add(Me.cbH264TargetUsage)
        Me.groupBox46.Controls.Add(Me.label359)
        Me.groupBox46.Controls.Add(Me.label352)
        Me.groupBox46.Controls.Add(Me.label353)
        Me.groupBox46.Controls.Add(Me.cbH264Level)
        Me.groupBox46.Controls.Add(Me.cbH264Profile)
        Me.groupBox46.Location = New System.Drawing.Point(18, 17)
        Me.groupBox46.Name = "groupBox46"
        Me.groupBox46.Size = New System.Drawing.Size(223, 97)
        Me.groupBox46.TabIndex = 6
        Me.groupBox46.TabStop = false
        Me.groupBox46.Text = "Profile settings"
        '
        'cbH264TargetUsage
        '
        Me.cbH264TargetUsage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbH264TargetUsage.FormattingEnabled = true
        Me.cbH264TargetUsage.Items.AddRange(New Object() {"Auto", "Best quality", "Balanced", "Best speed"})
        Me.cbH264TargetUsage.Location = New System.Drawing.Point(94, 73)
        Me.cbH264TargetUsage.Name = "cbH264TargetUsage"
        Me.cbH264TargetUsage.Size = New System.Drawing.Size(121, 21)
        Me.cbH264TargetUsage.TabIndex = 5
        '
        'label359
        '
        Me.label359.AutoSize = true
        Me.label359.Location = New System.Drawing.Point(7, 76)
        Me.label359.Name = "label359"
        Me.label359.Size = New System.Drawing.Size(70, 13)
        Me.label359.TabIndex = 4
        Me.label359.Text = "Target usage"
        '
        'label352
        '
        Me.label352.AutoSize = true
        Me.label352.Location = New System.Drawing.Point(7, 49)
        Me.label352.Name = "label352"
        Me.label352.Size = New System.Drawing.Size(33, 13)
        Me.label352.TabIndex = 3
        Me.label352.Text = "Level"
        '
        'label353
        '
        Me.label353.AutoSize = true
        Me.label353.Location = New System.Drawing.Point(7, 22)
        Me.label353.Name = "label353"
        Me.label353.Size = New System.Drawing.Size(36, 13)
        Me.label353.TabIndex = 2
        Me.label353.Text = "Profile"
        '
        'cbH264Level
        '
        Me.cbH264Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbH264Level.FormattingEnabled = true
        Me.cbH264Level.Items.AddRange(New Object() {"Auto", "1.0", "1.1", "1.2", "1.3", "2.0", "2.1", "2.2", "3.0", "3.1", "3.2", "4.0", "4.1", "4.2", "5.0", "5.1"})
        Me.cbH264Level.Location = New System.Drawing.Point(94, 46)
        Me.cbH264Level.Name = "cbH264Level"
        Me.cbH264Level.Size = New System.Drawing.Size(121, 21)
        Me.cbH264Level.TabIndex = 1
        '
        'cbH264Profile
        '
        Me.cbH264Profile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbH264Profile.FormattingEnabled = true
        Me.cbH264Profile.Items.AddRange(New Object() {"Auto", "Baseline", "Main", "High", "High 10", "High 422"})
        Me.cbH264Profile.Location = New System.Drawing.Point(94, 19)
        Me.cbH264Profile.Name = "cbH264Profile"
        Me.cbH264Profile.Size = New System.Drawing.Size(121, 21)
        Me.cbH264Profile.TabIndex = 0
        '
        'tabPage10
        '
        Me.tabPage10.Controls.Add(Me.label354)
        Me.tabPage10.Controls.Add(Me.cbAACOutput)
        Me.tabPage10.Controls.Add(Me.label355)
        Me.tabPage10.Controls.Add(Me.cbAACBitrate)
        Me.tabPage10.Controls.Add(Me.label356)
        Me.tabPage10.Controls.Add(Me.cbAACObjectType)
        Me.tabPage10.Controls.Add(Me.label357)
        Me.tabPage10.Controls.Add(Me.cbAACVersion)
        Me.tabPage10.Controls.Add(Me.label358)
        Me.tabPage10.Location = New System.Drawing.Point(4, 22)
        Me.tabPage10.Name = "tabPage10"
        Me.tabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage10.Size = New System.Drawing.Size(329, 298)
        Me.tabPage10.TabIndex = 2
        Me.tabPage10.Text = "Audio"
        Me.tabPage10.UseVisualStyleBackColor = true
        '
        'label354
        '
        Me.label354.AutoSize = true
        Me.label354.Location = New System.Drawing.Point(230, 88)
        Me.label354.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label354.Name = "label354"
        Me.label354.Size = New System.Drawing.Size(31, 13)
        Me.label354.TabIndex = 17
        Me.label354.Text = "Kbps"
        '
        'cbAACOutput
        '
        Me.cbAACOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAACOutput.FormattingEnabled = true
        Me.cbAACOutput.Items.AddRange(New Object() {"RAW", "ADTS"})
        Me.cbAACOutput.Location = New System.Drawing.Point(105, 124)
        Me.cbAACOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAACOutput.Name = "cbAACOutput"
        Me.cbAACOutput.Size = New System.Drawing.Size(156, 21)
        Me.cbAACOutput.TabIndex = 16
        '
        'label355
        '
        Me.label355.AutoSize = true
        Me.label355.Location = New System.Drawing.Point(12, 126)
        Me.label355.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label355.Name = "label355"
        Me.label355.Size = New System.Drawing.Size(39, 13)
        Me.label355.TabIndex = 15
        Me.label355.Text = "Output"
        '
        'cbAACBitrate
        '
        Me.cbAACBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAACBitrate.FormattingEnabled = true
        Me.cbAACBitrate.Items.AddRange(New Object() {"32", "40", "48", "56", "64", "72", "80", "88", "96", "104", "112", "120", "128", "140", "160", "192", "224", "256"})
        Me.cbAACBitrate.Location = New System.Drawing.Point(105, 86)
        Me.cbAACBitrate.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAACBitrate.Name = "cbAACBitrate"
        Me.cbAACBitrate.Size = New System.Drawing.Size(121, 21)
        Me.cbAACBitrate.TabIndex = 14
        '
        'label356
        '
        Me.label356.AutoSize = true
        Me.label356.Location = New System.Drawing.Point(12, 88)
        Me.label356.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label356.Name = "label356"
        Me.label356.Size = New System.Drawing.Size(37, 13)
        Me.label356.TabIndex = 13
        Me.label356.Text = "Bitrate"
        '
        'cbAACObjectType
        '
        Me.cbAACObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAACObjectType.FormattingEnabled = true
        Me.cbAACObjectType.Items.AddRange(New Object() {"Main", "Low complexity", "Scalable Sampling Rate", "Long Term Predictor"})
        Me.cbAACObjectType.Location = New System.Drawing.Point(105, 50)
        Me.cbAACObjectType.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAACObjectType.Name = "cbAACObjectType"
        Me.cbAACObjectType.Size = New System.Drawing.Size(156, 21)
        Me.cbAACObjectType.TabIndex = 12
        '
        'label357
        '
        Me.label357.AutoSize = true
        Me.label357.Location = New System.Drawing.Point(12, 52)
        Me.label357.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label357.Name = "label357"
        Me.label357.Size = New System.Drawing.Size(61, 13)
        Me.label357.TabIndex = 11
        Me.label357.Text = "Object type"
        '
        'cbAACVersion
        '
        Me.cbAACVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAACVersion.FormattingEnabled = true
        Me.cbAACVersion.Items.AddRange(New Object() {"MPEG-4", "MPEG-2"})
        Me.cbAACVersion.Location = New System.Drawing.Point(105, 15)
        Me.cbAACVersion.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAACVersion.Name = "cbAACVersion"
        Me.cbAACVersion.Size = New System.Drawing.Size(156, 21)
        Me.cbAACVersion.TabIndex = 10
        '
        'label358
        '
        Me.label358.AutoSize = true
        Me.label358.Location = New System.Drawing.Point(12, 18)
        Me.label358.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label358.Name = "label358"
        Me.label358.Size = New System.Drawing.Size(75, 13)
        Me.label358.TabIndex = 9
        Me.label358.Text = "MPEG version"
        '
        'openFileDialog2
        '
        Me.openFileDialog2.Filter = "Pictures|*.bmp; *.jpg; *.jpeg; *.jpe; *.png; *.gif; *.tiff;|All files|*.*"
        '
        'llVideoTutorials
        '
        Me.llVideoTutorials.AutoSize = true
        Me.llVideoTutorials.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.llVideoTutorials.Location = New System.Drawing.Point(749, 4)
        Me.llVideoTutorials.Name = "llVideoTutorials"
        Me.llVideoTutorials.Size = New System.Drawing.Size(68, 13)
        Me.llVideoTutorials.TabIndex = 92
        Me.llVideoTutorials.TabStop = true
        Me.llVideoTutorials.Text = "Video tutorial"
        '
        'VideoCapture1
        '
        Me.VideoCapture1.Additional_Audio_CaptureDevice_MixChannels = false
        Me.VideoCapture1.Audio_CaptureDevice = ""
        Me.VideoCapture1.Audio_CaptureDevice_CustomLatency = 0
        Me.VideoCapture1.Audio_CaptureDevice_Format = ""
        Me.VideoCapture1.Audio_CaptureDevice_Format_UseBest = true
        Me.VideoCapture1.Audio_CaptureDevice_Line = ""
        Me.VideoCapture1.Audio_CaptureDevice_Path = Nothing
        Me.VideoCapture1.Audio_Decoder = Nothing
        Me.VideoCapture1.Audio_Effects_Enabled = false
        Me.VideoCapture1.Audio_Effects_UseLegacyEffects = false
        Me.VideoCapture1.Audio_Enhancer_Enabled = false
        Me.VideoCapture1.Audio_OutputDevice = "Default DirectSound Device"
        Me.VideoCapture1.Audio_PlayAudio = true
        Me.VideoCapture1.Audio_RecordAudio = true
        Me.VideoCapture1.Audio_Sample_Grabber_Enabled = false
        Me.VideoCapture1.Audio_VUMeter_Enabled = false
        Me.VideoCapture1.Audio_VUMeter_Pro_Enabled = false
        Me.VideoCapture1.Audio_VUMeter_Pro_Volume = 100
        Me.VideoCapture1.BackColor = System.Drawing.Color.Black
        Me.VideoCapture1.Barcode_Reader_Enabled = false
        Me.VideoCapture1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.[Auto]
        Me.VideoCapture1.Debug_Dir = ""
        Me.VideoCapture1.Debug_Mode = false
        Me.VideoCapture1.Decklink_Input = VisioForge.Types.DecklinkInput.[Auto]
        Me.VideoCapture1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.[Auto]
        Me.VideoCapture1.Decklink_Input_IREUSA = false
        Me.VideoCapture1.Decklink_Input_SMPTE = false
        Me.VideoCapture1.DirectCapture_Muxer = Nothing
        Me.VideoCapture1.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full
        Me.VideoCapture1.Location = New System.Drawing.Point(387, 26)
        Me.VideoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoCapture
        Me.VideoCapture1.MPEG_Audio_Decoder = ""
        Me.VideoCapture1.MPEG_Video_Decoder = ""
        Me.VideoCapture1.MultiScreen_Enabled = false
        Me.VideoCapture1.Name = "VideoCapture1"
        Me.VideoCapture1.Network_Streaming_Audio_Enabled = false
        Me.VideoCapture1.Network_Streaming_Enabled = false
        Me.VideoCapture1.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV
        Me.VideoCapture1.Network_Streaming_Network_Port = 100
        Me.VideoCapture1.Network_Streaming_Output = Nothing
        Me.VideoCapture1.Network_Streaming_URL = ""
        Me.VideoCapture1.Network_Streaming_WMV_Maximum_Clients = 10
        Me.VideoCapture1.Output_Filename = ""
        Me.VideoCapture1.Output_Format = Nothing
        Me.VideoCapture1.PIP_AddSampleGrabbers = false
        Me.VideoCapture1.PIP_Mode = VisioForge.Types.VFPIPMode.Custom
        Me.VideoCapture1.SeparateCapture_AutostartCapture = false
        Me.VideoCapture1.SeparateCapture_Enabled = false
        Me.VideoCapture1.SeparateCapture_Filename_Mask = "output %yyyy-%MM-%dd %hh-%mm-%ss.%ext"
        Me.VideoCapture1.SeparateCapture_FileSizeThreshold = CType(0,Long)
        Me.VideoCapture1.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal
        Me.VideoCapture1.SeparateCapture_TimeThreshold = CType(0,Long)
        Me.VideoCapture1.Size = New System.Drawing.Size(429, 322)
        Me.VideoCapture1.Start_DelayEnabled = false
        Me.VideoCapture1.TabIndex = 93
        Me.VideoCapture1.TVTuner_Channel = 0
        Me.VideoCapture1.TVTuner_Country = ""
        Me.VideoCapture1.TVTuner_FM_Tuning_StartFrequency = 80000000
        Me.VideoCapture1.TVTuner_FM_Tuning_Step = 160000000
        Me.VideoCapture1.TVTuner_FM_Tuning_StopFrequency = 0
        Me.VideoCapture1.TVTuner_Frequency = 0
        Me.VideoCapture1.TVTuner_InputType = ""
        Me.VideoCapture1.TVTuner_Name = ""
        Me.VideoCapture1.TVTuner_TVFormat = VisioForge.Types.VFTVTunerVideoFormat.PAL_D
        Me.VideoCapture1.Video_CaptureDevice = ""
        Me.VideoCapture1.Video_CaptureDevice_Format = ""
        Me.VideoCapture1.Video_CaptureDevice_Format_UseBest = true
        Me.VideoCapture1.Video_CaptureDevice_FrameRate = 0R
        Me.VideoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = ""
        Me.VideoCapture1.Video_CaptureDevice_IsAudioSource = false
        Me.VideoCapture1.Video_CaptureDevice_Path = Nothing
        Me.VideoCapture1.Video_CaptureDevice_UseClosedCaptions = false
        Me.VideoCapture1.Video_CaptureDevice_UseRAWSampleGrabber = false
        Me.VideoCapture1.Video_Decoder = Nothing
        Me.VideoCapture1.Video_Effects_Enabled = false
        Me.VideoCapture1.Video_ResizeOrCrop_Enabled = false
        Me.VideoCapture1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone
        Me.VideoCapture1.Video_Sample_Grabber_Enabled = false
        Me.VideoCapture1.Video_Sample_Grabber_UseForVideoEffects = false
        Me.VideoCapture1.Video_Still_Frames_Grabber_Enabled = false
        Me.VideoCapture1.Virtual_Camera_Output_Enabled = false
        Me.VideoCapture1.Virtual_Camera_Output_LicenseKey = Nothing
        Me.VideoCapture1.VLC_Path = Nothing
        '
        'cbMode
        '
        Me.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMode.FormattingEnabled = true
        Me.cbMode.Items.AddRange(New Object() {"Preview", "Capture to AVI", "Capture to WMV", "Capture to MP4"})
        Me.cbMode.Location = New System.Drawing.Point(425, 412)
        Me.cbMode.Name = "cbMode"
        Me.cbMode.Size = New System.Drawing.Size(121, 21)
        Me.cbMode.TabIndex = 100
        '
        'label35
        '
        Me.label35.AutoSize = true
        Me.label35.Location = New System.Drawing.Point(385, 415)
        Me.label35.Name = "label35"
        Me.label35.Size = New System.Drawing.Size(34, 13)
        Me.label35.TabIndex = 99
        Me.label35.Text = "Mode"
        '
        'label34
        '
        Me.label34.AutoSize = true
        Me.label34.Location = New System.Drawing.Point(496, 356)
        Me.label34.Name = "label34"
        Me.label34.Size = New System.Drawing.Size(214, 13)
        Me.label34.TabIndex = 101
        Me.label34.Text = "Much more features available in Main Demo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 442)
        Me.Controls.Add(Me.label34)
        Me.Controls.Add(Me.cbMode)
        Me.Controls.Add(Me.label35)
        Me.Controls.Add(Me.VideoCapture1)
        Me.Controls.Add(Me.llVideoTutorials)
        Me.Controls.Add(Me.btStop)
        Me.Controls.Add(Me.btStart)
        Me.Controls.Add(Me.btSelectOutput)
        Me.Controls.Add(Me.edOutput)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.tabControl1)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Form1"
        Me.Text = "Screen Capture Demo - VisioForge Video Capture SDK .Net"
        Me.groupBox2.ResumeLayout(false)
        Me.groupBox2.PerformLayout
        CType(Me.tbJPEGQuality,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage3.ResumeLayout(false)
        Me.tabPage3.PerformLayout
        CType(Me.tbImageLogoTransp,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbTextLogoTransp,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupBox1.ResumeLayout(false)
        Me.groupBox1.PerformLayout
        Me.tabPage4.ResumeLayout(false)
        Me.tabControl1.ResumeLayout(false)
        Me.tabPage1.ResumeLayout(false)
        Me.tabPage1.PerformLayout
        Me.tabPage2.ResumeLayout(false)
        Me.tabControl2.ResumeLayout(false)
        Me.tabPage5.ResumeLayout(false)
        Me.tabPage5.PerformLayout
        Me.tabPage6.ResumeLayout(false)
        Me.tabPage6.PerformLayout
        Me.tabPage7.ResumeLayout(false)
        Me.tabControl3.ResumeLayout(false)
        Me.tabPage9.ResumeLayout(false)
        Me.groupBox29.ResumeLayout(false)
        Me.groupBox29.PerformLayout
        Me.groupBox46.ResumeLayout(false)
        Me.groupBox46.PerformLayout
        Me.tabPage10.ResumeLayout(false)
        Me.tabPage10.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents cbImageType As System.Windows.Forms.ComboBox
    Private WithEvents lbJPEGQuality As System.Windows.Forms.Label
    Private WithEvents btStop As System.Windows.Forms.Button
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label38 As System.Windows.Forms.Label
    Private WithEvents btSaveScreenshot As System.Windows.Forms.Button
    Private WithEvents label63 As System.Windows.Forms.Label
    Private WithEvents edScreenshotsFolder As System.Windows.Forms.TextBox
    Private WithEvents tbJPEGQuality As System.Windows.Forms.TrackBar
    Private WithEvents btStart As System.Windows.Forms.Button
    Private WithEvents btSelectOutput As System.Windows.Forms.Button
    Private WithEvents tabPage3 As System.Windows.Forms.TabPage
    Private WithEvents edImageLogoTop As System.Windows.Forms.TextBox
    Private WithEvents cbImageLogo As System.Windows.Forms.CheckBox
    Private WithEvents label155 As System.Windows.Forms.Label
    Private WithEvents tbImageLogoTransp As System.Windows.Forms.TrackBar
    Private WithEvents edImageLogoLeft As System.Windows.Forms.TextBox
    Private WithEvents label156 As System.Windows.Forms.Label
    Private WithEvents label154 As System.Windows.Forms.Label
    Private WithEvents btSelectImage As System.Windows.Forms.Button
    Private WithEvents label157 As System.Windows.Forms.Label
    Private WithEvents edImageLogoFilename As System.Windows.Forms.TextBox
    Private WithEvents label32 As System.Windows.Forms.Label
    Private WithEvents tbTextLogoTransp As System.Windows.Forms.TrackBar
    Private WithEvents edTextLogoTop As System.Windows.Forms.TextBox
    Private WithEvents label139 As System.Windows.Forms.Label
    Private WithEvents edTextLogoLeft As System.Windows.Forms.TextBox
    Private WithEvents label140 As System.Windows.Forms.Label
    Private WithEvents btFont As System.Windows.Forms.Button
    Private WithEvents edTextLogo As System.Windows.Forms.TextBox
    Private WithEvents cbTextLogo As System.Windows.Forms.CheckBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents cbDebugMode As System.Windows.Forms.CheckBox
    Private WithEvents mmLog As System.Windows.Forms.TextBox
    Private WithEvents tabPage4 As System.Windows.Forms.TabPage
    Private WithEvents edOutput As System.Windows.Forms.TextBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents cbUseBestAudioInputFormat As System.Windows.Forms.CheckBox
    Private WithEvents btAudioInputDeviceSettings As System.Windows.Forms.Button
    Private WithEvents cbAudioInputLine As System.Windows.Forms.ComboBox
    Private WithEvents cbAudioInputFormat As System.Windows.Forms.ComboBox
    Private WithEvents cbAudioInputDevice As System.Windows.Forms.ComboBox
    Private WithEvents label22 As System.Windows.Forms.Label
    Private WithEvents label23 As System.Windows.Forms.Label
    Private WithEvents label25 As System.Windows.Forms.Label
    Private WithEvents cbRecordAudio As System.Windows.Forms.CheckBox
    Private WithEvents btScreenCaptureUpdate As System.Windows.Forms.Button
    Private WithEvents label124 As System.Windows.Forms.Label
    Private WithEvents label123 As System.Windows.Forms.Label
    Private WithEvents label122 As System.Windows.Forms.Label
    Private WithEvents cbScreenCapture_GrabMouseCursor As System.Windows.Forms.CheckBox
    Private WithEvents label79 As System.Windows.Forms.Label
    Private WithEvents edScreenFrameRate As System.Windows.Forms.TextBox
    Private WithEvents label43 As System.Windows.Forms.Label
    Private WithEvents edScreenBottom As System.Windows.Forms.TextBox
    Private WithEvents label42 As System.Windows.Forms.Label
    Private WithEvents edScreenTop As System.Windows.Forms.TextBox
    Private WithEvents label26 As System.Windows.Forms.Label
    Private WithEvents edScreenRight As System.Windows.Forms.TextBox
    Private WithEvents label40 As System.Windows.Forms.Label
    Private WithEvents fontDialog1 As System.Windows.Forms.FontDialog
    Private WithEvents edScreenLeft As System.Windows.Forms.TextBox
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents label24 As System.Windows.Forms.Label
    Private WithEvents rbScreenCustomArea As System.Windows.Forms.RadioButton
    Private WithEvents rbScreenFullScreen As System.Windows.Forms.RadioButton
    Private WithEvents tabPage2 As System.Windows.Forms.TabPage
    Private WithEvents openFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents llVideoTutorials As System.Windows.Forms.LinkLabel
    Friend WithEvents VideoCapture1 As VisioForge.Controls.UI.WinForms.VideoCapture
    Private WithEvents cbScreenCaptureDisplayIndex As System.Windows.Forms.ComboBox
    Private WithEvents label93 As System.Windows.Forms.Label
    Private WithEvents label294 As System.Windows.Forms.Label
    Private WithEvents edScreenCaptureWindowName As System.Windows.Forms.TextBox
    Private WithEvents rbScreenCaptureWindow As System.Windows.Forms.RadioButton
    Private WithEvents cbMode As System.Windows.Forms.ComboBox
    Private WithEvents label35 As System.Windows.Forms.Label
    Private WithEvents tabControl2 As System.Windows.Forms.TabControl
    Private WithEvents tabPage5 As System.Windows.Forms.TabPage
    Private WithEvents label27 As System.Windows.Forms.Label
    Private WithEvents btAudioSettings As System.Windows.Forms.Button
    Private WithEvents btVideoSettings As System.Windows.Forms.Button
    Private WithEvents label28 As System.Windows.Forms.Label
    Private WithEvents label29 As System.Windows.Forms.Label
    Private WithEvents label30 As System.Windows.Forms.Label
    Private WithEvents label31 As System.Windows.Forms.Label
    Private WithEvents cbChannels As System.Windows.Forms.ComboBox
    Private WithEvents cbBPS As System.Windows.Forms.ComboBox
    Private WithEvents cbAudioCodecs As System.Windows.Forms.ComboBox
    Private WithEvents cbSampleRate As System.Windows.Forms.ComboBox
    Private WithEvents cbVideoCodecs As System.Windows.Forms.ComboBox
    Private WithEvents tabPage6 As System.Windows.Forms.TabPage
    Private WithEvents label33 As System.Windows.Forms.Label
    Private WithEvents cbWMVInternalProfile9 As System.Windows.Forms.ComboBox
    Private WithEvents tabPage7 As System.Windows.Forms.TabPage
    Private WithEvents tabControl3 As System.Windows.Forms.TabControl
    Private WithEvents tabPage9 As System.Windows.Forms.TabPage
    Private WithEvents groupBox29 As System.Windows.Forms.GroupBox
    Private WithEvents cbH264GOP As System.Windows.Forms.CheckBox
    Private WithEvents cbH264AutoBitrate As System.Windows.Forms.CheckBox
    Private WithEvents label350 As System.Windows.Forms.Label
    Private WithEvents edH264Bitrate As System.Windows.Forms.TextBox
    Private WithEvents label351 As System.Windows.Forms.Label
    Private WithEvents cbH264RateControl As System.Windows.Forms.ComboBox
    Private WithEvents groupBox46 As System.Windows.Forms.GroupBox
    Private WithEvents cbH264TargetUsage As System.Windows.Forms.ComboBox
    Private WithEvents label359 As System.Windows.Forms.Label
    Private WithEvents label352 As System.Windows.Forms.Label
    Private WithEvents label353 As System.Windows.Forms.Label
    Private WithEvents cbH264Level As System.Windows.Forms.ComboBox
    Private WithEvents cbH264Profile As System.Windows.Forms.ComboBox
    Private WithEvents tabPage10 As System.Windows.Forms.TabPage
    Private WithEvents label354 As System.Windows.Forms.Label
    Private WithEvents cbAACOutput As System.Windows.Forms.ComboBox
    Private WithEvents label355 As System.Windows.Forms.Label
    Private WithEvents cbAACBitrate As System.Windows.Forms.ComboBox
    Private WithEvents label356 As System.Windows.Forms.Label
    Private WithEvents cbAACObjectType As System.Windows.Forms.ComboBox
    Private WithEvents label357 As System.Windows.Forms.Label
    Private WithEvents cbAACVersion As System.Windows.Forms.ComboBox
    Private WithEvents label358 As System.Windows.Forms.Label
    Private WithEvents label34 As System.Windows.Forms.Label
    Private WithEvents cbScreenCapture_DesktopDuplication As System.Windows.Forms.CheckBox
    Private WithEvents cbLicensing As CheckBox
End Class
