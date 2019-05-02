Public NotInheritable Class SplashScreen1
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Form1.Show()
        Me.Close()
    End Sub
End Class
