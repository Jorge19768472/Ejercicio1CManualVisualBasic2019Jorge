Module Module1

    Sub Main()
        'Ejercic3ManualVisualBaic2019 Jorge
        'Programa para sumar, restar, multiplicar, dividir y el resto utilizando if then anidados
        Dim Num1 As Double 'Primera variable declarada
        Dim Num2 As Double 'Segunda variable declarada
        Dim Resultado As Double 'Tercera variable declarada
        Console.SetCursorPosition(10, 10) 'Posición del cursor
        Console.Write(“Dime un valor: ”) ' Escribe por pantalla
        Num1 = Console.ReadLine() 'recoge el valor en Num1
        Console.SetCursorPosition(10, 12) 'Posición del cursor
        Console.Write(“Dime otro valor: ”) ' Escribe por pantalla
        Num2 = Console.ReadLine() 'recoge el valor en Num2
        Dim OpcionAelegir As String 'Variable para recoger si sumas, restas, multoplicas, divides o resto
        Console.SetCursorPosition(10, 14) 'Posición del cursor
        Console.Write(“menú de operación”) ' Escribe por pantalla
        Console.SetCursorPosition(10, 16) 'Posición del cursor
        Console.Write(“Suma ‘ S ’ o ‘ s ’ ”) ' Escribe por pantalla
        Console.SetCursorPosition(10, 16) 'Posición del cursor
        Console.Write(“Resta ‘ R ’ o ‘ r ’ ”) ' Escribe por pantalla
        Console.SetCursorPosition(10, 18) 'Posición del cursor
        Console.Write(“Multiplicacion ‘ M ’ o ‘ m ’ ”) ' Escribe por pantalla
        Console.SetCursorPosition(10, 20) 'Posición del cursor
        Console.Write(“División ‘ D ’ o ‘ d ’ ”) ' Escribe por pantalla
        Console.SetCursorPosition(10, 22) ' Posicion de pantalla
        Console.Write("Elige opcion: ") ' Escribe en pantala
        OpcionAelegir = Console.ReadLine() 'recoge el valor en OpcionAelegir
        Select Case OpcionAelegir
            Case “S”, “ s”
                Resultado = Num1 + Num2
                Console.SetCursorPosition(10, 24) 'Posición del cursor
                Console.Write(“La suma de “ & Num1 & “ + “ & Num2 & “ = “ & Resultado)' Escribe por pantalla

            Case “R”, “r”
                Resultado = Num1 - Num2
                Console.SetCursorPosition(10, 24) 'Posición del cursor
                Console.Write(“La Resta de “ & Num1 & “ - “ & Num2 & “ = “ & Resultado)' Escribe por pantalla

            Case “M”, “m”
                Resultado = Num1 * Num2
                Console.SetCursorPosition(10, 24) 'Posición del cursor
                Console.Write(“La Multiplicacion de “ & Num1 & “ * “ & Num2 & “ = “ & Resultado)' Escribe por pantalla

            Case “D”, “d”
                Resultado = Num1 / Num2
                Console.SetCursorPosition(10, 24) 'Posición del cursor
                Console.Write(“La Division de “ & Num1 & “ /“ & Num2 & “ = “ & Resultado) ' Escribe por pantalla


            Case Else
                Console.SetCursorPosition(10, 24) 'Posición del cursor
                Console.Write(“Tecla equivocada”) ' Escribe por pantalla

        End Select
        Console.ReadKey() ' Espera la respuesta del uusuario

    End Sub

End Module
