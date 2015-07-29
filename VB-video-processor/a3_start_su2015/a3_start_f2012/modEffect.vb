Module modEffect
    Public firstTime As Boolean = True
    Public Function IsKeyframe(ByRef input1 As Bitmap, ByRef input2 As Bitmap, _
                               ByVal threshold As Double, ByVal similarity As Double) As Boolean


        ' input1 and input2 are successive frames in the video
        ' threshold is the percentage of colour difference between two pixels in order to consider that they are different
        ' similarity is the percentage of same/similar pixels in the frame so that the two frames are considered similar

        ' *** Add your code here
        Dim totalPixelAssisted As Integer = 0
        Dim difference As Integer = 0

        For width As Integer = (input1.Width / 4) To (input1.Width * 3 / 4)
            For height As Integer = (input1.Height / 4) To (input1.Height * 3 / 4)
                Dim pixel1 As Color = input1.GetPixel(width, height)
                Dim pixel2 As Color = input2.GetPixel(width, height)
                Dim red1 As Integer = pixel1.R
                Dim red2 As Integer = pixel2.R
                Dim green1 As Integer = pixel1.G
                Dim green2 As Integer = pixel2.G
                Dim blue1 As Integer = pixel1.B
                Dim blue2 As Integer = pixel2.B

                Dim redDiff As Short = red1 - red2
                Dim greenDiff As Short = green1 - green2
                Dim blueDiff As Short = blue1 - blue2

                If redDiff < 0 Then
                    redDiff *= -1
                End If
                If greenDiff < 0 Then
                    greenDiff *= -1
                End If
                If blueDiff < 0 Then
                    blueDiff *= -1
                End If

                Dim colorDifference As Integer = redDiff + greenDiff + blueDiff

                If (colorDifference / (3 * 255)) > threshold Then
                    difference = difference + 1
                End If

                totalPixelAssisted = totalPixelAssisted + 1
            Next
        Next

        Dim sim As Double = difference / totalPixelAssisted
        If sim > similarity Then
            Return True
        End If
        ' Remember you only have to compare the central area of the frames


        Return False
    End Function

    Public Function FadeIn(ByRef input As Bitmap, ByVal startRate As Double, _
                           ByVal currentIndex As Integer, ByVal startFrame As Integer, ByVal endFrame As Integer) As Bitmap
        Dim output As New Bitmap(input.Width, input.Height, Imaging.PixelFormat.Format24bppRgb)
        Dim pixel As Color = New Color()
        Dim red As Integer = 0
        Dim green As Integer = 0
        Dim blue As Integer = 0

        ' *** Add your code here
        Dim ratio As Double = (currentIndex - startFrame) / (endFrame - startFrame)
        Dim multiplier As Double = ratio

        For width As Integer = 0 To input.Width - 1
            For height As Integer = 0 To input.Height - 1
                pixel = input.GetPixel(width, height)
                red = pixel.R * multiplier
                green = pixel.G * multiplier
                blue = pixel.B * multiplier
                output.SetPixel(width, height, Color.FromArgb(red, green, blue))
            Next
        Next


        Return output
    End Function

    Public Function FadeOut(ByRef input As Bitmap, ByVal endRate As Double, _
                            ByVal currentIndex As Integer, ByVal startFrame As Integer, ByVal endFrame As Integer) As Bitmap
        Dim output As New Bitmap(input.Width, input.Height, Imaging.PixelFormat.Format24bppRgb)


        ' *** Add your code here
        Dim pixel As Color = New Color()
        Dim red As Integer = 0
        Dim green As Integer = 0
        Dim blue As Integer = 0

        ' *** Add your code here
        Dim ratio As Double = (currentIndex - startFrame) / (endFrame - startFrame)
        Dim multiplier As Double = 1 - ratio

        For width As Integer = 0 To input.Width - 1
            For height As Integer = 0 To input.Height - 1
                pixel = input.GetPixel(width, height)
                red = pixel.R * multiplier
                green = pixel.G * multiplier
                blue = pixel.B * multiplier
                output.SetPixel(width, height, Color.FromArgb(red, green, blue))
            Next
        Next

        Return output
    End Function

    Public Function Melt(ByRef input As Bitmap, _
                         ByVal useSine As Boolean, ByVal amplitude As Integer, ByVal cycle As Integer, _
                         ByVal useRandom As Boolean, ByVal offset As Integer, ByVal period As Integer, _
                         ByVal currentIndex As Integer, ByVal startFrame As Integer, ByVal endFrame As Integer, ByVal newOp As Boolean) As Bitmap
        Dim output As New Bitmap(input.Width, input.Height, Imaging.PixelFormat.Format24bppRgb)
        Static Dim displacement() As Integer = New Integer(0 To 2 * input.Width) {}
        Static Dim firstTime As Integer = True
        Dim currentPeriod As Integer = 0
        Dim currentOffset As Integer = 0
        Dim randomWidth As Integer = 0
        Dim sign As Integer = 0
        'test = test + 1
        'Debug.WriteLine("Displacement: " + displacement(1).ToString + " " + displacement(2).ToString + " " + displacement(3).ToString)
        If useSine Then
            For width As Integer = 0 To input.Width - 1
                displacement(width) = Math.Abs(amplitude * Math.Sin(2 * Math.PI * cycle * (width / input.Width)))
            Next
        End If


        If useRandom Then
            If firstTime Then
                randomWidth = 0
                Do While randomWidth < (input.Width - 1)
                    'Period is a random number from 1 to maximum value set by slider
                    'currentOffset = 0
                    currentPeriod = 1 + Rnd() * (period - 1)
                    If Rnd() >= 0.5 Then
                        sign = 1
                    Else
                        sign = -1
                    End If
                    Dim random As Double = Rnd()
                    For i As Integer = randomWidth To (randomWidth + currentPeriod - 1)
                        'For each column i, create the random offset
                        currentOffset = currentOffset + sign * random * offset
                        If currentOffset < 0 Then
                            currentOffset = -1 * currentOffset
                            sign = -1 * sign
                        End If

                        displacement(i) = currentOffset

                    Next

                    randomWidth = randomWidth + currentPeriod

                Loop
                firstTime = False
            End If

        End If

        ' *** Add your code here
        Dim ratio As Double = (currentIndex - startFrame) / (endFrame - startFrame)
        For width As Integer = 0 To input.Width - 1
            For height As Integer = 0 To input.Height - 1

                Dim newX As Integer = width
                Dim newY As Integer = height - (displacement(width) * ratio)

                If newY > input.Height - 1 Then
                    newY = input.Height - 1
                ElseIf newY < 0 Then
                    newY = 0
                End If
                output.SetPixel(width, height, GetPixel(input, newX, newY))
            Next
        Next


        Return output
    End Function

    Public Function Transition(ByRef input1 As Bitmap, ByRef input2 As Bitmap, ByVal type As Integer, ByVal duration As Double, ByVal direction As Integer, _
                               ByVal currentIndex As Integer, ByVal startFrame As Integer, ByVal endFrame As Integer, ByVal newOp As Boolean) As Bitmap
        Dim output As New Bitmap(input1.Width, input1.Height, Imaging.PixelFormat.Format24bppRgb)
        ' The parameter duration is the time spanned by the transition effect
        ' at the middle of the selected video segment
        '
        ' For example,
        ' if startFrame = 20, endFrame = 80 and duration = 0.5,
        ' the transition lasts for (80 - 20) * 0.5 = 30 frames and
        ' the transition starts at frame (80 - 20 - 30) / 2 + 20 = 35
        '
        ' Similarly,
        ' if startFrame = 60, endFrame = 100 and duration = 0.25,
        ' the transition lasts for (100 - 60) * 0.25 = 10 frames and
        ' the transition starts at frame (100 - 60 - 10) / 2 + 60 = 75
        Dim transitionLasts As Integer = (endFrame - startFrame) * duration
        Dim transitionStarts As Integer = (endFrame - startFrame - transitionLasts) / 2 + startFrame

        Static lineBoolean(0 To input1.Height) As Boolean
        Dim percentage As Double = (currentIndex - startFrame) / (endFrame - startFrame)
        If firstTime Then
            For i As Integer = 0 To input1.Height
                lineBoolean(i) = False
            Next
            For j As Integer = 0 To input1.Height
                If Rnd() < percentage Then
                    lineBoolean(j) = True
                Else
                    lineBoolean(j) = False
                End If
            Next
            firstTime = False
        End If
        

        If type = 0 Then
            If currentIndex < transitionStarts Then
                For width As Integer = 0 To input1.Width - 1
                    For height As Integer = 0 To input1.Height - 1
                        output.SetPixel(width, height, GetPixel(input1, width, height))
                    Next
                Next
            ElseIf currentIndex >= transitionStarts And currentIndex < transitionStarts + transitionLasts Then

                If direction = 1 Then
                    For width As Integer = 0 To input1.Width - 1
                        For height As Integer = 0 To input1.Height - 1
                            '(x * video2.Width / video1.Width, y * video2.Height / video1.Height)
                            If ((width / input1.Width) < 1 - percentage) Then
                                output.SetPixel(width, height, GetPixel(input2, width * (input2.Width / input1.Width), height * (input2.Height / input1.Height)))
                            Else
                                output.SetPixel(width, height, GetPixel(input1, width, height))
                            End If
                        Next
                    Next
                ElseIf direction = 2 Then
                    For width As Integer = 0 To input1.Width - 1
                        For height As Integer = 0 To input1.Height - 1
                            '(x * video2.Width / video1.Width, y * video2.Height / video1.Height)
                            If ((width / input1.Width) < percentage) Then
                                output.SetPixel(width, height, GetPixel(input2, width * (input2.Width / input1.Width), height * (input2.Height / input1.Height)))
                            Else
                                output.SetPixel(width, height, GetPixel(input1, width, height))
                            End If
                        Next
                    Next
                ElseIf direction = 3 Then
                    For width As Integer = 0 To input1.Width - 1
                        For height As Integer = 0 To input1.Height - 1
                            '(x * video2.Width / video1.Width, y * video2.Height / video1.Height)
                            If ((height / input1.Height) < 1 - percentage) Then
                                output.SetPixel(width, height, GetPixel(input2, width * (input2.Width / input1.Width), height * (input2.Height / input1.Height)))
                            Else
                                output.SetPixel(width, height, GetPixel(input1, width, height))
                            End If
                        Next
                    Next
                ElseIf direction = 4 Then
                    For width As Integer = 0 To input1.Width - 1
                        For height As Integer = 0 To input1.Height - 1
                            '(x * video2.Width / video1.Width, y * video2.Height / video1.Height)
                            If ((height / input1.Height) < percentage) Then
                                output.SetPixel(width, height, GetPixel(input2, width * (input2.Width / input1.Width), height * (input2.Height / input1.Height)))
                            Else
                                output.SetPixel(width, height, GetPixel(input1, width, height))
                            End If
                        Next
                    Next
                End If
            ElseIf currentIndex >= transitionStarts + transitionLasts Then
                For width As Integer = 0 To input1.Width - 1
                    For height As Integer = 0 To input1.Height - 1
                        output.SetPixel(width, height, GetPixel(input2, width, height))
                    Next
                Next
            End If
        Else
            Dim lineNumber As Integer = input1.Height * (currentIndex - startFrame) / (endFrame - startFrame)
            'output = input1.Clone
            If currentIndex < transitionStarts Then
                For width As Integer = 0 To input1.Width - 1
                    For height As Integer = 0 To input1.Height - 1
                        output.SetPixel(width, height, GetPixel(input1, width, height))
                    Next
                Next
            ElseIf currentIndex >= transitionStarts And currentIndex < transitionStarts + transitionLasts Then

                Debug.WriteLine("Percentage: " + percentage.ToString + " lineNumber : " + lineNumber.ToString + " Lines")
                Dim count As Integer = 0
                For j As Integer = 0 To input1.Height - 1
                    count = count + 1
                    Dim temp As Integer = (Rnd() * (input1.Height - 1 - j)) + j
                    If lineBoolean(temp) Then
                        If count > lineNumber Then
                            Exit For
                        End If
                    Else
                        If Rnd() < percentage Then
                            lineBoolean(temp) = True
                        Else
                            lineBoolean(temp) = False
                        End If
                    End If
                Next
                For width As Integer = 0 To input1.Width - 1
                    For i As Integer = 0 To input1.Height - 1
                        If lineBoolean(i) Then
                            output.SetPixel(width, i, GetPixel(input2, width, i))
                        Else
                            output.SetPixel(width, i, GetPixel(input1, width, i))
                        End If

                    Next
                Next
            ElseIf currentIndex >= transitionStarts + transitionLasts Then
            For width As Integer = 0 To input1.Width - 1
                For height As Integer = 0 To input1.Height - 1
                    output.SetPixel(width, height, GetPixel(input2, width, height))
                Next
            Next
        End If
        End If

        ' *** Add your code here

        Return output
    End Function

    Public Function MotionBlur(ByRef input As Bitmap, ByVal blurCount As Integer, _
                               ByVal currentIndex As Integer, ByVal startFrame As Integer, ByVal endFrame As Integer, ByVal newOp As Boolean, _
                               ByVal dirname As String) As Bitmap
        Dim output As New Bitmap(input.Width, input.Height, Imaging.PixelFormat.Format24bppRgb)

        Static Dim bufferR(input.Width - 1, input.Height - 1) As Integer
        Static Dim bufferG(input.Width - 1, input.Height - 1) As Integer
        Static Dim bufferB(input.Width - 1, input.Height - 1) As Integer


        ' *** Add your code here

        ' You need to initialize the buffers at the start of the operation


        Return output
    End Function
    Public Function TimeShift(ByRef input1 As Bitmap, ByRef input2 As Bitmap, ByVal cutOffPos As Double, _
                               ByVal currentIndex As Integer, ByVal startFrame As Integer, ByVal endFrame As Integer, ByVal newOp As Boolean) As Bitmap
        Dim output As New Bitmap(input1.Width, input1.Height, Imaging.PixelFormat.Format24bppRgb)

        Return output
    End Function

    ' Get the pixel from the bitmap with the boundary pixels correctly handled
    Private Function GetPixel(ByRef bitmap As Bitmap, ByVal x As Short, ByVal y As Short) As Color
        If x < 0 Then
            x = 0
        ElseIf x > bitmap.Width - 1 Then
            x = bitmap.Width - 1
        End If

        If y < 0 Then
            y = 0
        ElseIf y > bitmap.Height - 1 Then
            y = bitmap.Height - 1
        End If

        GetPixel = bitmap.GetPixel(x, y)
    End Function

    ' Clipping function
    Private Function Clip(ByVal value As Integer) As Integer
        If value > 255 Then
            Return 255
        ElseIf value < 0 Then
            Return 0
        End If
        Return value
    End Function

End Module
