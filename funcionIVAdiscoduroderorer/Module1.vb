Module Module1

    Sub Main()
        Const VALOR_IVA As Integer = 21 ' La conatante de iva

        Console.WriteLine("Escribe el valor del producto")

        Dim producto As Double = Console.ReadLine

        'Invcoco la funcion
        ' El valor final es produto +su IVA
        Dim valor_finala = producto + IVA(VALOR_IVA, producto)

        Console.WriteLine("El valor final del producto es: " & valor_finala & " eursos")
        Console.ReadKey()

    End Sub

    Function IVA(valor_IVA As Integer, valorProducto As Double) As Double
        Return (valor_IVA / 100) * valorProducto

    End Function
End Module
