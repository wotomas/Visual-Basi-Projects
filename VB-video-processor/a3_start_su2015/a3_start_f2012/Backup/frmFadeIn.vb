Public Class frmFadeIn
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
    Public WithEvents btnApply As System.Windows.Forms.Button
    Private WithEvents tbStartRate As System.Windows.Forms.TrackBar
    Public WithEvents lblMin As System.Windows.Forms.Label
    Public WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents gbStartRate As System.Windows.Forms.GroupBox
    Public WithEvents lblStartRate As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnApply = New System.Windows.Forms.Button
        Me.tbStartRate = New System.Windows.Forms.TrackBar
        Me.lblStartRate = New System.Windows.Forms.Label
        Me.lblMin = New System.Windows.Forms.Label
        Me.lblMax = New System.Windows.Forms.Label
        Me.gbStartRate = New System.Windows.Forms.GroupBox
        CType(Me.tbStartRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStartRate.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnApply.Location = New System.Drawing.Point(107, 100)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(80, 24)
        Me.btnApply.TabIndex = 3
        Me.btnApply.Text = "Apply"
        '
        'tbStartRate
        '
        Me.tbStartRate.Location = New System.Drawing.Point(12, 19)
        Me.tbStartRate.Maximum = 100
        Me.tbStartRate.Name = "tbStartRate"
        Me.tbStartRate.Size = New System.Drawing.Size(216, 42)
        Me.tbStartRate.TabIndex = 4
        Me.tbStartRate.TickFrequency = 10
        '
        'lblStartRate
        '
        Me.lblStartRate.Location = New System.Drawing.Point(234, 24)
        Me.lblStartRate.Name = "lblStartRate"
        Me.lblStartRate.Size = New System.Drawing.Size(30, 13)
        Me.lblStartRate.TabIndex = 6
        Me.lblStartRate.Text = "0%"
        Me.lblStartRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(16, 48)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(21, 13)
        Me.lblMin.TabIndex = 7
        Me.lblMin.Text = "0%"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(199, 48)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(33, 13)
        Me.lblMax.TabIndex = 8
        Me.lblMax.Text = "100%"
        Me.lblMax.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbStartRate
        '
        Me.gbStartRate.Controls.Add(Me.lblMin)
        Me.gbStartRate.Controls.Add(Me.lblMax)
        Me.gbStartRate.Controls.Add(Me.tbStartRate)
        Me.gbStartRate.Controls.Add(Me.lblStartRate)
        Me.gbStartRate.Location = New System.Drawing.Point(12, 12)
        Me.gbStartRate.Name = "gbStartRate"
        Me.gbStartRate.Size = New System.Drawing.Size(270, 76)
        Me.gbStartRate.TabIndex = 9
        Me.gbStartRate.TabStop = False
        Me.gbStartRate.Text = "Start Rate"
        '
        'frmFadeIn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(294, 137)
        Me.Controls.Add(Me.gbStartRate)
        Me.Controls.Add(Me.btnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFadeIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fade In Effect"
        CType(Me.tbStartRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbStartRate.ResumeLayout(False)
        Me.gbStartRate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public settings As FadeInSettings

    Public Sub New(ByVal settings As FadeInSettings)
        Me.New()
        Me.settings = settings
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        settings.startRate = tbStartRate.Value / 100.0#
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub tbStartRate_Updated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbStartRate.ValueChanged, tbStartRate.Scroll
        lblStartRate.Text = CStr(tbStartRate.Value) + "%"
    End Sub

    Private Sub frmFadeIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbStartRate.Value = CInt(settings.startRate * 100.0#)
    End Sub
End Class
