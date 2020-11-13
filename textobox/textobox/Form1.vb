Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Texto.Text = " jorge ignacio de vilota" ' al cuadro de tescto de le añade una infoacion
        Texto.TextAlign = HorizontalAlignment.Center ' se pone que arientacion tiene
    End Sub

    Private Sub Texto_TextChanged(sender As Object, e As EventArgs) Handles Texto.TextChanged

    End Sub
End Class
