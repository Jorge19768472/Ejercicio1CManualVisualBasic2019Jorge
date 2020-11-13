Module Module1

    Sub Main()
        Dim numeroAleatorio As Integer = numeroAleatorioEntre(1, 10) ' Asi se crea una funcion 
        Console.WriteLine("El numeo generado es: " & numeroAleatorio) ' muestra el numero generado por la funcion

        Console.ReadKey() ' espera respuesta del usuario


    End Sub
    Function numeroAleatorioEntre(ByVal minimo As Integer, ByVal maximo As Integer) As Integer ' La funcion que gerara 
        ' un nuero literario
        Randomize() ' iniciador de generador numero aleatorio
        Return CLng((minimo - maximo) * Rnd() + maximo) ' devuelve un moero entre 1 y 10 
    End Function ' fin de la funcin
End Module
