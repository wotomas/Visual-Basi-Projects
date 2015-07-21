Public Class frmBgRemoval
    Inherits frmEffect

    Shared buttonColor As Color
    Private fourMode As Boolean = True
    Private threshold As Double = 0
    Shared seedX As Integer = 0
    Shared seedY As Integer = 0
    Private newImage(2000, 2000) As Color
    Private pixelChangedFlag(2000, 2000) As Boolean
    Private recursionDoneFlag As Boolean = False

    Private Sub frmBgRemoval_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Activated
        Me.colorButton.BackColor = buttonColor
        Label5.Text = "X-Axis: " + seedX.ToString
        Label7.Text = "Y-Axis: " + seedY.ToString
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Label3.Text = TrackBar1.Value
        threshold = TrackBar1.Value
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            fourMode = True
            CheckBox2.Checked = False
        Else
            CheckBox2.Checked = True
            fourMode = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            fourMode = False
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
            fourMode = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim point As Point = New Point()
        point.X = seedX
        point.Y = seedY
        threshold = TrackBar1.Value / 1000000
        'nonRecursiveFloodFill(newImage(seedX, seedY), Color.FromArgb(255, 255, 255), buttonColor)
        ApplyEffect()

        For i As Integer = 0 To 2000
            For j As Integer = 0 To 2000
                newImage(i, j) = Color.White
                pixelChangedFlag(i, j) = False
            Next
        Next
        recursionDoneFlag = False
    End Sub

    Overrides Function Process(ByRef image As Bitmap, ByVal x As Integer, ByVal y As Integer) As Color
        Try
            If recursionDoneFlag Then
                If pixelChangedFlag(x, y) Then
                    Return Color.White
                Else
                    Return image.GetPixel(x, y)
                End If
            Else
                newImage(x, y) = image.GetPixel(x, y)
                Dim tempPoint As Point = New Point(seedX, seedY)

                If seedX = x And seedY = y Then
                    nonRecursiveFloodFill(image, tempPoint, Color.FromArgb(255, 255, 255), buttonColor)
                End If
                Return newImage(x, y)
                End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Function

    Shared Sub changeButtonBackColor(ByVal inputColor As Color, ByVal x As Integer, ByVal y As Integer)
        buttonColor = inputColor
        seedX = x
        seedY = y
        
        For Each frame As Form In Application.OpenForms
            If frame.Name = "frmBgRemoval" Then
                frame.BringToFront()
            End If
        Next
    End Sub

    Private Sub nonRecursiveFloodFill(ByVal image As Bitmap, ByVal point As Point, ByVal NewColor As Color, ByVal OldColor As Color)
        Dim stack As Queue = New Queue
        Dim count As Integer = 0

        stack.Enqueue(point)
        While stack.Count > 0
            point = stack.Dequeue()

            If (point.X >= 0 And point.X < 2000) Then
                If (point.Y >= 0 And point.Y < 2000) Then
                    Dim oldRed As Integer = OldColor.R
                    Dim newRed As Integer = image.GetPixel(point.X, point.Y).R

                    Dim oldGreen As Integer = OldColor.G
                    Dim newGreen As Integer = image.GetPixel(point.X, point.Y).G

                    Dim oldBlue As Integer = OldColor.B
                    Dim newBlue As Integer = image.GetPixel(point.X, point.Y).B

                    If (newRed < 0) Then
                        newRed = 0
                    ElseIf newRed > 255 Then
                        newRed = 255
                    End If
                    If (newGreen < 0) Then
                        newGreen = 0
                    ElseIf newGreen > 255 Then
                        newGreen = 255
                    End If
                    If (newBlue < 0) Then
                        newBlue = 0
                    ElseIf newBlue > 255 Then
                        newBlue = 255
                    End If

                    If (oldRed < 0) Then
                        oldRed = 0
                    ElseIf oldRed > 255 Then
                        oldRed = 255
                    End If
                    If (oldGreen < 0) Then
                        oldGreen = 0
                    ElseIf oldGreen > 255 Then
                        oldGreen = 255
                    End If
                    If (oldBlue < 0) Then
                        oldBlue = 0
                    ElseIf oldBlue > 255 Then
                        oldBlue = 255
                    End If

                    'd = ( (double)  ) / 1000.0 ;
                    Dim thresholdLimit As Double = ((Math.Sqrt(newRed - oldRed)) + (Math.Sqrt(newGreen - oldGreen)) + (Math.Sqrt(newBlue - oldBlue))) / (255 ^ 2)

                    If thresholdLimit < 0.00001 Then
                        thresholdLimit = 0.00001
                    ElseIf thresholdLimit > 0.055 Then
                        thresholdLimit = 0.1
                    Else

                    End If
                    'Debug.WriteLine(thresholdLimit.ToString + " " + threshold.ToString)
                    If (thresholdLimit < threshold) Then
                        If (changeColor(point, NewColor, OldColor)) Then
                            If fourMode Then
                                stack.Enqueue(New Point(point.X - 1, point.Y))
                                stack.Enqueue(New Point(point.X + 1, point.Y))
                                stack.Enqueue(New Point(point.X, point.Y - 1))
                                stack.Enqueue(New Point(point.X, point.Y + 1))
                            Else
                                stack.Enqueue(New Point(point.X - 1, point.Y))
                                stack.Enqueue(New Point(point.X + 1, point.Y))
                                stack.Enqueue(New Point(point.X, point.Y - 1))
                                stack.Enqueue(New Point(point.X, point.Y + 1))

                                stack.Enqueue(New Point(point.X - 1, point.Y - 1))
                                stack.Enqueue(New Point(point.X + 1, point.Y - 1))
                                stack.Enqueue(New Point(point.X - 1, point.Y + 1))
                                stack.Enqueue(New Point(point.X + 1, point.Y + 1))
                            End If

                        End If
                    End If

                End If
            End If
        End While

        recursionDoneFlag = True
    End Sub

    Private Function changeColor(ByVal point As Point, ByVal NewColor As Color, ByVal OldColor As Color) As Boolean
        If newImage(point.X, point.Y).R = NewColor.R And newImage(point.X, point.Y).G = NewColor.G And newImage(point.X, point.Y).B = NewColor.B Then
            'Debug.WriteLine("Failed to Change Pixel at : " + point.X.ToString + " " + point.Y.ToString)
            Return False
        Else
            newImage(point.X, point.Y) = NewColor
            pixelChangedFlag(point.X, point.Y) = True
            Return True
        End If

    End Function

End Class
