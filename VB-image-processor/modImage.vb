Module modImage
    Public Sub Ripple(ByRef fImageForm As frmImage, ByVal frequency As Double, ByVal magnitude As Integer)
        Dim centerX As Integer = 0
        Dim centerY As Integer = 0
        Dim radius As Integer = 0
        Dim distX As Integer = 0
        Dim distY As Integer = 0
        Dim newDistX As Integer = 0
        Dim newDIstY As Integer = 0
        Dim newRadius As Integer = 0

        If fImageForm.selectedArea.Width = 0 And fImageForm.selectedArea.Height = 0 Then
            fImageForm.SelectAll()
        End If

        Dim buffer As Bitmap = fImageForm.image.Clone()
        Dim tempBuffer As Bitmap = fImageForm.image.Clone()
        fImageForm.RemoveDashRect()

        centerY = (fImageForm.selectedArea.Top + fImageForm.selectedArea.Bottom) / 2
        centerX = (fImageForm.selectedArea.Right + fImageForm.selectedArea.Left) / 2
        'MsgBox("Center : " + centerX.ToString + " " + centerY.ToString)

        For y As Integer = fImageForm.selectedArea.Top To fImageForm.selectedArea.Bottom
            For x As Integer = fImageForm.selectedArea.Left To fImageForm.selectedArea.Right
                distX = x - centerX
                distY = y - centerY
                radius = Math.Sqrt(distX ^ 2 + distY ^ 2)
                'Debug.WriteLine(radius.ToString)

                newDistX = distX + (magnitude * Math.Sin(2 * Math.PI * radius * frequency))
                newDIstY = distY + (magnitude * Math.Sin(2 * Math.PI * radius * frequency))


                'newRadius = radius + (magnitude * Math.Sin(2 * Math.PI * radius * frequency))

                'newDistX = distX + Math.Sqrt(newRadius)
                'newDIstY = distY + Math.Sqrt(newRadius)

                If (fImageForm.selectedArea.Left <= (newDistX + centerX)) And ((newDistX + centerX) <= fImageForm.selectedArea.Right) And (fImageForm.selectedArea.Top <= (newDIstY + centerY)) And ((newDIstY + centerY) <= fImageForm.selectedArea.Bottom) Then
                    buffer.SetPixel(x, y, tempBuffer.GetPixel(newDistX + centerX, newDIstY + centerY))
                Else
                    buffer.SetPixel(x, y, Color.White)
                End If

                'buffer.SetPixel(x, y, Color.White)
            Next
        Next

        fImageForm.SetPicture(buffer.Clone())
        fImageForm.DrawDashRect()

    End Sub
    Public Sub Edge(ByRef fImageForm As frmImage, ByVal strength As Integer, ByVal blackEdge As Boolean)
        Dim red As Integer = 0
        Dim green As Integer = 0
        Dim blue As Integer = 0

        If fImageForm.selectedArea.Width = 0 And fImageForm.selectedArea.Height = 0 Then
            fImageForm.SelectAll()
        End If

        Dim buffer As Bitmap = fImageForm.image.Clone()
        Dim tempBuffer As Bitmap = fImageForm.image.Clone()
        fImageForm.RemoveDashRect()

        For y As Integer = fImageForm.selectedArea.Top To fImageForm.selectedArea.Bottom
            For x As Integer = fImageForm.selectedArea.Left To fImageForm.selectedArea.Right
                Dim mainpixel As Color = GetPixel(tempBuffer, x, y)
                Dim topPixel As Color = GetPixel(tempBuffer, x + 1, y)
                Dim bottomPixel As Color = GetPixel(tempBuffer, x, y + 1)
                Dim leftPixel As Color = GetPixel(tempBuffer, x, y - 1)
                Dim rightPixel As Color = GetPixel(tempBuffer, x - 1, y)

                Dim topLeftPixel As Color = GetPixel(tempBuffer, x + 1, y + 1)
                Dim bottomRightPixel As Color = GetPixel(tempBuffer, x - 1, y + 1)
                Dim bottomLeftPixel As Color = GetPixel(tempBuffer, x + 1, y - 1)
                Dim topRightPixel As Color = GetPixel(tempBuffer, x - 1, y - 1)

                red = bottomRightPixel.R * -1 + bottomLeftPixel.R * -1 + topRightPixel.R * -1 + topLeftPixel.R * -1 + (topPixel.R * -1) + (bottomPixel.R * -1) + (leftPixel.R * -1) + (rightPixel.R * -1) + (mainpixel.R * 8)
                blue = bottomRightPixel.B * -1 + bottomLeftPixel.B * -1 + topRightPixel.B * -1 + topLeftPixel.B * -1 + topPixel.B * -1 + bottomPixel.B * -1 + leftPixel.B * -1 + rightPixel.B * -1 + mainpixel.B * 8
                green = bottomRightPixel.G * -1 + bottomLeftPixel.G * -1 + topRightPixel.G * -1 + topLeftPixel.G * -1 + topPixel.G * -1 + bottomPixel.G * -1 + leftPixel.G * -1 + rightPixel.G * -1 + mainpixel.G * 8

                red *= strength
                blue *= strength
                green *= strength

                If red < 0 Then
                    red = 0
                ElseIf red > 255 Then
                    red = 255
                End If
                If blue < 0 Then
                    blue = 0
                ElseIf blue > 255 Then
                    blue = 255
                End If
                If green < 0 Then
                    green = 0
                ElseIf green > 255 Then
                    green = 255
                End If

                If blackEdge Then
                    buffer.SetPixel(x, y, Color.FromArgb(255 - red, 255 - green, 255 - blue))
                Else
                    buffer.SetPixel(x, y, Color.FromArgb(red, green, blue))
                End If

            Next
        Next
        fImageForm.SetPicture(buffer.Clone())
        fImageForm.DrawDashRect()

        'MsgBox(fImageForm.selectedArea.X.ToString + " " + fImageForm.selectedArea.Y.ToString)
        'MsgBox(fImageForm.selectedArea.Width.ToString + " " + fImageForm.selectedArea.Height.ToString)

    End Sub


    ' This function applies roughen on a pixel using a deviation from 0 to 1
    Public Function Roughen(ByVal color As Color, ByVal deviation As Double, ByVal hueCheck As Boolean, ByVal saturationCheck As Boolean, ByVal brightnessCheck As Boolean) As Color
        Dim red As Integer = color.R
        Dim green As Integer = color.G
        Dim blue As Integer = color.B
        Dim hue As Double = color.GetHue()
        Dim saturation As Double = color.GetSaturation()
        Dim value As Double = color.GetBrightness()

        RGB2HSV(red, green, blue, hue, saturation, value)
        Dim randomValue As Double = Rnd()
        'MsgBox(brightnessCheck.ToString + " " + saturationCheck.ToString + " " + hueCheck.ToString)

        'if brightnessCheck is true
        If brightnessCheck Then
            If randomValue >= 0.5 Then
                value = value + deviation * randomValue
                If value > 1 Then
                    ClipFloat(value)
                End If
            Else
                value = value - deviation * randomValue
                If value < 0 Then
                    ClipFloat(value)
                End If
            End If
        End If

        'if saturationCheck is true
        If saturationCheck Then
            If randomValue >= 0.5 Then
                saturation = saturation + deviation * randomValue
                If saturation > 1 Then
                    ClipFloat(saturation)
                End If
            Else
                saturation = saturation - deviation * randomValue
                If saturation < 0 Then
                    ClipFloat(saturation)
                End If
            End If
        End If

        'if HueCheck is true
        If hueCheck Then
            If randomValue >= 0.5 Then
                hue = hue + deviation * 360 * randomValue
                If hue > 1 Then
                    ClipHue(hue)
                End If
            Else
                hue = hue - deviation * 360 * randomValue
                If hue < 0 Then
                    ClipHue(hue)
                End If
            End If
        End If

        'MsgBox("RandomValue: " + randomValue.ToString + " Value: " + value.ToString + " Diviation: " + deviation.ToString)
        ' Adjust the V component of the colour using the deviation here
        HSV2RGB(hue, saturation, value, red, green, blue)

        Return color.FromArgb(red, green, blue)
    End Function

    ' This function applies melt on an input image
    Public Sub Melt(ByRef input As Bitmap, ByRef output As Bitmap, ByVal rect As Rectangle, _
                    ByVal useSine As Boolean, ByVal amplitude As Integer, ByVal cycle As Integer, _
                    ByVal useRandom As Boolean, ByVal offset As Integer, ByVal period As Integer, _
                    ByVal useRotation As Boolean, ByVal angle As Integer)

        Dim displacement(0 To rect.Width) As Integer
        Dim rotationOffset As Integer = angle
        Dim currentPeriod As Integer = 0
        Dim currentOffset As Integer = 0
        Dim sign As Integer = 0
        Dim x As Integer = 0
        Dim tempInput As Bitmap = input.Clone()
        If useRotation Then
            rotationOffset = angle
            Rotate(tempInput, input, rect, rotationOffset)
        Else
            rotationOffset = 0
        End If
        If useSine Then
            For i As Integer = 0 To rect.Width
                displacement(i) = Math.Abs(amplitude * Math.Sin(2 * Math.PI * cycle * (i / rect.Width)))
            Next
        End If
        If useRandom Then
            Do While x < rect.Width
                'Period is a random number from 1 to maximum value set by slider
                currentPeriod = 1 + Rnd() * (period - 1)
                If Rnd() >= 0.5 Then
                    sign = 1
                Else
                    sign = -1
                End If

                For i As Integer = x To x + currentPeriod - 1
                    'For each column i, create the random offset
                    currentOffset = currentOffset + sign * Rnd() * offset
                    If currentOffset < 0 Then
                        currentOffset = -1 * currentOffset
                        sign = -1 * sign
                    End If
                    displacement(i) = currentOffset
                Next

                x = x + currentPeriod

            Loop
        End If

        ' Apply melt to the selected area here
        Try
            For i As Integer = rect.X To rect.X + rect.Width
                For j As Integer = rect.Y To rect.Y + rect.Height
                    'Output to a new image
                    Dim inputPixel As Integer = j - displacement(i - rect.X)

                    If inputPixel >= rect.Bottom Then
                        inputPixel = rect.Bottom
                    ElseIf inputPixel <= rect.Top Then
                        inputPixel = rect.Top
                    End If

                    output.SetPixel(i, j, input.GetPixel(i, inputPixel))
                Next j
            Next i
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If useRotation Then
            Dim tempOutput As Bitmap = output.Clone()
            Rotate(tempOutput, output, rect, 360 - rotationOffset)
        End If
        



    End Sub

    ' This function applies rotation on an input image
    Public Sub Rotate(ByRef input As Bitmap, ByRef output As Bitmap, ByVal rect As Rectangle, ByVal angle As Integer)

        Dim maxsize As Integer = 0
        Dim centerX As Integer = 0
        Dim centerY As Integer = 0
        Dim distX As Integer = 0
        Dim distY As Integer = 0
        Dim sourceX As Integer = 0
        Dim sourceY As Integer = 0

        maxsize = Math.Ceiling(Math.Sqrt(rect.Width ^ 2 + rect.Height ^ 2))
        centerX = rect.X + rect.Width / 2.0
        centerY = rect.Y + rect.Height / 2.0
        ' Apply rotation to the selected area here
        For x As Integer = centerX - maxsize / 2 To centerX + maxsize / 2
            For y As Integer = centerY - maxsize / 2 To centerY + maxsize / 2
                distX = x - centerX
                distY = y - centerY
                sourceX = Math.Cos(Math.PI * angle / 180) * distX + Math.Sin(Math.PI * angle / 180) * distY
                sourceY = -Math.Sin(Math.PI * angle / 180) * distX + Math.Cos(Math.PI * angle / 180) * distY
                sourceX = sourceX + centerX
                sourceY = sourceY + centerY
                ' i.e. (rect.Left <= source.X <= rect.Right) and (rect.Top <= source.Y <= rect.Bottom)
                If (rect.Left <= sourceX) And (sourceX <= rect.Right) And (rect.Top <= sourceY) And (sourceY <= rect.Bottom) Then
                    output.SetPixel(x, y, GetPixel(input, sourceX, sourceY))
                Else
                    output.SetPixel(x, y, Color.White)
                End If
            Next
        Next


    End Sub

    Public Sub RGB2HSV(ByVal red As Integer, ByVal green As Integer, ByVal blue As Integer, ByRef h As Double, ByRef s As Double, ByRef v As Double)
        Dim max, min As Double
        Dim r As Double, g As Double, b As Double

        r = red / 255.0
        g = green / 255.0
        b = blue / 255.0
        'Convert RGB to [0,1]

        'Then get the max and min of r,g,b
        max = r
        If max < g Then max = g
        If max < b Then max = b
        min = r
        If min > g Then min = g
        If min > b Then min = b

        v = max 'this is value v

        'next calculate saturation, s 
        If max = 0 Then
            s = 0
        Else
            s = (max - min) / max
        End If

        ' The last step is hue, h
        If s = 0 Then
            h = -1
        Else
            If r = max Then
                h = (g - b) / (max - min)
            ElseIf g = max Then
                h = 2 + (b - r) / (max - min)
            ElseIf b = max Then
                h = 4 + (r - g) / (max - min)
            End If

            h = h * 60
            If h < 0 Then
                h = h + 360
            End If
        End If
    End Sub


    Private Sub HSV2RGB(ByVal h As Double, ByVal s As Double, ByVal v As Double, ByRef red As Integer, ByRef green As Integer, ByRef blue As Integer)
        Dim r As Double, g As Double, b As Double
        Dim i As Double, f As Double, p As Double, q As Double, t As Double

        If s = 0 Then
            r = v
            g = v
            b = v
        Else
            If h = 360 Then
                h = 0
            End If
            h = h / 60
            i = Int(h)

            f = h - i
            p = v * (1 - s)
            q = v * (1 - (s * f))
            t = v * (1 - (s * (1 - f)))

            Select Case i
                Case 0
                    r = v
                    g = t
                    b = p
                Case 1
                    r = q
                    g = v
                    b = p
                Case 2
                    r = p
                    g = v
                    b = t
                Case 3
                    r = p
                    g = q
                    b = v
                Case 4
                    r = t
                    g = p
                    b = v
                Case 5
                    r = v
                    g = p
                    b = q
            End Select
        End If

        red = CInt(r * 255.0)
        green = CInt(g * 255.0)
        blue = CInt(b * 255.0)

        red = ClipByte(red)
        green = ClipByte(green)
        blue = ClipByte(blue)
    End Sub

    ' This function clips a value into the range of 0 to 255
    Private Function ClipByte(ByRef value As Integer) As Integer
        If value > 255 Then
            Return 255
        ElseIf value < 0 Then
            Return 0
        End If
        Return value
    End Function

    ' This function clips a value into the range of 0 to 1
    Private Function ClipFloat(ByRef value As Double) As Double
        If value > 1 Then
            Return 1
        ElseIf value < 0 Then
            Return 0
        End If
        Return value
    End Function

    ' This function clips a value into the range of 0 to 1
    Private Function ClipHue(ByRef value As Integer) As Double
        If value > 360 Then
            Return 360
        ElseIf value < 0 Then
            Return 0
        End If
        Return value
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

    ' This function returns the interpolation of four pixels around an x and y position
    Private Function Interpolation(ByRef image As Bitmap, ByVal x As Double, ByVal y As Double) As Color
        Dim bx As Integer = Math.Floor(x)
        Dim by As Integer = Math.Floor(y)
        Dim a As Double, b As Double, a0 As Double, a1 As Double, a2 As Double, a3 As Double
        Dim red As Double, green As Double, blue As Double

        a = x - bx
        b = y - by

        a0 = (1 - a) * (1 - b)
        a1 = a * (1 - b)
        a2 = (1 - a) * b
        a3 = a * b

        red = GetPixel(image, bx, by).R * a0 + GetPixel(image, bx + 1, by).R * a1 + GetPixel(image, bx, by + 1).R * a2 + GetPixel(image, bx + 1, by + 1).R * a3
        green = GetPixel(image, bx, by).G * a0 + GetPixel(image, bx + 1, by).G * a1 + GetPixel(image, bx, by + 1).G * a2 + GetPixel(image, bx + 1, by + 1).G * a3
        blue = GetPixel(image, bx, by).B * a0 + GetPixel(image, bx + 1, by).B * a1 + GetPixel(image, bx, by + 1).B * a2 + GetPixel(image, bx + 1, by + 1).B * a3

        Return Color.FromArgb(red, green, blue)
    End Function

End Module

