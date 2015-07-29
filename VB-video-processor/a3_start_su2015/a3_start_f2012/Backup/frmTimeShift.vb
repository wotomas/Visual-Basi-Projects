Public Class frmTimeShift
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
    Friend WithEvents lblCaption2 As System.Windows.Forms.Label
    Private WithEvents tbCutOff As System.Windows.Forms.TrackBar
    Public WithEvents cmdApply As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblMax = New System.Windows.Forms.Label
        Me.lblMin = New System.Windows.Forms.Label
        Me.lblCaption2 = New System.Windows.Forms.Label
        Me.tbCutOff = New System.Windows.Forms.TrackBar
        Me.cmdApply = New System.Windows.Forms.Button
        CType(Me.tbCutOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(225, 57)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(33, 13)
        Me.lblMax.TabIndex = 14
        Me.lblMax.Text = "100%"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(12, 57)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(21, 13)
        Me.lblMin.TabIndex = 13
        Me.lblMin.Text = "0%"
        '
        'lblCaption2
        '
        Me.lblCaption2.AutoSize = True
        Me.lblCaption2.Location = New System.Drawing.Point(9, 9)
        Me.lblCaption2.Name = "lblCaption2"
        Me.lblCaption2.Size = New System.Drawing.Size(84, 13)
        Me.lblCaption2.TabIndex = 11
        Me.lblCaption2.Text = "Cut-off Position: "
        '
        'tbCutOff
        '
        Me.tbCutOff.Location = New System.Drawing.Point(12, 25)
        Me.tbCutOff.Maximum = 100
        Me.tbCutOff.Name = "tbCutOff"
        Me.tbCutOff.Size = New System.Drawing.Size(240, 45)
        Me.tbCutOff.TabIndex = 10
        Me.tbCutOff.TickFrequency = 10
        Me.tbCutOff.Value = 5
        '
        'cmdApply
        '
        Me.cmdApply.BackColor = System.Drawing.SystemColors.Control
        Me.cmdApply.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdApply.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdApply.Location = New System.Drawing.Point(12, 86)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdApply.Size = New System.Drawing.Size(240, 30)
        Me.cmdApply.TabIndex = 9
        Me.cmdApply.Text = "Apply"
        Me.cmdApply.UseVisualStyleBackColor = False
        '
        'frmTimeShift
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(276, 130)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblCaption2)
        Me.Controls.Add(Me.tbCutOff)
        Me.Controls.Add(Me.cmdApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTimeShift"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transition Effect"
        CType(Me.tbCutOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public settings As TimeShiftSettings

    Public Sub New(ByVal settings As TimeShiftSettings)
        Me.New()
        Me.settings = settings
    End Sub

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        settings.cutOffPos = tbCutOff.Value / 100.0#
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmTransition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbCutOff.Value = CInt(settings.cutOffPos * 100.0#)
    End Sub
End Class
