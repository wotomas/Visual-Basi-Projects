Public Class frmFadeOut
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
    Public WithEvents btnApply As System.Windows.Forms.Button
    Public WithEvents lblMax As System.Windows.Forms.Label
    Public WithEvents lblMin As System.Windows.Forms.Label
    Public WithEvents lblEndRate As System.Windows.Forms.Label
    Friend WithEvents gbEndRate As System.Windows.Forms.GroupBox
    Private WithEvents tbEndRate As System.Windows.Forms.TrackBar
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnApply = New System.Windows.Forms.Button
        Me.tbEndRate = New System.Windows.Forms.TrackBar
        Me.lblMax = New System.Windows.Forms.Label
        Me.lblMin = New System.Windows.Forms.Label
        Me.lblEndRate = New System.Windows.Forms.Label
        Me.gbEndRate = New System.Windows.Forms.GroupBox
        CType(Me.tbEndRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEndRate.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(107, 100)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(80, 24)
        Me.btnApply.TabIndex = 1
        Me.btnApply.Text = "Apply"
        '
        'tbEndRate
        '
        Me.tbEndRate.Location = New System.Drawing.Point(12, 19)
        Me.tbEndRate.Maximum = 100
        Me.tbEndRate.Name = "tbEndRate"
        Me.tbEndRate.Size = New System.Drawing.Size(216, 42)
        Me.tbEndRate.TabIndex = 3
        Me.tbEndRate.TickFrequency = 10
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(199, 48)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(33, 13)
        Me.lblMax.TabIndex = 12
        Me.lblMax.Text = "100%"
        Me.lblMax.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(16, 48)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(21, 13)
        Me.lblMin.TabIndex = 11
        Me.lblMin.Text = "0%"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEndRate
        '
        Me.lblEndRate.Location = New System.Drawing.Point(234, 24)
        Me.lblEndRate.Name = "lblEndRate"
        Me.lblEndRate.Size = New System.Drawing.Size(30, 13)
        Me.lblEndRate.TabIndex = 10
        Me.lblEndRate.Text = "0%"
        Me.lblEndRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbEndRate
        '
        Me.gbEndRate.Controls.Add(Me.lblMin)
        Me.gbEndRate.Controls.Add(Me.lblMax)
        Me.gbEndRate.Controls.Add(Me.tbEndRate)
        Me.gbEndRate.Controls.Add(Me.lblEndRate)
        Me.gbEndRate.Location = New System.Drawing.Point(12, 12)
        Me.gbEndRate.Name = "gbEndRate"
        Me.gbEndRate.Size = New System.Drawing.Size(270, 76)
        Me.gbEndRate.TabIndex = 13
        Me.gbEndRate.TabStop = False
        Me.gbEndRate.Text = "End Rate"
        '
        'frmFadeOut
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(294, 137)
        Me.Controls.Add(Me.gbEndRate)
        Me.Controls.Add(Me.btnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFadeOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fade Out Effect"
        CType(Me.tbEndRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEndRate.ResumeLayout(False)
        Me.gbEndRate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Public settings As FadeOutSettings

    Public Sub New(ByVal settings As FadeOutSettings)
        Me.New()
        Me.settings = settings
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        settings.endRate = tbEndRate.Value / 100.0#
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub tbEndRate_Updated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbEndRate.ValueChanged, tbEndRate.Scroll
        lblEndRate.Text = CStr(tbEndRate.Value) + "%"
    End Sub

    Private Sub frmFadeOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbEndRate.Value = CInt(settings.endRate * 100.0#)
    End Sub
End Class