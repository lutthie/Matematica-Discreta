Public Class conjuntos
    'INTERSECCION
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conjunto1() As String
        Dim conjunto2() As String
        Dim coma As String
        Dim b As Integer
        Dim a As Integer
        Dim n1 As Integer
        Dim n2 As Integer
        conjunto1 = Split(TextBox1.Text, ",")
        conjunto2 = Split(TextBox2.Text, ",")
        coma = ""
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            TextBox3.Text = ""
            n1 = UBound(conjunto1)
            n2 = UBound(conjunto2)
            For a = 0 To n1
                For b = 0 To n2
                    If conjunto1(a) = conjunto2(b) Then
                        TextBox3.Text = TextBox3.Text & coma & conjunto2(b)
                        coma = ","
                    End If
                Next
            Next
        End If
    End Sub
    'UNION
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conjunto1() As String
        Dim conjunto2() As String
        Dim coma As String

        Dim b As Integer
        Dim a As Integer

        Dim n1 As Integer
        Dim n2 As Integer

        conjunto1 = Split(TextBox1.Text, ",")
        conjunto2 = Split(TextBox2.Text, ",")

        coma = ""

        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            TextBox4.Text = ""
            n1 = UBound(conjunto1)
            n2 = UBound(conjunto2)

            For a = 0 To n1
                TextBox4.Text = TextBox4.Text & coma & conjunto1(a)
                coma = ","
            Next
            Dim ok As Boolean

            For b = 0 To n2
                ok = True
                For a = 0 To n1
                    If conjunto1(a) = conjunto2(b) Then
                        ok = False
                    End If
                Next
                If ok Then
                    TextBox4.Text = TextBox4.Text & coma & conjunto2(b)
                End If
            Next
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim CancelButtom As Integer
        CancelButtom = 0
        'sonido chido :v
        My.Computer.Audio.Play(My.Resources.Volver, AudioPlayMode.Background)
        'Boton salir
        covolver.Show()

    End Sub
End Class