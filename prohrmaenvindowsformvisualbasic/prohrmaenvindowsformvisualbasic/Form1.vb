Imports System.Drawing.Drawing2D
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim generator As New Random
        Dim randomValue As Integer
        randomValue = generator.Next(10, 100)
        Dim msgBoxResultado = MsgBox("Número aleatorio: " & randomValue,, "Numero generarado")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim path As New GraphicsPath()
        Dim points() As Point = {
            New Point(0, 0),
            New Point(100, 0),
            New Point(100, 100),
            New Point(0, 0)}
        path.AddLines(points)

        Dim surface As Graphics = PictureBox1.CreateGraphics
        surface.DrawPath(Pens.Black, path)

    End Sub


End Class
