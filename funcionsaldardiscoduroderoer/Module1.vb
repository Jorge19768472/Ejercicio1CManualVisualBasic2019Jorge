Module Module1

    Sub Main()
        Console.WriteLine("Escribe un nombre")
        Dim nombre As String = Console.ReadLine()

        'invoca al subproceso
        saludador(nombre)
        Console.ReadKey()

    End Sub

    Sub saludador(nombre As String) ' el subproceso
        Console.WriteLine("¡HOLA!: " & nombre & " !")

    End Sub
End Module
