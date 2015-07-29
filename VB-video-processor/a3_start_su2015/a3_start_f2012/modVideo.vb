Imports System.IO
Imports System.Diagnostics

Module modVideo

    Public Function ExecCmd(ByRef program As String, ByRef arguments As String) As Integer

        Dim newProcess As Process = New Process

        newProcess.StartInfo.FileName = program
        newProcess.StartInfo.Arguments = arguments
        newProcess.StartInfo.UseShellExecute = False
        newProcess.StartInfo.RedirectStandardOutput = True
        newProcess.StartInfo.RedirectStandardError = True

        newProcess.Start()
        newProcess.WaitForExit()
        newProcess.Close()

    End Function


    Public Sub PrintParaFile(ByVal frameNum As Integer, ByVal width As Integer, ByVal height As Integer)
        Dim sw As StreamWriter = New StreamWriter("temp.par")

        sw.WriteLine("MPEG-1 Test Sequence, 25 frames/sec")
        sw.WriteLine("out%d    /* name of source files */")
        sw.WriteLine("-       /* name of reconstructed images (-: don't store) */")
        sw.WriteLine("-         /* name of intra quant matrix file     (-: default matrix) */")
        sw.WriteLine("-         /* name of non intra quant matrix file (-: default matrix) */")
        sw.WriteLine("stat.txt  /* name of statistics file (-: stdout ) */")
        sw.WriteLine("3         /* input picture file format: 0=*.Y,*.U,*.V, 1=*.yuv, 2=*.ppm, 3=*.bmp */ ")
        sw.WriteLine(CStr(frameNum) & "       /* number of frames */")
        sw.WriteLine("0         /* number of first frame */")
        sw.WriteLine("00:00:00:00 /* timecode of first frame */")
        sw.WriteLine("12        /* N (# of frames in GOP) */")
        sw.WriteLine("3         /* M (I/P frame distance) */")
        sw.WriteLine("1         /* ISO/IEC 11172-2 stream */")
        sw.WriteLine("0         /* 0:frame pictures, 1:field pictures */")
        sw.WriteLine(CStr(width) & "       /* horizontal_size */")
        sw.WriteLine(CStr(height) & "       /* vertical_size */")
        sw.WriteLine("8         /* aspect_ratio_information 8=CCIR601 625 line, 9=CCIR601 525 line */")
        sw.WriteLine("3         /* frame_rate_code 1=23.976, 2=24, 3=25, 4=29.97, 5=30 frames/sec. */")
        sw.WriteLine("1152000.0 /* bit_rate (bits/s) */")
        sw.WriteLine("20        /* vbv_buffer_size (in multiples of 16 kbit) */")
        sw.WriteLine("0         /* low_delay  */")
        sw.WriteLine("1         /* constrained_parameters_flag */")
        sw.WriteLine("4         /* Profile ID: Simple = 5, Main = 4, SNR = 3, Spatial = 2, High = 1 */")
        sw.WriteLine("8         /* Level ID:   Low = 10, Main = 8, High 1440 = 6, High = 4          */")
        sw.WriteLine("1         /* progressive_sequence */")
        sw.WriteLine("1         /* chroma_format: 1=4:2:0, 2=4:2:2, 3=4:4:4 */")
        sw.WriteLine("1         /* video_format: 0=comp., 1=PAL, 2=NTSC, 3=SECAM, 4=MAC, 5=unspec. */")
        sw.WriteLine("5         /* color_primaries */")
        sw.WriteLine("5         /* transfer_characteristics */")
        sw.WriteLine("5         /* matrix_coefficients */")
        sw.WriteLine(CStr(width) & "       /* display_horizontal_size */")
        sw.WriteLine(CStr(height) & "       /* display_vertical_size */")
        sw.WriteLine("0         /* intra_dc_precision (0: 8 bit, 1: 9 bit, 2: 10 bit, 3: 11 bit */")
        sw.WriteLine("0         /* top_field_first */")
        sw.WriteLine("1 1 1     /* frame_pred_frame_dct (I P B) */")
        sw.WriteLine("0 0 0     /* concealment_motion_vectors (I P B) */")
        sw.WriteLine("0 0 0     /* q_scale_type  (I P B) */")
        sw.WriteLine("0 0 0     /* intra_vlc_format (I P B)*/")
        sw.WriteLine("0 0 0     /* alternate_scan (I P B) */")
        sw.WriteLine("0         /* repeat_first_field */")
        sw.WriteLine("1         /* progressive_frame */")
        sw.WriteLine("0         /* P distance between complete intra slice refresh */")
        sw.WriteLine("0         /* rate control: r (reaction parameter) */")
        sw.WriteLine("0         /* rate control: avg_act (initial average activity) */")
        sw.WriteLine("0         /* rate control: Xi (initial I frame global complexity measure) */")
        sw.WriteLine("0         /* rate control: Xp (initial P frame global complexity measure) */")
        sw.WriteLine("0         /* rate control: Xb (initial B frame global complexity measure) */")
        sw.WriteLine("0         /* rate control: d0i (initial I frame virtual buffer fullness) */")
        sw.WriteLine("0         /* rate control: d0p (initial P frame virtual buffer fullness) */")
        sw.WriteLine("0         /* rate control: d0b (initial B frame virtual buffer fullness) */")
        sw.WriteLine("2 2 11 11 /* P:  forw_hor_f_code forw_vert_f_code search_width/height */")
        sw.WriteLine("1 1 3  3  /* B1: forw_hor_f_code forw_vert_f_code search_width/height */")
        sw.WriteLine("1 1 7  7  /* B1: back_hor_f_code back_vert_f_code search_width/height */")
        sw.WriteLine("1 1 7  7  /* B2: forw_hor_f_code forw_vert_f_code search_width/height */")
        sw.WriteLine("1 1 3  3  /* B2: back_hor_f_code back_vert_f_code search_width/height */")

        sw.Close()
    End Sub

End Module