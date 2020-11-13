Module Module1

    Sub Main()
        Console.WriteLine("Escribe un número") ' pregunta el numero a factorizar
        Dim numero As Double = Console.ReadLine() ' recoge le numero a factirzar, la variable esta en double y no en
        'intergere ya que con grandes numeros a factizar daba error de desbordamiento 
        Console.WriteLine("El facotor de " & numero & " es " & factorial(numero)) ' recoge le resultado
        Console.ReadKey() ' espera que el usuario pulse caulquier tecla


    End Sub

    Function factorial(ByVal numero As Double) As Double ' la funcion factrioal
        'creo la variable producto y la variable para hacre la operacion de factirzacion
        Dim producto = numero ' declara y asigna el valor de la varibla enrdada
        Dim i As Double
        For i = numero - 1 To 1 Step -1 ' cuenta atras con el for
            producto *= i ' hace la oeracion

        Next ' si no ha llegado a cero vuelve al for
        Return producto ' devuelve el resultado
    End Function

End Module
