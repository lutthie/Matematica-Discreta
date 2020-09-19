Public Class noprimos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = 0
        Dim num As Integer
        num = TextBox1.Text
        For i As Integer = 1 To num + 1
            If (num Mod i = 0) Then
                a = a + 1
            End If
        Next i
        If (a <> 2) Then
            TextBox2.Text = "El número no es primo."
        Else
            TextBox2.Text = "El número es primo."
        End If
        If num < 2 Then
            TextBox2.Text = "El número no es válido."
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.Volver, AudioPlayMode.Background)
        novolver.show()
    End Sub
End Class