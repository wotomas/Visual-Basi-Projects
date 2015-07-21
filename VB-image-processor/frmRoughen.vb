Public Class frmRoughen
    Inherits frmEffect

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
    Friend WithEvents gbxRoughen As System.Windows.Forms.GroupBox
    Friend WithEvents lblWeak As System.Windows.Forms.Label
    Friend WithEvents lblMedium As System.Windows.Forms.Label
    Friend WithEvents lblStrong As System.Windows.Forms.Label
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BrightnessCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SaturationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HueCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents tbRoughen As System.Windows.Forms.TrackBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbxRoughen = New System.Windows.Forms.GroupBox()
        Me.lblWeak = New System.Windows.Forms.Label()
        Me.lblMedium = New System.Windows.Forms.Label()
        Me.lblStrong = New System.Windows.Forms.Label()
        Me.tbRoughen = New System.Windows.Forms.TrackBar()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BrightnessCheckBox = New System.Windows.Forms.CheckBox()
        Me.SaturationCheckBox = New System.Windows.Forms.CheckBox()
        Me.HueCheckBox = New System.Windows.Forms.CheckBox()
        Me.gbxRoughen.SuspendLayout()
        CType(Me.tbRoughen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxRoughen
        '
        Me.gbxRoughen.Controls.Add(Me.lblWeak)
        Me.gbxRoughen.Controls.Add(Me.lblMedium)
        Me.gbxRoughen.Controls.Add(Me.lblStrong)
        Me.gbxRoughen.Controls.Add(Me.tbRoughen)
        Me.gbxRoughen.Location = New System.Drawing.Point(14, 14)
        Me.gbxRoughen.Name = "gbxRoughen"
        Me.gbxRoughen.Size = New System.Drawing.Size(324, 90)
        Me.gbxRoughen.TabIndex = 9
        Me.gbxRoughen.TabStop = False
        Me.gbxRoughen.Text = "Strength of Roughen"
        '
        'lblWeak
        '
        Me.lblWeak.AutoSize = True
        Me.lblWeak.Location = New System.Drawing.Point(8, 58)
        Me.lblWeak.Name = "lblWeak"
        Me.lblWeak.Size = New System.Drawing.Size(44, 17)
        Me.lblWeak.TabIndex = 3
        Me.lblWeak.Text = "Weak"
        '
        'lblMedium
        '
        Me.lblMedium.AutoSize = True
        Me.lblMedium.Location = New System.Drawing.Point(109, 58)
        Me.lblMedium.Name = "lblMedium"
        Me.lblMedium.Size = New System.Drawing.Size(57, 17)
        Me.lblMedium.TabIndex = 4
        Me.lblMedium.Text = "Medium"
        '
        'lblStrong
        '
        Me.lblStrong.AutoSize = True
        Me.lblStrong.Location = New System.Drawing.Point(270, 58)
        Me.lblStrong.Name = "lblStrong"
        Me.lblStrong.Size = New System.Drawing.Size(50, 17)
        Me.lblStrong.TabIndex = 5
        Me.lblStrong.Text = "Strong"
        '
        'tbRoughen
        '
        Me.tbRoughen.LargeChange = 10
        Me.tbRoughen.Location = New System.Drawing.Point(14, 22)
        Me.tbRoughen.Maximum = 50
        Me.tbRoughen.Name = "tbRoughen"
        Me.tbRoughen.Size = New System.Drawing.Size(296, 56)
        Me.tbRoughen.TabIndex = 0
        Me.tbRoughen.TickFrequency = 10
        Me.tbRoughen.Value = 10
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(228, 133)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(96, 27)
        Me.btnApply.TabIndex = 8
        Me.btnApply.Text = "Apply"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = " "
        '
        'BrightnessCheckBox
        '
        Me.BrightnessCheckBox.AutoSize = True
        Me.BrightnessCheckBox.Checked = True
        Me.BrightnessCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BrightnessCheckBox.Location = New System.Drawing.Point(14, 110)
        Me.BrightnessCheckBox.Name = "BrightnessCheckBox"
        Me.BrightnessCheckBox.Size = New System.Drawing.Size(97, 21)
        Me.BrightnessCheckBox.TabIndex = 11
        Me.BrightnessCheckBox.Text = "Brightness"
        Me.BrightnessCheckBox.UseVisualStyleBackColor = True
        '
        'SaturationCheckBox
        '
        Me.SaturationCheckBox.AutoSize = True
        Me.SaturationCheckBox.Location = New System.Drawing.Point(14, 137)
        Me.SaturationCheckBox.Name = "SaturationCheckBox"
        Me.SaturationCheckBox.Size = New System.Drawing.Size(95, 21)
        Me.SaturationCheckBox.TabIndex = 12
        Me.SaturationCheckBox.Text = "Saturation"
        Me.SaturationCheckBox.UseVisualStyleBackColor = True
        '
        'HueCheckBox
        '
        Me.HueCheckBox.AutoSize = True
        Me.HueCheckBox.Location = New System.Drawing.Point(14, 164)
        Me.HueCheckBox.Name = "HueCheckBox"
        Me.HueCheckBox.Size = New System.Drawing.Size(56, 21)
        Me.HueCheckBox.TabIndex = 13
        Me.HueCheckBox.Text = "Hue"
        Me.HueCheckBox.UseVisualStyleBackColor = True
        '
        'frmRoughen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(353, 198)
        Me.Controls.Add(Me.HueCheckBox)
        Me.Controls.Add(Me.SaturationCheckBox)
        Me.Controls.Add(Me.BrightnessCheckBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.gbxRoughen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRoughen"
        Me.Text = "Roughen"
        Me.gbxRoughen.ResumeLayout(False)
        Me.gbxRoughen.PerformLayout()
        CType(Me.tbRoughen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        ApplyEffect()
    End Sub

    Overrides Function Process(ByRef image As Bitmap, ByVal x As Integer, ByVal y As Integer) As Color
        Return Roughen(image.GetPixel(x, y), tbRoughen.Value / 100.0#, HueCheckBox.Checked, SaturationCheckBox.Checked, BrightnessCheckBox.Checked)
    End Function

    Private Sub tbRoughen_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRoughen.Scroll
        'Label1.Text = tbRoughen.Value / 100.0#
    End Sub
End Class
