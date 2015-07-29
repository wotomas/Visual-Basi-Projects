Public Class frmMotionBlur
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
    Public WithEvents lblMax As System.Windows.Forms.Label
    Public WithEvents lblMin As System.Windows.Forms.Label
    Public WithEvents lblBlurCount As System.Windows.Forms.Label
    Private WithEvents tbBlurCount As System.Windows.Forms.TrackBar
    Friend WithEvents gbBlurCount As System.Windows.Forms.GroupBox
    Public WithEvents btnApply As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblMax = New System.Windows.Forms.Label
        Me.lblMin = New System.Windows.Forms.Label
        Me.lblBlurCount = New System.Windows.Forms.Label
        Me.tbBlurCount = New System.Windows.Forms.TrackBar
        Me.btnApply = New System.Windows.Forms.Button
        Me.gbBlurCount = New System.Windows.Forms.GroupBox
        CType(Me.tbBlurCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBlurCount.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(205, 48)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(19, 13)
        Me.lblMax.TabIndex = 14
        Me.lblMax.Text = "30"
        Me.lblMax.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(19, 48)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(13, 13)
        Me.lblMin.TabIndex = 13
        Me.lblMin.Text = "1"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBlurCount
        '
        Me.lblBlurCount.Location = New System.Drawing.Point(234, 24)
        Me.lblBlurCount.Name = "lblBlurCount"
        Me.lblBlurCount.Size = New System.Drawing.Size(30, 13)
        Me.lblBlurCount.TabIndex = 12
        Me.lblBlurCount.Text = "0"
        Me.lblBlurCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbBlurCount
        '
        Me.tbBlurCount.Location = New System.Drawing.Point(12, 19)
        Me.tbBlurCount.Maximum = 30
        Me.tbBlurCount.Minimum = 1
        Me.tbBlurCount.Name = "tbBlurCount"
        Me.tbBlurCount.Size = New System.Drawing.Size(216, 42)
        Me.tbBlurCount.TabIndex = 10
        Me.tbBlurCount.Value = 1
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(107, 100)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(80, 24)
        Me.btnApply.TabIndex = 9
        Me.btnApply.Text = "Apply"
        '
        'gbBlurCount
        '
        Me.gbBlurCount.Controls.Add(Me.lblMin)
        Me.gbBlurCount.Controls.Add(Me.lblMax)
        Me.gbBlurCount.Controls.Add(Me.tbBlurCount)
        Me.gbBlurCount.Controls.Add(Me.lblBlurCount)
        Me.gbBlurCount.Location = New System.Drawing.Point(12, 12)
        Me.gbBlurCount.Name = "gbBlurCount"
        Me.gbBlurCount.Size = New System.Drawing.Size(270, 76)
        Me.gbBlurCount.TabIndex = 15
        Me.gbBlurCount.TabStop = False
        Me.gbBlurCount.Text = "Number of Frames to Blur"
        '
        'frmMotionBlur
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(294, 137)
        Me.Controls.Add(Me.gbBlurCount)
        Me.Controls.Add(Me.btnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMotionBlur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Motion Blur Effect"
        CType(Me.tbBlurCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBlurCount.ResumeLayout(False)
        Me.gbBlurCount.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public settings As MotionBlurSettings

    Public Sub New(ByVal settings As MotionBlurSettings)
        Me.New()
        Me.settings = settings
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        settings.blurCount = tbBlurCount.Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub tbBlurCount_Updated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbBlurCount.ValueChanged, tbBlurCount.Scroll
        lblBlurCount.Text = tbBlurCount.Value
    End Sub

    Private Sub frmMotionBlur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbBlurCount.Value = settings.blurCount
    End Sub
End Class
