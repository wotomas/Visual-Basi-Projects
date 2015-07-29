Imports System.IO

Public Class frmMain
    Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents picBox As System.Windows.Forms.PictureBox
    Public WithEvents lblMax As System.Windows.Forms.Label
    Public WithEvents lblCenter As System.Windows.Forms.Label
    Public WithEvents lblMin As System.Windows.Forms.Label
    Public WithEvents lblFrame As System.Windows.Forms.Label
    Public WithEvents btnProcess As System.Windows.Forms.Button
    Public WithEvents gbOutputFrame As System.Windows.Forms.GroupBox

    Public WithEvents gbOutputVideo As System.Windows.Forms.GroupBox

    Public WithEvents gbInputVideo1 As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents sbMessage As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Public WithEvents gbInputFrame1 As System.Windows.Forms.GroupBox
    Public WithEvents picInput1 As System.Windows.Forms.PictureBox
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Public WithEvents btnSet As System.Windows.Forms.Button
    Public WithEvents cboOperation As System.Windows.Forms.ComboBox
    Public WithEvents gbOperation As System.Windows.Forms.GroupBox
    Public WithEvents btnSettings As System.Windows.Forms.Button
    Public WithEvents lblOperation As System.Windows.Forms.Label
    Public WithEvents btnReset As System.Windows.Forms.Button
    Public WithEvents optSelect As System.Windows.Forms.RadioButton
    Public WithEvents optEdit As System.Windows.Forms.RadioButton
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnKeyframes As System.Windows.Forms.Button
    Friend WithEvents mnuSave As System.Windows.Forms.MenuItem
    Friend WithEvents lblOperationCaption As System.Windows.Forms.Label
    Friend WithEvents lblSetOperation As System.Windows.Forms.Label
    Friend WithEvents mnuExtractFrames As System.Windows.Forms.MenuItem
    Public WithEvents gbProcess As System.Windows.Forms.GroupBox
    Friend WithEvents wmpInput1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents wmpOutput As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents mnuOpen2 As System.Windows.Forms.MenuItem
    Friend WithEvents tcInput As System.Windows.Forms.TabControl
    Friend WithEvents tabInput1 As System.Windows.Forms.TabPage
    Friend WithEvents tabInput2 As System.Windows.Forms.TabPage
    Public WithEvents gbInputVideo2 As System.Windows.Forms.GroupBox
    Friend WithEvents wmpInput2 As AxWMPLib.AxWindowsMediaPlayer
    Public WithEvents gbInputFrame2 As System.Windows.Forms.GroupBox
    Public WithEvents picInput2 As System.Windows.Forms.PictureBox
    Friend WithEvents tcOutput As System.Windows.Forms.TabControl
    Friend WithEvents tabOutput As System.Windows.Forms.TabPage
    Public WithEvents lblMode As System.Windows.Forms.Label
    Public WithEvents lblSpeed As System.Windows.Forms.Label
    Public WithEvents picOutput As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.gbProcess = New System.Windows.Forms.GroupBox
        Me.lblSpeed = New System.Windows.Forms.Label
        Me.btnReset = New System.Windows.Forms.Button
        Me.lblMode = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnKeyframes = New System.Windows.Forms.Button
        Me.gbOperation = New System.Windows.Forms.GroupBox
        Me.lblSetOperation = New System.Windows.Forms.Label
        Me.lblOperationCaption = New System.Windows.Forms.Label
        Me.btnSettings = New System.Windows.Forms.Button
        Me.lblOperation = New System.Windows.Forms.Label
        Me.cboOperation = New System.Windows.Forms.ComboBox
        Me.btnSet = New System.Windows.Forms.Button
        Me.optSelect = New System.Windows.Forms.RadioButton
        Me.optEdit = New System.Windows.Forms.RadioButton
        Me.picBox = New System.Windows.Forms.PictureBox
        Me.lblMax = New System.Windows.Forms.Label
        Me.lblCenter = New System.Windows.Forms.Label
        Me.lblMin = New System.Windows.Forms.Label
        Me.lblFrame = New System.Windows.Forms.Label
        Me.btnProcess = New System.Windows.Forms.Button
        Me.gbOutputFrame = New System.Windows.Forms.GroupBox
        Me.picOutput = New System.Windows.Forms.PictureBox
        Me.gbOutputVideo = New System.Windows.Forms.GroupBox
        Me.wmpOutput = New AxWMPLib.AxWindowsMediaPlayer
        Me.gbInputVideo1 = New System.Windows.Forms.GroupBox
        Me.wmpInput1 = New AxWMPLib.AxWindowsMediaPlayer
        Me.sbMessage = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuOpen = New System.Windows.Forms.MenuItem
        Me.mnuOpen2 = New System.Windows.Forms.MenuItem
        Me.mnuSave = New System.Windows.Forms.MenuItem
        Me.mnuExit = New System.Windows.Forms.MenuItem
        Me.mnuExtractFrames = New System.Windows.Forms.MenuItem
        Me.gbInputFrame1 = New System.Windows.Forms.GroupBox
        Me.picInput1 = New System.Windows.Forms.PictureBox
        Me.tcInput = New System.Windows.Forms.TabControl
        Me.tabInput1 = New System.Windows.Forms.TabPage
        Me.tabInput2 = New System.Windows.Forms.TabPage
        Me.gbInputVideo2 = New System.Windows.Forms.GroupBox
        Me.wmpInput2 = New AxWMPLib.AxWindowsMediaPlayer
        Me.gbInputFrame2 = New System.Windows.Forms.GroupBox
        Me.picInput2 = New System.Windows.Forms.PictureBox
        Me.tcOutput = New System.Windows.Forms.TabControl
        Me.tabOutput = New System.Windows.Forms.TabPage
        Me.gbProcess.SuspendLayout()
        Me.gbOperation.SuspendLayout()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOutputFrame.SuspendLayout()
        CType(Me.picOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOutputVideo.SuspendLayout()
        CType(Me.wmpOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInputVideo1.SuspendLayout()
        CType(Me.wmpInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInputFrame1.SuspendLayout()
        CType(Me.picInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcInput.SuspendLayout()
        Me.tabInput1.SuspendLayout()
        Me.tabInput2.SuspendLayout()
        Me.gbInputVideo2.SuspendLayout()
        CType(Me.wmpInput2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInputFrame2.SuspendLayout()
        CType(Me.picInput2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcOutput.SuspendLayout()
        Me.tabOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbProcess
        '
        Me.gbProcess.Controls.Add(Me.lblSpeed)
        Me.gbProcess.Controls.Add(Me.btnReset)
        Me.gbProcess.Controls.Add(Me.lblMode)
        Me.gbProcess.Controls.Add(Me.btnDelete)
        Me.gbProcess.Controls.Add(Me.btnKeyframes)
        Me.gbProcess.Controls.Add(Me.gbOperation)
        Me.gbProcess.Controls.Add(Me.optSelect)
        Me.gbProcess.Controls.Add(Me.optEdit)
        Me.gbProcess.Controls.Add(Me.picBox)
        Me.gbProcess.Controls.Add(Me.lblMax)
        Me.gbProcess.Controls.Add(Me.lblCenter)
        Me.gbProcess.Controls.Add(Me.lblMin)
        Me.gbProcess.Controls.Add(Me.lblFrame)
        Me.gbProcess.Controls.Add(Me.btnProcess)
        Me.gbProcess.Location = New System.Drawing.Point(280, 6)
        Me.gbProcess.Name = "gbProcess"
        Me.gbProcess.Size = New System.Drawing.Size(433, 486)
        Me.gbProcess.TabIndex = 10
        Me.gbProcess.TabStop = False
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(6, 21)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(38, 13)
        Me.lblSpeed.TabIndex = 47
        Me.lblSpeed.Text = "Speed"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(255, 292)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(80, 24)
        Me.btnReset.TabIndex = 39
        Me.btnReset.Text = "Reset Points"
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(172, 21)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(84, 13)
        Me.lblMode.TabIndex = 46
        Me.lblMode.Text = "Selection Mode:"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(169, 292)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 38
        Me.btnDelete.Text = "Delete Point"
        '
        'btnKeyframes
        '
        Me.btnKeyframes.Location = New System.Drawing.Point(341, 292)
        Me.btnKeyframes.Name = "btnKeyframes"
        Me.btnKeyframes.Size = New System.Drawing.Size(80, 24)
        Me.btnKeyframes.TabIndex = 44
        Me.btnKeyframes.Text = "Keyframes"
        '
        'gbOperation
        '
        Me.gbOperation.Controls.Add(Me.lblSetOperation)
        Me.gbOperation.Controls.Add(Me.lblOperationCaption)
        Me.gbOperation.Controls.Add(Me.btnSettings)
        Me.gbOperation.Controls.Add(Me.lblOperation)
        Me.gbOperation.Controls.Add(Me.cboOperation)
        Me.gbOperation.Controls.Add(Me.btnSet)
        Me.gbOperation.Location = New System.Drawing.Point(12, 322)
        Me.gbOperation.Name = "gbOperation"
        Me.gbOperation.Size = New System.Drawing.Size(410, 92)
        Me.gbOperation.TabIndex = 42
        Me.gbOperation.TabStop = False
        '
        'lblSetOperation
        '
        Me.lblSetOperation.AutoSize = True
        Me.lblSetOperation.Location = New System.Drawing.Point(12, 61)
        Me.lblSetOperation.Name = "lblSetOperation"
        Me.lblSetOperation.Size = New System.Drawing.Size(75, 13)
        Me.lblSetOperation.TabIndex = 39
        Me.lblSetOperation.Text = "Set Operation:"
        '
        'lblOperationCaption
        '
        Me.lblOperationCaption.AutoSize = True
        Me.lblOperationCaption.Location = New System.Drawing.Point(12, 25)
        Me.lblOperationCaption.Name = "lblOperationCaption"
        Me.lblOperationCaption.Size = New System.Drawing.Size(93, 13)
        Me.lblOperationCaption.TabIndex = 38
        Me.lblOperationCaption.Text = "Current Operation:"
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(318, 19)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(80, 24)
        Me.btnSettings.TabIndex = 37
        Me.btnSettings.Text = "Settings"
        '
        'lblOperation
        '
        Me.lblOperation.BackColor = System.Drawing.Color.White
        Me.lblOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperation.Location = New System.Drawing.Point(117, 19)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(195, 24)
        Me.lblOperation.TabIndex = 36
        Me.lblOperation.Text = "None"
        Me.lblOperation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboOperation
        '
        Me.cboOperation.BackColor = System.Drawing.SystemColors.Window
        Me.cboOperation.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboOperation.Location = New System.Drawing.Point(117, 57)
        Me.cboOperation.Name = "cboOperation"
        Me.cboOperation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboOperation.Size = New System.Drawing.Size(195, 21)
        Me.cboOperation.TabIndex = 31
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(318, 55)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(80, 24)
        Me.btnSet.TabIndex = 32
        Me.btnSet.Text = "Set"
        '
        'optSelect
        '
        Me.optSelect.AutoSize = True
        Me.optSelect.Location = New System.Drawing.Point(343, 19)
        Me.optSelect.Name = "optSelect"
        Me.optSelect.Size = New System.Drawing.Size(78, 17)
        Me.optSelect.TabIndex = 41
        Me.optSelect.TabStop = True
        Me.optSelect.Text = "Select Line"
        '
        'optEdit
        '
        Me.optEdit.AutoSize = True
        Me.optEdit.Checked = True
        Me.optEdit.Location = New System.Drawing.Point(262, 19)
        Me.optEdit.Name = "optEdit"
        Me.optEdit.Size = New System.Drawing.Size(75, 17)
        Me.optEdit.TabIndex = 40
        Me.optEdit.TabStop = True
        Me.optEdit.Text = "Edit Points"
        '
        'picBox
        '
        Me.picBox.BackColor = System.Drawing.Color.White
        Me.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picBox.Location = New System.Drawing.Point(19, 40)
        Me.picBox.Name = "picBox"
        Me.picBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picBox.Size = New System.Drawing.Size(403, 246)
        Me.picBox.TabIndex = 12
        Me.picBox.TabStop = False
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(6, 40)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(13, 13)
        Me.lblMax.TabIndex = 18
        Me.lblMax.Text = "3"
        Me.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCenter
        '
        Me.lblCenter.AutoSize = True
        Me.lblCenter.Location = New System.Drawing.Point(6, 157)
        Me.lblCenter.Name = "lblCenter"
        Me.lblCenter.Size = New System.Drawing.Size(13, 13)
        Me.lblCenter.TabIndex = 17
        Me.lblCenter.Text = "0"
        Me.lblCenter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(3, 273)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(16, 13)
        Me.lblMin.TabIndex = 16
        Me.lblMin.Text = "-3"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFrame
        '
        Me.lblFrame.AutoSize = True
        Me.lblFrame.Location = New System.Drawing.Point(11, 298)
        Me.lblFrame.Name = "lblFrame"
        Me.lblFrame.Size = New System.Drawing.Size(82, 13)
        Me.lblFrame.TabIndex = 13
        Me.lblFrame.Text = "Current Frame: -"
        '
        'btnProcess
        '
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnProcess.Location = New System.Drawing.Point(136, 426)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(160, 48)
        Me.btnProcess.TabIndex = 9
        Me.btnProcess.Text = "Process"
        '
        'gbOutputFrame
        '
        Me.gbOutputFrame.Controls.Add(Me.picOutput)
        Me.gbOutputFrame.Location = New System.Drawing.Point(12, 250)
        Me.gbOutputFrame.Name = "gbOutputFrame"
        Me.gbOutputFrame.Size = New System.Drawing.Size(225, 192)
        Me.gbOutputFrame.TabIndex = 6
        Me.gbOutputFrame.TabStop = False
        Me.gbOutputFrame.Text = "Output Frame"
        '
        'picOutput
        '
        Me.picOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picOutput.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picOutput.Location = New System.Drawing.Point(12, 19)
        Me.picOutput.Name = "picOutput"
        Me.picOutput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picOutput.Size = New System.Drawing.Size(200, 160)
        Me.picOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOutput.TabIndex = 7
        Me.picOutput.TabStop = False
        '
        'gbOutputVideo
        '
        Me.gbOutputVideo.Controls.Add(Me.wmpOutput)
        Me.gbOutputVideo.Location = New System.Drawing.Point(12, 12)
        Me.gbOutputVideo.Name = "gbOutputVideo"
        Me.gbOutputVideo.Size = New System.Drawing.Size(225, 232)
        Me.gbOutputVideo.TabIndex = 2
        Me.gbOutputVideo.TabStop = False
        Me.gbOutputVideo.Text = "Output"
        '
        'wmpOutput
        '
        Me.wmpOutput.Enabled = True
        Me.wmpOutput.Location = New System.Drawing.Point(12, 19)
        Me.wmpOutput.Name = "wmpOutput"
        Me.wmpOutput.OcxState = CType(resources.GetObject("wmpOutput.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpOutput.Size = New System.Drawing.Size(200, 200)
        Me.wmpOutput.TabIndex = 1
        '
        'gbInputVideo1
        '
        Me.gbInputVideo1.Controls.Add(Me.wmpInput1)
        Me.gbInputVideo1.Location = New System.Drawing.Point(12, 12)
        Me.gbInputVideo1.Name = "gbInputVideo1"
        Me.gbInputVideo1.Size = New System.Drawing.Size(225, 232)
        Me.gbInputVideo1.TabIndex = 1
        Me.gbInputVideo1.TabStop = False
        Me.gbInputVideo1.Text = "Input"
        '
        'wmpInput1
        '
        Me.wmpInput1.Enabled = True
        Me.wmpInput1.Location = New System.Drawing.Point(12, 19)
        Me.wmpInput1.Name = "wmpInput1"
        Me.wmpInput1.OcxState = CType(resources.GetObject("wmpInput1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpInput1.Size = New System.Drawing.Size(200, 200)
        Me.wmpInput1.TabIndex = 0
        '
        'sbMessage
        '
        Me.sbMessage.Location = New System.Drawing.Point(0, 505)
        Me.sbMessage.Name = "sbMessage"
        Me.sbMessage.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.sbMessage.ShowPanels = True
        Me.sbMessage.Size = New System.Drawing.Size(994, 16)
        Me.sbMessage.TabIndex = 20
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 1000
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuExtractFrames})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOpen, Me.mnuOpen2, Me.mnuSave, Me.mnuExit})
        Me.mnuFile.Text = "&File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Index = 0
        Me.mnuOpen.Text = "&Open Input Video (1st)"
        '
        'mnuOpen2
        '
        Me.mnuOpen2.Index = 1
        Me.mnuOpen2.Text = "Open Input Video (2nd)"
        '
        'mnuSave
        '
        Me.mnuSave.Enabled = False
        Me.mnuSave.Index = 2
        Me.mnuSave.Text = "&Save Ouput Video"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 3
        Me.mnuExit.Text = "E&xit"
        '
        'mnuExtractFrames
        '
        Me.mnuExtractFrames.Enabled = False
        Me.mnuExtractFrames.Index = 1
        Me.mnuExtractFrames.Text = "Extract Frames"
        '
        'gbInputFrame1
        '
        Me.gbInputFrame1.Controls.Add(Me.picInput1)
        Me.gbInputFrame1.Location = New System.Drawing.Point(12, 250)
        Me.gbInputFrame1.Name = "gbInputFrame1"
        Me.gbInputFrame1.Size = New System.Drawing.Size(225, 192)
        Me.gbInputFrame1.TabIndex = 21
        Me.gbInputFrame1.TabStop = False
        Me.gbInputFrame1.Text = "Input Frame"
        '
        'picInput1
        '
        Me.picInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picInput1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picInput1.Location = New System.Drawing.Point(12, 19)
        Me.picInput1.Name = "picInput1"
        Me.picInput1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picInput1.Size = New System.Drawing.Size(200, 160)
        Me.picInput1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInput1.TabIndex = 7
        Me.picInput1.TabStop = False
        '
        'tcInput
        '
        Me.tcInput.Controls.Add(Me.tabInput1)
        Me.tcInput.Controls.Add(Me.tabInput2)
        Me.tcInput.Location = New System.Drawing.Point(12, 12)
        Me.tcInput.Name = "tcInput"
        Me.tcInput.SelectedIndex = 0
        Me.tcInput.Size = New System.Drawing.Size(257, 480)
        Me.tcInput.TabIndex = 22
        '
        'tabInput1
        '
        Me.tabInput1.Controls.Add(Me.gbInputVideo1)
        Me.tabInput1.Controls.Add(Me.gbInputFrame1)
        Me.tabInput1.Location = New System.Drawing.Point(4, 22)
        Me.tabInput1.Name = "tabInput1"
        Me.tabInput1.Size = New System.Drawing.Size(249, 454)
        Me.tabInput1.TabIndex = 0
        Me.tabInput1.Text = "Input Video 1"
        '
        'tabInput2
        '
        Me.tabInput2.Controls.Add(Me.gbInputVideo2)
        Me.tabInput2.Controls.Add(Me.gbInputFrame2)
        Me.tabInput2.Location = New System.Drawing.Point(4, 22)
        Me.tabInput2.Name = "tabInput2"
        Me.tabInput2.Size = New System.Drawing.Size(249, 454)
        Me.tabInput2.TabIndex = 1
        Me.tabInput2.Text = "Input Video 2"
        '
        'gbInputVideo2
        '
        Me.gbInputVideo2.Controls.Add(Me.wmpInput2)
        Me.gbInputVideo2.Location = New System.Drawing.Point(12, 12)
        Me.gbInputVideo2.Name = "gbInputVideo2"
        Me.gbInputVideo2.Size = New System.Drawing.Size(225, 232)
        Me.gbInputVideo2.TabIndex = 22
        Me.gbInputVideo2.TabStop = False
        Me.gbInputVideo2.Text = "Input"
        '
        'wmpInput2
        '
        Me.wmpInput2.Enabled = True
        Me.wmpInput2.Location = New System.Drawing.Point(12, 19)
        Me.wmpInput2.Name = "wmpInput2"
        Me.wmpInput2.OcxState = CType(resources.GetObject("wmpInput2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpInput2.Size = New System.Drawing.Size(200, 200)
        Me.wmpInput2.TabIndex = 0
        '
        'gbInputFrame2
        '
        Me.gbInputFrame2.Controls.Add(Me.picInput2)
        Me.gbInputFrame2.Location = New System.Drawing.Point(12, 250)
        Me.gbInputFrame2.Name = "gbInputFrame2"
        Me.gbInputFrame2.Size = New System.Drawing.Size(225, 192)
        Me.gbInputFrame2.TabIndex = 23
        Me.gbInputFrame2.TabStop = False
        Me.gbInputFrame2.Text = "Input Frame"
        '
        'picInput2
        '
        Me.picInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picInput2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picInput2.Location = New System.Drawing.Point(12, 19)
        Me.picInput2.Name = "picInput2"
        Me.picInput2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picInput2.Size = New System.Drawing.Size(200, 160)
        Me.picInput2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInput2.TabIndex = 7
        Me.picInput2.TabStop = False
        '
        'tcOutput
        '
        Me.tcOutput.Controls.Add(Me.tabOutput)
        Me.tcOutput.Location = New System.Drawing.Point(725, 12)
        Me.tcOutput.Name = "tcOutput"
        Me.tcOutput.SelectedIndex = 0
        Me.tcOutput.Size = New System.Drawing.Size(257, 480)
        Me.tcOutput.TabIndex = 23
        '
        'tabOutput
        '
        Me.tabOutput.Controls.Add(Me.gbOutputVideo)
        Me.tabOutput.Controls.Add(Me.gbOutputFrame)
        Me.tabOutput.Location = New System.Drawing.Point(4, 22)
        Me.tabOutput.Name = "tabOutput"
        Me.tabOutput.Size = New System.Drawing.Size(249, 454)
        Me.tabOutput.TabIndex = 0
        Me.tabOutput.Text = "Output Video"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(994, 521)
        Me.Controls.Add(Me.tcOutput)
        Me.Controls.Add(Me.tcInput)
        Me.Controls.Add(Me.sbMessage)
        Me.Controls.Add(Me.gbProcess)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Video Processing"
        Me.gbProcess.ResumeLayout(False)
        Me.gbProcess.PerformLayout()
        Me.gbOperation.ResumeLayout(False)
        Me.gbOperation.PerformLayout()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOutputFrame.ResumeLayout(False)
        CType(Me.picOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOutputVideo.ResumeLayout(False)
        CType(Me.wmpOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInputVideo1.ResumeLayout(False)
        CType(Me.wmpInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInputFrame1.ResumeLayout(False)
        CType(Me.picInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcInput.ResumeLayout(False)
        Me.tabInput1.ResumeLayout(False)
        Me.tabInput2.ResumeLayout(False)
        Me.gbInputVideo2.ResumeLayout(False)
        CType(Me.wmpInput2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInputFrame2.ResumeLayout(False)
        CType(Me.picInput2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcOutput.ResumeLayout(False)
        Me.tabOutput.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private filename1 As String
    Private filename2 As String
    Dim dirname1 As String
    Dim dirname2 As String
    Dim frameNum1 As Integer ' Frame number of input video 1
    Dim frameNum2 As Integer ' Frame number of input video 2

    ' Parameters for the editor
    Dim points() As PointData ' array of Points
    Dim dragIndex As Integer ' drag point Index
    Dim selectedIndex As Integer ' selected point Index
    Public selectedLine As Integer
    Dim tickFreq As Short ' tick frequency of Frames
    Dim maxMultiplier As Double ' maximum increase/decrease of speed for the video
    Dim pointRadius As Single ' radius of the Points
    Dim origin As PointData ' the origin of the graph
    Dim skip As Boolean = False

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbProcess.Enabled = False

        filename1 = ""
        filename2 = ""
        frameNum1 = -1
        frameNum2 = -1

        ' Set parameters for the editor
        pointRadius = 5
        tickFreq = 10
        maxMultiplier = 6.0#
        lblMax.Text = CStr(maxMultiplier)
        lblMin.Text = "-" & CStr(maxMultiplier)
        selectedLine = -1

        btnSettings.Enabled = False

        ' Set the operation combo box items to be the video processing operations available
        cboOperation.Items.Add("None")
        cboOperation.Items.Add("Fade In")
        cboOperation.Items.Add("Fade Out")
        cboOperation.Items.Add("Motion blur")
        'cboOperation.Items.Add("Ripple")
        cboOperation.Items.Add("Melt")
        cboOperation.Items.Add("Transition")
        cboOperation.Items.Add("Time Shift")
        cboOperation.SelectedIndex = 0
    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        If selectedLine < 0 Then Exit Sub
        If points(selectedLine).settings Is Nothing Then Exit Sub

        If TypeOf points(selectedLine).settings Is FadeInSettings Then
            Dim settings As FadeInSettings = CType(points(selectedLine).settings, FadeInSettings)
            Dim frm As New frmFadeIn(settings)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                settings = frm.settings
            End If
        ElseIf TypeOf points(selectedLine).settings Is FadeOutSettings Then
            Dim settings As FadeOutSettings = CType(points(selectedLine).settings, FadeOutSettings)
            Dim frm As New frmFadeOut(settings)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                settings = frm.settings
            End If
        ElseIf TypeOf points(selectedLine).settings Is MotionBlurSettings Then
            Dim settings As MotionBlurSettings = CType(points(selectedLine).settings, MotionBlurSettings)
            Dim frm As New frmMotionBlur(settings)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                settings = frm.settings
            End If
        ElseIf TypeOf points(selectedLine).settings Is MeltSettings Then
            Dim settings As MeltSettings = CType(points(selectedLine).settings, MeltSettings)
            Dim frm As New frmMelt(settings)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                settings = frm.settings
            End If
        ElseIf TypeOf points(selectedLine).settings Is TransitionSettings Then
            Dim settings As TransitionSettings = CType(points(selectedLine).settings, TransitionSettings)
            Dim frm As New frmTransition(settings)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                settings = frm.settings
            End If
         ElseIf TypeOf points(selectedLine).settings Is TimeShiftSettings Then
        Dim settings As TimeShiftSettings = CType(points(selectedLine).settings, TimeShiftSettings)
        Dim frm As New frmTimeShift(settings)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            settings = frm.settings
        End If
        End If
    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        If selectedLine < 0 Then Exit Sub

        btnSettings.Enabled = True

        Select Case cboOperation.SelectedIndex
            Case 0 ' None
                points(selectedLine).settings = Nothing
                btnSettings.Enabled = False
            Case 1 ' Fade In
                points(selectedLine).settings = New FadeInSettings
            Case 2 ' Fade Out
                points(selectedLine).settings = New FadeOutSettings
            Case 3 ' Motion Blur
                points(selectedLine).settings = New MotionBlurSettings
                'Case 4 ' Ripple
                '    points(selectedLine).settings = New RippleSettings
            Case 4 ' Melt
                points(selectedLine).settings = New MeltSettings
            Case 5 ' Transition
                points(selectedLine).settings = New TransitionSettings
            Case 6 ' Time Shift
                points(selectedLine).settings = New TimeShiftSettings
        End Select

        points(selectedLine).operation = cboOperation.SelectedIndex

        picBox.Invalidate()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If frameNum1 <= 0 Then Exit Sub

        InitPoints()
        selectedIndex = 0
        selectedLine = -1
        picBox.Invalidate()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If frameNum1 <= 0 Then Exit Sub

        If selectedIndex = 0 Or selectedIndex = UBound(points) Then
            MsgBox("Cannot delete first/last points")
            Exit Sub
        End If

        For index As Integer = selectedIndex To UBound(points) - 1
            points(index) = points(index + 1)
        Next

        ReDim Preserve points(UBound(points) - 1)
        If selectedLine > 0 And selectedLine >= selectedIndex Then
            selectedLine = selectedLine - 1
        End If
        selectedIndex = selectedIndex - 1

        picBox.Invalidate()
    End Sub

    Private Sub AddKeyFrame(ByVal currentIndex As Integer, ByRef bitmap As Bitmap)
        Dim data As New PointData
        data.x = CInt(currentIndex / (frameNum1 - 1) * picBox.ClientRectangle.Width)
        data.y = CInt(picBox.ClientRectangle.Height / 2)
        data.keyframe = bitmap.Clone()

        Dim n As Integer = points.Length
        ReDim Preserve points(n)

        points(n) = points(n - 1)
        points(n - 1) = data
    End Sub

    Private Sub btnKeyframes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyframes.Click
        Static Dim settings As New KeyframeSettings

        ' Show the keyframe settings
        Dim dialog As New frmKeyframe(settings)
        If dialog.ShowDialog() <> Windows.Forms.DialogResult.OK Then Exit Sub
        settings = dialog.settings

        Me.Enabled = False

        ' Extract keyframes
        Dim fileSpec As String
        Dim inputBitmap1 As Bitmap
        Dim inputBitmap2 As Bitmap

        InitPoints()
        selectedIndex = 0
        selectedLine = -1

        ' Get the first frame from the input video
        ChDir(Application.StartupPath)
        fileSpec = dirname1 & "\f0.bmp"
        inputBitmap1 = New Bitmap(fileSpec)

        points(0).keyframe = inputBitmap1.Clone()

        ' Extract key frames
        For currentIndex As Integer = 1 To frameNum1 - 2
            ' Get the current Frame
            fileSpec = dirname1 & "\f" & CStr(currentIndex) & ".bmp"

            ' Load the input Frame
            inputBitmap2 = New Bitmap(fileSpec)
            picInput1.Image = CType(inputBitmap2, Image)

            If IsKeyframe(inputBitmap1, inputBitmap2, settings.threshold, settings.similarity) Then
                AddKeyFrame(currentIndex, inputBitmap2)
            End If

            inputBitmap1 = inputBitmap2

            sbMessage.Panels(0).Text = "Processing frame " & Str(currentIndex) & "......"
            System.Windows.Forms.Application.DoEvents()
        Next

        sbMessage.Panels(0).Text = "Keyframes generation finished......"

        picBox.Invalidate()

        Me.Enabled = True
    End Sub

    ' Start video processing
    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        ProcessVideo()
    End Sub

    Private Sub ProcessFrame(ByVal inputFrameIndex As Integer, ByVal outputFrameIndex As Integer, ByRef settings As Object, ByRef startFrame As Integer, ByRef endFrame As Integer, ByRef newOp As Boolean)
        Dim fileSpec1 As String
        Dim fileSpec2 As String

        skip = False

        ' Get the input Frame from the input video
        ChDir(Application.StartupPath)
        fileSpec1 = dirname1 & "\f" & CStr(inputFrameIndex) & ".bmp"
        fileSpec2 = dirname2 & "\f" & CStr(inputFrameIndex) & ".bmp"

        ' Load the input Frame
        If Not picInput1.Image Is Nothing Then
            picInput1.Image.Dispose()
        End If
        Dim inputBitmap1 As New Bitmap(fileSpec1)
        picInput1.Image = CType(inputBitmap1, Image)

        ' Load the input Frame2
        If Not picInput2.Image Is Nothing Then
            picInput2.Image.Dispose()
        End If
        Dim inputBitmap2 As Bitmap
        If File.Exists(fileSpec2) Then
            inputBitmap2 = New Bitmap(fileSpec2)
        Else
            inputBitmap2 = inputBitmap1.Clone()
        End If
        picInput2.Image = CType(inputBitmap2, Image)

        ' Output Frame bitmap
        Dim outputBitmap As Bitmap = Nothing

        ' Decide if operation is needed to apply to the input Frame
        If Not (settings Is Nothing) Then
            If TypeOf settings Is FadeInSettings Then
                Dim op As FadeInSettings = CType(settings, FadeInSettings)
                outputBitmap = FadeIn(inputBitmap1, op.startRate, inputFrameIndex, startFrame, endFrame)
            ElseIf TypeOf settings Is FadeOutSettings Then
                Dim op As FadeOutSettings = CType(settings, FadeOutSettings)
                outputBitmap = FadeOut(inputBitmap1, op.endRate, inputFrameIndex, startFrame, endFrame)
            ElseIf TypeOf settings Is MotionBlurSettings Then
                Dim op As MotionBlurSettings = CType(settings, MotionBlurSettings)
                outputBitmap = MotionBlur(inputBitmap1, op.blurCount, inputFrameIndex, startFrame, endFrame, newOp, dirname1)
            ElseIf TypeOf settings Is MeltSettings Then
                Dim op As MeltSettings = CType(settings, MeltSettings)
                outputBitmap = Melt(inputBitmap1, op.useSine, op.amplitude, op.cycle, op.useRandom, op.offset, op.period, inputFrameIndex, startFrame, endFrame, newOp)
            ElseIf TypeOf settings Is TransitionSettings Then
                Dim op As TransitionSettings = CType(settings, TransitionSettings)
                ' outputBitmap = Transition(inputBitmap1, inputBitmap2, op.duration, inputFrameIndex, startFrame, endFrame, newOp)
                outputBitmap = Transition(inputBitmap1, inputBitmap2, op.type, op.duration, inputFrameIndex, startFrame, endFrame, newOp)
            ElseIf TypeOf settings Is TimeShiftSettings Then
                Dim op As TimeShiftSettings = CType(settings, TimeShiftSettings)
                outputBitmap = TimeShift(inputBitmap1, inputBitmap2, op.cutOffPos, inputFrameIndex, startFrame, endFrame, newOp)
            End If
        End If

            ' Put the output bitmap to the output picture box
            If Not picOutput.Image Is Nothing Then
                picOutput.Image.Dispose()
            End If

            If outputBitmap Is Nothing Then
                picOutput.Image = CType(inputBitmap1, Image)
            Else
                picOutput.Image = CType(outputBitmap, Image)
            End If

            If skip = False Then
                ' Save the output Frame
                picOutput.Image.Save(".\out" & CStr(outputFrameIndex) & ".bmp", Imaging.ImageFormat.Bmp)
            End If

            newOp = False
    End Sub

    ' Process the video
    Private Sub ProcessVideo()
        Dim index As Integer
        Dim frame As Integer
        Dim frameCount As Integer
        Dim startFrame As Integer
        Dim endFrame As Integer
        Dim newFrameNum As Integer
        Dim frameStep As Integer
        Dim multiplier As Double
        Dim multiplierCount As Double
        Dim endIndex As Integer
        Dim opNew As Boolean

        Me.Enabled = False

        frameStep = 10 ' process every 10 Frames
        frameCount = 0

        ' Get the index for frames of each operation
        Dim opStartFrame As Integer = -1
        Dim opEndFrame As Integer = -1
        Dim opIndex As Integer = -1

        ' Get start and end Frame
        startFrame = CInt(points(0).x / picBox.ClientRectangle.Width * (frameNum1 - 1))
        endFrame = CInt(points(UBound(points)).x / picBox.ClientRectangle.Width * (frameNum1 - 1))

        ' Calculate the new number of Frame
        newFrameNum = endFrame - startFrame + 1

        'Try
        ' Go through all the Frames
        For index = startFrame To endFrame Step frameStep
            If index > opEndFrame Then
                opIndex = opIndex + 1
                GetStartEndFrame(opIndex, opStartFrame, opEndFrame)
                opNew = True
            End If

            While opStartFrame = opEndFrame
                opIndex = opIndex + 1
                GetStartEndFrame(opIndex, opStartFrame, opEndFrame)
                opNew = True
            End While

            endIndex = index + frameStep - 1
            If endIndex > endFrame Then
                endIndex = endFrame
            End If

            ' Get the multiplier from the editor
            multiplier = GetMultiplier(CInt(Math.Floor((index + endIndex) / 2)))
            multiplierCount = 0

            ' Process every "FrameStep" Frames
            ' Slow down or speed up the video
            ' The method used is smiliar to the method used to stretch or shrink an audio file
            For frame = index To endIndex
                ' The following six lines of code are what you need
                If frame > opEndFrame Then
                    opIndex = opIndex + 1
                    GetStartEndFrame(opIndex, opStartFrame, opEndFrame)
                    opNew = True
                    multiplier = GetMultiplier(CInt(Math.Floor((frame + endIndex) / 2)))
                    multiplierCount = 0
                End If

                If multiplier <= 0 Then ' slow down the video
                    ProcessFrame(frame, frameCount, points(opIndex).settings, opStartFrame, opEndFrame, opNew)
                    If skip = False Then frameCount = frameCount + 1
                    multiplierCount = multiplierCount - multiplier

                    Do While (multiplierCount > 0)
                        ProcessFrame(frame, frameCount, points(opIndex).settings, opStartFrame, opEndFrame, opNew)
                        If skip = False Then frameCount = frameCount + 1
                        multiplierCount = multiplierCount - 1
                    Loop
                Else ' speed up the video
                    multiplierCount = multiplierCount + (1 - (1 / (multiplier + 1)))

                    If multiplierCount < 1 Then
                        ProcessFrame(frame, frameCount, points(opIndex).settings, opStartFrame, opEndFrame, opNew)
                        If skip = False Then frameCount = frameCount + 1
                    Else
                        multiplierCount = multiplierCount - 1
                    End If
                End If

                sbMessage.Panels(0).Text = "Processing frame " & Str(frame) & "......"
                System.Windows.Forms.Application.DoEvents()
            Next
        Next
        sbMessage.Panels(0).Text = frameCount & " frames are processed"

        ' Output the video
        ChDir(Application.StartupPath)
        PrintParaFile(frameCount, picOutput.Image.Width, picOutput.Image.Height)
        wmpOutput.URL = ""

        ExecCmd("mpeg2enc", "temp.par temp.mpg")
        wmpOutput.Enabled = True
        wmpOutput.URL = ".\temp.mpg"

        mnuSave.Enabled = True

        Me.Enabled = True
        Me.Focus()
        Me.Activate()
        Me.BringToFront()
        'Catch e As Exception
        '    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.Enabled = True
        'End Try
    End Sub

    ' Extract frames from a video
    Private Function ExtractFrames(ByVal filename As String, ByRef dirname As String) As Integer
        Dim token() As String
        Dim fileSpec As String
        Dim index As Integer

        If filename Is Nothing Or filename = "" Then Return 0

        ' Extract the frames into f%d.bmp
        token = Split(filename, "\")
        fileSpec = token(UBound(token))
        ChDir((Application.StartupPath))
        dirname = Mid(fileSpec, 1, InStr(fileSpec, ".") - 1)

        If Not Directory.Exists(dirname) Then
            Directory.CreateDirectory(dirname)
        End If
        fileSpec = dirname & "\f0.bmp"

        If Not File.Exists(fileSpec) Then
            ExecCmd("mpeg2dec", "-q -o6 """ & dirname & "\f%d"" -b """ & filename & """")
        End If

        'Get the frame numbers of the video
        index = 0
        fileSpec = dirname & "\f" & CStr(index) & ".bmp"

        While File.Exists(fileSpec)
            index = index + 1
            fileSpec = dirname & "\f" & CStr(index) & ".bmp"
        End While

        Return index
    End Function

    Private Sub mnuExtractFrames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExtractFrames.Click
        ' Extract Frames from the video
        frameNum1 = ExtractFrames(filename1, dirname1)
        frameNum2 = ExtractFrames(filename2, dirname2)

        If frameNum1 = 0 And frameNum2 = 0 Then
            MsgBox("Nothing is extracted.")
            Return
        End If

        ' Initialize editor parameters
        InitPoints()
        selectedIndex = 0
        selectedLine = -1
        picBox.Invalidate()

        gbProcess.Enabled = True

        Dim g As Graphics
        g = picInput1.CreateGraphics()
        g.Clear(Color.White)
        g = picInput2.CreateGraphics()
        g.Clear(Color.White)
        g = picOutput.CreateGraphics()
        g.Clear(Color.White)

        Me.Focus()

        sbMessage.Panels(0).Text = "Start editing"
    End Sub

    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        Dim dialog As New OpenFileDialog

        dialog.Filter = "MPEG Files (*.mpg, *.mpeg)|*.mpg;*.mpeg"
        dialog.RestoreDirectory = True

        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If Len(dialog.FileName) = 0 Then
                Exit Sub
            End If

            filename1 = dialog.FileName

            wmpInput1.URL = filename1
            wmpOutput.URL = ""

            mnuExtractFrames.Enabled = True
            sbMessage.Panels(0).Text = "Input video 1 opened"
            gbProcess.Enabled = False
        End If
    End Sub

    Private Sub mnuOpen2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen2.Click
        Dim dialog As New OpenFileDialog

        dialog.Filter = "MPEG Files (*.mpg, *.mpeg)|*.mpg;*.mpeg"
        dialog.RestoreDirectory = True

        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If Len(dialog.FileName) = 0 Then
                Exit Sub
            End If

            filename2 = dialog.FileName

            wmpInput2.URL = filename2
            wmpOutput.URL = ""

            sbMessage.Panels(0).Text = "Input video 2 opened"
            gbProcess.Enabled = False
        End If
    End Sub

    Private Sub mnuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSave.Click
        Dim dialog As New SaveFileDialog

        dialog.Filter = "MPEG Files (*.mpg, *.mpeg)|*.mpg;*.mpeg"
        dialog.RestoreDirectory = True

        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If Len(dialog.FileName) = 0 Then Exit Sub

            Try
                ChDir(Application.StartupPath)
                File.Copy(".\temp.mpg", dialog.FileName)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim cancel As Boolean = e.Cancel
        Dim answer As DialogResult
        Dim index As Integer
        Dim fileSpec As String

        ChDir(Application.StartupPath)

        ' Clean the whole directory of unnecessary files
        If File.Exists(".\temp.mpg") Then
            answer = MessageBox.Show("Do you want to keep the MPEG result?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            If answer = Windows.Forms.DialogResult.Cancel Then
                cancel = True
                e.Cancel = cancel
                Exit Sub
            End If

            If answer = Windows.Forms.DialogResult.No Then
                wmpOutput.URL = ""
                File.Delete(".\temp.mpg")
            End If
        End If

        index = 0
        fileSpec = ".\out" & CStr(index) & ".bmp"
        While File.Exists(fileSpec)
            File.Delete(fileSpec)
            index = index + 1
            fileSpec = ".\out" & CStr(index) & ".bmp"
        End While

        If File.Exists(".\temp.par") Then File.Delete(".\temp.par")
        If File.Exists(".\stat.txt") Then File.Delete(".\stat.txt")
    End Sub


    ' //////////////////////////////////////////////////////////////////////////////
    ' //                      functions for the video editor       
    ' //////////////////////////////////////////////////////////////////////////////

    Public Sub GetStartEndFrame(ByVal index As Integer, ByRef startFrame As Integer, ByRef endFrame As Integer)
        startFrame = CInt(points(index).x / picBox.ClientRectangle.Width * (frameNum1 - 1))
        endFrame = CInt(points(index + 1).x / picBox.ClientRectangle.Width * (frameNum1 - 1))
    End Sub

    Public Sub InitPoints()
        ' Initialize the array of Points
        Dim data As PointData = Nothing

        ReDim points(1)

        origin.x = 0
        origin.y = CInt(picBox.ClientRectangle.Height / 2)
        points(0) = origin

        data.x = picBox.ClientRectangle.Width
        data.y = CInt(picBox.ClientRectangle.Height / 2)
        points(1) = data

        dragIndex = -1
        selectedIndex = 0
        selectedLine = -1
    End Sub

    Private Sub picBox_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBox.MouseDown
        If frameNum1 <= 0 Then Exit Sub

        Dim x As Integer = e.X
        Dim y As Integer = e.Y
        Dim i, j As Integer

        Dim data As PointData = Nothing
        data.x = x
        data.y = y

        Dim d As Single ' sensitivity
        Dim n As Integer = UBound(points) + 1 ' number of Points

        ' select a line
        Dim yy As Integer
        If optSelect.Checked = True Then
            For i = 0 To n - 2
                If points(i).x - points(i + 1).x = 0 Then
                    yy = y
                Else
                    yy = CInt(points(i).y - (points(i).y - points(i + 1).y) / (points(i).x - points(i + 1).x) * (points(i).x - x))
                End If

                d = CInt(System.Math.Abs(points(i + 1).y - points(i).y) * 0.3)
                If d < 30 Then
                    d = 30
                End If
                If x > points(i).x And x < points(i + 1).x And System.Math.Abs(y - yy) < d Then
                    selectedLine = i
                    picBox.Invalidate()
                    Exit For
                End If
            Next
            Exit Sub
        End If

        ' check if the point exists
        d = 20
        For i = 0 To n - 1
            If System.Math.Abs(x - points(i).x) < pointRadius + d And System.Math.Abs(y - points(i).y) < pointRadius + d Then
                selectedIndex = i
                If i >= 0 And i <= n - 1 Then
                    dragIndex = i
                    picBox.Invalidate()
                End If
                Exit Sub
            End If
        Next

        ' add a new point
        For i = 0 To n - 2
            If x >= points(i).x And x < points(i + 1).x Then
                Exit For
            End If
        Next
        If i = n - 1 Then Exit Sub

        ReDim Preserve points(n)
        For j = n To i + 2 Step -1
            points(j) = points(j - 1)
        Next

        points(i + 1) = data
        selectedIndex = i + 1
        dragIndex = i + 1
        If selectedLine >= 0 And selectedLine >= i + 1 Then
            selectedLine = selectedLine + 1
        End If

        picBox.Invalidate()
    End Sub

    Private Sub picBox_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBox.MouseMove
        Dim X As Integer = e.X
        Dim Y As Integer = e.Y

        If frameNum1 <= 0 Then Exit Sub

        ' check if in drag mode
        If dragIndex < 0 Then
            Exit Sub
        End If

        ' check if the new position of the point is valid
        If dragIndex = 0 Then
            If X < 0 Or X > points(dragIndex + 1).x Then
                Exit Sub
            End If
        ElseIf dragIndex = UBound(points) Then
            If X < points(dragIndex - 1).x Or X > picBox.ClientRectangle.Width Then
                Exit Sub
            End If
        Else
            If X < points(dragIndex - 1).x Or X > points(dragIndex + 1).x Then
                Exit Sub
            End If
        End If

        If Y < 0 Or Y > picBox.ClientRectangle.Height Then
            Exit Sub
        End If

        points(dragIndex).x = X
        points(dragIndex).y = Y
        If Not (points(dragIndex).keyframe Is Nothing) Then
            points(dragIndex).keyframe.Dispose()
            points(dragIndex).keyframe = Nothing
        End If
        picBox.Invalidate()
    End Sub

    Private Sub picBox_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBox.MouseUp
        If frameNum1 <= 0 Then Exit Sub

        dragIndex = -1

        Dim FileSpec As String
        Dim inFrame As Integer
        inFrame = CInt(points(selectedIndex).x / picBox.ClientRectangle.Width * (frameNum1 - 1))

        ' get the input Frame from the input video
        ChDir(Application.StartupPath)
        FileSpec = dirname1 & "\f" & CStr(inFrame) & ".bmp"
        picInput1.Image = System.Drawing.Image.FromFile(FileSpec)
    End Sub

    ' get the multipier from the editor
    Public Function GetMultiplier(ByRef Frame As Integer) As Double
        Dim i As Integer
        Dim Y As Double

        For i = 0 To UBound(points) - 1
            If Frame / (frameNum1 - 1) >= points(i).x / picBox.ClientRectangle.Width And Frame / (frameNum1 - 1) < points(i + 1).x / picBox.ClientRectangle.Width Then
                Exit For
            End If
        Next i

        If i >= UBound(points) Then
            i = UBound(points) - 1
        End If

        ' calculate the y poisition in the picture box for the Frame
        If (points(i).x - points(i + 1).x) = 0 Then
            Y = (points(i).y + points(i + 1).y) / 2
        Else
            Y = points(i).y - (points(i).y - points(i + 1).y) / (points(i).x - points(i + 1).x) * (points(i).x - Frame / (frameNum1 - 1) * picBox.ClientRectangle.Width)
        End If

        GetMultiplier = (picBox.ClientRectangle.Height / 2 - Y) / (picBox.ClientRectangle.Height / 2) * maxMultiplier
    End Function

    Private Sub picBox_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picBox.Paint
        If frameNum1 <= 0 Then Exit Sub

        Dim g As Graphics = e.Graphics()
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        ' draw the figure
        Dim i As Integer
        Dim tickLen As Integer
        Dim offset As Integer

        offset = 1
        tickLen = 5

        g.Clear(Color.White)

        Dim blackPen As New Pen(Color.Black, 1)
        Dim bluePen As New Pen(Color.Blue, 1)

        ' draw x axis
        Dim point1 As Point
        Dim point2 As Point
        point1.X = origin.x
        point1.Y = origin.y
        point2.X = picBox.ClientRectangle.Width
        point2.Y = origin.y
        g.DrawLine(blackPen, point1, point2)

        ' draw the ticks for x axis
        Dim d As Double
        d = CInt(picBox.ClientRectangle.Width / frameNum1 * tickFreq)
        For i = 1 To CInt((frameNum1 - 1) / tickFreq)
            point1.X = CInt(i * d)
            point1.Y = CInt(picBox.ClientRectangle.Height / 2 - tickLen / 2)
            point2.X = CInt(i * d)
            point2.Y = CInt(picBox.ClientRectangle.Height / 2 + tickLen / 2)
            g.DrawLine(bluePen, point1, point2)
        Next

        ' draw the ticks for y axis
        d = picBox.ClientRectangle.Height / 2 / maxMultiplier
        For i = 1 To CInt(picBox.ClientRectangle.Height / 2 / d)
            point1.X = 0
            point1.Y = CInt(picBox.ClientRectangle.Height / 2 - i * d)
            point2.X = tickLen
            point2.Y = CInt(picBox.ClientRectangle.Height / 2 - i * d)
            g.DrawLine(bluePen, point1, point2)
        Next
        For i = 1 To CInt(picBox.ClientRectangle.Height / 2 / d)
            point1.X = 0
            point1.Y = CInt(picBox.ClientRectangle.Height / 2 + i * d - offset)
            point2.X = tickLen
            point2.Y = CInt(picBox.ClientRectangle.Height / 2 + i * d - offset)
            g.DrawLine(bluePen, point1, point2)
        Next

        ' draw the keyframes
        For i = 0 To UBound(points)
            If Not (points(i).keyframe Is Nothing) Then
                Dim w As Integer = 50
                Dim h As Integer = 50 / points(i).keyframe.Width * points(i).keyframe.Height
                Dim x As Integer = points(i).x - w / 2
                Dim y As Integer
                If i Mod 2 = 0 Then
                    y = points(i).y + pointRadius * 2
                Else
                    y = points(i).y - h - pointRadius * 2
                End If

                g.DrawImage(points(i).keyframe, x, y, w, h)
            End If
        Next

        ' draw the lines
        Dim purplePen As New Pen(Color.Purple, 2)
        Dim orangePen As New Pen(Color.Orange, 2)
        Dim greenPen As New Pen(Color.Green, 2)
        Dim pinkPen As New Pen(Color.Pink, 2)
        Dim brownPen As New Pen(Color.Brown, 2)
        Dim cyanPen As New Pen(Color.Cyan, 2)
        Dim goldPen As New Pen(Color.Gold, 2)
        Dim grayPen As New Pen(Color.Gray, 2)
        Dim lightseagreenPen As New Pen(Color.LightSeaGreen, 2)
        Dim greenyellowPen As New Pen(Color.GreenYellow, 2)
        Dim yellowPen As New Pen(Color.Yellow, 2)
        bluePen = New Pen(Color.Blue, 2)

        For i = 0 To UBound(points) - 1
            point1.X = points(i).x
            point1.Y = points(i).y
            point2.X = points(i + 1).x
            point2.Y = points(i + 1).y
            If Not (points(i).settings Is Nothing) Then
                If TypeOf points(i).settings Is FadeInSettings Then
                    g.DrawLine(pinkPen, point1, point2)
                ElseIf TypeOf points(i).settings Is FadeOutSettings Then
                    g.DrawLine(purplePen, point1, point2)
                ElseIf TypeOf points(i).settings Is MotionBlurSettings Then
                    g.DrawLine(brownPen, point1, point2)
                ElseIf TypeOf points(i).settings Is MeltSettings Then
                    g.DrawLine(goldPen, point1, point2)
                ElseIf TypeOf points(i).settings Is TransitionSettings Then
                    g.DrawLine(greenyellowPen, point1, point2)
                End If
            Else
                g.DrawLine(bluePen, point1, point2)
            End If

            If i = selectedLine Then
                g.DrawLine(yellowPen, point1, point2)
            End If
        Next i

        Dim redBrush As New SolidBrush(Color.Red)
        ' draw the Points
        For i = 0 To UBound(points)
            If i <> selectedIndex Then
                g.FillEllipse(redBrush, points(i).x - pointRadius, points(i).y - pointRadius, pointRadius * 2, pointRadius * 2)
            End If
        Next i

        ' draw the selected point
        Dim greenBrush As New SolidBrush(Color.Green)
        g.FillEllipse(greenBrush, points(selectedIndex).x - pointRadius, points(selectedIndex).y - pointRadius, pointRadius * 2, pointRadius * 2)

        lblFrame.Text = "Current Frame: " & CStr(CShort(points(selectedIndex).x / picBox.ClientRectangle.Width * (frameNum1 - 1)))

        If selectedLine >= 0 Then
            Dim cboItem As Object
            cboItem = cboOperation.Items.Item(points(selectedLine).operation)
            lblOperation.Text = cboItem.ToString()
        End If
    End Sub

End Class
