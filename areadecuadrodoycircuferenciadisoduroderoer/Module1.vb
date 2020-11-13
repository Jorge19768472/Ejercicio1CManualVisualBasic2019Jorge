Module Module1

    Sub Main()
        Console.WriteLine("escribe el valor de un radio") ' muestra informacion que pide
        Dim radio As Double = Console.ReadLine() 'asigna la variable radio como double y acepta or teclado
        Dim area As Double = Math.PI * Math.Pow(radio, 2) ' asigana la variable y la asigna una operacion

        Console.WriteLine("El area es " & area) ' muestra el area
        Console.ReadKey() 'espera resuesta por teclado

    End Sub

End Module