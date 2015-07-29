Public Class frmMelt
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents lblAmpMax As System.Windows.Forms.Label
    Public WithEvents lblAmpMin As System.Windows.Forms.Label
    Public WithEvents lblAmplitude As System.Windows.Forms.Label
    Private WithEvents tbAmplitude As System.Windows.Forms.TrackBar
    Public WithEvents btnApply As System.Windows.Forms.Button
    Public WithEvents lblFreqMax As System.Windows.Forms.Label
    Public WithEvents lblFreqMin As System.Windows.Forms.Label
    Public WithEvents lblOffset As System.Windows.Forms.Label
    Friend WithEvents gbSine As System.Windows.Forms.GroupBox
    Friend WithEvents gbRandom As System.Windows.Forms.GroupBox
    Public WithEvents lblCaption1 As System.Windows.Forms.Label
    Public WithEvents lblCaption2 As System.Windows.Forms.Label
    Public WithEvents lblCycleMax As System.Windows.Forms.Label
    Public WithEvents lblCycleMin As System.Windows.Forms.Label
    Public WithEvents lblCycle As System.Windows.Forms.Label
    Private WithEvents tbCycle As System.Windows.Forms.TrackBar
    Public WithEvents lblCaption3 As System.Windows.Forms.Label
    Public WithEvents lblCaption4 As System.Windows.Forms.Label
    Public WithEvents lblPeriodMin As System.Windows.Forms.Label
    Public WithEvents lblPeriodMax As System.Windows.Forms.Label
    Public WithEvents lblPeriod As System.Windows.Forms.Label
    Private WithEvents tbPeriod As System.Windows.Forms.TrackBar
    Friend WithEvents cbxSine As System.Windows.Forms.CheckBox
    Friend WithEvents cbxRandom As System.Windows.Forms.CheckBox
    Private WithEvents tbOffset As System.Windows.Forms.TrackBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblAmpMax = New System.Windows.Forms.Label()
        Me.lblAmpMin = New System.Windows.Forms.Label()
        Me.lblAmplitude = New System.Windows.Forms.Label()
        Me.tbAmplitude = New System.Windows.Forms.TrackBar()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.lblFreqMax = New System.Windows.Forms.Label()
        Me.lblFreqMin = New System.Windows.Forms.Label()
        Me.lblOffset = New System.Windows.Forms.Label()
        Me.tbOffset = New System.Windows.Forms.TrackBar()
        Me.gbSine = New System.Windows.Forms.GroupBox()
        Me.cbxSine = New System.Windows.Forms.CheckBox()
        Me.lblCaption2 = New System.Windows.Forms.Label()
        Me.lblCycleMax = New System.Windows.Forms.Label()
        Me.lblCycleMin = New System.Windows.Forms.Label()
        Me.lblCycle = New System.Windows.Forms.Label()
        Me.tbCycle = New System.Windows.Forms.TrackBar()
        Me.lblCaption1 = New System.Windows.Forms.Label()
        Me.gbRandom = New System.Windows.Forms.GroupBox()
        Me.cbxRandom = New System.Windows.Forms.CheckBox()
        Me.lblCaption4 = New System.Windows.Forms.Label()
        Me.lblPeriodMin = New System.Windows.Forms.Label()
        Me.lblPeriodMax = New System.Windows.Forms.Label()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.tbPeriod = New System.Windows.Forms.TrackBar()
        Me.lblCaption3 = New System.Windows.Forms.Label()
        CType(Me.tbAmplitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSine.SuspendLayout()
        CType(Me.tbCycle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRandom.SuspendLayout()
        CType(Me.tbPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAmpMax
        '
        Me.lblAmpMax.AutoSize = True
        Me.lblAmpMax.Location = New System.Drawing.Point(246, 74)
        Me.lblAmpMax.Name = "lblAmpMax"
        Me.lblAmpMax.Size = New System.Drawing.Size(24, 17)
        Me.lblAmpMax.TabIndex = 14
        Me.lblAmpMax.Text = "20"
        '
        'lblAmpMin
        '
        Me.lblAmpMin.AutoSize = True
        Me.lblAmpMin.Location = New System.Drawing.Point(23, 74)
        Me.lblAmpMin.Name = "lblAmpMin"
        Me.lblAmpMin.Size = New System.Drawing.Size(16, 17)
        Me.lblAmpMin.TabIndex = 13
        Me.lblAmpMin.Text = "0"
        '
        'lblAmplitude
        '
        Me.lblAmplitude.Location = New System.Drawing.Point(281, 46)
        Me.lblAmplitude.Name = "lblAmplitude"
        Me.lblAmplitude.Size = New System.Drawing.Size(36, 15)
        Me.lblAmplitude.TabIndex = 12
        Me.lblAmplitude.Text = "0"
        Me.lblAmplitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbAmplitude
        '
        Me.tbAmplitude.Location = New System.Drawing.Point(14, 40)
        Me.tbAmplitude.Maximum = 20
        Me.tbAmplitude.Name = "tbAmplitude"
        Me.tbAmplitude.Size = New System.Drawing.Size(260, 56)
        Me.tbAmplitude.TabIndex = 10
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(128, 406)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(96, 28)
        Me.btnApply.TabIndex = 9
        Me.btnApply.Text = "Apply"
        '
        'lblFreqMax
        '
        Me.lblFreqMax.AutoSize = True
        Me.lblFreqMax.Location = New System.Drawing.Point(241, 74)
        Me.lblFreqMax.Name = "lblFreqMax"
        Me.lblFreqMax.Size = New System.Drawing.Size(24, 17)
        Me.lblFreqMax.TabIndex = 19
        Me.lblFreqMax.Text = "10"
        '
        'lblFreqMin
        '
        Me.lblFreqMin.AutoSize = True
        Me.lblFreqMin.Location = New System.Drawing.Point(18, 74)
        Me.lblFreqMin.Name = "lblFreqMin"
        Me.lblFreqMin.Size = New System.Drawing.Size(16, 17)
        Me.lblFreqMin.TabIndex = 18
        Me.lblFreqMin.Text = "0"
        '
        'lblOffset
        '
        Me.lblOffset.Location = New System.Drawing.Point(276, 46)
        Me.lblOffset.Name = "lblOffset"
        Me.lblOffset.Size = New System.Drawing.Size(36, 15)
        Me.lblOffset.TabIndex = 17
        Me.lblOffset.Text = "0"
        Me.lblOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbOffset
        '
        Me.tbOffset.Location = New System.Drawing.Point(10, 40)
        Me.tbOffset.Name = "tbOffset"
        Me.tbOffset.Size = New System.Drawing.Size(259, 56)
        Me.tbOffset.TabIndex = 15
        '
        'gbSine
        '
        Me.gbSine.Controls.Add(Me.cbxSine)
        Me.gbSine.Controls.Add(Me.lblCaption2)
        Me.gbSine.Controls.Add(Me.lblCycleMax)
        Me.gbSine.Controls.Add(Me.lblCycleMin)
        Me.gbSine.Controls.Add(Me.lblCycle)
        Me.gbSine.Controls.Add(Me.tbCycle)
        Me.gbSine.Controls.Add(Me.lblCaption1)
        Me.gbSine.Controls.Add(Me.lblAmpMax)
        Me.gbSine.Controls.Add(Me.lblAmpMin)
        Me.gbSine.Controls.Add(Me.lblAmplitude)
        Me.gbSine.Controls.Add(Me.tbAmplitude)
        Me.gbSine.Location = New System.Drawing.Point(14, 14)
        Me.gbSine.Name = "gbSine"
        Me.gbSine.Size = New System.Drawing.Size(324, 182)
        Me.gbSine.TabIndex = 20
        Me.gbSine.TabStop = False
        '
        'cbxSine
        '
        Me.cbxSine.AutoSize = True
        Me.cbxSine.Location = New System.Drawing.Point(7, 0)
        Me.cbxSine.Name = "cbxSine"
        Me.cbxSine.Size = New System.Drawing.Size(147, 21)
        Me.cbxSine.TabIndex = 21
        Me.cbxSine.Text = "Sine Displacement"
        Me.cbxSine.UseVisualStyleBackColor = True
        '
        'lblCaption2
        '
        Me.lblCaption2.AutoSize = True
        Me.lblCaption2.Location = New System.Drawing.Point(14, 99)
        Me.lblCaption2.Name = "lblCaption2"
        Me.lblCaption2.Size = New System.Drawing.Size(46, 17)
        Me.lblCaption2.TabIndex = 20
        Me.lblCaption2.Text = "Cycle:"
        '
        'lblCycleMax
        '
        Me.lblCycleMax.AutoSize = True
        Me.lblCycleMax.Location = New System.Drawing.Point(246, 151)
        Me.lblCycleMax.Name = "lblCycleMax"
        Me.lblCycleMax.Size = New System.Drawing.Size(24, 17)
        Me.lblCycleMax.TabIndex = 19
        Me.lblCycleMax.Text = "10"
        '
        'lblCycleMin
        '
        Me.lblCycleMin.AutoSize = True
        Me.lblCycleMin.Location = New System.Drawing.Point(23, 151)
        Me.lblCycleMin.Name = "lblCycleMin"
        Me.lblCycleMin.Size = New System.Drawing.Size(16, 17)
        Me.lblCycleMin.TabIndex = 18
        Me.lblCycleMin.Text = "0"
        '
        'lblCycle
        '
        Me.lblCycle.Location = New System.Drawing.Point(281, 123)
        Me.lblCycle.Name = "lblCycle"
        Me.lblCycle.Size = New System.Drawing.Size(36, 15)
        Me.lblCycle.TabIndex = 17
        Me.lblCycle.Text = "0"
        Me.lblCycle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbCycle
        '
        Me.tbCycle.Location = New System.Drawing.Point(14, 118)
        Me.tbCycle.Name = "tbCycle"
        Me.tbCycle.Size = New System.Drawing.Size(260, 56)
        Me.tbCycle.TabIndex = 16
        '
        'lblCaption1
        '
        Me.lblCaption1.AutoSize = True
        Me.lblCaption1.Location = New System.Drawing.Point(14, 22)
        Me.lblCaption1.Name = "lblCaption1"
        Me.lblCaption1.Size = New System.Drawing.Size(74, 17)
        Me.lblCaption1.TabIndex = 15
        Me.lblCaption1.Text = "Amplitude:"
        '
        'gbRandom
        '
        Me.gbRandom.Controls.Add(Me.cbxRandom)
        Me.gbRandom.Controls.Add(Me.lblCaption4)
        Me.gbRandom.Controls.Add(Me.lblPeriodMin)
        Me.gbRandom.Controls.Add(Me.lblPeriodMax)
        Me.gbRandom.Controls.Add(Me.lblPeriod)
        Me.gbRandom.Controls.Add(Me.tbPeriod)
        Me.gbRandom.Controls.Add(Me.lblCaption3)
        Me.gbRandom.Controls.Add(Me.lblFreqMin)
        Me.gbRandom.Controls.Add(Me.lblFreqMax)
        Me.gbRandom.Controls.Add(Me.lblOffset)
        Me.gbRandom.Controls.Add(Me.tbOffset)
        Me.gbRandom.Location = New System.Drawing.Point(14, 210)
        Me.gbRandom.Name = "gbRandom"
        Me.gbRandom.Size = New System.Drawing.Size(324, 182)
        Me.gbRandom.TabIndex = 21
        Me.gbRandom.TabStop = False
        '
        'cbxRandom
        '
        Me.cbxRandom.AutoSize = True
        Me.cbxRandom.Location = New System.Drawing.Point(7, 0)
        Me.cbxRandom.Name = "cbxRandom"
        Me.cbxRandom.Size = New System.Drawing.Size(172, 21)
        Me.cbxRandom.TabIndex = 22
        Me.cbxRandom.Text = "Random Displacement"
        Me.cbxRandom.UseVisualStyleBackColor = True
        '
        'lblCaption4
        '
        Me.lblCaption4.AutoSize = True
        Me.lblCaption4.Location = New System.Drawing.Point(14, 99)
        Me.lblCaption4.Name = "lblCaption4"
        Me.lblCaption4.Size = New System.Drawing.Size(53, 17)
        Me.lblCaption4.TabIndex = 25
        Me.lblCaption4.Text = "Period:"
        '
        'lblPeriodMin
        '
        Me.lblPeriodMin.AutoSize = True
        Me.lblPeriodMin.Location = New System.Drawing.Point(18, 151)
        Me.lblPeriodMin.Name = "lblPeriodMin"
        Me.lblPeriodMin.Size = New System.Drawing.Size(16, 17)
        Me.lblPeriodMin.TabIndex = 23
        Me.lblPeriodMin.Text = "0"
        '
        'lblPeriodMax
        '
        Me.lblPeriodMax.AutoSize = True
        Me.lblPeriodMax.Location = New System.Drawing.Point(241, 151)
        Me.lblPeriodMax.Name = "lblPeriodMax"
        Me.lblPeriodMax.Size = New System.Drawing.Size(24, 17)
        Me.lblPeriodMax.TabIndex = 24
        Me.lblPeriodMax.Text = "10"
        '
        'lblPeriod
        '
        Me.lblPeriod.Location = New System.Drawing.Point(276, 123)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(36, 15)
        Me.lblPeriod.TabIndex = 22
        Me.lblPeriod.Text = "0"
        Me.lblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbPeriod
        '
        Me.tbPeriod.Location = New System.Drawing.Point(10, 118)
        Me.tbPeriod.Name = "tbPeriod"
        Me.tbPeriod.Size = New System.Drawing.Size(259, 56)
        Me.tbPeriod.TabIndex = 21
        '
        'lblCaption3
        '
        Me.lblCaption3.AutoSize = True
        Me.lblCaption3.Location = New System.Drawing.Point(14, 22)
        Me.lblCaption3.Name = "lblCaption3"
        Me.lblCaption3.Size = New System.Drawing.Size(50, 17)
        Me.lblCaption3.TabIndex = 20
        Me.lblCaption3.Text = "Offset:"
        '
        'frmMelt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(365, 446)
        Me.Controls.Add(Me.gbRandom)
        Me.Controls.Add(Me.gbSine)
        Me.Controls.Add(Me.btnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMelt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Melt Effect"
        CType(Me.tbAmplitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOffset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSine.ResumeLayout(False)
        Me.gbSine.PerformLayout()
        CType(Me.tbCycle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRandom.ResumeLayout(False)
        Me.gbRandom.PerformLayout()
        CType(Me.tbPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public settings As MeltSettings

    Public Sub New(ByVal settings As MeltSettings)
        Me.New()
        Me.settings = settings
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        settings.useSine = cbxSine.Checked
        settings.amplitude = tbAmplitude.Value
        settings.cycle = tbCycle.Value
        settings.useRandom = cbxRandom.Checked
        settings.offset = tbOffset.Value
        settings.period = tbPeriod.Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub tbAmplitude_Updated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbAmplitude.ValueChanged, tbAmplitude.Scroll
        lblAmplitude.Text = tbAmplitude.Value
    End Sub

    Private Sub tbCycle_Updated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbCycle.ValueChanged, tbCycle.Scroll
        lblCycle.Text = tbCycle.Value
    End Sub

    Private Sub tbOffset_Updated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbOffset.ValueChanged, tbOffset.Scroll
        lblOffset.Text = tbOffset.Value
    End Sub

    Private Sub tbPeriod_Updated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbPeriod.ValueChanged, tbPeriod.Scroll
        lblPeriod.Text = tbPeriod.Value
    End Sub

    Private Sub frmRipple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbxSine.Checked = settings.useSine
        tbAmplitude.Value = settings.amplitude
        tbCycle.Value = settings.cycle
        cbxRandom.Checked = settings.useRandom
        tbOffset.Value = settings.offset
        tbPeriod.Value = settings.period
    End Sub

End Class
