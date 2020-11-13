Module Module1

    Sub Main()
        ' TriangloDePapascal en Visual Basic 2019
        ' Declaracion de Variable
        Dim Filas As Integer = 0
        Dim Columna As Integer = 0
        Dim contador As Integer = 0
        Dim posicion As Integer = 0
        Dim f As Integer = 0
        Dim c As Integer = 0
        Dim Calculo As Integer = 0
        Console.SetCursorPosition(10, 10)
        Console.Write("Dime las filas: ")
        For contador = Filas - 1 To contador >= 0 Step -1
            Columna = Columna + contador
        Next
        Triangulo(Columna)

        For f = 0 To f < Filas
            For c = 0 To c <= f
                Calculo = factorial(f) / (factorial(c) * factorial(f - c))
                triangulo(posicion) = Calculo
                posicion = posicion + 1
            Next
        Next
        posicion = 0
        Console.SetCursorPosition(10, 12)
        For f = 0 To f < Filas - 1
            Console.WriteLine(Triangulo(posicion))
            posicion = posicion + 1

        Next


    End Sub
    Sub factorial(numero)
        Dim resultado As Integer = 0
        Dim contador As Integer = 0
        If numero = 0 Then
            resultado = 1
        Else
            resultado = 1
            For contador = numero To contador > 0 Step -1
                resultado = resultado * contador

            Next


        End If


    End Sub
    Sub Triangulo(posicion)
        Dim filas As Integer
        Dim f As Integer
        Dim c As Integer
        Dim calculo As Integer

        For f = 0 To f < filas
            For c = 0 To c <= f
                Calculo = factorial(f) / (factorial(c) * factorial(f - c))
                Triangulo(posicion) = Calculo
                posicion = posicion + 1
            Next
        Next
        posicion = 0
        Console.SetCursorPosition(10, 12)
        For f = 0 To f < filas - 1
            Console.WriteLine(Triangulo(posicion))
            posicion = posicion + 1

        Next


    End Sub
End Module
