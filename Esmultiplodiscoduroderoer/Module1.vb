Module Module1

    Sub Main()
        Console.WriteLine("Escribe el primero número") ' Pide un numero 
        Dim numero1 As Integer = Console.ReadLine ' recoge en la variable el primer valor

        Console.WriteLine("Escribe el segundo número") ' pide el segundo valor
        Dim numero2 As Integer = Console.ReadLine 'rcoge le segundo valor
        Dim multiplo As Boolean

        multiplo = esmultiploDe(numero1, numero2) ' ' va al funcion de comparacion

        If multiplo Then ' mira es verdadero 
            Console.WriteLine("El numero " & numero1 & " es mutplipo de: " & numero2) ' muestra por tantalla si es multiplo
        Else ' si 
            Console.WriteLine("El numero " & numero1 & "  no es mutplipo de: " & numero2) ' muestra por pantalla si no lo es

        End If
        Console.ReadKey() ' espera que se pulse una tecla

    End Sub
    Function esmultiploDe(ByVal num As Integer, ByVal multiplo As Integer) As Boolean ' funcion si es multiplo o no
        Dim esmultiplo As Boolean = False ' valriable se incia a false
        If num Mod multiplo = 0 Then ' no tiene resto 
            esmultiplo = True ' pone la variable en vedadero

        End If
        Return esmultiplo ' develve el valor 


    End Function
End Module
