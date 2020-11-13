Module Module1

    Sub Main()
        'Ejercicio10ManualVisualBasic2019Jorge
        'En este progrma Veeremos Subprocesos y Funcones Inspidado por Discoduro de roer
        Menu1() ' Va al metodo ménu1


    End Sub
    Sub Menu1() ' Metodo menu

        Marco() ' Metodo Marco
        Console.SetCursorPosition(20, 1) ' Instruccion de posicion
        Console.Write("Menu") ' mostrar or pantalla

        Console.SetCursorPosition(10, 4)
        Console.Write("0.- Salir")
        Console.SetCursorPosition(10, 6) ' Instruccion de posicion
        Console.Write("1.- Nombre por Subproceso") ' mostrar or pantalla

        Console.SetCursorPosition(10, 8) ' Instruccion de posicion
        Console.Write("2.- Iva por por funcion") ' mostrar or pantalla

        Console.SetCursorPosition(10, 10) ' Instruccion de posicion
        Console.Write("3.- Numero Aleatorio por funcion") ' mostrar or pantalla

        Dim opcion As Integer
        Console.SetCursorPosition(10, 20) ' Instruccion de posicion
        Console.Write("¿que opcion eliges?: ") ' instruccion de muestra por pantalla
        opcion = Val(Console.ReadLine()) ' Instruccion de recogida de datos y validando que sea un número
        Eleccion1(opcion) ' Va al metodo o funcion llevando consigo el valor reogido antarior mrnte

    End Sub
    Sub Marco() ' Método Marco
        Dim fila As Integer ' Declaracion de Variable
        Dim columna As Integer ' Declaracion variable
        For fila = 0 To 80 ' Instruccion For
            Console.SetCursorPosition(fila, 0) ' Instruccion de POsicionamiento
            Console.Write("*") ' Instruccion de mostrar en pantalla
            Temporizador() 'Método Temporizador

        Next '' fin del for
        For columna = 0 To 21 'Instruccion For

            Console.SetCursorPosition(80, columna) ' Instrruccion de posicionamiento
            Console.Write("*") ' Instruccion de mostrar portantalla
            Temporizador() ' Metodo Temporizador
        Next ' Fin for

        For fila = 80 To 1 Step -1 ' Instruccion For
            Console.SetCursorPosition(fila, 21) ' Instruccion de POsicionamiento
            Console.Write("*") ' Instruccion de mostrar en pantalla
            Temporizador() 'Método Temporizador

        Next ' fin del for
        For columna = 21 To 0 Step -1 'Instruccion For

            Console.SetCursorPosition(0, columna) ' Instrruccion de posicionamiento
            Console.Write("*") ' Instruccion de mostrar portantalla
            Temporizador() ' Metodo Temporizador
        Next ' Fin for


    End Sub
    Sub Borrado() '  Método borrado
        Dim Borra As Integer ' Declaracion de variable
        For Borra = 0 To 50 'inicio de For
            Console.WriteLine() '<mostrar por pantalla vacio
            Temporizador() ' Método Temprizador

        Next ' fin de for cuando Barra valga 50
        Console.Clear() ' despues de efecto de borrdo de pantalla se borra definitivamente


    End Sub

    Sub Temporizador() ' Método teporizador
        Dim tempo As Double 'Declaración de Variable
        For tempo = 0 To 100000000 ' recorre al variable dese 0 a 1000000
        Next

    End Sub
    Sub Eleccion1(opcion)
        Select Case opcion
            Case 0
                Salida()' metodo salida

            Case 1
                NombreSubProceso()' Va al metodo NombreSubProceso
            Case 2
                IvaPorFucnion()' Metodo que dar el Valor final de un product ocon iva
            Case 3
                NueroAlatorioEntreUnyDiez() ' Metodo que nos lleva a una funcion
            Case Else
                TeclaError() ' metoso tecla error

        End Select

    End Sub

    Private Sub NueroAlatorioEntreUnyDiez()
        Borrado() ' Metodo borrado
        Marco() ' Metodo Marco
        Dim i As Integer ' Declaracion de variable
        Dim Arrays(9) As Integer ' declaracion de mariz
        For i = 0 To 9 ' Instruccion for
            Console.SetCursorPosition(10, 7) ' instruccion de posicion
            Arrays(i) = NumAleatorioEntre(1, 10) '  recogida de funcion 
            Console.Write("Número generado: " & Arrays(i)) ' muestra por pantalla

        Next ' fin For
        For i = 0 To 9 ' inicio for
            Console.SetCursorPosition(10, 8 + i) ' Instruccion de posicionamiento
            'muestra por pantalla los resultados
            Console.Write("Los Valores recogidos en el array (" & i & ")" & " es  " & Arrays(i))
        Next ' fin for
        Console.ReadKey() ' espera a que eusuario haga algo
        Borrado() ' metodo Borrado
        Menu1() ' metodo menu

    End Sub

    Private Sub IvaPorFucnion()
        Borrado() ' Metodo Borrado
        Marco() ' metodo Marco
        Const VALOR_IVA As Integer = 21 ' Declaracion de constante
        Console.SetCursorPosition(10, 10) 'Instruccion de poscion
        Console.Write("Dime el valor del producto: ") ' Instruccion deMuestra por Pantalla
        Dim Producto As Double ' declaracion de Variable
        Producto = Val(Console.ReadLine()) ' Instruccion de recogida de vzalor y lo pasa a valor numerico
        Dim Valor_final As Double ' Declara la variable
        Valor_final = Producto + IVA(VALOR_IVA, Producto) ' Operavion que va a la funcion
        Console.SetCursorPosition(10, 12) 'Instruccion de posicion
        Console.Write("El valor final de producto es: " & Valor_final & " euros") ' Muestra por pantalla
        Console.ReadKey() 'Espera respuesta del usuario
        Borrado() ' Va al metodo borrado

        Menu1() ' Va  al metodo Menu
    End Sub

    Private Sub NombreSubProceso()

        ' Nombre por subproceso
        Borrado() ' medoto Borrado

        Marco() ' Metodo Marco
        Console.SetCursorPosition(20, 5) 'Instruccion de posicionamento del curor
        Console.Write("Nombre por suproceso") ' Instruccion de muestra por pantalla

        Console.SetCursorPosition(10, 7) ' Instruccion de posicinamiento
        Console.Write("Dime tu nomnre: ") ' Instruccuion de mostrar por pantalla
        Dim Nombre As String ' declaracion de Variable
        Nombre = Console.ReadLine()
        Saludo(Nombre) ' subproceso
        Console.ReadKey() ' espera a que el usario haga algo
        Borrado() 'Medodo borrado
        Menu1() ' Mededo menu

    End Sub

    Private Sub TeclaError()
        Borrado() ' Medtodo borrado
        Marco() ' Metodo Marco
        Console.SetCursorPosition(10, 10) ' Instruccion de posicion
        Console.Write("Tecla equivocada") ' mostrar en pantalla
        Console.ReadKey() ' espera al usuario
        Borrado() ' metodo Borrado
        Menu1() ' va de nueevo al menu

    End Sub

    Private Sub Salida()
        Borrado() ' metodo borrado

        Marco() ' medoto Marco
        Console.SetCursorPosition(10, 10) ' Instruccion de posicion
        Console.Write("Gracias por su visita") ' Muestra por pataal
        Borrado() 'Medoto Borrado

        End
    End Sub
    Sub Saludo(Nombre As String) ' sub Proceso
        ' Va mostrar mensaje en la posicion indicada
        Console.SetCursorPosition(10, 9)
        Console.Write("¡Hola " & Nombre & "!")
    End Sub
    Function IVA(Valor_IVA As Integer, valorProducto As Double) As Double ' funcion
        ' 
        Return (Valor_IVA / 100) * valorProducto ' devulve el resultado

    End Function
    Function NumAleatorioEntre(ByVal minmo As Integer, ByVal maximo As Integer) As Integer
        Randomize(Timer) ' Intruccion para crear numeros aleatrios
        Return CLng((minmo - maximo) * Rnd() + maximo) ' Devuelve el resultado de la operacion


    End Function

End Module
