Public Class permutaciones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        If TextBox1.Text.Trim.Length >= 2 Then
            Dim b As Integer
            Dim i As Integer
            Dim a() As String
            b = Len(TextBox1.Text)
            ReDim a(b)
            For i = 1 To Len(TextBox1.Text)
                a(i) = Mid(TextBox1.Text, i, 1)
            Next i
            Permutaciones(a, b, b, ListBox1)
            TextBox3.Text = ListBox1.Items.Count.ToString
        Else
            My.Computer.Audio.Play(My.Resources.Volver, AudioPlayMode.Background)
            errorperm.Show()
        End If
    End Sub

    Sub Permutaciones(a() As String, ByVal j As Integer, k As Integer, lista As ListBox)
        Dim i As Integer
        Dim n As String = ""
        Dim sTemp As String
        If j = 1 Then
            For i = 1 To k
                n = n & a(i)
            Next i
            lista.Items.Add(n)
        Else
            For i = 1 To j
                sTemp = a(i)
                a(i) = a(j)
                a(j) = sTemp
                Permutaciones(a, j - 1, k, lista)
                sTemp = a(j)
                a(j) = a(i)
                a(i) = sTemp
            Next i
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.Volver, AudioPlayMode.Background)
        pervolver.Show()
    End Sub
End Class