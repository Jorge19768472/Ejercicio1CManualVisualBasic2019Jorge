Module Module1

    Sub Main()
        Dim numero(5) As Integer ' array de cinco elmentos
        For i As Integer = 0 To (numero.Length - 1) ' inciar for
            numero(i) = i 'inroducir en el array un valor
            Console.WriteLine(numero(i)) ' imprimie por pantalla

        Next ' siguiente numero
        Console.ReadKey() ' respuesta por teckado

    End Sub

End Module
