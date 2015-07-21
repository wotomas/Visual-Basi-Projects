Public Class frmRipple
    Inherits frmEffect
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MagnitudeTrack As System.Windows.Forms.TrackBar
    Friend WithEvents FrequencyTrack As System.Windows.Forms.TrackBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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

#End Region
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FrequencyTrack = New System.Windows.Forms.TrackBar()
        Me.MagnitudeTrack = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FrequencyTrack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MagnitudeTrack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MagnitudeTrack)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 99)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Magnitude"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FrequencyTrack)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Frequency"
        '
        'FrequencyTrack
        '
        Me.FrequencyTrack.Location = New System.Drawing.Point(7, 22)
        Me.FrequencyTrack.Minimum = 1
        Me.FrequencyTrack.Name = "FrequencyTrack"
        Me.FrequencyTrack.Size = New System.Drawing.Size(389, 56)
        Me.FrequencyTrack.SmallChange = 30
        Me.FrequencyTrack.TabIndex = 0
        Me.FrequencyTrack.Value = 3
        '
        'MagnitudeTrack
        '
        Me.MagnitudeTrack.Location = New System.Drawing.Point(7, 22)
        Me.MagnitudeTrack.Minimum = 1
        Me.MagnitudeTrack.Name = "MagnitudeTrack"
        Me.MagnitudeTrack.Size = New System.Drawing.Size(389, 56)
        Me.MagnitudeTrack.TabIndex = 0
        Me.MagnitudeTrack.Value = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(175, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmRipple
        '
        Me.ClientSize = New System.Drawing.Size(426, 254)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRipple"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FrequencyTrack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MagnitudeTrack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub frmRipple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fImageForm As frmImage

        fImageForm = DirectCast(Me.MdiParent, frmMain).selectedImageForm

        If fImageForm.selectedArea.IsEmpty() Then
            MsgBox("Please select an area for application of the selected filter")
            Return
        End If

        If Not fImageForm Is Nothing Then
            'Console.WriteLine("run")
            Ripple(fImageForm, FrequencyTrack.Value / 100, MagnitudeTrack.Value)
        End If
    End Sub
End Class
