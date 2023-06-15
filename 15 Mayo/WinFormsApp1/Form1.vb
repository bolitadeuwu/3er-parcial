Public Class Form1
    Dim color As Long
    Dim p As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        color = RGB(0, 0, 0) 'negro
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        color = RGB(255, 0, 0) 'rojo
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        color = RGB(255, 192, 203) 'rosa
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        color = RGB(255, 255, 0) 'amarillo
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox1.Height = InputBox("Escribe el grosor del puntero:", "Altura")  'grosor puntero
        PictureBox1.Width = InputBox("Escribe el grosor del puntero:", "Ancho")

    End Sub

    Private Sub PictureBox1_MouseMove(button As Integer, shift As Integer, X As Single, Y As Single)
        If button = 1 Then
            PictureBox1.BackColor = BackColor
        End If

        If button = 2 Then
            PictureBox1.BackColor = BackColor
        End If
        If button = 3 Then
            PictureBox1.BackColor = BackColor
        End If
        If button = 4 Then
            PictureBox1.BackColor = BackColor
        End If
    End Sub

End Class
