Public Class TVLicenceChecker

    Private Sub TVLicenceChecker_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
        Timer1.Stop()
    End Sub


    Private Sub TVLicenceChecker_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.TVLicence, AudioPlayMode.Background)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
        Timer1.Stop()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            Process.Start("C:\Program Files\Workplace2Software\EOQAuth\EOQ Authenticator.exe")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("An error was encountered while trying to verify your identity. Please confirm that you have EOQ Tools installed on your system.", "Oh lord")
        End Try
    End Sub
End Class