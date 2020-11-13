Module Module1

    Sub Main()
        Dim num As Integer ' asigna num a interger
        Do ' se inicia do loop while
            Console.WriteLine("Escribe un número entr 0 y 10") ' muestra una informacion
            num = Console.ReadLine 'la variable num recoge lo aceptdo

        Loop While num <= 0 Or num >= 10 ' fin del do lop while

        Console.WriteLine("el numero introducido es " & num) ' muestra el numero
        Console.ReadKey() ' espera erspuersta de teclado
    End Sub

End Module
