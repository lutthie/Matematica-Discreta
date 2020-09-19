Public Class mcdmcm
    'MCM
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero1, numero2, mcm As Integer

        numero1 = Val(TextBox1.Text)
        numero2 = Val(TextBox2.Text)

        mcm = (numero1 / MCD(numero1, numero2)) * numero2

        TextBox3.Text = mcm

    End Sub

    Function MCD(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim a As Integer
        If (num1 < num2) Then
            a = num2
            num2 = num1
            num1 = a
        End If

        ' Algoritmo de Euclides
        While (num1 Mod num2 <> 0)
            a = num1
            num1 = num2
            num2 = a Mod num2
        End While
        MCD = num2
    End Function
    'MCD
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numero1, numero2, a As Integer

        numero1 = Val(TextBox1.Text)
        numero2 = Val(TextBox2.Text)
        TextBox4.Text = MCD(numero1, numero2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.Volver, AudioPlayMode.Background)
        mcvolver.Show()
    End Sub
End Class