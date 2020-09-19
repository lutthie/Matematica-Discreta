Public Class combiperm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        combinaciones.Show()
    End Sub
    'VOLVER
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.Volver, AudioPlayMode.Background)
        comvolver.Show()
    End Sub
    'PERMUTACIONES
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        permutaciones.Show()
    End Sub
End Class