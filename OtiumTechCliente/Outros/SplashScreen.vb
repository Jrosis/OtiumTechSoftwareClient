Public Class SplashScreen

    Private Sub timerSplash_Tick(sender As Object, e As EventArgs) Handles timerSplash.Tick
        timerSplash.Enabled = False
        FrmLogin.Show()
        Me.Close()

    End Sub

  
End Class