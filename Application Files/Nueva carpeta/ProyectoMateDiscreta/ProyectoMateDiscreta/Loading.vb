﻿Public Class Loading
    'Al ejecutar inicia conteo
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        'Aqui va el 100% 
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

            Me.Hide()
            Menuprin.Show() 'Muestra el menu principal
        End If
    End Sub

End Class
