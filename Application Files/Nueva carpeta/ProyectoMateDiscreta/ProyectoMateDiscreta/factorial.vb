Public Class factorial
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, num, fac As Double
        fac = 1
        num = TextBox1.Text

        For i = 1 To num
            fac = fac * i
        Next i
        TextBox2.Text = fac
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.Volver, AudioPlayMode.Background)
        favolver.show()
    End Sub
End Class