Module Module1

    Sub Main()
        Dim numeroAleatorio As Integer
        Dim i As Integer
        For i = 1 To 10 ' re
            numeroAleatorio = numAleatorioEntre(1, 10) ' recoge la varible el valor de la funcion
            Console.WriteLine("El numero generado es :" & numeroAleatorio) ' muetra el munero alatorio sacado de la funcion
        Next ' vulve al for hasta que el sea diez en este caso
        Console.ReadKey() ' espera respuesta del usuario


    End Sub
    Function numAleatorioEntre(ByVal minimo As Integer, ByVal maximo As Integer) As Integer ' las varables deben tener tener un foamato 
        'en este ejemplo todos son integer
        Randomize() ' incioa el generador de numero aleatorios
        Return CLng((minimo - maximo) * Rnd() + maximo) ' devulve un muero aleariorio
    End Function
End Module

