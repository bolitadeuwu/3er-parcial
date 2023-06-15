Public Class Form1
    Private line As New List(Of Point)

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        line = New List(Of Point)
        line.Add(e.Location)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            line.Add(e.Location)
            Me.Invalidate()
        End If
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If line.Count > 1 Then
            e.Graphics.DrawLines(Pens.Black, line.ToArray)
        End If
    End Sub

End Class
