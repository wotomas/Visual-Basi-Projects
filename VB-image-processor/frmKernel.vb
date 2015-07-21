Public Class frmKernel
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
    Friend WithEvents Label1 As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnApply As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(128, 14)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(96, 28)
        Me.btnApply.TabIndex = 8
        Me.btnApply.Text = "Apply"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 9
        '
        'frmKernel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(374, 51)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKernel"
        Me.Text = "Kernel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public kernel(2, 2) As Double            ' The kernel (default: 3x3 matrix. Will be changed when you load your kernel.)
    Public kernel_width As Integer           ' The kernel width
    Public kernel_height As Integer          ' The kernel height

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        ' Load image file and convert it into kernel before applying the effect
        Dim dlg As New OpenFileDialog

        dlg.Filter = "Image Files (.bmp,.jpg,.png)|*.bmp;*.jpg;*.png"
        dlg.FilterIndex = 1
        dlg.RestoreDirectory = True

        If dlg.ShowDialog() = DialogResult.OK Then
            If Len(dlg.FileName) = 0 Then Exit Sub

            Dim image As Bitmap = New Bitmap(dlg.FileName)

            kernel_width = image.Width
            kernel_height = image.Height
            ReDim kernel(kernel_width - 1, kernel_height - 1)

            Dim totalSum As Double

            'load image brightness to kernel
            totalSum = 0
            For y As Integer = 0 To (image.Height - 1)
                For x As Integer = 0 To (image.Width - 1)
                    kernel(x, y) = image.GetPixel(x, y).GetBrightness()
                    totalSum += kernel(x, y)
                Next
            Next

            'normalize the kernel
            If (totalSum > 0.0001) Then
                For y As Integer = 0 To (image.Height - 1)
                    For x As Integer = 0 To (image.Width - 1)
                        kernel(x, y) = kernel(x, y) / totalSum
                    Next
                Next
            End If

            ApplyEffect()

        End If
    End Sub

    Overrides Function Process(ByRef image As Bitmap, ByVal x As Integer, ByVal y As Integer) As Color

        'Convolute your image by using the 'kernel' defined in this form
        'The size of the kernel is kernel_width x kernel_height
        'Hint: Use nested for-loop (2 level) to loop through the kernel

        'For your convenience, the excrept of the declaration is here:
		'================================================================
	    'Public kernel(2, 2) As Double            ' The kernel (default: 3x3 matrix. Will be changed when you load your kernel.)
		'Public kernel_width As Integer           ' The kernel width
		'Public kernel_height As Integer          ' The kernel height
		'================================================================

		'Q) How to define filter center when you encounter even number for the kernel width/height?
		'A) Use the following equations to calculate the filter center:
		'Dim cx As Integer = Math.Floor(kernel_width / 2.0)
        'Dim cy As Integer = Math.Floor(kernel_height / 2.0)
        Dim red As Integer = 0
        Dim green As Integer = 0
        Dim blue As Integer = 0


        For width As Integer = 0 To kernel_width - 1
            For height As Integer = 0 To kernel_height - 1
                Dim pixel As Color = GetPixel(image, x - Math.Floor(kernel_width / 2.0) + width, y - Math.Floor(kernel_height / 2.0) + height)
                red += pixel.R * kernel(width, height)
                green += pixel.G * kernel(width, height)
                blue += pixel.B * kernel(width, height)
            Next
        Next


        Dim pixColor As Color = Color.FromArgb(red, green, blue)
        
        'Your code here
        Return pixColor

    End Function

    ' This function gets a pixel from the image without going out of bounds
    Private Function GetPixel(ByRef image As Bitmap, ByVal x As Integer, ByVal y As Integer) As Color
        If x < 0 Then
            x = 0
        ElseIf x > image.Width - 1 Then
            x = image.Width - 1
        End If
        If y < 0 Then
            y = 0
        ElseIf y > image.Height - 1 Then
            y = image.Height - 1
        End If
        Return image.GetPixel(x, y)
    End Function
End Class
