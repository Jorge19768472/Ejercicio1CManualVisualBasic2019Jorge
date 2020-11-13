Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim angulo1 As Double
        Dim angulo2 As Double
        Dim angulo3 As Double
        angulo1 = Val(TextBox1.Text)
        angulo2 = Val(TextBox2.Text)
        angulo3 = Val(TextBox3.Text)
        If angulo1 = 0 Or angulo2 = 0 Or angulo3 = 0 Then
            MsgBox("No grados en los textbox", vbOK, "no hay triangulos con estos grados")
        Else
            If angulo1 + angulo2 + angulo3 > 180 Then
                MsgBox("Esto es un semicirculo o mas", vbOK, "Semicirculo o más")
            Else
                If angulo1 = angulo2 And angulo2 = angulo3 Then
                    If angulo1 <> 60 Then
                        MsgBox("no hay ningun triangulo de " & angulo1 & " grados en todos ellos", vbOK, "tipo de triangulo")
                    Else
                        MsgBox("Es un triangulo equilatero", vbOK, "Tipo de triangulo")
                    End If
                Else
                    If angulo1 = 90 Or angulo2 = 90 Or angulo3 = 90 Then
                        MsgBox("es un triangulo rectagulo", vbOK, "triangulo rectangulo")
                    Else
                        MsgBox("Es un triangulo escaleno", vbOK, "Triangulo escaleno")

                    End If

                End If


                End If
        End If


    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim longitud1 As Double
        Dim longitud2 As Double
        Dim longitud3 As Double

        longitud1 = Val(TextBox4.Text)
        longitud2 = Val(TextBox5.Text)
        longitud3 = Val(TextBox6.Text)

        If longitud1 = longitud2 And longitud2 = longitud3 Then
            MsgBox("Triangulo equuilatero", vbOK, "Triangulo por su lado")
        Else
            If longitud1 = longitud2 Or longitud1 = longitud3 Or longitud2 = longitud3 Then
                MsgBox("Es un triangulo isosceles", vbOK, "triangulo por su lado")
            Else
                MsgBox("Es un triangulo escaleno", vbOK, "triangulo por su lado")

            End If

        End If




    End Sub
End Class