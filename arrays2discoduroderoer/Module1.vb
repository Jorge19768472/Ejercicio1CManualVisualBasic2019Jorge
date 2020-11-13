Module Module1

    Sub Main()
        Dim numeros(10) As Integer
        For i As Integer = 0 To (numeros.Length - 1)

            Console.WriteLine("inserta un numero en la posicion " & i)
            numeros(i) = Console.ReadLine()

        Next
        Console.WriteLine("resultados")
        For i = 0 To (numeros.Length - 1)
            Console.WriteLine((numeros(i)))
        Next
        Console.ReadKey()

    End Sub

End Module
