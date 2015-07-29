Public Class frmTransition
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
    Public WithEvents lblMax As System.Windows.Forms.Label
    Public WithEvents lblMin As System.Windows.Forms.Label
    Public WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents lblCaption2 As System.Windows.Forms.Label
    Private WithEvents tbDuration As System.Windows.Forms.TrackBar
    Public WithEvents cmdApply As System.Windows.Forms.Button
    Friend WithEvents lblCaption1 As System.Windows.Forms.Label
    Friend WithEvents cbxType As System.Windows.Forms.ComboBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblMax = New System.Windows.Forms.Label
        Me.lblMin = New System.Windows.Forms.Label
        Me.lblDuration = New System.Windows.Forms.Label
        Me.lblCaption2 = New System.Windows.Forms.Label
        Me.tbDuration = New System.Windows.Forms.TrackBar
        Me.cmdApply = New System.Windows.Forms.Button
        Me.lblCaption1 = New System.Windows.Forms.Label
        Me.cbxType = New System.Windows.Forms.ComboBox
        CType(Me.tbDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(270, 94)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(29, 12)
        Me.lblMax.TabIndex = 14
        Me.lblMax.Text = "100%"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(22, 94)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(17, 12)
        Me.lblMin.TabIndex = 13
        Me.lblMin.Text = "0%"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(313, 72)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(17, 12)
        Me.lblDuration.TabIndex = 12
        Me.lblDuration.Text = "0%"
        '
        'lblCaption2
        '
        Me.lblCaption2.AutoSize = True
        Me.lblCaption2.Location = New System.Drawing.Point(14, 45)
        Me.lblCaption2.Name = "lblCaption2"
        Me.lblCaption2.Size = New System.Drawing.Size(167, 12)
        Me.lblCaption2.TabIndex = 11
        Me.lblCaption2.Text = "Duration of the Transition:"
        '
        'tbDuration
        '
        Me.tbDuration.Location = New System.Drawing.Point(18, 62)
        Me.tbDuration.Maximum = 100
        Me.tbDuration.Name = "tbDuration"
        Me.tbDuration.Size = New System.Drawing.Size(288, 45)
        Me.tbDuration.TabIndex = 10
        Me.tbDuration.TickFrequency = 10
        '
        'cmdApply
        '
        Me.cmdApply.BackColor = System.Drawing.SystemColors.Control
        Me.cmdApply.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdApply.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdApply.Location = New System.Drawing.Point(128, 114)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdApply.Size = New System.Drawing.Size(96, 32)
        Me.cmdApply.TabIndex = 9
        Me.cmdApply.Text = "Apply"
        Me.cmdApply.UseVisualStyleBackColor = False
        '
        'lblCaption1
        '
        Me.lblCaption1.AutoSize = True
        Me.lblCaption1.Location = New System.Drawing.Point(14, 16)
        Me.lblCaption1.Name = "lblCaption1"
        Me.lblCaption1.Size = New System.Drawing.Size(143, 12)
        Me.lblCaption1.TabIndex = 11
        Me.lblCaption1.Text = "Type of the Transition:"
        '
        'cbxType
        '
        Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxType.FormattingEnabled = True
        Me.cbxType.Items.AddRange(New Object() {"Wipe", "Line Dissolve"})
        Me.cbxType.Location = New System.Drawing.Point(157, 13)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(181, 20)
        Me.cbxType.TabIndex = 15
        '
        'frmTransition
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(395, 165)
        Me.Controls.Add(Me.cbxType)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblCaption1)
        Me.Controls.Add(Me.lblCaption2)
        Me.Controls.Add(Me.tbDuration)
        Me.Controls.Add(Me.cmdApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transition Effect"
        CType(Me.tbDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public settings As TransitionSettings

    Public Sub New(ByVal settings As TransitionSettings)
        Me.New()
        Me.settings = settings
    End Sub

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        settings.type = cbxType.SelectedIndex
        settings.duration = tbDuration.Value / 100.0#
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub tbDuration_Updated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDuration.ValueChanged, tbDuration.Scroll
        lblDuration.Text = CStr(tbDuration.Value) + "%"
    End Sub

    Private Sub frmTransition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbxType.SelectedIndex = settings.type
        tbDuration.Value = CInt(settings.duration * 100.0#)
    End Sub
End Class
