Public Class SPlash
    Dim r As New Random()

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not ProgressBar1.Value = 100 Then
            ProgressBar1.Value += 5
            Select Case r.Next(1, 7)
                Case 1
                    Timer1.Interval = 100
                Case 2
                    Timer1.Interval = 200
                Case 3
                    Timer1.Interval = 300
                Case 4
                    Timer1.Interval = 400
                Case 5
                    Timer1.Interval = 600
                Case 6
                    Timer1.Interval = 900
            End Select
        Else
            Timer1.Stop()
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub SPlash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Points, AudioPlayMode.Background)
    End Sub
End Class