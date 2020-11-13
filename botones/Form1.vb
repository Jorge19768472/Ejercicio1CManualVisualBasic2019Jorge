Public Class Form1
    Private Sub BtnUno_Click(sender As Object, e As EventArgs) Handles BtnUno.Click
        MsgBox("hola mundo", MsgBoxStyle.Information, "saludo")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BtnSuma_Click(sender As Object, e As EventArgs) Handles BtnSuma.Click
        Dim suma As Double

        suma = Val(Textnum1.Text) + Val(Textnum2.Text)
        MsgBox(suma)
    End Sub

    Private Sub Textnum1_TextChanged(sender As Object, e As EventArgs) Handles Textnum1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resta As Double
        resta = Val(Textnum1.Text) - Val(Textnum2.Text)
        MsgBox(resta)
    End Sub
End Class
