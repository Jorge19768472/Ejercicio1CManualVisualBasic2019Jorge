Module Module1


    Sub Main()
        'Ejercicio6Manual Basic 2019 Jorge
        ' Programa que engloba todo lo visto en los ejercios anteriores más otras
        'instrucciones  basicas
        ' declaracion de  variables 
        Dim Numero1 As Double

        Dim Fila As Double
        Dim Columna As Double
        ' el for
        For Numero1 = 0 To 1000
            Fila = Int(Rnd() * 80 + 1) ' posicion aleatoria
            Columna = Int(Rnd() * 28 + 1) ' posicion aleatoria
            Console.SetCursorPosition(Fila, Columna) ' la posicion
            Console.Write("*") ' mostra por pantalla

        Next

        Console.ReadKey() ' espera que se pulse algo el usuario



    End Sub

End Module
