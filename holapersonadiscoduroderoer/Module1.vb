Friend Module Module1

    Sub Main()
        ' Nos pregunta por nuestronombre de la web discoduroderoer
        Console.WriteLine("Escibe un nombre")

        Dim nombre As String = Console.ReadLine 'define una variable para aceptar texto y luego
        'la asigna a console.redline que lo recoge

        Console.WriteLine("¡Hola, " & nombre & "!") ' nos saluda

        Console.ReadKey() ' espera que apretemos una tecla para continuar en este cso cerrar el progrma


    End Sub

End Module