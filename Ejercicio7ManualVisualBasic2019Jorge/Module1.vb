Module Module1

    Sub Main()
        'Programa Ejercicio7ManualVisualBasic2019Jorge
        ' Declarar las variables y matriz
        Dim Posiciones As Integer
        Dim MatrizUnidimensonal() As Integer
        Dim Numero As Integer
        Dim PosicionIcio As Integer
        Randomize(Timer) ' Inicia la aleatoriadod
        Console.SetCursorPosition(5, 5) ' En posicion
        Console.Write("De cuantos valores tiene la matriz: ") 'Muestra en pantalla la peticion de cantidad de umeros que habra en una matriz

        Posiciones = Console.ReadLine() 'Pide saber de cuantos elementos habrá en la matriz
        ReDim MatrizUnidimensonal(Posiciones) 'redimensiona la matriz
        For PosicionIcio = 0 To Posiciones ' recorre 
            Numero = Int(Rnd() * 70 + 1) ' Numero alatoria
            MatrizUnidimensonal(PosicionIcio) = Numero ' va a la posiocn de arrar
            Console.WriteLine(Numero & " En la posicion: " & PosicionIcio) ' Muestra por pantalla

        Next
        Console.ReadKey() ' espera que el usuario 

    End Sub

End Module
