Public Class fibonacci
    'fibonacci
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        Dim series As Integer
        series = Val(TextBox1.Text)
        TextBox2.Text = ""
        a = 1
        For x = 1 To series
            If x > 2 Then
                c = a + b
                a = b
                b = c
                TextBox2.Text = TextBox2.Text & "," & Str(c)
            Else
                TextBox2.Text = Str(a)
                b = a
            End If
        Next x
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.Volver, AudioPlayMode.Background)
        fivolver.Show()
    End Sub
End Class