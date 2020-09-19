Public Class combinaciones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim k, n, i, j, z, c As Double
        TextBox3.Text = ""
        Dim acum1 As Double = 1
        Dim acum2 As Double = 1
        Dim acum3 As Double = 1
        Dim acum4 As Double = 1
        k = TextBox1.Text
        n = TextBox2.Text
        j = k
        c = n
        If k > n Then
            For c = (k) To 1 Step -1
                acum2 *= c
            Next
            z = k - n
            For z = (k - n) To 1 Step -1
                acum3 *= z
            Next
            i = n
            For i = (n) To 1 Step -1
                acum3 *= i
            Next
            acum1 = acum2 / (acum1 * acum3)
            TextBox3.Text = TextBox3.Text & acum1.ToString

        Else
            My.Computer.Audio.Play(My.Resources.Volver, AudioPlayMode.Background)
            errorcombi.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.Volver, AudioPlayMode.Background)
        combivolver.show()
    End Sub
End Class