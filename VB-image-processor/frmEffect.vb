Public Class frmEffect
    Inherits System.Windows.Forms.Form

    Sub ApplyEffect()
        If Not DirectCast(Me.MdiParent, frmMain).selectedImageForm Is Nothing Then
            Dim selectedImageForm As frmImage = DirectCast(Me.MdiParent, frmMain).selectedImageForm

            If selectedImageForm.selectedArea.IsEmpty() Then
                MsgBox("Please select an area for application of the selected filter")
                Return
            End If

            If selectedImageForm.selectedArea.Width = 0 And selectedImageForm.selectedArea.Height = 0 Then
                selectedImageForm.SelectAll()
            End If
            Dim buffer As Bitmap = selectedImageForm.image.Clone()

            selectedImageForm.RemoveDashRect()

            Dim color As Color
            For y As Integer = selectedImageForm.selectedArea.Top To selectedImageForm.selectedArea.Bottom
                For x As Integer = selectedImageForm.selectedArea.Left To selectedImageForm.selectedArea.Right
                    color = Process(selectedImageForm.image, x, y)
                    buffer.SetPixel(x, y, color)
                Next
            Next

            selectedImageForm.SetPicture(buffer.Clone())
            selectedImageForm.DrawDashRect()
        End If
    End Sub

    Overridable Function Process(ByRef image As Bitmap, ByVal x As Integer, ByVal y As Integer) As Color

    End Function

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'frmEffect
        '
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Name = "frmEffect"
        Me.ResumeLayout(False)

    End Sub

End Class
