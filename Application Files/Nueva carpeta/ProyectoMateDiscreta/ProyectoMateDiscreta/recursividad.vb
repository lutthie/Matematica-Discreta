Public Class recursividad
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        fibonacci.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        factorial.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.Volver, AudioPlayMode.Background)
        revolver.Show()
    End Sub
End Class