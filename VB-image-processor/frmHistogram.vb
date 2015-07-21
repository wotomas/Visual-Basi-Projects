Public Class frmHistogram
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
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents lblPlanes As System.Windows.Forms.Label
    Friend WithEvents cboPlane As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picHistogram As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.picHistogram = New System.Windows.Forms.PictureBox()
        Me.lblPlanes = New System.Windows.Forms.Label()
        Me.cboPlane = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picHistogram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(14, 206)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(117, 29)
        Me.btnShow.TabIndex = 8
        Me.btnShow.Text = "Auto Contrast"
        '
        'picHistogram
        '
        Me.picHistogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picHistogram.Location = New System.Drawing.Point(14, 52)
        Me.picHistogram.Name = "picHistogram"
        Me.picHistogram.Size = New System.Drawing.Size(324, 148)
        Me.picHistogram.TabIndex = 10
        Me.picHistogram.TabStop = False
        '
        'lblPlanes
        '
        Me.lblPlanes.AutoSize = True
        Me.lblPlanes.Location = New System.Drawing.Point(14, 17)
        Me.lblPlanes.Name = "lblPlanes"
        Me.lblPlanes.Size = New System.Drawing.Size(92, 17)
        Me.lblPlanes.TabIndex = 12
        Me.lblPlanes.Text = "Histogram of:"
        '
        'cboPlane
        '
        Me.cboPlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlane.FormattingEnabled = True
        Me.cboPlane.Items.AddRange(New Object() {"Value", "Red", "Green", "Blue"})
        Me.cboPlane.Location = New System.Drawing.Point(104, 14)
        Me.cboPlane.Name = "cboPlane"
        Me.cboPlane.Size = New System.Drawing.Size(234, 24)
        Me.cboPlane.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 13
        '
        'frmHistogram
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(350, 242)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPlanes)
        Me.Controls.Add(Me.cboPlane)
        Me.Controls.Add(Me.picHistogram)
        Me.Controls.Add(Me.btnShow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHistogram"
        Me.Text = "Histogram"
        CType(Me.picHistogram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Histogram(0 To 255) As Integer
    Private maxLight As Integer = 0
    Private minLight As Integer = 255
    Private autoContrastFlag As Boolean = False

    Private Sub frmHistogram_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboPlane.SelectedIndex = 0
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

        ' Clear the histogram using Array.Clear here

        For start As Integer = 0 To 255
            If Histogram(start) <> 0 Then
                minLight = start
                Exit For
            End If
        Next

        For start As Integer = -255 To 0
            start *= -1
            If Histogram(start) <> 0 Then
                maxLight = start
                Exit For
            End If
            start *= -1
        Next

        autoContrastFlag = True
        'MsgBox("Min Light: " + minLight.ToString + " Max Light: " + maxLight.ToString)

        ApplyEffect()
        autoContrastFlag = False
        Array.Clear(Histogram, 0, 256)
        ApplyEffect()
        picHistogram.Refresh()
    End Sub

    Overrides Function Process(ByRef image As Bitmap, ByVal x As Integer, ByVal y As Integer) As Color
        Dim testImage As Color = image.GetPixel(x, y)

        If autoContrastFlag Then
            Dim expansion As Double = 255.0 / (maxLight - minLight)
            Dim red As Integer = testImage.R
            Dim green As Integer = testImage.G
            Dim blue As Integer = testImage.B
            Dim light As Integer = 0

            light = (red + green + blue) / 3
            'MsgBox("1st: " + light.ToString)
            light = Math.Floor(CDbl(light - minLight) * expansion)
            'MsgBox("2nd: " + light.ToString)
            light = Math.Max(0, Math.Min(light, 255))
            'MsgBox("3rd: " + light.ToString)

            image.SetPixel(x, y, Color.FromArgb(light, light, light))

            Return Color.FromArgb(light, light, light)

        Else
            ' Count the histogram using the selected colour plane here
            ' Note: there are 256 boxes in the histogram
            If cboPlane.SelectedIndex = 0 Then
                Dim red As Integer = testImage.R
                Dim green As Integer = testImage.G
                Dim blue As Integer = testImage.B

                Dim grayscale As Integer = (red + green + blue) / 3
                Histogram(grayscale) += 1
            ElseIf cboPlane.SelectedIndex = 1 Then
                Dim red As Integer = testImage.R
                Histogram(red) += 1
            ElseIf cboPlane.SelectedIndex = 2 Then
                Dim green As Integer = testImage.G
                Histogram(green) += 1
            ElseIf cboPlane.SelectedIndex = 3 Then
                Dim blue As Integer = testImage.B
                Histogram(blue) += 1
            Else
                MsgBox("Out of Bound")
            End If
            Return testImage
        End If




    End Function

    Private Sub picHistogram_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picHistogram.Paint
        Dim g As Graphics = e.Graphics()
        g.Clear(Color.White)

        Dim max As Integer = 0
        Dim i As Integer
        For i = 0 To 255
            If Histogram(i) > max Then
                max = Histogram(i)
            End If
        Next

        If max > 0 Then
            Dim x As Integer, y As Integer
            For x = 0 To picHistogram.ClientRectangle.Width - 1
                y = (1.0# - Histogram(x / (picHistogram.ClientRectangle.Width - 1) * 255) / max) * (picHistogram.ClientRectangle.Height - 1)
                g.DrawLine(Pens.Black, x, picHistogram.ClientRectangle.Height - 1, x, y)
            Next
        End If
    End Sub

    Private Sub cboPlane_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPlane.SelectedIndexChanged
        ' Clear the histogram using Array.Clear here
        'Label1.Text = cboPlane.SelectedIndex
        If cboPlane.SelectedIndex <> 0 Then
            btnShow.Enabled = False
        Else
            btnShow.Enabled = True
        End If
        Array.Clear(Histogram, 0, 256)
        ApplyEffect()

        picHistogram.Refresh()
    End Sub
End Class
