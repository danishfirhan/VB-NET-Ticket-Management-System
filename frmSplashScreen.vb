Public Class frmSplashScreen

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 50 ' Set the interval for smoother progress bar loading
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 2 ' Increment progress by 2 each tick
        Else
            Timer1.Stop()
            Form1.Show() ' Show the main form after splash screen completes
            Me.Close() ' Close the splash screen
        End If
    End Sub
End Class

