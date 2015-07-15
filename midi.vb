Option Explicit On
Public Class frmMidiPiano
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
    Private WithEvents vsbVolume As System.Windows.Forms.VScrollBar
    Public WithEvents _key_15 As System.Windows.Forms.CheckBox
    Public WithEvents _key_13 As System.Windows.Forms.CheckBox
    Public WithEvents _key_10 As System.Windows.Forms.CheckBox
    Public WithEvents _key_8 As System.Windows.Forms.CheckBox
    Public WithEvents _key_6 As System.Windows.Forms.CheckBox
    Public WithEvents _key_3 As System.Windows.Forms.CheckBox
    Public WithEvents _key_1 As System.Windows.Forms.CheckBox
    Public WithEvents _key_16 As System.Windows.Forms.CheckBox
    Public WithEvents _key_14 As System.Windows.Forms.CheckBox
    Public WithEvents _key_12 As System.Windows.Forms.CheckBox
    Public WithEvents _key_11 As System.Windows.Forms.CheckBox
    Public WithEvents _key_9 As System.Windows.Forms.CheckBox
    Public WithEvents _key_7 As System.Windows.Forms.CheckBox
    Public WithEvents _key_5 As System.Windows.Forms.CheckBox
    Public WithEvents _key_4 As System.Windows.Forms.CheckBox
    Public WithEvents _key_2 As System.Windows.Forms.CheckBox
    Public WithEvents _key_0 As System.Windows.Forms.CheckBox
    Private WithEvents lblVolume As System.Windows.Forms.Label
    Public WithEvents mnuDevice0 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice1 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice2 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice3 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice4 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice5 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice6 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice7 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice8 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice9 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice10 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel0 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel1 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel2 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel3 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel4 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel5 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel6 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel7 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel8 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel9 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel10 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel11 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel12 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel13 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel14 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel15 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel As System.Windows.Forms.MenuItem
    Public WithEvents mnuBaseNote As System.Windows.Forms.MenuItem
    Public mnuMain As System.Windows.Forms.MainMenu
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Private WithEvents btnPlay As System.Windows.Forms.Button
    Private WithEvents btnStop As System.Windows.Forms.Button
    Private WithEvents btnRecord As System.Windows.Forms.Button
    Private WithEvents btnRemoveSilence As System.Windows.Forms.Button
    Friend WithEvents tbSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents lblSeqSlow As System.Windows.Forms.Label
    Friend WithEvents lblSeqNormal As System.Windows.Forms.Label
    Friend WithEvents lblSeqFast As System.Windows.Forms.Label
    Friend WithEvents gbxInstrument As System.Windows.Forms.GroupBox
    Friend WithEvents tbBankMSB As System.Windows.Forms.TrackBar
    Friend WithEvents tbInstrument As System.Windows.Forms.TrackBar
    Friend WithEvents lblBankMSB As System.Windows.Forms.Label
    Friend WithEvents tmrSequencer As System.Windows.Forms.Timer
    Friend WithEvents tclMidiFunction As System.Windows.Forms.TabControl
    Friend WithEvents tabSequencer As System.Windows.Forms.TabPage
    Friend WithEvents tabDrumMachine As System.Windows.Forms.TabPage
    Friend WithEvents tabWhiteboard As System.Windows.Forms.TabPage
    Friend WithEvents gbxXAxis As System.Windows.Forms.GroupBox
    Friend WithEvents lblXValue As System.Windows.Forms.Label
    Friend WithEvents cboXTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblXTitle As System.Windows.Forms.Label
    Friend WithEvents lblXCaption As System.Windows.Forms.Label
    Friend WithEvents picWhiteboard As System.Windows.Forms.PictureBox
    Friend WithEvents gbxYAxis As System.Windows.Forms.GroupBox
    Friend WithEvents cboYTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblYTitle As System.Windows.Forms.Label
    Friend WithEvents lblYCaption As System.Windows.Forms.Label
    Friend WithEvents lblYValue As System.Windows.Forms.Label
    Public WithEvents btnDrumStop As System.Windows.Forms.Button
    Public WithEvents btnDrumStart As System.Windows.Forms.Button
    Public WithEvents picDrum As System.Windows.Forms.PictureBox
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.MenuItem
    Public WithEvents tmrDrumPlayback As System.Windows.Forms.Timer
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TrackBar3 As System.Windows.Forms.TrackBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TrackBar4 As System.Windows.Forms.TrackBar
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents lblInstrument As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.vsbVolume = New System.Windows.Forms.VScrollBar()
        Me._key_15 = New System.Windows.Forms.CheckBox()
        Me._key_13 = New System.Windows.Forms.CheckBox()
        Me._key_10 = New System.Windows.Forms.CheckBox()
        Me._key_8 = New System.Windows.Forms.CheckBox()
        Me._key_6 = New System.Windows.Forms.CheckBox()
        Me._key_3 = New System.Windows.Forms.CheckBox()
        Me._key_1 = New System.Windows.Forms.CheckBox()
        Me._key_16 = New System.Windows.Forms.CheckBox()
        Me._key_14 = New System.Windows.Forms.CheckBox()
        Me._key_12 = New System.Windows.Forms.CheckBox()
        Me._key_11 = New System.Windows.Forms.CheckBox()
        Me._key_9 = New System.Windows.Forms.CheckBox()
        Me._key_7 = New System.Windows.Forms.CheckBox()
        Me._key_5 = New System.Windows.Forms.CheckBox()
        Me._key_4 = New System.Windows.Forms.CheckBox()
        Me._key_2 = New System.Windows.Forms.CheckBox()
        Me._key_0 = New System.Windows.Forms.CheckBox()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.mnuChannel0 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel1 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel2 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel3 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel4 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel5 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel6 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel7 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel8 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel9 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel10 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel11 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel12 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel13 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel14 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel15 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice0 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice1 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice2 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice3 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice4 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice5 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice6 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice7 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice8 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice9 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice10 = New System.Windows.Forms.MenuItem()
        Me.mnuMain = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuOpen = New System.Windows.Forms.MenuItem()
        Me.mnuDevice = New System.Windows.Forms.MenuItem()
        Me.mnuChannel = New System.Windows.Forms.MenuItem()
        Me.mnuBaseNote = New System.Windows.Forms.MenuItem()
        Me.lblSeqFast = New System.Windows.Forms.Label()
        Me.lblSeqNormal = New System.Windows.Forms.Label()
        Me.lblSeqSlow = New System.Windows.Forms.Label()
        Me.tbSpeed = New System.Windows.Forms.TrackBar()
        Me.btnRemoveSilence = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.gbxInstrument = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbBankMSB = New System.Windows.Forms.TrackBar()
        Me.tbInstrument = New System.Windows.Forms.TrackBar()
        Me.lblBankMSB = New System.Windows.Forms.Label()
        Me.lblInstrument = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tmrSequencer = New System.Windows.Forms.Timer(Me.components)
        Me.tclMidiFunction = New System.Windows.Forms.TabControl()
        Me.tabSequencer = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tabWhiteboard = New System.Windows.Forms.TabPage()
        Me.gbxXAxis = New System.Windows.Forms.GroupBox()
        Me.lblXValue = New System.Windows.Forms.Label()
        Me.cboXTitle = New System.Windows.Forms.ComboBox()
        Me.lblXTitle = New System.Windows.Forms.Label()
        Me.lblXCaption = New System.Windows.Forms.Label()
        Me.picWhiteboard = New System.Windows.Forms.PictureBox()
        Me.gbxYAxis = New System.Windows.Forms.GroupBox()
        Me.cboYTitle = New System.Windows.Forms.ComboBox()
        Me.lblYTitle = New System.Windows.Forms.Label()
        Me.lblYCaption = New System.Windows.Forms.Label()
        Me.lblYValue = New System.Windows.Forms.Label()
        Me.tabDrumMachine = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnDrumStop = New System.Windows.Forms.Button()
        Me.btnDrumStart = New System.Windows.Forms.Button()
        Me.picDrum = New System.Windows.Forms.PictureBox()
        Me.tmrDrumPlayback = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.TrackBar4 = New System.Windows.Forms.TrackBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInstrument.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBankMSB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbInstrument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tclMidiFunction.SuspendLayout()
        Me.tabSequencer.SuspendLayout()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWhiteboard.SuspendLayout()
        Me.gbxXAxis.SuspendLayout()
        CType(Me.picWhiteboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxYAxis.SuspendLayout()
        Me.tabDrumMachine.SuspendLayout()
        CType(Me.picDrum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsbVolume
        '
        Me.vsbVolume.LargeChange = 1
        Me.vsbVolume.Location = New System.Drawing.Point(14, 29)
        Me.vsbVolume.Maximum = 127
        Me.vsbVolume.Name = "vsbVolume"
        Me.vsbVolume.Size = New System.Drawing.Size(60, 143)
        Me.vsbVolume.TabIndex = 17
        Me.vsbVolume.TabStop = True
        '
        '_key_15
        '
        Me._key_15.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_15.BackColor = System.Drawing.Color.Black
        Me._key_15.ForeColor = System.Drawing.Color.White
        Me._key_15.Location = New System.Drawing.Point(425, 14)
        Me._key_15.Name = "_key_15"
        Me._key_15.Size = New System.Drawing.Size(20, 97)
        Me._key_15.TabIndex = 16
        Me._key_15.Text = ";"
        Me._key_15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_15.UseVisualStyleBackColor = False
        '
        '_key_13
        '
        Me._key_13.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_13.BackColor = System.Drawing.Color.Black
        Me._key_13.ForeColor = System.Drawing.Color.White
        Me._key_13.Location = New System.Drawing.Point(386, 14)
        Me._key_13.Name = "_key_13"
        Me._key_13.Size = New System.Drawing.Size(21, 97)
        Me._key_13.TabIndex = 15
        Me._key_13.Text = "L"
        Me._key_13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_13.UseVisualStyleBackColor = False
        '
        '_key_10
        '
        Me._key_10.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_10.BackColor = System.Drawing.Color.Black
        Me._key_10.ForeColor = System.Drawing.Color.White
        Me._key_10.Location = New System.Drawing.Point(310, 14)
        Me._key_10.Name = "_key_10"
        Me._key_10.Size = New System.Drawing.Size(20, 97)
        Me._key_10.TabIndex = 14
        Me._key_10.Text = "J"
        Me._key_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_10.UseVisualStyleBackColor = False
        '
        '_key_8
        '
        Me._key_8.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_8.BackColor = System.Drawing.Color.Black
        Me._key_8.ForeColor = System.Drawing.Color.White
        Me._key_8.Location = New System.Drawing.Point(271, 14)
        Me._key_8.Name = "_key_8"
        Me._key_8.Size = New System.Drawing.Size(21, 97)
        Me._key_8.TabIndex = 13
        Me._key_8.Text = "H"
        Me._key_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_8.UseVisualStyleBackColor = False
        '
        '_key_6
        '
        Me._key_6.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_6.BackColor = System.Drawing.Color.Black
        Me._key_6.ForeColor = System.Drawing.Color.White
        Me._key_6.Location = New System.Drawing.Point(233, 14)
        Me._key_6.Name = "_key_6"
        Me._key_6.Size = New System.Drawing.Size(20, 97)
        Me._key_6.TabIndex = 12
        Me._key_6.Text = "G"
        Me._key_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_6.UseVisualStyleBackColor = False
        '
        '_key_3
        '
        Me._key_3.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_3.BackColor = System.Drawing.Color.Black
        Me._key_3.ForeColor = System.Drawing.Color.White
        Me._key_3.Location = New System.Drawing.Point(156, 14)
        Me._key_3.Name = "_key_3"
        Me._key_3.Size = New System.Drawing.Size(20, 97)
        Me._key_3.TabIndex = 11
        Me._key_3.Text = "D"
        Me._key_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_3.UseVisualStyleBackColor = False
        '
        '_key_1
        '
        Me._key_1.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_1.BackColor = System.Drawing.Color.Black
        Me._key_1.ForeColor = System.Drawing.Color.White
        Me._key_1.Location = New System.Drawing.Point(118, 14)
        Me._key_1.Name = "_key_1"
        Me._key_1.Size = New System.Drawing.Size(20, 97)
        Me._key_1.TabIndex = 10
        Me._key_1.Text = "S"
        Me._key_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_1.UseVisualStyleBackColor = False
        '
        '_key_16
        '
        Me._key_16.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_16.BackColor = System.Drawing.Color.White
        Me._key_16.ForeColor = System.Drawing.Color.Black
        Me._key_16.Location = New System.Drawing.Point(434, 14)
        Me._key_16.Name = "_key_16"
        Me._key_16.Size = New System.Drawing.Size(40, 158)
        Me._key_16.TabIndex = 9
        Me._key_16.Text = "/"
        Me._key_16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_16.UseVisualStyleBackColor = False
        '
        '_key_14
        '
        Me._key_14.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_14.BackColor = System.Drawing.Color.White
        Me._key_14.ForeColor = System.Drawing.Color.Black
        Me._key_14.Location = New System.Drawing.Point(396, 14)
        Me._key_14.Name = "_key_14"
        Me._key_14.Size = New System.Drawing.Size(40, 158)
        Me._key_14.TabIndex = 8
        Me._key_14.Text = "."
        Me._key_14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_14.UseVisualStyleBackColor = False
        '
        '_key_12
        '
        Me._key_12.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_12.BackColor = System.Drawing.Color.White
        Me._key_12.ForeColor = System.Drawing.Color.Black
        Me._key_12.Location = New System.Drawing.Point(358, 14)
        Me._key_12.Name = "_key_12"
        Me._key_12.Size = New System.Drawing.Size(39, 158)
        Me._key_12.TabIndex = 7
        Me._key_12.Text = ","
        Me._key_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_12.UseVisualStyleBackColor = False
        '
        '_key_11
        '
        Me._key_11.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_11.BackColor = System.Drawing.Color.White
        Me._key_11.ForeColor = System.Drawing.Color.Black
        Me._key_11.Location = New System.Drawing.Point(319, 14)
        Me._key_11.Name = "_key_11"
        Me._key_11.Size = New System.Drawing.Size(40, 158)
        Me._key_11.TabIndex = 6
        Me._key_11.Text = "M"
        Me._key_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_11.UseVisualStyleBackColor = False
        '
        '_key_9
        '
        Me._key_9.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_9.BackColor = System.Drawing.Color.White
        Me._key_9.ForeColor = System.Drawing.Color.Black
        Me._key_9.Location = New System.Drawing.Point(281, 14)
        Me._key_9.Name = "_key_9"
        Me._key_9.Size = New System.Drawing.Size(39, 158)
        Me._key_9.TabIndex = 5
        Me._key_9.Text = "N"
        Me._key_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_9.UseVisualStyleBackColor = False
        '
        '_key_7
        '
        Me._key_7.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_7.BackColor = System.Drawing.Color.White
        Me._key_7.ForeColor = System.Drawing.Color.Black
        Me._key_7.Location = New System.Drawing.Point(242, 14)
        Me._key_7.Name = "_key_7"
        Me._key_7.Size = New System.Drawing.Size(40, 158)
        Me._key_7.TabIndex = 4
        Me._key_7.Text = "B"
        Me._key_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_7.UseVisualStyleBackColor = False
        '
        '_key_5
        '
        Me._key_5.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_5.BackColor = System.Drawing.Color.White
        Me._key_5.ForeColor = System.Drawing.Color.Black
        Me._key_5.Location = New System.Drawing.Point(204, 14)
        Me._key_5.Name = "_key_5"
        Me._key_5.Size = New System.Drawing.Size(40, 158)
        Me._key_5.TabIndex = 3
        Me._key_5.Text = "V"
        Me._key_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_5.UseVisualStyleBackColor = False
        '
        '_key_4
        '
        Me._key_4.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_4.BackColor = System.Drawing.Color.White
        Me._key_4.ForeColor = System.Drawing.Color.Black
        Me._key_4.Location = New System.Drawing.Point(166, 14)
        Me._key_4.Name = "_key_4"
        Me._key_4.Size = New System.Drawing.Size(39, 158)
        Me._key_4.TabIndex = 2
        Me._key_4.Text = "C"
        Me._key_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_4.UseVisualStyleBackColor = False
        '
        '_key_2
        '
        Me._key_2.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_2.BackColor = System.Drawing.Color.White
        Me._key_2.ForeColor = System.Drawing.Color.Black
        Me._key_2.Location = New System.Drawing.Point(127, 14)
        Me._key_2.Name = "_key_2"
        Me._key_2.Size = New System.Drawing.Size(40, 158)
        Me._key_2.TabIndex = 1
        Me._key_2.Text = "X"
        Me._key_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_2.UseVisualStyleBackColor = False
        '
        '_key_0
        '
        Me._key_0.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_0.BackColor = System.Drawing.Color.White
        Me._key_0.ForeColor = System.Drawing.Color.Black
        Me._key_0.Location = New System.Drawing.Point(89, 14)
        Me._key_0.Name = "_key_0"
        Me._key_0.Size = New System.Drawing.Size(39, 158)
        Me._key_0.TabIndex = 0
        Me._key_0.Text = "Z"
        Me._key_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_0.UseVisualStyleBackColor = False
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Location = New System.Drawing.Point(19, 14)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(55, 17)
        Me.lblVolume.TabIndex = 18
        Me.lblVolume.Text = "Volume"
        '
        'mnuChannel0
        '
        Me.mnuChannel0.Index = 0
        Me.mnuChannel0.Text = "1"
        '
        'mnuChannel1
        '
        Me.mnuChannel1.Index = 1
        Me.mnuChannel1.Text = "2"
        '
        'mnuChannel2
        '
        Me.mnuChannel2.Index = 2
        Me.mnuChannel2.Text = "3"
        '
        'mnuChannel3
        '
        Me.mnuChannel3.Index = 3
        Me.mnuChannel3.Text = "4"
        '
        'mnuChannel4
        '
        Me.mnuChannel4.Index = 4
        Me.mnuChannel4.Text = "5"
        '
        'mnuChannel5
        '
        Me.mnuChannel5.Index = 5
        Me.mnuChannel5.Text = "6"
        '
        'mnuChannel6
        '
        Me.mnuChannel6.Index = 6
        Me.mnuChannel6.Text = "7"
        '
        'mnuChannel7
        '
        Me.mnuChannel7.Index = 7
        Me.mnuChannel7.Text = "8"
        '
        'mnuChannel8
        '
        Me.mnuChannel8.Index = 8
        Me.mnuChannel8.Text = "9"
        '
        'mnuChannel9
        '
        Me.mnuChannel9.Index = 9
        Me.mnuChannel9.Text = "10"
        '
        'mnuChannel10
        '
        Me.mnuChannel10.Index = 10
        Me.mnuChannel10.Text = "11"
        '
        'mnuChannel11
        '
        Me.mnuChannel11.Index = 11
        Me.mnuChannel11.Text = "12"
        '
        'mnuChannel12
        '
        Me.mnuChannel12.Index = 12
        Me.mnuChannel12.Text = "13"
        '
        'mnuChannel13
        '
        Me.mnuChannel13.Index = 13
        Me.mnuChannel13.Text = "14"
        '
        'mnuChannel14
        '
        Me.mnuChannel14.Index = 14
        Me.mnuChannel14.Text = "15"
        '
        'mnuChannel15
        '
        Me.mnuChannel15.Index = 15
        Me.mnuChannel15.Text = "16"
        '
        'mnuDevice0
        '
        Me.mnuDevice0.Index = 0
        Me.mnuDevice0.Text = ""
        '
        'mnuDevice1
        '
        Me.mnuDevice1.Enabled = False
        Me.mnuDevice1.Index = 1
        Me.mnuDevice1.Text = ""
        Me.mnuDevice1.Visible = False
        '
        'mnuDevice2
        '
        Me.mnuDevice2.Enabled = False
        Me.mnuDevice2.Index = 2
        Me.mnuDevice2.Text = ""
        Me.mnuDevice2.Visible = False
        '
        'mnuDevice3
        '
        Me.mnuDevice3.Enabled = False
        Me.mnuDevice3.Index = 3
        Me.mnuDevice3.Text = ""
        Me.mnuDevice3.Visible = False
        '
        'mnuDevice4
        '
        Me.mnuDevice4.Enabled = False
        Me.mnuDevice4.Index = 4
        Me.mnuDevice4.Text = ""
        Me.mnuDevice4.Visible = False
        '
        'mnuDevice5
        '
        Me.mnuDevice5.Enabled = False
        Me.mnuDevice5.Index = 5
        Me.mnuDevice5.Text = ""
        Me.mnuDevice5.Visible = False
        '
        'mnuDevice6
        '
        Me.mnuDevice6.Enabled = False
        Me.mnuDevice6.Index = 6
        Me.mnuDevice6.Text = ""
        Me.mnuDevice6.Visible = False
        '
        'mnuDevice7
        '
        Me.mnuDevice7.Enabled = False
        Me.mnuDevice7.Index = 7
        Me.mnuDevice7.Text = ""
        Me.mnuDevice7.Visible = False
        '
        'mnuDevice8
        '
        Me.mnuDevice8.Enabled = False
        Me.mnuDevice8.Index = 8
        Me.mnuDevice8.Text = ""
        Me.mnuDevice8.Visible = False
        '
        'mnuDevice9
        '
        Me.mnuDevice9.Enabled = False
        Me.mnuDevice9.Index = 9
        Me.mnuDevice9.Text = ""
        Me.mnuDevice9.Visible = False
        '
        'mnuDevice10
        '
        Me.mnuDevice10.Enabled = False
        Me.mnuDevice10.Index = 10
        Me.mnuDevice10.Text = ""
        Me.mnuDevice10.Visible = False
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuDevice, Me.mnuChannel, Me.mnuBaseNote})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOpen})
        Me.mnuFile.Text = "Midi &File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Index = 0
        Me.mnuOpen.Text = "&Open"
        '
        'mnuDevice
        '
        Me.mnuDevice.Index = 1
        Me.mnuDevice.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDevice0, Me.mnuDevice1, Me.mnuDevice2, Me.mnuDevice3, Me.mnuDevice4, Me.mnuDevice5, Me.mnuDevice6, Me.mnuDevice7, Me.mnuDevice8, Me.mnuDevice9, Me.mnuDevice10})
        Me.mnuDevice.Text = "Midi &Device"
        '
        'mnuChannel
        '
        Me.mnuChannel.Index = 2
        Me.mnuChannel.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuChannel0, Me.mnuChannel1, Me.mnuChannel2, Me.mnuChannel3, Me.mnuChannel4, Me.mnuChannel5, Me.mnuChannel6, Me.mnuChannel7, Me.mnuChannel8, Me.mnuChannel9, Me.mnuChannel10, Me.mnuChannel11, Me.mnuChannel12, Me.mnuChannel13, Me.mnuChannel14, Me.mnuChannel15})
        Me.mnuChannel.Text = "&Channel"
        '
        'mnuBaseNote
        '
        Me.mnuBaseNote.Index = 3
        Me.mnuBaseNote.Text = "&Base Note"
        '
        'lblSeqFast
        '
        Me.lblSeqFast.Location = New System.Drawing.Point(854, 52)
        Me.lblSeqFast.Name = "lblSeqFast"
        Me.lblSeqFast.Size = New System.Drawing.Size(41, 26)
        Me.lblSeqFast.TabIndex = 27
        Me.lblSeqFast.Text = "Fast"
        Me.lblSeqFast.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSeqNormal
        '
        Me.lblSeqNormal.Location = New System.Drawing.Point(746, 52)
        Me.lblSeqNormal.Name = "lblSeqNormal"
        Me.lblSeqNormal.Size = New System.Drawing.Size(60, 37)
        Me.lblSeqNormal.TabIndex = 26
        Me.lblSeqNormal.Text = "Normal Speed"
        Me.lblSeqNormal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSeqSlow
        '
        Me.lblSeqSlow.Location = New System.Drawing.Point(654, 52)
        Me.lblSeqSlow.Name = "lblSeqSlow"
        Me.lblSeqSlow.Size = New System.Drawing.Size(41, 26)
        Me.lblSeqSlow.TabIndex = 25
        Me.lblSeqSlow.Text = "Slow"
        '
        'tbSpeed
        '
        Me.tbSpeed.Location = New System.Drawing.Point(658, 14)
        Me.tbSpeed.Maximum = 9
        Me.tbSpeed.Minimum = -9
        Me.tbSpeed.Name = "tbSpeed"
        Me.tbSpeed.Size = New System.Drawing.Size(237, 56)
        Me.tbSpeed.TabIndex = 24
        '
        'btnRemoveSilence
        '
        Me.btnRemoveSilence.Location = New System.Drawing.Point(378, 14)
        Me.btnRemoveSilence.Name = "btnRemoveSilence"
        Me.btnRemoveSilence.Size = New System.Drawing.Size(172, 29)
        Me.btnRemoveSilence.TabIndex = 23
        Me.btnRemoveSilence.Text = "Remove Silence"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(257, 14)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(114, 29)
        Me.btnPlay.TabIndex = 22
        Me.btnPlay.Text = "Play"
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(136, 14)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(114, 29)
        Me.btnStop.TabIndex = 21
        Me.btnStop.Text = "Stop"
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(14, 14)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(114, 29)
        Me.btnRecord.TabIndex = 20
        Me.btnRecord.Text = "Record"
        '
        'gbxInstrument
        '
        Me.gbxInstrument.Controls.Add(Me.Label3)
        Me.gbxInstrument.Controls.Add(Me.TrackBar2)
        Me.gbxInstrument.Controls.Add(Me.Label2)
        Me.gbxInstrument.Controls.Add(Me.TrackBar1)
        Me.gbxInstrument.Controls.Add(Me.ComboBox1)
        Me.gbxInstrument.Controls.Add(Me.Button2)
        Me.gbxInstrument.Controls.Add(Me.Button1)
        Me.gbxInstrument.Controls.Add(Me.tbBankMSB)
        Me.gbxInstrument.Controls.Add(Me.tbInstrument)
        Me.gbxInstrument.Controls.Add(Me.lblBankMSB)
        Me.gbxInstrument.Controls.Add(Me.lblInstrument)
        Me.gbxInstrument.Location = New System.Drawing.Point(488, 14)
        Me.gbxInstrument.Name = "gbxInstrument"
        Me.gbxInstrument.Size = New System.Drawing.Size(448, 257)
        Me.gbxInstrument.TabIndex = 22
        Me.gbxInstrument.TabStop = False
        Me.gbxInstrument.Text = "MIDI Instrument"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Pitch Bend: "
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(90, 198)
        Me.TrackBar2.Maximum = 16383
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(348, 56)
        Me.TrackBar2.TabIndex = 10
        Me.TrackBar2.Value = 8192
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Panning: "
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(90, 151)
        Me.TrackBar1.Maximum = 127
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(348, 56)
        Me.TrackBar1.TabIndex = 7
        Me.TrackBar1.Value = 63
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Items.AddRange(New Object() {"(none)", "A Major 7th Chord ", "A Minor 7th Chord", "A Dominant 7th Chord", "An Augmented 7th Chord "})
        Me.ComboBox1.Location = New System.Drawing.Point(245, 114)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(181, 24)
        Me.ComboBox1.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(127, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 41)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Chord"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(16, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Note"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbBankMSB
        '
        Me.tbBankMSB.LargeChange = 2
        Me.tbBankMSB.Location = New System.Drawing.Point(90, 66)
        Me.tbBankMSB.Maximum = 8
        Me.tbBankMSB.Name = "tbBankMSB"
        Me.tbBankMSB.Size = New System.Drawing.Size(348, 56)
        Me.tbBankMSB.TabIndex = 3
        '
        'tbInstrument
        '
        Me.tbInstrument.Location = New System.Drawing.Point(90, 22)
        Me.tbInstrument.Maximum = 127
        Me.tbInstrument.Name = "tbInstrument"
        Me.tbInstrument.Size = New System.Drawing.Size(348, 56)
        Me.tbInstrument.TabIndex = 2
        '
        'lblBankMSB
        '
        Me.lblBankMSB.AutoSize = True
        Me.lblBankMSB.Location = New System.Drawing.Point(12, 74)
        Me.lblBankMSB.Name = "lblBankMSB"
        Me.lblBankMSB.Size = New System.Drawing.Size(77, 17)
        Me.lblBankMSB.TabIndex = 1
        Me.lblBankMSB.Text = "Bank MSB:"
        '
        'lblInstrument
        '
        Me.lblInstrument.AutoSize = True
        Me.lblInstrument.Location = New System.Drawing.Point(12, 29)
        Me.lblInstrument.Name = "lblInstrument"
        Me.lblInstrument.Size = New System.Drawing.Size(78, 17)
        Me.lblInstrument.TabIndex = 0
        Me.lblInstrument.Text = "Instrument:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(364, 190)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 27)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "System Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tmrSequencer
        '
        '
        'tclMidiFunction
        '
        Me.tclMidiFunction.Controls.Add(Me.tabSequencer)
        Me.tclMidiFunction.Controls.Add(Me.tabWhiteboard)
        Me.tclMidiFunction.Controls.Add(Me.tabDrumMachine)
        Me.tclMidiFunction.Location = New System.Drawing.Point(14, 268)
        Me.tclMidiFunction.Name = "tclMidiFunction"
        Me.tclMidiFunction.SelectedIndex = 0
        Me.tclMidiFunction.Size = New System.Drawing.Size(922, 400)
        Me.tclMidiFunction.TabIndex = 23
        '
        'tabSequencer
        '
        Me.tabSequencer.Controls.Add(Me.Label6)
        Me.tabSequencer.Controls.Add(Me.Label5)
        Me.tabSequencer.Controls.Add(Me.Label4)
        Me.tabSequencer.Controls.Add(Me.TrackBar3)
        Me.tabSequencer.Controls.Add(Me.Button5)
        Me.tabSequencer.Controls.Add(Me.Button4)
        Me.tabSequencer.Controls.Add(Me.lblSeqFast)
        Me.tabSequencer.Controls.Add(Me.btnRecord)
        Me.tabSequencer.Controls.Add(Me.lblSeqNormal)
        Me.tabSequencer.Controls.Add(Me.btnStop)
        Me.tabSequencer.Controls.Add(Me.lblSeqSlow)
        Me.tabSequencer.Controls.Add(Me.btnPlay)
        Me.tabSequencer.Controls.Add(Me.tbSpeed)
        Me.tabSequencer.Controls.Add(Me.btnRemoveSilence)
        Me.tabSequencer.Location = New System.Drawing.Point(4, 25)
        Me.tabSequencer.Name = "tabSequencer"
        Me.tabSequencer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSequencer.Size = New System.Drawing.Size(914, 371)
        Me.tabSequencer.TabIndex = 0
        Me.tabSequencer.Text = "MIDI Sequencer"
        Me.tabSequencer.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(848, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 37)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "High Pitch"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(646, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 37)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Low Pitch"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(746, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 37)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Normal Pitch"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(657, 82)
        Me.TrackBar3.Maximum = 60
        Me.TrackBar3.Minimum = -60
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(239, 56)
        Me.TrackBar3.TabIndex = 30
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(138, 50)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 28)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Loop"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(14, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(114, 28)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Append"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'tabWhiteboard
        '
        Me.tabWhiteboard.Controls.Add(Me.gbxXAxis)
        Me.tabWhiteboard.Controls.Add(Me.picWhiteboard)
        Me.tabWhiteboard.Controls.Add(Me.gbxYAxis)
        Me.tabWhiteboard.Location = New System.Drawing.Point(4, 25)
        Me.tabWhiteboard.Name = "tabWhiteboard"
        Me.tabWhiteboard.Size = New System.Drawing.Size(914, 371)
        Me.tabWhiteboard.TabIndex = 2
        Me.tabWhiteboard.Text = "MIDI Whiteboard"
        Me.tabWhiteboard.UseVisualStyleBackColor = True
        '
        'gbxXAxis
        '
        Me.gbxXAxis.Controls.Add(Me.lblXValue)
        Me.gbxXAxis.Controls.Add(Me.cboXTitle)
        Me.gbxXAxis.Controls.Add(Me.lblXTitle)
        Me.gbxXAxis.Controls.Add(Me.lblXCaption)
        Me.gbxXAxis.Location = New System.Drawing.Point(389, 14)
        Me.gbxXAxis.Name = "gbxXAxis"
        Me.gbxXAxis.Size = New System.Drawing.Size(174, 92)
        Me.gbxXAxis.TabIndex = 40
        Me.gbxXAxis.TabStop = False
        Me.gbxXAxis.Text = "X - axis"
        '
        'lblXValue
        '
        Me.lblXValue.Location = New System.Drawing.Point(58, 28)
        Me.lblXValue.Name = "lblXValue"
        Me.lblXValue.Size = New System.Drawing.Size(57, 18)
        Me.lblXValue.TabIndex = 38
        '
        'cboXTitle
        '
        Me.cboXTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboXTitle.Items.AddRange(New Object() {"(none)", "instrument", "velocity", "pitch", "stereo position", "pitch bend"})
        Me.cboXTitle.Location = New System.Drawing.Point(48, 55)
        Me.cboXTitle.Name = "cboXTitle"
        Me.cboXTitle.Size = New System.Drawing.Size(115, 24)
        Me.cboXTitle.TabIndex = 37
        '
        'lblXTitle
        '
        Me.lblXTitle.Location = New System.Drawing.Point(10, 59)
        Me.lblXTitle.Name = "lblXTitle"
        Me.lblXTitle.Size = New System.Drawing.Size(38, 18)
        Me.lblXTitle.TabIndex = 36
        Me.lblXTitle.Text = "Title:"
        '
        'lblXCaption
        '
        Me.lblXCaption.Location = New System.Drawing.Point(10, 28)
        Me.lblXCaption.Name = "lblXCaption"
        Me.lblXCaption.Size = New System.Drawing.Size(48, 18)
        Me.lblXCaption.TabIndex = 0
        Me.lblXCaption.Text = "Value:"
        '
        'picWhiteboard
        '
        Me.picWhiteboard.BackColor = System.Drawing.Color.White
        Me.picWhiteboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picWhiteboard.Location = New System.Drawing.Point(14, 14)
        Me.picWhiteboard.Name = "picWhiteboard"
        Me.picWhiteboard.Size = New System.Drawing.Size(360, 346)
        Me.picWhiteboard.TabIndex = 39
        Me.picWhiteboard.TabStop = False
        '
        'gbxYAxis
        '
        Me.gbxYAxis.Controls.Add(Me.cboYTitle)
        Me.gbxYAxis.Controls.Add(Me.lblYTitle)
        Me.gbxYAxis.Controls.Add(Me.lblYCaption)
        Me.gbxYAxis.Controls.Add(Me.lblYValue)
        Me.gbxYAxis.Location = New System.Drawing.Point(389, 120)
        Me.gbxYAxis.Name = "gbxYAxis"
        Me.gbxYAxis.Size = New System.Drawing.Size(174, 92)
        Me.gbxYAxis.TabIndex = 41
        Me.gbxYAxis.TabStop = False
        Me.gbxYAxis.Text = "Y - axis"
        '
        'cboYTitle
        '
        Me.cboYTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYTitle.Items.AddRange(New Object() {"(none)", "instrument", "velocity", "pitch", "stereo position", "pitch bend"})
        Me.cboYTitle.Location = New System.Drawing.Point(48, 55)
        Me.cboYTitle.Name = "cboYTitle"
        Me.cboYTitle.Size = New System.Drawing.Size(115, 24)
        Me.cboYTitle.TabIndex = 37
        '
        'lblYTitle
        '
        Me.lblYTitle.Location = New System.Drawing.Point(10, 59)
        Me.lblYTitle.Name = "lblYTitle"
        Me.lblYTitle.Size = New System.Drawing.Size(38, 18)
        Me.lblYTitle.TabIndex = 36
        Me.lblYTitle.Text = "Title:"
        '
        'lblYCaption
        '
        Me.lblYCaption.Location = New System.Drawing.Point(10, 28)
        Me.lblYCaption.Name = "lblYCaption"
        Me.lblYCaption.Size = New System.Drawing.Size(48, 18)
        Me.lblYCaption.TabIndex = 0
        Me.lblYCaption.Text = "Value:"
        '
        'lblYValue
        '
        Me.lblYValue.Location = New System.Drawing.Point(58, 28)
        Me.lblYValue.Name = "lblYValue"
        Me.lblYValue.Size = New System.Drawing.Size(57, 18)
        Me.lblYValue.TabIndex = 39
        '
        'tabDrumMachine
        '
        Me.tabDrumMachine.Controls.Add(Me.Button14)
        Me.tabDrumMachine.Controls.Add(Me.Button13)
        Me.tabDrumMachine.Controls.Add(Me.Label9)
        Me.tabDrumMachine.Controls.Add(Me.Label8)
        Me.tabDrumMachine.Controls.Add(Me.Label7)
        Me.tabDrumMachine.Controls.Add(Me.TrackBar4)
        Me.tabDrumMachine.Controls.Add(Me.Button12)
        Me.tabDrumMachine.Controls.Add(Me.Button11)
        Me.tabDrumMachine.Controls.Add(Me.ComboBox9)
        Me.tabDrumMachine.Controls.Add(Me.ComboBox8)
        Me.tabDrumMachine.Controls.Add(Me.ComboBox7)
        Me.tabDrumMachine.Controls.Add(Me.ComboBox6)
        Me.tabDrumMachine.Controls.Add(Me.ComboBox5)
        Me.tabDrumMachine.Controls.Add(Me.ComboBox4)
        Me.tabDrumMachine.Controls.Add(Me.Button10)
        Me.tabDrumMachine.Controls.Add(Me.ComboBox3)
        Me.tabDrumMachine.Controls.Add(Me.ComboBox2)
        Me.tabDrumMachine.Controls.Add(Me.Button9)
        Me.tabDrumMachine.Controls.Add(Me.Button8)
        Me.tabDrumMachine.Controls.Add(Me.Button7)
        Me.tabDrumMachine.Controls.Add(Me.Button6)
        Me.tabDrumMachine.Controls.Add(Me.btnDrumStop)
        Me.tabDrumMachine.Controls.Add(Me.btnDrumStart)
        Me.tabDrumMachine.Controls.Add(Me.picDrum)
        Me.tabDrumMachine.Location = New System.Drawing.Point(4, 25)
        Me.tabDrumMachine.Name = "tabDrumMachine"
        Me.tabDrumMachine.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDrumMachine.Size = New System.Drawing.Size(914, 371)
        Me.tabDrumMachine.TabIndex = 1
        Me.tabDrumMachine.Text = "Drum Machine"
        Me.tabDrumMachine.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(343, 339)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 23)
        Me.Button7.TabIndex = 29
        Me.Button7.Text = "- Drum"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(246, 339)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(95, 23)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "+ Drum"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btnDrumStop
        '
        Me.btnDrumStop.Enabled = False
        Me.btnDrumStop.Location = New System.Drawing.Point(126, 336)
        Me.btnDrumStop.Name = "btnDrumStop"
        Me.btnDrumStop.Size = New System.Drawing.Size(114, 29)
        Me.btnDrumStop.TabIndex = 27
        Me.btnDrumStop.Text = "Stop Drum"
        '
        'btnDrumStart
        '
        Me.btnDrumStart.Location = New System.Drawing.Point(6, 336)
        Me.btnDrumStart.Name = "btnDrumStart"
        Me.btnDrumStart.Size = New System.Drawing.Size(114, 29)
        Me.btnDrumStart.TabIndex = 26
        Me.btnDrumStart.Text = "Start Drum"
        '
        'picDrum
        '
        Me.picDrum.BackColor = System.Drawing.SystemColors.Window
        Me.picDrum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDrum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picDrum.Location = New System.Drawing.Point(14, 14)
        Me.picDrum.Name = "picDrum"
        Me.picDrum.Size = New System.Drawing.Size(360, 46)
        Me.picDrum.TabIndex = 25
        Me.picDrum.TabStop = False
        '
        'tmrDrumPlayback
        '
        Me.tmrDrumPlayback.Interval = 250
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 672)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Label1"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(445, 339)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(93, 23)
        Me.Button8.TabIndex = 30
        Me.Button8.Text = "+ Cell"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(544, 339)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(99, 23)
        Me.Button9.TabIndex = 31
        Me.Button9.Text = "- Cell"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"35 Acoustic Bass Drum", "36 Bass Drum 1", "37 Side Stick", "38 Acoustic Snare", "39 Hand Clap", "40 Electric Snare ", "41 Low Floor Tom", "42 Closed Hi-Hat", "43 High Floor Tom", "44 Pedal Hi-Hat  ", "45 Low Tom ", "46 Open Hi-Hat ", "47 Low-Mid Tom ", "48 Hi-Mid Tom ", "49 Crash Cymbal 1 ", "50 High Tom ", "51 Ride Cymbal 1 ", "52 Chinese Cymbal ", "53 Ride Bell ", "54 Tambourine ", "55 Splash Cymbal ", "56 Cowbell ", "57 Crash Cymbal 2 ", "58 Vibraslap ", "59 Ride Cymbal 2 ", "60 Hi Bongo", "61 Low Bongo", "62 Mute Hi Conga", "63 Open Hi Conga ", "64 Low Conga ", "65 High Timbale ", "66 Low Timbale  ", "67 High Agogo ", "68 Low Agogo ", "69 Cabasa ", "70 Maracas ", "71 Short Whistle ", "72 Long Whistle ", "73 Short Guiro ", "74 Long Guiro ", "75 Claves ", "76 Hi Wood Block ", "77 Low Wood Block ", "78 Mute Cuica ", "79 Open Cuica ", "80 Mute Triangle ", "81 Open Triangle "})
        Me.ComboBox2.Location = New System.Drawing.Point(757, 14)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(150, 24)
        Me.ComboBox2.TabIndex = 32
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"35 Acoustic Bass Drum", "36 Bass Drum 1", "37 Side Stick", "38 Acoustic Snare", "39 Hand Clap", "40 Electric Snare ", "41 Low Floor Tom", "42 Closed Hi-Hat", "43 High Floor Tom", "44 Pedal Hi-Hat  ", "45 Low Tom ", "46 Open Hi-Hat ", "47 Low-Mid Tom ", "48 Hi-Mid Tom ", "49 Crash Cymbal 1 ", "50 High Tom ", "51 Ride Cymbal 1 ", "52 Chinese Cymbal ", "53 Ride Bell ", "54 Tambourine ", "55 Splash Cymbal ", "56 Cowbell ", "57 Crash Cymbal 2 ", "58 Vibraslap ", "59 Ride Cymbal 2 ", "60 Hi Bongo", "61 Low Bongo", "62 Mute Hi Conga", "63 Open Hi Conga ", "64 Low Conga ", "65 High Timbale ", "66 Low Timbale  ", "67 High Agogo ", "68 Low Agogo ", "69 Cabasa ", "70 Maracas ", "71 Short Whistle ", "72 Long Whistle ", "73 Short Guiro ", "74 Long Guiro ", "75 Claves ", "76 Hi Wood Block ", "77 Low Wood Block ", "78 Mute Cuica ", "79 Open Cuica ", "80 Mute Triangle ", "81 Open Triangle "})
        Me.ComboBox3.Location = New System.Drawing.Point(757, 45)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(150, 24)
        Me.ComboBox3.TabIndex = 33
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(649, 339)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 34
        Me.Button10.Text = "Random"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"35 Acoustic Bass Drum", "36 Bass Drum 1", "37 Side Stick", "38 Acoustic Snare", "39 Hand Clap", "40 Electric Snare ", "41 Low Floor Tom", "42 Closed Hi-Hat", "43 High Floor Tom", "44 Pedal Hi-Hat  ", "45 Low Tom ", "46 Open Hi-Hat ", "47 Low-Mid Tom ", "48 Hi-Mid Tom ", "49 Crash Cymbal 1 ", "50 High Tom ", "51 Ride Cymbal 1 ", "52 Chinese Cymbal ", "53 Ride Bell ", "54 Tambourine ", "55 Splash Cymbal ", "56 Cowbell ", "57 Crash Cymbal 2 ", "58 Vibraslap ", "59 Ride Cymbal 2 ", "60 Hi Bongo", "61 Low Bongo", "62 Mute Hi Conga", "63 Open Hi Conga ", "64 Low Conga ", "65 High Timbale ", "66 Low Timbale  ", "67 High Agogo ", "68 Low Agogo ", "69 Cabasa ", "70 Maracas ", "71 Short Whistle ", "72 Long Whistle ", "73 Short Guiro ", "74 Long Guiro ", "75 Claves ", "76 Hi Wood Block ", "77 Low Wood Block ", "78 Mute Cuica ", "79 Open Cuica ", "80 Mute Triangle ", "81 Open Triangle "})
        Me.ComboBox4.Location = New System.Drawing.Point(757, 75)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(150, 24)
        Me.ComboBox4.TabIndex = 35
        Me.ComboBox4.Visible = False
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"35 Acoustic Bass Drum", "36 Bass Drum 1", "37 Side Stick", "38 Acoustic Snare", "39 Hand Clap", "40 Electric Snare ", "41 Low Floor Tom", "42 Closed Hi-Hat", "43 High Floor Tom", "44 Pedal Hi-Hat  ", "45 Low Tom ", "46 Open Hi-Hat ", "47 Low-Mid Tom ", "48 Hi-Mid Tom ", "49 Crash Cymbal 1 ", "50 High Tom ", "51 Ride Cymbal 1 ", "52 Chinese Cymbal ", "53 Ride Bell ", "54 Tambourine ", "55 Splash Cymbal ", "56 Cowbell ", "57 Crash Cymbal 2 ", "58 Vibraslap ", "59 Ride Cymbal 2 ", "60 Hi Bongo", "61 Low Bongo", "62 Mute Hi Conga", "63 Open Hi Conga ", "64 Low Conga ", "65 High Timbale ", "66 Low Timbale  ", "67 High Agogo ", "68 Low Agogo ", "69 Cabasa ", "70 Maracas ", "71 Short Whistle ", "72 Long Whistle ", "73 Short Guiro ", "74 Long Guiro ", "75 Claves ", "76 Hi Wood Block ", "77 Low Wood Block ", "78 Mute Cuica ", "79 Open Cuica ", "80 Mute Triangle ", "81 Open Triangle "})
        Me.ComboBox5.Location = New System.Drawing.Point(757, 106)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(150, 24)
        Me.ComboBox5.TabIndex = 36
        Me.ComboBox5.Visible = False
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"35 Acoustic Bass Drum", "36 Bass Drum 1", "37 Side Stick", "38 Acoustic Snare", "39 Hand Clap", "40 Electric Snare ", "41 Low Floor Tom", "42 Closed Hi-Hat", "43 High Floor Tom", "44 Pedal Hi-Hat  ", "45 Low Tom ", "46 Open Hi-Hat ", "47 Low-Mid Tom ", "48 Hi-Mid Tom ", "49 Crash Cymbal 1 ", "50 High Tom ", "51 Ride Cymbal 1 ", "52 Chinese Cymbal ", "53 Ride Bell ", "54 Tambourine ", "55 Splash Cymbal ", "56 Cowbell ", "57 Crash Cymbal 2 ", "58 Vibraslap ", "59 Ride Cymbal 2 ", "60 Hi Bongo", "61 Low Bongo", "62 Mute Hi Conga", "63 Open Hi Conga ", "64 Low Conga ", "65 High Timbale ", "66 Low Timbale  ", "67 High Agogo ", "68 Low Agogo ", "69 Cabasa ", "70 Maracas ", "71 Short Whistle ", "72 Long Whistle ", "73 Short Guiro ", "74 Long Guiro ", "75 Claves ", "76 Hi Wood Block ", "77 Low Wood Block ", "78 Mute Cuica ", "79 Open Cuica ", "80 Mute Triangle ", "81 Open Triangle "})
        Me.ComboBox6.Location = New System.Drawing.Point(757, 137)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(150, 24)
        Me.ComboBox6.TabIndex = 37
        Me.ComboBox6.Visible = False
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"35 Acoustic Bass Drum", "36 Bass Drum 1", "37 Side Stick", "38 Acoustic Snare", "39 Hand Clap", "40 Electric Snare ", "41 Low Floor Tom", "42 Closed Hi-Hat", "43 High Floor Tom", "44 Pedal Hi-Hat  ", "45 Low Tom ", "46 Open Hi-Hat ", "47 Low-Mid Tom ", "48 Hi-Mid Tom ", "49 Crash Cymbal 1 ", "50 High Tom ", "51 Ride Cymbal 1 ", "52 Chinese Cymbal ", "53 Ride Bell ", "54 Tambourine ", "55 Splash Cymbal ", "56 Cowbell ", "57 Crash Cymbal 2 ", "58 Vibraslap ", "59 Ride Cymbal 2 ", "60 Hi Bongo", "61 Low Bongo", "62 Mute Hi Conga", "63 Open Hi Conga ", "64 Low Conga ", "65 High Timbale ", "66 Low Timbale  ", "67 High Agogo ", "68 Low Agogo ", "69 Cabasa ", "70 Maracas ", "71 Short Whistle ", "72 Long Whistle ", "73 Short Guiro ", "74 Long Guiro ", "75 Claves ", "76 Hi Wood Block ", "77 Low Wood Block ", "78 Mute Cuica ", "79 Open Cuica ", "80 Mute Triangle ", "81 Open Triangle "})
        Me.ComboBox7.Location = New System.Drawing.Point(757, 167)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(150, 24)
        Me.ComboBox7.TabIndex = 38
        Me.ComboBox7.Visible = False
        '
        'ComboBox8
        '
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"35 Acoustic Bass Drum", "36 Bass Drum 1", "37 Side Stick", "38 Acoustic Snare", "39 Hand Clap", "40 Electric Snare ", "41 Low Floor Tom", "42 Closed Hi-Hat", "43 High Floor Tom", "44 Pedal Hi-Hat  ", "45 Low Tom ", "46 Open Hi-Hat ", "47 Low-Mid Tom ", "48 Hi-Mid Tom ", "49 Crash Cymbal 1 ", "50 High Tom ", "51 Ride Cymbal 1 ", "52 Chinese Cymbal ", "53 Ride Bell ", "54 Tambourine ", "55 Splash Cymbal ", "56 Cowbell ", "57 Crash Cymbal 2 ", "58 Vibraslap ", "59 Ride Cymbal 2 ", "60 Hi Bongo", "61 Low Bongo", "62 Mute Hi Conga", "63 Open Hi Conga ", "64 Low Conga ", "65 High Timbale ", "66 Low Timbale  ", "67 High Agogo ", "68 Low Agogo ", "69 Cabasa ", "70 Maracas ", "71 Short Whistle ", "72 Long Whistle ", "73 Short Guiro ", "74 Long Guiro ", "75 Claves ", "76 Hi Wood Block ", "77 Low Wood Block ", "78 Mute Cuica ", "79 Open Cuica ", "80 Mute Triangle ", "81 Open Triangle "})
        Me.ComboBox8.Location = New System.Drawing.Point(757, 197)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(150, 24)
        Me.ComboBox8.TabIndex = 39
        Me.ComboBox8.Visible = False
        '
        'ComboBox9
        '
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Items.AddRange(New Object() {"35 Acoustic Bass Drum", "36 Bass Drum 1", "37 Side Stick", "38 Acoustic Snare", "39 Hand Clap", "40 Electric Snare ", "41 Low Floor Tom", "42 Closed Hi-Hat", "43 High Floor Tom", "44 Pedal Hi-Hat  ", "45 Low Tom ", "46 Open Hi-Hat ", "47 Low-Mid Tom ", "48 Hi-Mid Tom ", "49 Crash Cymbal 1 ", "50 High Tom ", "51 Ride Cymbal 1 ", "52 Chinese Cymbal ", "53 Ride Bell ", "54 Tambourine ", "55 Splash Cymbal ", "56 Cowbell ", "57 Crash Cymbal 2 ", "58 Vibraslap ", "59 Ride Cymbal 2 ", "60 Hi Bongo", "61 Low Bongo", "62 Mute Hi Conga", "63 Open Hi Conga ", "64 Low Conga ", "65 High Timbale ", "66 Low Timbale  ", "67 High Agogo ", "68 Low Agogo ", "69 Cabasa ", "70 Maracas ", "71 Short Whistle ", "72 Long Whistle ", "73 Short Guiro ", "74 Long Guiro ", "75 Claves ", "76 Hi Wood Block ", "77 Low Wood Block ", "78 Mute Cuica ", "79 Open Cuica ", "80 Mute Triangle ", "81 Open Triangle "})
        Me.ComboBox9.Location = New System.Drawing.Point(757, 227)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(150, 24)
        Me.ComboBox9.TabIndex = 40
        Me.ComboBox9.Visible = False
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(730, 339)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 41
        Me.Button11.Text = "Inverse"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(811, 339)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 42
        Me.Button12.Text = "Reverse"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'TrackBar4
        '
        Me.TrackBar4.LargeChange = 1
        Me.TrackBar4.Location = New System.Drawing.Point(6, 274)
        Me.TrackBar4.Maximum = 9
        Me.TrackBar4.Minimum = -9
        Me.TrackBar4.Name = "TrackBar4"
        Me.TrackBar4.Size = New System.Drawing.Size(368, 56)
        Me.TrackBar4.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(340, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 26)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Fast"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 26)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Slow"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(166, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 37)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Normal Speed"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(407, 286)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(108, 32)
        Me.Button13.TabIndex = 47
        Me.Button13.Text = "Reset"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(521, 286)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(146, 32)
        Me.Button14.TabIndex = 48
        Me.Button14.Text = "Load Drum File"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'frmMidiPiano
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(945, 715)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tclMidiFunction)
        Me.Controls.Add(Me.gbxInstrument)
        Me.Controls.Add(Me.vsbVolume)
        Me.Controls.Add(Me._key_15)
        Me.Controls.Add(Me._key_13)
        Me.Controls.Add(Me._key_10)
        Me.Controls.Add(Me._key_8)
        Me.Controls.Add(Me._key_6)
        Me.Controls.Add(Me._key_3)
        Me.Controls.Add(Me._key_1)
        Me.Controls.Add(Me._key_16)
        Me.Controls.Add(Me._key_14)
        Me.Controls.Add(Me._key_12)
        Me.Controls.Add(Me._key_11)
        Me.Controls.Add(Me._key_9)
        Me.Controls.Add(Me._key_7)
        Me.Controls.Add(Me._key_5)
        Me.Controls.Add(Me._key_4)
        Me.Controls.Add(Me._key_2)
        Me.Controls.Add(Me._key_0)
        Me.Controls.Add(Me.lblVolume)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(11, 49)
        Me.MaximizeBox = False
        Me.Menu = Me.mnuMain
        Me.Name = "frmMidiPiano"
        Me.Text = "VB Midi Piano"
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInstrument.ResumeLayout(False)
        Me.gbxInstrument.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBankMSB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbInstrument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tclMidiFunction.ResumeLayout(False)
        Me.tabSequencer.ResumeLayout(False)
        Me.tabSequencer.PerformLayout()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWhiteboard.ResumeLayout(False)
        Me.gbxXAxis.ResumeLayout(False)
        CType(Me.picWhiteboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxYAxis.ResumeLayout(False)
        Me.tabDrumMachine.ResumeLayout(False)
        Me.tabDrumMachine.PerformLayout()
        CType(Me.picDrum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Const INVALID_NOTE As Short = -1 ' Code for keyboard keys that we don't handle

    Dim numDevices As Integer ' number of midi output devices
    Dim curDevice As Integer ' current midi device
    Dim hmidi As Integer ' midi output handle
    Dim rc As Integer ' return code
    Dim midimsg As Integer ' midi output message buffer
    Dim channel As Short ' midi output channel
    Dim volume As Short ' midi volume
    Dim baseNote As Short ' the first note on our "piano"
    Dim playChord As Boolean
    Dim speed As Double = 1
    Dim drumSpeed As Double = 1

    Dim key As CheckBoxArray ' an array of check box for keys
    Dim chan As MenuItemArray ' an array of menu item for channel
    Dim device As MenuItemArray ' an array of menu item for midi device

    ' for recording
    Dim isRecording As Boolean ' recording status
    Dim currentTime As Double 'the current time in double
    Dim startTime As System.DateTime ' the time of starting recording
    Dim midiSequence As SequenceData ' store MIDI sequence
    Dim midiSequencetemp As SequenceData ' Store Midi Sequence Temp
    Dim currentIndex As Integer ' store the current playing sequence index
    Dim firstTime As Boolean ' Check First time running
    Dim loopingFlag As Boolean ' Looping Flag

    ' for MIDI whiteboard
    Dim lastMidiMessage As Integer = -1 ' previous MIDI message sent to the card
    Dim cbXselected As Short = 0 ' selection of the X axis
    Dim cbYselected As Short = 3 ' selection of the Y axis

    ' for drum machine
    Dim DRUM_INSTRUMENT As Short = 2 ' Predefined number of drum instruments
    Dim DRUM_SLOT As Short = 8 ' Predefined number of slots across the drum machine
    Dim drumSlot(DRUM_INSTRUMENT, DRUM_SLOT) As Boolean ' Slot On/Off for the drum machine
    Dim drumNumber(8) As Short ' The instrument for the drums
    Dim drumMessageSent(8) As Boolean ' True if a note-on midi message for a drum is sent

    ' For chord and note
    Dim chordNumber As Short = 0
    Dim chordFlag As Boolean  'Chord flag to check if the chord button is pressed. Index 0 is the chord flag and 1~4 are the major chords

    ' For Input text file
    Dim inputDrumCount As Short = 0
    Dim inputCellCount As Short = 0
    Dim inputDrumNumber(8) As Short

    'For slider check
    Const CHANNEL_NUMBER As Short = 15
    Dim instrumentSlider(CHANNEL_NUMBER) As Integer
    Dim panningSlider(CHANNEL_NUMBER) As Integer
    Dim pitchSlider(CHANNEL_NUMBER) As Integer
    Dim pitch(CHANNEL_NUMBER) As Integer







#Region "function initControlArray()"


    Public Sub initControlArray()
        ' initialize panningSlider
        Dim counter As Integer = 0

        For counter = 0 To CHANNEL_NUMBER
            panningSlider(counter) = 63
            pitchSlider(counter) = 8192
            pitch(counter) = 0
        Next

       

        ' initialize key checkboxarray (not generated by vb)
        key = New CheckBoxArray

        AddHandler _key_0.MouseDown, AddressOf key_MouseDown
        AddHandler _key_0.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_0)

        AddHandler _key_1.MouseDown, AddressOf key_MouseDown
        AddHandler _key_1.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_1)

        AddHandler _key_2.MouseDown, AddressOf key_MouseDown
        AddHandler _key_2.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_2)

        AddHandler _key_3.MouseDown, AddressOf key_MouseDown
        AddHandler _key_3.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_3)

        AddHandler _key_4.MouseDown, AddressOf key_MouseDown
        AddHandler _key_4.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_4)

        AddHandler _key_5.MouseDown, AddressOf key_MouseDown
        AddHandler _key_5.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_5)

        AddHandler _key_6.MouseDown, AddressOf key_MouseDown
        AddHandler _key_6.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_6)

        AddHandler _key_7.MouseDown, AddressOf key_MouseDown
        AddHandler _key_7.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_7)

        AddHandler _key_8.MouseDown, AddressOf key_MouseDown
        AddHandler _key_8.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_8)

        AddHandler _key_9.MouseDown, AddressOf key_MouseDown
        AddHandler _key_9.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_9)

        AddHandler _key_10.MouseDown, AddressOf key_MouseDown
        AddHandler _key_10.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_10)

        AddHandler _key_11.MouseDown, AddressOf key_MouseDown
        AddHandler _key_11.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_11)

        AddHandler _key_12.MouseDown, AddressOf key_MouseDown
        AddHandler _key_12.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_12)

        AddHandler _key_13.MouseDown, AddressOf key_MouseDown
        AddHandler _key_13.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_13)

        AddHandler _key_14.MouseDown, AddressOf key_MouseDown
        AddHandler _key_14.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_14)

        AddHandler _key_15.MouseDown, AddressOf key_MouseDown
        AddHandler _key_15.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_15)

        AddHandler _key_16.MouseDown, AddressOf key_MouseDown
        AddHandler _key_16.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_16)

        ' initialize channel menuitemarray (not generated by vb)
        chan = New MenuItemArray
        AddHandler mnuChannel0.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel0)

        AddHandler mnuChannel1.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel1)

        AddHandler mnuChannel2.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel2)

        AddHandler mnuChannel3.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel3)

        AddHandler mnuChannel4.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel4)

        AddHandler mnuChannel5.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel5)

        AddHandler mnuChannel6.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel6)

        AddHandler mnuChannel7.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel7)

        AddHandler mnuChannel8.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel8)

        AddHandler mnuChannel9.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel9)

        AddHandler mnuChannel10.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel10)

        AddHandler mnuChannel11.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel11)

        AddHandler mnuChannel12.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel12)

        AddHandler mnuChannel13.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel13)

        AddHandler mnuChannel14.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel14)

        AddHandler mnuChannel15.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel15)

        ' initialize device menuitemarray (not generated by vb)
        device = New MenuItemArray

        AddHandler mnuDevice0.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice0)

        AddHandler mnuDevice1.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice1)

        AddHandler mnuDevice2.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice2)

        AddHandler mnuDevice3.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice3)

        AddHandler mnuDevice4.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice4)

        AddHandler mnuDevice5.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice5)

        AddHandler mnuDevice6.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice6)

        AddHandler mnuDevice7.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice7)

        AddHandler mnuDevice8.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice8)

        AddHandler mnuDevice9.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice9)

        AddHandler mnuDevice10.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice10)

        ComboBox2.SelectedIndex = 60 - 35
        ComboBox3.SelectedIndex = 61 - 35
    End Sub
#End Region

    ' Set the value for the starting note of the piano
    Public Sub base_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBaseNote.Click
        Dim s As String
        Dim i As Short
        s = InputBox("Enter the new base note for the keyboard (0 - 111)", "Base note", CStr(baseNote))
        If IsNumeric(s) Then
            i = CShort(s)
            If i >= 0 And i < 112 Then
                baseNote = i
            End If
        End If
    End Sub

    ' Select the midi output channel
    Public Sub chan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim index As Integer
        index = CType(sender, System.Windows.Forms.MenuItem).Index
        chan(channel).Checked = False
        channel = index
        chan(channel).Checked = True

        'Change the slider value to the appropriate Value
        tbInstrument.Value = instrumentSlider(channel)
        TrackBar1.Value = panningSlider(channel)
        TrackBar2.Value = pitchSlider(channel)
        TrackBar3.Value = pitch(channel)
    End Sub

    ' Open the midi device selected in the menu. The menu index equals the midi device number + 1.
    Public Sub device_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim index As Integer
        index = CType(sender, System.Windows.Forms.MenuItem).Index
        device(curDevice + 1).Checked = False
        device(index).Checked = True
        curDevice = index - 1
        rc = midiOutClose(hmidi)
        rc = midiOutOpen(hmidi, curDevice, 0, 0, 0)
        If rc <> 0 Then
            MessageBox.Show("Couldn't open midi out, rc = " & rc, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' If user presses a keyboard key, start the corresponding midi note
    Private Sub frmMidiPiano_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = e.KeyCode

        StartNote(NoteFromKey(KeyCode))
    End Sub

    ' If user lifts a keyboard key, stop the corresponding midi note
    Private Sub frmMidiPiano_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Dim KeyCode As Short = e.KeyCode

        StopNote(NoteFromKey(KeyCode))
    End Sub

    Private Sub frmMidiPiano_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim caps As MIDIOUTCAPS

        Try
            initControlArray()
            ' Set firsttime variable
            firstTime = True

            ' Set the first device as midi mapper
            device(0).Text = "MIDI Mapper"
            device(0).Visible = True
            device(0).Enabled = True

            ' Get the rest of the midi devices
            numDevices = midiOutGetNumDevs()
            For i = 0 To (numDevices - 1)
                midiOutGetDevCaps(i, caps, Len(caps))
                device(i + 1).Text = caps.szPname
                device(i + 1).Visible = True
                device(i + 1).Enabled = True
            Next

            ' Select the MIDI Mapper as the default device
            device_Click(device.Item(0), New System.EventArgs)

            ' Set the default channel
            channel = 0
            chan(channel).Checked = True

            ' Set the base note
            baseNote = 60

            ' Set volume range
            volume = 127
            vsbVolume.Value = vsbVolume.Maximum - volume

            cboXTitle.SelectedIndex = cbXselected
            cboYTitle.SelectedIndex = cbYselected

            drumNumber(1) = 60
            drumNumber(2) = 61
            drumNumber(3) = 62
            drumNumber(4) = 63
            drumNumber(5) = 64
            drumNumber(6) = 65
            drumNumber(7) = 66
            drumNumber(8) = 67

            For counter As Integer = 1 To 8
                inputDrumNumber(counter) = drumNumber(counter)
            Next

            midiSequence = Nothing
            midiSequencetemp = Nothing
            isRecording = False
            loopingFlag = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMidiPiano_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ' Close current midi device
        rc = midiOutClose(hmidi)
    End Sub

    ' Start a note when user click on it
    Public Sub key_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim index As Integer
        index = CType(sender, System.Windows.Forms.CheckBox).Tag
        StartNote(index)
    End Sub

    ' Stop the note when user lifts the mouse button
    Public Sub key_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim index As Integer
        index = CType(sender, System.Windows.Forms.CheckBox).Tag
        StopNote(index)
    End Sub

    ' Press the button and send midi start event
    Private Sub StartNote(ByRef Index As Short)
        If Index = INVALID_NOTE Then
            Exit Sub
        End If
        If key(Index).CheckState = 1 Then
            Exit Sub
        End If

        key(Index).CheckState = System.Windows.Forms.CheckState.Checked
        midimsg = &H90 + ((baseNote + Index + pitch(channel)) * &H100) + (volume * &H10000) + channel
        sendMidiMsg(hmidi, midimsg)
        If chordFlag Then
            If chordNumber = 0 Then
                'When Combobox chooses (none)
            ElseIf chordNumber = 1 Then
                'When Combobox chooses A Major 7th Chord 
                midimsg = &H90 + ((baseNote + Index + 4 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H90 + ((baseNote + Index + 7 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H90 + ((baseNote + Index + 11 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            ElseIf chordNumber = 2 Then
                'When Combobox chooses A Minor 7th Chord
                midimsg = &H90 + ((baseNote + Index + 3 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H90 + ((baseNote + Index + 7 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H90 + ((baseNote + Index + 10 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            ElseIf chordNumber = 3 Then
                'When Combobox chooses A Dominant 7th Chord
                midimsg = &H90 + ((baseNote + Index + 4 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H90 + ((baseNote + Index + 7 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H90 + ((baseNote + Index + 10 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            Else
                'When Combobox chooses An Augmented 7th Chord
                midimsg = &H90 + ((baseNote + Index + 4 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H90 + ((baseNote + Index + 8 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H90 + ((baseNote + Index + 11 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            End If
        End If
    End Sub

    ' Raise the button and send midi stop event
    Private Sub StopNote(ByRef Index As Short)
        If Index = INVALID_NOTE Then
            Exit Sub
        End If

        key(Index).CheckState = System.Windows.Forms.CheckState.Unchecked
        midimsg = &H80 + ((baseNote + Index + pitch(channel)) * &H100) + (volume * &H10000) + channel
        sendMidiMsg(hmidi, midimsg)
        If chordFlag Then
            If chordNumber = 0 Then
                'When Combobox chooses (none)
            ElseIf chordNumber = 1 Then
                'When Combobox chooses A Major 7th Chord 
                midimsg = &H80 + ((baseNote + Index + 4 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H80 + ((baseNote + Index + 7 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H80 + ((baseNote + Index + 11 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            ElseIf chordNumber = 2 Then
                'When Combobox chooses A Minor 7th Chord
                midimsg = &H80 + ((baseNote + Index + 3 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H80 + ((baseNote + Index + 7 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H80 + ((baseNote + Index + 10 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            ElseIf chordNumber = 3 Then
                'When Combobox chooses A Dominant 7th Chord
                midimsg = &H80 + ((baseNote + Index + 4 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H80 + ((baseNote + Index + 7 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H80 + ((baseNote + Index + 10 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            Else
                'When Combobox chooses An Augmented 7th Chord
                midimsg = &H80 + ((baseNote + Index + 4 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H80 + ((baseNote + Index + 8 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H80 + ((baseNote + Index + 11 + pitch(channel)) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            End If
        End If
    End Sub

    ' Get the note corresponding to a keyboard key
    Private Function NoteFromKey(ByRef key As Short) As Short

        NoteFromKey = INVALID_NOTE

        Select Case key
            Case System.Windows.Forms.Keys.Z
                NoteFromKey = 0
            Case System.Windows.Forms.Keys.S
                NoteFromKey = 1
            Case System.Windows.Forms.Keys.X
                NoteFromKey = 2
            Case System.Windows.Forms.Keys.D
                NoteFromKey = 3
            Case System.Windows.Forms.Keys.C
                NoteFromKey = 4
            Case System.Windows.Forms.Keys.V
                NoteFromKey = 5
            Case System.Windows.Forms.Keys.G
                NoteFromKey = 6
            Case System.Windows.Forms.Keys.B
                NoteFromKey = 7
            Case System.Windows.Forms.Keys.H
                NoteFromKey = 8
            Case System.Windows.Forms.Keys.N
                NoteFromKey = 9
            Case System.Windows.Forms.Keys.J
                NoteFromKey = 10
            Case System.Windows.Forms.Keys.M
                NoteFromKey = 11
            Case 188 ' comma
                NoteFromKey = 12
            Case System.Windows.Forms.Keys.L
                NoteFromKey = 13
            Case 190 ' period
                NoteFromKey = 14
            Case 186 ' semicolon
                NoteFromKey = 15
            Case 191 ' forward slash
                NoteFromKey = 16
        End Select

    End Function

    ' Set the volume
    Private Sub vsbVolume_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsbVolume.Scroll
        Select Case e.Type
            Case System.Windows.Forms.ScrollEventType.EndScroll
                volume = vsbVolume.Maximum - e.NewValue
        End Select
    End Sub

    ' Start recording MIDI sequence
    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        ' 2.1 Start recording a MIDI sequence
        ' Initialize the sequence data
        isRecording = True                 ' set the recording flag
        startTime = DateTime.Now           ' remember the time when recording starts

        ' the following two lines reset the midiSequence object
        midiSequence = Nothing             ' dump the midiSequence object
        midiSequence = New SequenceData    ' create a new midiSequence object
        ' Send the messages for the instrument so that the playback will match
        midimsg = &HC0 + (tbInstrument.Value * &H100) + channel
        sendMidiMsg(hmidi, midimsg)

        ' Disable record, play, removeSilence Button
        btnRecord.Enabled = False
        btnPlay.Enabled = False
        btnRemoveSilence.Enabled = False
        btnStop.Enabled = True

        ' Append Button
        Button4.Enabled = False

        ' Loop Button
        Button5.Enabled = False


    End Sub

    ' Stop recording MIDI sequence
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        ' 2.2 Stop recording a MIDI sequence
        ' Stop the recording
        isRecording = False
        btnRecord.Enabled = True
        btnPlay.Enabled = True
        btnRemoveSilence.Enabled = True
        ' 2.3 Play a MIDI sequence
        ' Stop the playback
        tmrSequencer.Enabled = False
        midimsg = &HB0 + (&H7B * &H100) + channel
        sendMidiMsg(hmidi, midimsg)

        ' append button
        Button4.Enabled = True

        ' looping Button
        loopingFlag = False
        Button5.Enabled = True


    End Sub

    ' Play the MIDI sequence recorded
    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        If midiSequence Is Nothing Then
            Label1.Text = "MidiFile not found"
            Exit Sub
        End If
        ' 2.3 Play a MIDI sequence
        ' Start the timer using the time of the first sequencer message data
        currentIndex = 0 ' Store the current index of the MIDI msg

        ' Start the timer using the time of the first sequencer message data
        tmrSequencer.Interval = (CInt(midiSequence.data(0).time.TotalMilliseconds) + 1) * speed
        tmrSequencer.Enabled = True

        Label1.Text = tmrSequencer.Interval

        btnRecord.Enabled = False
        btnPlay.Enabled = False
        btnStop.Enabled = True
        btnRemoveSilence.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False


    End Sub

    Private Sub tmrSequencer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSequencer.Tick
        ' 2.3 Play a MIDI sequence
        ' Send the MIDI message of the current message and schedule the next one
        ' Stop the timer from running
        tmrSequencer.Enabled = False
        ' Consume all sequence data which is on time
        currentTime = midiSequence.data(currentIndex).time.TotalMilliseconds

        While currentTime >= midiSequence.data(currentIndex).time.TotalMilliseconds
            sendMidiMsg(hmidi, midiSequence.data(currentIndex).midiMsg)
            currentIndex = currentIndex + 1
            If currentIndex = midiSequence.dataLength Then
                If loopingFlag Then
                    currentIndex = 0
                    currentTime = midiSequence.data(currentIndex).time.TotalMilliseconds
                Else
                    Exit While
                End If
            End If
        End While

        ' Schedule the timer for the next sequencer message
        If currentIndex < midiSequence.dataLength Then
            tmrSequencer.Interval = (CInt(midiSequence.data(currentIndex).time.TotalMilliseconds - currentTime) + 1) * speed
            tmrSequencer.Enabled = True
        Else
            btnRecord.Enabled = True
            btnPlay.Enabled = True
            btnRemoveSilence.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
        End If

    End Sub

    ' Send a MIDI message and store the message
    Private Sub sendMidiMsg(ByVal hMidiOut As Integer, ByVal dwMsg As Integer)
        ' Send a MIDI message
        midiOutShortMsg(hMidiOut, dwMsg)
        If isRecording Then
            midiSequence.AddSequenceData(dwMsg, DateTime.Now.Subtract(startTime))
        End If

    End Sub

    Private Sub tbSpeed_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSpeed.Scroll
        If tbSpeed.Value > 0 Then
            speed = 1 - tbSpeed.Value / 10.0
        Else
            speed = 1 - tbSpeed.Value / 10.0
        End If

        Label1.Text = speed.ToString()
    End Sub

    Private Sub btnRemoveSilence_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSilence.Click
        If midiSequence Is Nothing Then
            Exit Sub
        End If

        If firstTime Then
            currentIndex = 1
            firstTime = False
        End If

        Dim subtractValue As TimeSpan = midiSequence.data(1).time

        While currentIndex < midiSequence.dataLength
            midiSequence.data(currentIndex).time = midiSequence.data(currentIndex).time - subtractValue
            currentIndex = currentIndex + 1
        End While
    End Sub

    ' Change the instrument by sending a program change message
    Private Sub tbInstrument_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbInstrument.ValueChanged
        ' Send a program change message for the instrument
        midimsg = &HC0 + (tbInstrument.Value * &H100) + channel
        sendMidiMsg(hmidi, midimsg)

        instrumentSlider(channel) = tbInstrument.Value
    End Sub

    Private Sub tbBankMSB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBankMSB.ValueChanged
        ' Send a control change message to change the bank
        midimsg = &HB0 + channel + (&H0 * &H100) + (tbBankMSB.Value * &H10000)
        sendMidiMsg(hmidi, midimsg)

        ' Resend a program change message for the instrument so that it comes into effect immediately
        midimsg = &HC0 + (tbInstrument.Value * &H100) + channel
        sendMidiMsg(hmidi, midimsg)
    End Sub

    Private Function sendMsgForWhiteboard(ByVal x As Double, ByVal y As Double) As Integer
        Dim pitch As Integer
        Dim lsb As Integer
        Dim msb As Integer

        ' Instrument is selected
        If cbXselected = 1 Or cbYselected = 1 Then
            tbInstrument.Value = IIf(cbXselected = 1, x * 127, y * 127)

            If lastMidiMessage <> -1 Then
                midimsg = lastMidiMessage And &HFFFFEF
                sendMidiMsg(hmidi, midimsg)
            End If
            midimsg = &HC0 + channel + (tbInstrument.Value * &H100)
            sendMidiMsg(hmidi, midimsg)
            lastMidiMessage = midimsg
        End If

        ' Velocity is selected
        If cbXselected = 2 Or cbYselected = 2 Then
            volume = IIf(cbXselected = 2, x * 127, y * 127)
            vsbVolume.Value = 127 - volume
        End If

        ' Stereo Position is selected
        If cbXselected = 4 Or cbYselected = 4 Then
            panningSlider(channel) = IIf(cbXselected = 4, x * 127, y * 127)
            TrackBar1.Value = 127 - panningSlider(channel)

            'Label1.Text = panningSlider(channel)

            If lastMidiMessage <> -1 Then
                midimsg = lastMidiMessage And &HFFFFEF
                sendMidiMsg(hmidi, midimsg)
            End If
            midimsg = &HB0 + channel + (10 * &H100) + (TrackBar1.Value * &H10000)
            sendMidiMsg(hmidi, midimsg)
            lastMidiMessage = midimsg
        End If

        ' Pitch bend is selected
        If cbXselected = 5 Or cbYselected = 5 Then
            pitchSlider(channel) = IIf(cbXselected = 5, x * 16383, y * 16383)
            TrackBar2.Value = 16383 - pitchSlider(channel)
            lsb = pitchSlider(channel) Mod 128
            msb = Math.Floor(pitchSlider(channel) / 128)

            'Label1.Text = "Pitch Slider Value: " + pitchSlider(channel).ToString
            If lastMidiMessage <> -1 Then
                midimsg = lastMidiMessage And &HFFFFEF
                sendMidiMsg(hmidi, midimsg)
            End If
            midimsg = &HE0 + channel + (lsb * &H100) + (msb * &H10000)
            sendMidiMsg(hmidi, midimsg)
            lastMidiMessage = midimsg
        End If


        ' Pitch is selected
        If cbXselected = 3 Or cbYselected = 3 Then
            pitch = IIf(cbXselected = 3, x * 127, y * 127)
            If lastMidiMessage <> -1 Then
                midimsg = lastMidiMessage And &HFFFFEF
                sendMidiMsg(hmidi, midimsg)
            End If
            midimsg = &H90 + (pitch * &H100) + (volume * &H10000) + channel
            sendMidiMsg(hmidi, midimsg)
            lastMidiMessage = midimsg
        End If


    End Function

    Private Sub picWhiteboard_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picWhiteboard.MouseMove
        Dim x As Double
        Dim y As Double

        If Not e.Button = Windows.Forms.MouseButtons.Left Or e.X < 0 Or e.X >= picWhiteboard.Width Or e.Y < 0 Or e.Y >= picWhiteboard.Height Then
            Exit Sub
        End If

        x = e.X / (picWhiteboard.Width - 1)
        y = e.Y / (picWhiteboard.Height - 1)
        Label1.Text = "X-axis: " + CStr(x) + " Y-Axis: " + CStr(y)
        sendMsgForWhiteboard(x, y)
    End Sub

    Private Sub cboXTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboXTitle.SelectedIndexChanged
        If cboXTitle.SelectedIndex = cbYselected Then
            cboXTitle.SelectedIndex = cbXselected
        Else
            cbXselected = cboXTitle.SelectedIndex
        End If
    End Sub

    Private Sub cboYTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYTitle.SelectedIndexChanged
        If cboYTitle.SelectedIndex = cbXselected Then
            cboYTitle.SelectedIndex = cbYselected
        Else
            cbYselected = cboYTitle.SelectedIndex
        End If
    End Sub

    Private Sub picWhiteboard_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picWhiteboard.MouseDown

        ' ***** Add your code here
        picWhiteboard_MouseMove(sender, e)
    End Sub

    Private Sub picWhiteboard_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picWhiteboard.MouseUp

        ' ***** Add your code here
        If lastMidiMessage <> -1 Then
            midimsg = lastMidiMessage And &HFFFFEF
            sendMidiMsg(hmidi, midimsg)
            lastMidiMessage = -1
        End If
    End Sub

    ' Draw the drum slots in a PictureBox (picDrum) in two rows
    Private Sub DrawDrumConfiguration(ByVal g As Graphics)
        Dim Slot, Drum As Short
        Dim X1, X2 As Single
        Dim Y1, Y2 As Single
        Dim Width, Height As Single

        ' The width and height of a slot in the drum machine
        Width = picDrum.ClientRectangle.Width / DRUM_SLOT
        Height = picDrum.ClientRectangle.Height / DRUM_INSTRUMENT

        g.Clear(Color.White)

        'Create pens
        Dim blackBrush As New SolidBrush(Color.Black)
        Dim redPen As New Pen(Color.Red, 3)

        For Slot = 1 To DRUM_SLOT
            X1 = Width * (Slot - 1)
            X2 = Width * Slot

            For Drum = 1 To DRUM_INSTRUMENT
                Y1 = Height * (Drum - 1)
                Y2 = Height * Drum

                ' Draw a black box if the slot is selected
                If drumSlot(Drum, Slot) Then
                    g.FillRectangle(blackBrush, X1, Y1, Width, Height)
                End If
            Next
            g.DrawLine(redPen, X1, 0, X1, (picDrum.ClientRectangle.Height))
        Next

        ' Draw the red separators between the slots
        For Drum = 1 To DRUM_INSTRUMENT - 1
            g.DrawLine(redPen, 0, Height * Drum, (picDrum.ClientRectangle.Width), Height * Drum)
        Next
    End Sub

    Private Sub picDrum_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picDrum.MouseDown
        Dim X As Single = e.X
        Dim Y As Single = e.Y
        Dim Drum, Slot As Short
        Dim Width, Height As Single


        Width = picDrum.ClientRectangle.Width / DRUM_SLOT
        Height = picDrum.ClientRectangle.Height / DRUM_INSTRUMENT

        ' Determine the slot where the user has selected
        Slot = Math.Floor(X / Width) + 1
        Drum = Math.Floor(Y / Height) + 1

        ' Set/unset the drum slot
        drumSlot(Drum, Slot) = Not drumSlot(Drum, Slot)

        ' Redraw the drum machine
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub tmrDrumPlayback_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDrumPlayback.Tick
        Static Slot As Short
        Static Slot_p As Short = 0
        Dim Drum As Short
        Dim X1, X2, Width As Single
        Dim bluePen As New Pen(Color.Blue, 3)
        Dim redPen As New Pen(Color.Red, 3)
        Dim g As Graphics = picDrum.CreateGraphics

        Width = picDrum.ClientRectangle.Width / DRUM_SLOT
        X1 = Width * (Slot_p - 1)
        X2 = Width * (Slot - 1)

        Dim point1 As New Point(X1, 0)
        Dim point2 As New Point(X1, Width + 500)

        Dim point3 As New Point(X2, 0)
        Dim point4 As New Point(X2, Width + 500)


        Label1.Text = Width.ToString + "   X1: " + X1.ToString + "   X2: " + X2.ToString
        'Draw the red line to overwrite the blue line

        ' *** Add your code here
        g.DrawLine(redPen, point1, point2)


        ' Initialize the slot number
        If Slot = 0 Then Slot = 1

        ' Start/Stop a drum for each row in the drum machine
        For Drum = 1 To DRUM_INSTRUMENT
            If drumMessageSent(Drum) Then
                ' You need to stop any drum note already sent to
                ' the midi card by checking the variable DrumMessageSent

                ' *** Add your code here
                midimsg = &H80 + 9 + (drumNumber(Drum) * &H100) + (volume * &H10000)
                sendMidiMsg(hmidi, midimsg)

            End If

            If drumSlot(Drum, Slot) Then
                ' Here, a drum slot is selected that means you have to
                ' start a midi note with the drum sound

                ' *** Add your code here
                midimsg = &H90 + 9 + (drumNumber(Drum) * &H100) + (volume * &H10000)
                sendMidiMsg(hmidi, midimsg)


                drumMessageSent(Drum) = True
            Else
                drumMessageSent(Drum) = False
            End If
        Next


        'Draw the blue line

        ' *** Add your code here
        g.DrawLine(bluePen, point3, point4)


        'Save the current position
        Slot_p = Slot

        ' Increase the number by 1
        Slot = (Slot Mod DRUM_SLOT) + 1
    End Sub

    ' Draw the drum machine
    Private Sub picDrum_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picDrum.Paint
        DrawDrumConfiguration(e.Graphics())
    End Sub

    Private Sub btnDrumstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrumStart.Click
        ' start the drum timer
        tmrDrumPlayback.Enabled = True
        btnDrumStart.Enabled = False
        btnDrumStop.Enabled = True
        'Button9.Enabled = False
        'Button8.Enabled = False
        'Button7.Enabled = False
        'Button6.Enabled = False

    End Sub

    Private Sub btnDrumstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrumStop.Click
        Dim Drum As Short

        btnDrumStart.Enabled = True
        btnDrumStop.Enabled = False
        'ReDraw the drum machine
        DrawDrumConfiguration(picDrum.CreateGraphics())

        ' stop the drum timer
        tmrDrumPlayback.Enabled = False

        ' You need to stop any drum note already sent to the midi card

        ' *** Add your code here
        For Drum = 1 To DRUM_INSTRUMENT
            If drumMessageSent(Drum) Then
                midimsg = &H89 + (drumNumber(Drum) * &H100) + (&H7F * &H10000)
                midiOutShortMsg(hmidi, midimsg)
            End If
        Next

        'Button9.Enabled = True
        'Button8.Enabled = True
        'Button7.Enabled = True
        'Button6.Enabled = True

    End Sub

    Private Sub picDisplay_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim g As Graphics = e.Graphics()

        g.Clear(Color.White)

        ' This code simply draws three rectangles on the picture box
        g.FillRectangle(Brushes.Black, 10, 10, 10, 2)
        g.FillRectangle(Brushes.Black, 20, 20, 10, 2)
        g.FillRectangle(Brushes.Black, 30, 30, 10, 2)
    End Sub

    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        Dim dlg As New OpenFileDialog
        Dim midiFile As MIDIFile
        Dim midiSequences() As SequenceData

        ' Ask for the MIDI file
        dlg.DefaultExt = "mid"
        dlg.Filter = "MIDI files (*.mid)|*.mid"
        dlg.Multiselect = False

        If dlg.ShowDialog() = DialogResult.OK Then
            ' Load the file into the MIDIFile structure
            midiFile = New MIDIFile(dlg.FileName)

            ' Convert the MIDI file into the SequenceData memory structure
            midiSequences = midiFile.ConvertToSequence()
            If midiSequences.Length > 0 Then
                ' Here the first track of the MIDI file is set into the sequencer memory
                midiSequence = midiSequences(0)
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button1.Enabled = True
        Button2.Enabled = False
        ComboBox1.Enabled = True
        chordFlag = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        chordNumber = ComboBox1.SelectedIndex
        'Label1.Text = chordNumber.ToString


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button2.Enabled = True
        ComboBox1.Enabled = False
        chordFlag = False
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub tabSequencer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabSequencer.Click

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        midimsg = &HB0 + channel + (10 * &H100) + (TrackBar1.Value * &H10000)
        sendMidiMsg(hmidi, midimsg)

        panningSlider(channel) = TrackBar1.Value
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim channelReset As Integer
        For channelReset = 0 To CHANNEL_NUMBER
            ' send all note off message
            midimsg = &HB0 + channelReset + (&H7B * &H100) + (&H0 * &H10000)
            sendMidiMsg(hmidi, midimsg)
            ' Reset Stereo position to cetner
            midimsg = &HB0 + channelReset + (10 * &H100) + (63 * &H10000)
            sendMidiMsg(hmidi, midimsg)
            ' Reset Musical Instrument to 0
            midimsg = &HC0 + (0 * &H100) + channelReset
            sendMidiMsg(hmidi, midimsg)

            instrumentSlider(channelReset) = 0
            panningSlider(channelReset) = 63
            pitchSlider(channelReset) = 8192
        Next

        TrackBar1.Value = panningSlider(channel)
        tbInstrument.Value = instrumentSlider(channel)
        TrackBar2.Value = pitchSlider(channel)

    End Sub

    Private Sub tbInstrument_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbInstrument.Scroll
        ' Send a program change message for the instrument
        midimsg = &HC0 + (tbInstrument.Value * &H100) + channel
        sendMidiMsg(hmidi, midimsg)

        instrumentSlider(channel) = tbInstrument.Value
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub picWhiteboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picWhiteboard.Click

    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll
        Dim lsb As Integer
        Dim msb As Integer

        lsb = pitchSlider(channel) Mod 128
        msb = Math.Floor(pitchSlider(channel) / 128)

        midimsg = &HE0 + channel + (lsb * &H100) + (msb * &H10000)
        sendMidiMsg(hmidi, midimsg)

        pitchSlider(channel) = TrackBar2.Value
    End Sub

    Private Sub picDrum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picDrum.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        isRecording = True                 ' set the appending flag
        Dim appendingIndex As Integer = 0
        appendingIndex = midiSequence.dataLength - 1

        startTime = startTime + midiSequence.data(appendingIndex).time


        ' Disable record, play, removeSilence Button
        btnRecord.Enabled = False
        btnPlay.Enabled = False
        btnRemoveSilence.Enabled = False
        btnStop.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If midiSequence Is Nothing Then
            Label1.Text = "MidiFile not found"
            Exit Sub
        End If
        ' 2.3 Play a MIDI sequence
        ' Start the timer using the time of the first sequencer message data
        loopingFlag = True
        currentIndex = 0 ' Store the current index of the MIDI msg

        ' Start the timer using the time of the first sequencer message data
        tmrSequencer.Interval = (CInt(midiSequence.data(0).time.TotalMilliseconds) + 1) * speed
        tmrSequencer.Enabled = True

        Label1.Text = tmrSequencer.Interval

        btnRecord.Enabled = False
        btnPlay.Enabled = False
        btnStop.Enabled = True
        btnRemoveSilence.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False

    End Sub

    Private Sub TrackBar3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar3.Scroll
        pitch(channel) = TrackBar3.Value

        Label1.Text = "Channel " + channel.ToString + ": " + pitch(channel).ToString

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If DRUM_INSTRUMENT > 7 Then
            Label1.Text = "Drum Instrument Can't be Higher than 8"
            Exit Sub
        End If

        DRUM_INSTRUMENT = DRUM_INSTRUMENT + 1
        Select Case DRUM_INSTRUMENT
            Case 1
                ComboBox2.Visible = True
            Case 2
                ComboBox3.Visible = True
            Case 3
                ComboBox4.Visible = True
            Case 4
                ComboBox5.Visible = True
            Case 5
                ComboBox6.Visible = True
            Case 6
                ComboBox7.Visible = True
            Case 7
                ComboBox8.Visible = True
            Case 8
                ComboBox9.Visible = True
        End Select

        Dim tempDrumSlot(DRUM_INSTRUMENT, DRUM_SLOT) As Boolean
        Dim tempDrum As Integer = 0
        Dim tempSlot As Integer = 0

        For tempSlot = 1 To DRUM_SLOT
            For tempDrum = 1 To DRUM_INSTRUMENT - 1
                tempDrumSlot(tempDrum, tempSlot) = drumSlot(tempDrum, tempSlot)
            Next
        Next

        ReDim drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)

        For tempSlot = 1 To DRUM_SLOT
            For tempDrum = 1 To DRUM_INSTRUMENT
                drumSlot(tempDrum, tempSlot) = tempDrumSlot(tempDrum, tempSlot)
            Next
        Next

        Me.picDrum.Size = New System.Drawing.Size(DRUM_SLOT * 45, DRUM_INSTRUMENT * 23)
        Label1.Text = DRUM_INSTRUMENT

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If DRUM_SLOT > 15 Then
            Label1.Text = "Drum Slot Can't be Higher than 16"
            Exit Sub
        End If

        DRUM_SLOT = DRUM_SLOT + 1
        ReDim Preserve drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)

        Me.picDrum.Size = New System.Drawing.Size(DRUM_SLOT * 45, DRUM_INSTRUMENT * 23)
        Label1.Text = DRUM_SLOT
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If DRUM_SLOT < 9 Then
            Label1.Text = "Drum Slot lower than 8"
            Exit Sub
        End If

        DRUM_SLOT = DRUM_SLOT - 1
        ReDim Preserve drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)

        Me.picDrum.Size = New System.Drawing.Size(DRUM_SLOT * 45, DRUM_INSTRUMENT * 23)
        Label1.Text = DRUM_SLOT
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If DRUM_INSTRUMENT < 3 Then
            Label1.Text = "Drum Instrument Can't be Lower than 2"
            Exit Sub
        End If

        DRUM_INSTRUMENT = DRUM_INSTRUMENT - 1
        Select Case DRUM_INSTRUMENT
            Case 1
                ComboBox3.Visible = False
            Case 2
                ComboBox4.Visible = False
            Case 3
                ComboBox5.Visible = False
            Case 4
                ComboBox6.Visible = False
            Case 5
                ComboBox7.Visible = False
            Case 6
                ComboBox8.Visible = False
            Case 7
                ComboBox9.Visible = False
        End Select
        Dim tempDrumSlot(DRUM_INSTRUMENT, DRUM_SLOT) As Boolean
        Dim tempDrum As Integer = 0
        Dim tempSlot As Integer = 0

        For tempSlot = 1 To DRUM_SLOT
            For tempDrum = 1 To DRUM_INSTRUMENT - 1
                tempDrumSlot(tempDrum, tempSlot) = drumSlot(tempDrum, tempSlot)
            Next
        Next

        ReDim drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)

        For tempSlot = 1 To DRUM_SLOT
            For tempDrum = 1 To DRUM_INSTRUMENT
                drumSlot(tempDrum, tempSlot) = tempDrumSlot(tempDrum, tempSlot)
            Next
        Next

        Me.picDrum.Size = New System.Drawing.Size(DRUM_SLOT * 45, DRUM_INSTRUMENT * 23)
        Label1.Text = DRUM_INSTRUMENT
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim selectedIndex As Integer

        selectedIndex = ComboBox2.SelectedIndex + 35
        drumNumber(1) = selectedIndex
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim selectedIndex As Integer

        selectedIndex = ComboBox3.SelectedIndex + 35
        drumNumber(2) = selectedIndex
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim drumRandom(DRUM_INSTRUMENT) As Integer

        For tempDrum As Integer = 1 To DRUM_INSTRUMENT
            For tempSlot As Integer = 1 To DRUM_SLOT
                Randomize()
                Dim randomNumber As Integer = CInt(Int((2 * Rnd()) + 1))
                'Label4.Text = randomNumber
                If randomNumber.Equals(1) Then
                    drumSlot(tempDrum, tempSlot) = True
                Else
                    drumSlot(tempDrum, tempSlot) = False
                End If
            Next
        Next

        For tempCounter As Integer = 1 To DRUM_INSTRUMENT
            drumRandom(tempCounter) = CInt(Int((45 * Rnd()) + 35))
            drumNumber(tempCounter) = drumRandom(tempCounter)
        Next

        ComboBox2.SelectedIndex = drumNumber(1) - 35
        ComboBox3.SelectedIndex = drumNumber(2) - 35
        ComboBox4.SelectedIndex = drumNumber(3) - 35
        ComboBox5.SelectedIndex = drumNumber(4) - 35
        ComboBox6.SelectedIndex = drumNumber(5) - 35
        ComboBox7.SelectedIndex = drumNumber(6) - 35
        ComboBox8.SelectedIndex = drumNumber(7) - 35
        ComboBox9.SelectedIndex = drumNumber(8) - 35


        ' Redraw the drum machine
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim selectedIndex As Integer

        selectedIndex = ComboBox4.SelectedIndex + 35
        drumNumber(3) = selectedIndex
        Label1.Text = drumNumber(3).ToString
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        Dim selectedIndex As Integer

        selectedIndex = ComboBox5.SelectedIndex + 35
        drumNumber(4) = selectedIndex
        Label1.Text = drumNumber(4).ToString
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        Dim selectedIndex As Integer

        selectedIndex = ComboBox6.SelectedIndex + 35
        drumNumber(5) = selectedIndex
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged
        Dim selectedIndex As Integer

        selectedIndex = ComboBox7.SelectedIndex + 35
        drumNumber(6) = selectedIndex
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged
        Dim selectedIndex As Integer

        selectedIndex = ComboBox8.SelectedIndex + 35
        drumNumber(7) = selectedIndex
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox9.SelectedIndexChanged
        Dim selectedIndex As Integer

        selectedIndex = ComboBox9.SelectedIndex + 35
        drumNumber(8) = selectedIndex
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        For tempDrum As Integer = 1 To DRUM_INSTRUMENT
            For tempSlot As Integer = 1 To DRUM_SLOT
                If drumSlot(tempDrum, tempSlot) Then
                    drumSlot(tempDrum, tempSlot) = False
                Else
                    drumSlot(tempDrum, tempSlot) = True
                End If
            Next
        Next

        ' Redraw the drum machine
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim tempDrumSlot(DRUM_INSTRUMENT, DRUM_SLOT) As Boolean
        For tempDrum As Integer = 1 To DRUM_INSTRUMENT
            For tempSlot As Integer = 1 To DRUM_SLOT
                tempDrumSlot(tempDrum, tempSlot) = drumSlot(tempDrum, DRUM_SLOT - tempSlot + 1)
            Next
        Next


        For tempDrum As Integer = 1 To DRUM_INSTRUMENT
            For tempSlot As Integer = 1 To DRUM_SLOT
                drumSlot(tempDrum, tempSlot) = tempDrumSlot(tempDrum, tempSlot)
            Next
        Next

        ' Redraw the drum machine
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub TrackBar4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar4.Scroll
        If TrackBar4.Value > 0 Then
            drumSpeed = 1 - TrackBar4.Value / 10.0
        Else
            drumSpeed = 1 - TrackBar4.Value / 10.0
        End If


        tmrDrumPlayback.Interval = 250 * drumSpeed
        Label1.Text = tmrDrumPlayback.Interval


    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim channelReset As Integer
        For channelReset = 0 To CHANNEL_NUMBER
            ' send all note off message
            midimsg = &HB0 + channelReset + (&H7B * &H100) + (&H0 * &H10000)
            sendMidiMsg(hmidi, midimsg)
            ' Reset Stereo position to cetner
            midimsg = &HB0 + channelReset + (10 * &H100) + (63 * &H10000)
            sendMidiMsg(hmidi, midimsg)
            ' Reset Musical Instrument to 0
            midimsg = &HC0 + (0 * &H100) + channelReset
            sendMidiMsg(hmidi, midimsg)

            instrumentSlider(channelReset) = 0
            panningSlider(channelReset) = 63
            pitchSlider(channelReset) = 8192
        Next

        TrackBar1.Value = panningSlider(channel)
        tbInstrument.Value = instrumentSlider(channel)
        TrackBar2.Value = pitchSlider(channel)
        TrackBar4.Value = 0
        tmrDrumPlayback.Interval = 250

        For tempDrum As Integer = 1 To DRUM_INSTRUMENT
            For tempSlot As Integer = 1 To DRUM_SLOT
                drumSlot(tempDrum, tempSlot) = False
            Next
        Next

        btnDrumStart.Enabled = True
        btnDrumStop.Enabled = False

        ' stop the drum timer
        tmrDrumPlayback.Enabled = False

        ' You need to stop any drum note already sent to the midi card

        ' *** Add your code here
        For tempDrum As Integer = 1 To DRUM_INSTRUMENT
            If drumMessageSent(tempDrum) Then
                midimsg = &H89 + (drumNumber(tempDrum) * &H100) + (&H7F * &H10000)
                midiOutShortMsg(hmidi, midimsg)
            End If
        Next

        isRecording = False
        btnRecord.Enabled = True
        btnPlay.Enabled = True
        btnRemoveSilence.Enabled = True
        tmrSequencer.Enabled = False
        midimsg = &HB0 + (&H7B * &H100) + channel
        sendMidiMsg(hmidi, midimsg)

        ' append button
        Button4.Enabled = True

        ' looping Button
        loopingFlag = False
        Button5.Enabled = True

        ' reset variables
        DRUM_INSTRUMENT = 2
        DRUM_SLOT = 8

        drumNumber(1) = 60
        drumNumber(1) = 61

        ComboBox2.SelectedIndex = 60 - 35
        ComboBox3.SelectedIndex = 61 - 35

        ComboBox2.Visible = True
        ComboBox3.Visible = True
        ComboBox4.Visible = False
        ComboBox5.Visible = False
        ComboBox6.Visible = False
        ComboBox7.Visible = False
        ComboBox8.Visible = False
        ComboBox9.Visible = False

        Me.picDrum.Size = New System.Drawing.Size(DRUM_SLOT * 45, DRUM_INSTRUMENT * 23)

        'ReDraw the drum machine
        DrawDrumConfiguration(picDrum.CreateGraphics())

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim fileReader As String
        Dim dlg As New OpenFileDialog
        Dim text() As Char
        Dim numbers() As Short
        Dim lastNumber As Short = 2
        Dim inputLength As Integer = 2

        ' Ask for the text file
        dlg.DefaultExt = "text"
        dlg.Filter = "Text files (*.txt)|*.txt"
        dlg.Multiselect = False

        If dlg.ShowDialog() = DialogResult.OK Then
            ' Load the file into the MIDIFile structure
            fileReader = My.Computer.FileSystem.ReadAllText(dlg.FileName)
            text = fileReader.ToCharArray
            'Label1.Text = text(0) + " " + text(1) + " " + text(2) + " " + text(3)
            'inputDrumCount = CInt(text(0).ToString)
            numbers = changeToNumbers(text)

            'For i As Integer = 0 To numbers.Length - 1
            'Label1.Text += " " + numbers(i).ToString
            'Next

            inputDrumCount = numbers(0)
            inputCellCount = numbers(1)
            Try
                If inputDrumCount < 2 Then
                    Throw New ArgumentException()
                End If
                If inputDrumCount > 8 Then
                    Throw New ArgumentException()
                End If
                If numbers(1) = 1 Then
                    inputCellCount = numbers(1) * 10 + numbers(2)
                    If inputCellCount > 16 Then
                        Throw New ArgumentException()
                    End If
                    lastNumber += 1
                    Dim inputDrumSlot(inputDrumCount, inputCellCount) As Boolean

                    For tempDrum As Integer = 1 To inputDrumCount
                        For tempSlot As Integer = 1 To inputCellCount

                            If numbers(lastNumber) = 0 Then
                                inputDrumSlot(tempDrum, tempSlot) = False
                            ElseIf numbers(lastNumber) = 1 Then
                                inputDrumSlot(tempDrum, tempSlot) = True
                            Else
                                inputDrumNumber(tempDrum) = numbers(lastNumber)
                                lastNumber += 2
                                Label1.Text += " DrumSlots are: " + inputDrumNumber(tempDrum).ToString
                            End If
                            'Label1.Text += " " + numbers(lastNumber).ToString
                            lastNumber += 1

                        Next
                    Next
                    inputDrumNumber(inputDrumCount) = numbers(lastNumber)
                    Label1.Text += " DrumSlots are: " + inputDrumNumber(inputDrumCount).ToString

                    ReDim drumSlot(inputDrumCount, inputCellCount)

                    DRUM_INSTRUMENT = inputDrumCount
                    DRUM_SLOT = inputCellCount

                    For tempSlot As Integer = 1 To DRUM_SLOT
                        For tempDrum As Integer = 1 To DRUM_INSTRUMENT
                            drumSlot(tempDrum, tempSlot) = inputDrumSlot(tempDrum, tempSlot)
                        Next
                    Next

                    Me.picDrum.Size = New System.Drawing.Size(DRUM_SLOT * 45, DRUM_INSTRUMENT * 23)

                    Select Case DRUM_INSTRUMENT
                        Case 1
                            ComboBox2.Visible = True
                            ComboBox3.Visible = False
                            ComboBox4.Visible = False
                            ComboBox5.Visible = False
                            ComboBox6.Visible = False
                            ComboBox7.Visible = False
                            ComboBox8.Visible = False
                            ComboBox9.Visible = False
                        Case 2
                            ComboBox2.Visible = True
                            ComboBox3.Visible = True
                            ComboBox4.Visible = False
                            ComboBox5.Visible = False
                            ComboBox6.Visible = False
                            ComboBox7.Visible = False
                            ComboBox8.Visible = False
                            ComboBox9.Visible = False
                        Case 3
                            ComboBox2.Visible = True
                            ComboBox3.Visible = True
                            ComboBox4.Visible = True
                            ComboBox5.Visible = False
                            ComboBox6.Visible = False
                            ComboBox7.Visible = False
                            ComboBox8.Visible = False
                            ComboBox9.Visible = False
                        Case 4
                            ComboBox2.Visible = True
                            ComboBox3.Visible = True
                            ComboBox4.Visible = True
                            ComboBox5.Visible = True
                            ComboBox6.Visible = False
                            ComboBox7.Visible = False
                            ComboBox8.Visible = False
                            ComboBox9.Visible = False
                        Case 5
                            ComboBox2.Visible = True
                            ComboBox3.Visible = True
                            ComboBox4.Visible = True
                            ComboBox5.Visible = True
                            ComboBox6.Visible = True
                            ComboBox7.Visible = False
                            ComboBox8.Visible = False
                            ComboBox9.Visible = False
                        Case 6
                            ComboBox2.Visible = True
                            ComboBox3.Visible = True
                            ComboBox4.Visible = True
                            ComboBox5.Visible = True
                            ComboBox6.Visible = True
                            ComboBox7.Visible = True
                            ComboBox8.Visible = False
                            ComboBox9.Visible = False
                        Case 7
                            ComboBox2.Visible = True
                            ComboBox3.Visible = True
                            ComboBox4.Visible = True
                            ComboBox5.Visible = True
                            ComboBox6.Visible = True
                            ComboBox7.Visible = True
                            ComboBox8.Visible = True
                            ComboBox9.Visible = False
                        Case 8
                            ComboBox2.Visible = True
                            ComboBox3.Visible = True
                            ComboBox4.Visible = True
                            ComboBox5.Visible = True
                            ComboBox6.Visible = True
                            ComboBox7.Visible = True
                            ComboBox8.Visible = True
                            ComboBox9.Visible = True
                    End Select

                    ComboBox2.SelectedIndex = inputDrumNumber(1) - 35
                    ComboBox3.SelectedIndex = inputDrumNumber(2) - 35
                    ComboBox4.SelectedIndex = inputDrumNumber(3) - 35
                    ComboBox5.SelectedIndex = inputDrumNumber(4) - 35
                    ComboBox6.SelectedIndex = inputDrumNumber(5) - 35
                    ComboBox7.SelectedIndex = inputDrumNumber(6) - 35
                    ComboBox8.SelectedIndex = inputDrumNumber(7) - 35
                    ComboBox9.SelectedIndex = inputDrumNumber(8) - 35

                    ' Redraw the drum machine
                    DrawDrumConfiguration(picDrum.CreateGraphics())

                Else
                    If inputCellCount < 8 Then
                        Throw New ArgumentException()
                    End If
                    Dim inputDrumSlot(inputDrumCount, inputCellCount) As Boolean

                    For tempDrum As Integer = 1 To inputDrumCount
                        For tempSlot As Integer = 1 To inputCellCount

                            If numbers(lastNumber) = 0 Then
                                inputDrumSlot(tempDrum, tempSlot) = False
                            ElseIf numbers(lastNumber) = 1 Then
                                inputDrumSlot(tempDrum, tempSlot) = True
                            Else
                                inputDrumNumber(tempDrum) = numbers(lastNumber)
                                lastNumber += 2
                                Label1.Text += " DrumSlots are: " + inputDrumNumber(tempDrum).ToString
                            End If
                            'Label1.Text += " " + numbers(lastNumber).ToString
                            lastNumber += 1

                        Next
                    Next
                    inputDrumNumber(inputDrumCount) = numbers(lastNumber)
                    Label1.Text += " DrumSlots are: " + inputDrumNumber(inputDrumCount).ToString

                    ReDim drumSlot(inputDrumCount, inputCellCount)

                    DRUM_INSTRUMENT = inputDrumCount
                    DRUM_SLOT = inputCellCount

                    For tempSlot As Integer = 1 To DRUM_SLOT
                        For tempDrum As Integer = 1 To DRUM_INSTRUMENT
                            drumSlot(tempDrum, tempSlot) = inputDrumSlot(tempDrum, tempSlot)
                        Next
                    Next

                    Me.picDrum.Size = New System.Drawing.Size(DRUM_SLOT * 45, DRUM_INSTRUMENT * 23)

                    Select Case DRUM_INSTRUMENT
                        Case 1
                            ComboBox2.Visible = True
                            ComboBox3.Visible = False
                            ComboBox4.Visible = False
                            ComboBox5.Visible = False
                            ComboBox6.Visible = False
                            ComboBox7.Visible = False
                            ComboBox8.Visible = False
                            ComboBox9.Visible = False
                        Case 2
                            ComboBox2.Visible = True
                            ComboBox3.Visible = True
                            ComboBox4.Visible = False
                            ComboBox5.Visible = False
                            ComboBox6.Visible = False
                            ComboBox7.Visible = False
                            ComboBox8.Visible = False
                            ComboBox9.Visible = False
                        Case 3
                            ComboBox2.Visible = True
                            ComboBox3.Visible = True
                            ComboBox4.Visible = True
                            ComboBox5.Visible = False
                            ComboBox6.Visible = False
                            ComboBox7.Visible = False
                            ComboBox8.Visible = False
                            ComboBox9.Visible = False
                        Case 4
                            ComboBox2.Visible = True
                            ComboBox3.Visible = True
                            ComboBox4.Visible = True
                            ComboBox5.Visible = True
                            ComboBox6.Visible = False
                            ComboBox7.Visible = False
                            ComboBox8.Visible = False
                            ComboBox9.Visible = False
                        Case 5
                            ComboBox2.Visible = True
                            ComboBox3.Visible = True
                            ComboBox4.Visible = True
                            ComboBox5.Visible = True
                            ComboBox6.Visible = True
                            ComboBox7.Visible = False
                            ComboBox8.Visible = False
                            ComboBox9.Visible = False
                        Case 6
                            ComboBox2.Visible = True
                            ComboBox3.Visible = True
                            ComboBox4.Visible = True
                            ComboBox5.Visible = True
                            ComboBox6.Visible = True
                            ComboBox7.Visible = True
                            ComboBox8.Visible = False
                            ComboBox9.Visible = False
                        Case 7
                            ComboBox2.Visible = True
                            ComboBox3.Visible = True
                            ComboBox4.Visible = True
                            ComboBox5.Visible = True
                            ComboBox6.Visible = True
                            ComboBox7.Visible = True
                            ComboBox8.Visible = True
                            ComboBox9.Visible = False
                        Case 8
                            ComboBox2.Visible = True
                            ComboBox3.Visible = True
                            ComboBox4.Visible = True
                            ComboBox5.Visible = True
                            ComboBox6.Visible = True
                            ComboBox7.Visible = True
                            ComboBox8.Visible = True
                            ComboBox9.Visible = True
                    End Select

                    ComboBox2.SelectedIndex = inputDrumNumber(1) - 35
                    ComboBox3.SelectedIndex = inputDrumNumber(2) - 35
                    ComboBox4.SelectedIndex = inputDrumNumber(3) - 35
                    ComboBox5.SelectedIndex = inputDrumNumber(4) - 35
                    ComboBox6.SelectedIndex = inputDrumNumber(5) - 35
                    ComboBox7.SelectedIndex = inputDrumNumber(6) - 35
                    ComboBox8.SelectedIndex = inputDrumNumber(7) - 35
                    ComboBox9.SelectedIndex = inputDrumNumber(8) - 35

                    ' Redraw the drum machine
                    DrawDrumConfiguration(picDrum.CreateGraphics())

                End If
                'MsgBox(inputDrumCount.ToString)
                'MsgBox(inputCellCount.ToString)
                'Label1.Text = inputDrumCount.ToString + " " + inputCellCount.ToString
            Catch ex As Exception
                MsgBox("Invalid Drum File!: " + ex.Message)
            End Try
           
            
        End If

    End Sub

    Private Function changeToNumbers(ByRef text() As Char) As Short()
        Dim numbers(text.Length - 1) As Short
        Dim count As Short = 0
        For i As Integer = 0 To text.Length - 1
            Try
                numbers(count) = CInt(text(i).ToString)
                count = count + 1
            Catch ex As Exception
            End Try
        Next

        count = 0

        For j As Integer = 0 To numbers.Length - 1
            Try
                If count > 2 Then
                    If numbers(count) <> 0 Then
                        If numbers(count) <> 1 Then
                            numbers(count) = numbers(count) * 10 + numbers(count + 1)
                            count = count + 1
                        End If
                    End If
                Else

                End If
                count = count + 1

            Catch ex As Exception

            End Try
        Next
        Return numbers
    End Function
End Class
