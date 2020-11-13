Module Module1

    Sub Main()
        Dim numeros(9) As Integer '  arrays
        Dim suma As Integer = 0 ' variable suma
        For i As Integer = 0 To numeros.Length - 1 ' for 
            Console.WriteLine("inserta un numero en la posicion " & i) ' pide un valor para poscion que muestra
            numeros(i) = Console.ReadLine() ' recoge el valor
            suma += numeros(i) ' suma el conteido de numero(i) hasta que finaliza el arrays

        Next ' fin for 
        Console.WriteLine("la suma es " & suma) ' muestra la suma
        Console.ReadKey() ' espera que toquemos cualquie tecla

    End Sub

End Module
