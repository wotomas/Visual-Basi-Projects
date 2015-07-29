Module modEffect

    Public Function IsKeyframe(ByRef input1 As Bitmap, ByRef input2 As Bitmap, _
                               ByVal threshold As Double, ByVal similarity As Double) As Boolean


        ' input1 and input2 are successive frames in the video
        ' threshold is the percentage of colour difference between two pixels in order to consider that they are different
        ' similarity is the percentage of same/similar pixels in the frame so that the two frames are considered similar

        ' *** Add your code here

        ' Remember you only have to compare the central area of the frames


        Return False
    End Function

    Public Function FadeIn(ByRef input As Bitmap, ByVal startRate As Double, _
                           ByVal currentIndex As Integer, ByVal startFrame As Integer, ByVal endFrame As Integer) As Bitmap
        Dim output As New Bitmap(input.Width, input.Height, Imaging.PixelFormat.Format24bppRgb)


        ' *** Add your code here


        Return output
    End Function

    Public Function FadeOut(ByRef input As Bitmap, ByVal endRate As Double, _
                            ByVal currentIndex As Integer, ByVal startFrame As Integer, ByVal endFrame As Integer) As Bitmap
        Dim output As New Bitmap(input.Width, input.Height, Imaging.PixelFormat.Format24bppRgb)


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


    Public Function Melt(ByRef input As Bitmap, _
                         ByVal useSine As Boolean, ByVal amplitude As Integer, ByVal cycle As Integer, _
                         ByVal useRandom As Boolean, ByVal offset As Integer, ByVal period As Integer, _
                         ByVal currentIndex As Integer, ByVal startFrame As Integer, ByVal endFrame As Integer, ByVal newOp As Boolean) As Bitmap
        Dim output As New Bitmap(input.Width, input.Height, Imaging.PixelFormat.Format24bppRgb)
        Static Dim displacement() As Integer = Nothing


        ' *** Add your code here


        Return output
    End Function

    Public Function Transition(ByRef input1 As Bitmap, ByRef input2 As Bitmap, ByVal type As Integer, ByVal duration As Double, _
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

        ' *** Add your code here


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
