Public Class Form1

    Private Sub Form1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick, Me.Click, TVLicence.Click
        TVLicenceChecker.ShowDialog()
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            Me.Capture = False   'change this to the control you will use to move the window
            ' Create and send a WM_NCLBUTTONDOWN message.
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = _
             Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
              New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub

    Private Sub PWRButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PWRButton.Click
        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.WaitToComplete)
        Application.Exit()
        End
    End Sub

    Private Sub SkyButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SkyButton.Click
        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.WaitToComplete)
        Dialog1.ShowDialog()
    End Sub

    Private Sub tvButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvButton.Click
        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)
        Process.Start("https://www.youtube.com/watch?v=LrvE3B5Rz6A&t=188s")
    End Sub

    Private Sub boxofficeButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles boxofficeButton.Click, tvguideButton.Click, servicesButton.Click, interactiveButton.Click
        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)
        Process.Start("https://sky-epg.davwheat.dev/")
    End Sub

    Private Sub muteButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles muteButton.Click
        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\mute.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub backupButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles backupButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\backup.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub blueButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles blueButton.Click

    End Sub

    Private Sub ChDnButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChDnButton2.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\chdown.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ChUpButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChUpButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\chup.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub downButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles downButton3.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\down.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub eightButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles eightButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\8.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub fiveButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fiveButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\5.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub fourButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fourButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\4.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub greenButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles greenButton.Click

    End Sub

    Private Sub helpButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles helpButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\help.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub infoButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles infoButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\info.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub leftButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles leftButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\left.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub nineButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nineButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\9.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub oneButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles oneButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\1.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub redButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles redButton.Click

    End Sub

    Private Sub rightButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rightButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\right.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub selectButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles selectButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\select.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub sevenButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sevenButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\7.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub sixButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sixButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\6.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub textButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles textButton.Click
        Try
            Process.Start("narrator")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub threeButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles threeButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\3.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub twoButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles twoButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\2.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub upButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles upButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\up.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VolDownButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VolDownButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\voldn.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VolUpButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VolUpButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\volup.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub yellowButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles yellowButton.Click

    End Sub

    Private Sub zeroButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles zeroButton.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\SpareSkyRemote2012\scr\0.exe")
        Catch ex As Exception

        End Try
    End Sub

End Class
