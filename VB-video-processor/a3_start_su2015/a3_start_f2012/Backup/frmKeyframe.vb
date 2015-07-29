Public Class frmKeyframe
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
    Public WithEvents lblThrMax As System.Windows.Forms.Label
    Public WithEvents lblThrMin As System.Windows.Forms.Label
    Public WithEvents lblThreshold As System.Windows.Forms.Label
    Private WithEvents tbThreshold As System.Windows.Forms.TrackBar
    Public WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents gbKeyframe As System.Windows.Forms.GroupBox
    Public WithEvents lblCaption1 As System.Windows.Forms.Label
    Public WithEvents lblCaption2 As System.Windows.Forms.Label
    Public WithEvents lblSimMax As System.Windows.Forms.Label
    Public WithEvents lblSimMin As System.Windows.Forms.Label
    Public WithEvents lblSimilarity As System.Windows.Forms.Label
    Private WithEvents tbSimilarity As System.Windows.Forms.TrackBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblThrMax = New System.Windows.Forms.Label
        Me.lblThrMin = New System.Windows.Forms.Label
        Me.lblThreshold = New System.Windows.Forms.Label
        Me.tbThreshold = New System.Windows.Forms.TrackBar
        Me.btnApply = New System.Windows.Forms.Button
        Me.gbKeyframe = New System.Windows.Forms.GroupBox
        Me.lblCaption2 = New System.Windows.Forms.Label
        Me.lblSimMax = New System.Windows.Forms.Label
        Me.lblSimMin = New System.Windows.Forms.Label
        Me.lblSimilarity = New System.Windows.Forms.Label
        Me.tbSimilarity = New System.Windows.Forms.TrackBar
        Me.lblCaption1 = New System.Windows.Forms.Label
        CType(Me.tbThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbKeyframe.SuspendLayout()
        CType(Me.tbSimilarity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblThrMax
        '
        Me.lblThrMax.AutoSize = True
        Me.lblThrMax.Location = New System.Drawing.Point(199, 64)
        Me.lblThrMax.Name = "lblThrMax"
        Me.lblThrMax.Size = New System.Drawing.Size(33, 13)
        Me.lblThrMax.TabIndex = 14
        Me.lblThrMax.Text = "100%"
        '
        'lblThrMin
        '
        Me.lblThrMin.AutoSize = True
        Me.lblThrMin.Location = New System.Drawing.Point(19, 64)
        Me.lblThrMin.Name = "lblThrMin"
        Me.lblThrMin.Size = New System.Drawing.Size(13, 13)
        Me.lblThrMin.TabIndex = 13
        Me.lblThrMin.Text = "0"
        '
        'lblThreshold
        '
        Me.lblThreshold.Location = New System.Drawing.Point(224, 40)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(40, 13)
        Me.lblThreshold.TabIndex = 12
        Me.lblThreshold.Text = "0%"
        Me.lblThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbThreshold
        '
        Me.tbThreshold.Location = New System.Drawing.Point(12, 35)
        Me.tbThreshold.Maximum = 100
        Me.tbThreshold.Name = "tbThreshold"
        Me.tbThreshold.Size = New System.Drawing.Size(216, 42)
        Me.tbThreshold.TabIndex = 10
        Me.tbThreshold.TickFrequency = 10
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(107, 182)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(80, 24)
        Me.btnApply.TabIndex = 9
        Me.btnApply.Text = "Apply"
        '
        'gbKeyframe
        '
        Me.gbKeyframe.Controls.Add(Me.lblCaption2)
        Me.gbKeyframe.Controls.Add(Me.lblSimMax)
        Me.gbKeyframe.Controls.Add(Me.lblSimMin)
        Me.gbKeyframe.Controls.Add(Me.lblSimilarity)
        Me.gbKeyframe.Controls.Add(Me.tbSimilarity)
        Me.gbKeyframe.Controls.Add(Me.lblCaption1)
        Me.gbKeyframe.Controls.Add(Me.lblThrMax)
        Me.gbKeyframe.Controls.Add(Me.lblThrMin)
        Me.gbKeyframe.Controls.Add(Me.lblThreshold)
        Me.gbKeyframe.Controls.Add(Me.tbThreshold)
        Me.gbKeyframe.Location = New System.Drawing.Point(12, 12)
        Me.gbKeyframe.Name = "gbKeyframe"
        Me.gbKeyframe.Size = New System.Drawing.Size(270, 158)
        Me.gbKeyframe.TabIndex = 20
        Me.gbKeyframe.TabStop = False
        '
        'lblCaption2
        '
        Me.lblCaption2.AutoSize = True
        Me.lblCaption2.Location = New System.Drawing.Point(12, 86)
        Me.lblCaption2.Name = "lblCaption2"
        Me.lblCaption2.Size = New System.Drawing.Size(152, 13)
        Me.lblCaption2.TabIndex = 20
        Me.lblCaption2.Text = "Percentage of Image Similarity:"
        '
        'lblSimMax
        '
        Me.lblSimMax.AutoSize = True
        Me.lblSimMax.Location = New System.Drawing.Point(199, 131)
        Me.lblSimMax.Name = "lblSimMax"
        Me.lblSimMax.Size = New System.Drawing.Size(33, 13)
        Me.lblSimMax.TabIndex = 19
        Me.lblSimMax.Text = "100%"
        '
        'lblSimMin
        '
        Me.lblSimMin.AutoSize = True
        Me.lblSimMin.Location = New System.Drawing.Point(19, 131)
        Me.lblSimMin.Name = "lblSimMin"
        Me.lblSimMin.Size = New System.Drawing.Size(13, 13)
        Me.lblSimMin.TabIndex = 18
        Me.lblSimMin.Text = "0"
        '
        'lblSimilarity
        '
        Me.lblSimilarity.Location = New System.Drawing.Point(224, 107)
        Me.lblSimilarity.Name = "lblSimilarity"
        Me.lblSimilarity.Size = New System.Drawing.Size(40, 13)
        Me.lblSimilarity.TabIndex = 17
        Me.lblSimilarity.Text = "0%"
        Me.lblSimilarity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbSimilarity
        '
        Me.tbSimilarity.Location = New System.Drawing.Point(12, 102)
        Me.tbSimilarity.Maximum = 100
        Me.tbSimilarity.Name = "tbSimilarity"
        Me.tbSimilarity.Size = New System.Drawing.Size(216, 42)
        Me.tbSimilarity.TabIndex = 16
        Me.tbSimilarity.TickFrequency = 10
        '
        'lblCaption1
        '
        Me.lblCaption1.AutoSize = True
        Me.lblCaption1.Location = New System.Drawing.Point(12, 19)
        Me.lblCaption1.Name = "lblCaption1"
        Me.lblCaption1.Size = New System.Drawing.Size(125, 13)
        Me.lblCaption1.TabIndex = 15
        Me.lblCaption1.Text = "Pixel Similarity Threshold:"
        '
        'frmKeyframe
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(294, 217)
        Me.Controls.Add(Me.gbKeyframe)
        Me.Controls.Add(Me.btnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKeyframe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Keyframe Extraction"
        CType(Me.tbThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbKeyframe.ResumeLayout(False)
        Me.gbKeyframe.PerformLayout()
        CType(Me.tbSimilarity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public settings As KeyframeSettings

    Public Sub New(ByVal settings As KeyframeSettings)
        Me.New()
        Me.settings = settings
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        settings.threshold = tbThreshold.Value / 100.0#
        settings.similarity = tbSimilarity.Value / 100.0#
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub tbThreshold_Updated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbThreshold.ValueChanged, tbThreshold.Scroll
        lblThreshold.Text = tbThreshold.Value & "%"
    End Sub

    Private Sub tbSimilarity_Updated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbSimilarity.ValueChanged, tbSimilarity.Scroll
        lblSimilarity.Text = tbSimilarity.Value & "%"
    End Sub

    Private Sub frmRipple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbThreshold.Value = settings.threshold * 100
        tbSimilarity.Value = settings.similarity * 100
    End Sub

End Class
