Module Module1

    Sub Main()
        'progrma sacado del desorrollador discodurodereer
        ' la tabla de multiplicar
        Console.WriteLine("escribe un n-umero") ' nos muestra por tantalla
        Dim numero As Integer = Console.ReadLine ' asigana una variable a interger un asigana a una instruccion

        For i As Integer = 1 To 10 ' asigna varible y se utliza, es la mas habitual
            ' tipoco de los años 80 que se utilizabN directamente
            Console.WriteLine(numero & " x " & i & " = " & numero * i) ' se recore por la tabla de mu,tiplicar

        Next

        Console.ReadKey() ' se espera que se pulse una tecla para cerrar el programa

    End Sub

End Module
