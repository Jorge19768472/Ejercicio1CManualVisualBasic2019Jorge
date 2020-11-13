Module Module1


    Sub Main()
        Console.WriteLine("Escribe el valor del promer número") ' pide un numero
        Dim num1 As Integer = Console.ReadLine() ' guarda el numero en la varivble num1

        Console.WriteLine("Escribe el valor del promer número") ' pide un segundo núumeo
        Dim num2 As Integer = Console.ReadLine() ' guasra el número en la variable num2

        If num1 Mod num2 = 0 Then ' mira si el resto de la divison es cero

            Console.WriteLine("el Numero: " & num1 & " es divisible por: " & num2) ' si el resto de la division es cero

        Else ' si no tiene como resto cero

            Console.WriteLine("el Numero: " & num1 & " no es divisible por: " & num2) ' si el rsto no es cero

        End If
        Console.ReadKey() ' espera que toquemeosa cualquier teclaa 

    End Sub

End Module
