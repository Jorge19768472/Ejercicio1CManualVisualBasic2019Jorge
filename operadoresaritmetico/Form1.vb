Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num1, num2, operacion As Double
        num1 = 2
        num2 = 5

        ' opercion suma y lo muestra
        operacion = num1 + num2
        MsgBox(operacion.ToString)

        ' operacion resta

        operacion = num1 - num2
        MsgBox(operacion.ToString)

        'operacion  muriplcacion
        operacion = num1 * num2
        MsgBox(operacion.ToString)

        'operacion  diviosn
        operacion = num1 / num2

        MsgBox(operacion.ToString)

        'operacion  restos
        operacion = num1 Mod num2
        MsgBox(operacion.ToString)

        'operacion  resto con un número y una variable
        operacion = 5 Mod num2
        MsgBox(operacion.ToString)

        ' incremenar una variable en 1
        num1 += 1
        MsgBox(num1.ToString)

        'incrementarven en 5
        num1 += 5
        MsgBox(num1.ToString)

        'restar a una variable
        num1 -= 5
        MsgBox(num1.ToString)


    End Sub
End Class
