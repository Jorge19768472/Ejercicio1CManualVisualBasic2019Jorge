Module Module1

    Sub Main()
        Console.WriteLine("dime la longitud de la base") ' muesta los pide a usuario
        Dim base As Double = Console.ReadLine() ' recoge el valor de la base


        Console.WriteLine("dime la longitud de la altura") 'muestra los que pide al usuario
        Dim altura As Double = Console.ReadLine() ' recoge el valor de laaltura

        areaTriangulo(base, altura) ' va una seccion de los programas dosnde hace los calculos

        Console.ReadKey() ' despera info,acion por teclado


    End Sub
    Sub areaTriangulo(base As Double, altura As Double)
        Dim area As Double = (base * altura) / 2 ' forma del area de un triangulo
        Console.WriteLine("El area del triangulo es: " & area & " metros cuadrados") ' muestra los resulta
    End Sub
End Module