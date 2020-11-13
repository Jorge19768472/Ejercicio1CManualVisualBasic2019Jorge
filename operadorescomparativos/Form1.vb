Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resultado As Boolean ' hace que sea verdadoreo o falso

        resultado = 1 = 1  ' da el vedadoro    
        MsgBox(resultado) ' muestra que es verdarero asolo poner la variable

        resultado = 1 = 2 ' da falso 
        MsgBox(resultado) ' muestra falso solo poner la variable

        resultado = 1 > 2 ' mira si el valor primero es mayor que el segundo
        MsgBox(resultado) ' muestra falso

        resultado = 1 < 2 ' mira si el valor primero es menor que el segundo
        MsgBox(resultado) ' muestra veddadero

        resultado = 1 >= 2 ' mira si el valor primero es mayor o igual que el segundo
        MsgBox(resultado) ' muestra falso

        resultado = 1 <= 2 ' mira si el valor primero es menor o igual que el segundo
        MsgBox(resultado) ' muestra falso

        resultado = 1 <> 2 ' mira si el valor primero es difernte que el segundo
        MsgBox(resultado) ' muestra falso

        resultado = "Jorge " <> "Jorge " ' mira si el valor primero es difente que el segundo
        MsgBox(resultado) ' muestra falso

        resultado = "Jorge " <> "de villota " ' mira si el valor primero es diferente que el segundo
        MsgBox(resultado) ' muestra falso

        resultado = (2 + 1) = 3 ' mira si la suma es igal al restado propurdto
        MsgBox(resultado) ' muestra verdadero
        resultado = (2 + 1) = (5 * 1) ' mira si la suma es igal al restado propurdto
        MsgBox(resultado) ' muestra falso



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim menorque As Boolean
        menorque = numero1.Text < numero2.Text
        MsgBox(menorque)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim igual As Boolean
        igual = numero1.Text = numero2.Text
        MsgBox(igual)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mayorque As Boolean
        mayorque = numero1.Text > numero2.Text
        MsgBox(mayorque)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim menoroigual As Boolean
        menoroigual = numero1.Text <= numero2.Text
        MsgBox(menoroigual)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim mayoroigual As Boolean
        mayoroigual = numero1.Text >= numero2.Text
        MsgBox(mayoroigual)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim diferente As Boolean
        diferente = numero1.Text <> numero2.Text
        MsgBox(diferente)
    End Sub
End Class