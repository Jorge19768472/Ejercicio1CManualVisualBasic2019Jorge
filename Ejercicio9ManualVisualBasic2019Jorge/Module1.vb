Module Module1

    Sub Main()
        'Ejercicios9ManualVisualNasic209Jorge
        Menu1() ' Va al medodo Menú

    End Sub
    Sub Menu1()
        Marco() ' Va al metodo Marco

        Console.SetCursorPosition(30, 2) ' Instruccción de poscion
        Console.Write("Menu") ' Instruccion que muestra por pantalla
        Console.SetCursorPosition(10, 5) ' instrucción de poscion
        Console.Write("0.- salir") ' Imstruccion que muestra por pantalla
        Console.SetCursorPosition(10, 7) ' Instruccion de poscion
        Console.Write("1.- ¿Cómo te llamas?") ' Instruccion que muestra por pantalla
        Console.SetCursorPosition(10, 9) 'instruccion de posicion
        Console.Write("2.- El area De un triangulo") ' Insrucción de mostar
        Console.SetCursorPosition(10, 11) 'Instruccion de posicion
        Console.Write("3.- ¿Cual es el mayor el menor de varior numeros de un Array?") ' Instruccion de muestra en pantalla

        Dim opcion As Integer ' Declaro la variable opcion para ver que quiero elegir
        Console.SetCursorPosition(10, 20) ' Instruccion de poscion
        Console.Write("¿qué opcición eliges?: ")
        opcion = Val(Console.ReadLine()) ' recoge un valor y ademas se asegura que el valor sea numérico

        Elecion1(opcion) ' va a un metodo pero pasando la inforcion de la repuesta dada
    End Sub
    Sub Marco() ' Método marco 
        Dim fila As Integer ' Declaracion de la primera variable
        Dim columna As Integer ' Declaracion de la segunda variable


        For fila = 0 To 80 ' instruccion for que recorre valores desde un valor incial a uno final
            Console.SetCursorPosition(fila, 0) ' Instruccion de posicion que recorre unas determinadas posicones
            Console.Write("*") ' Instruccion para mostrar un valor o "*" entre comillas
            Temporizador() ' Va al metodo temporizador
        Next

        For columna = 0 To 21 ' recorre columnoa desde 0 a 21
            Console.SetCursorPosition(80, columna) ' recorre la posicion fila columnoa
            Console.Write("*") ' en la pisición muestra el caeracter "*"
            Temporizador() ' va al metodo Temporizador

        Next
        For fila = 80 To 0 Step -1 ' recorre hacia atras de 80 hasta 0 de 1 en 1
            Console.SetCursorPosition(fila, 21) 'Mostrar en la poscion fila columna 21
            Console.Write("*") ' mostrara el siguiente caracter
            Temporizador() ' va al metodo Temporizador

        Next
        For columna = 21 To 0 Step -1 'recorrer hacia atras de 21 a 0 de 1 en 1
            Console.SetCursorPosition(0, columna) ' Mostra en la fila 0  de columna
            Console.Write("*") ' Muestra el caracter 
            Temporizador() ' va al temporizador

        Next
    End Sub
    Sub Temporizador() ' Metodo Temporiado
        Dim tempo As Double ' Declracion de variable
        For tempo = 0 To 100000000 ' istruccion que recorre des un valor hasta otro, si se hace vacio
            'como en este caso lo conviertsun temporizador

        Next
    End Sub
    Sub Elecion1(opcion)
        Select Case opcion
            Case 0
                Salida() ' Va al medetodo salida

            Case 1
                HolaSenor()' Va al metodo HolaSenor
            Case 2
                AreaTriangulo()' Metodo Area de triangulo
            Case 3
                MaximoMinimo() ' Va al metodo Maximo minimo
            Case Else
                RespuestaEquivocada() ' va al metodo donde se le muestra que ha dado una aacion no reconocida 
                'por el programa

        End Select


    End Sub

    Private Sub RespuestaEquivocada()
        Borrado()
        Marco()
        Console.SetCursorPosition(5, 10)
        Console.Write("Tecla no apactada")
        Console.ReadKey()

        Borrado()
        Marco()
    End Sub

    Private Sub MaximoMinimo()
        Borrado() ' Medtodo Borrado
        Marco() ' Metodo Marco

        Dim Array1() As Double ' Declaracion de una Array
        Dim posiciones As Integer ' Declaracion de una variable
        Console.SetCursorPosition(5, 10) ' instruccion de posicion
        Console.Write("¿de cuantos numeros va constar el array?: ") ' Instrucion de mostrar por pantalla
        posiciones = Console.ReadLine() 'Instruccion de recogida de infomacin
        ReDim Array1(posiciones) ' Instruccion de redimension del Arrays
        Dim TotalPosiciones As Double ' Declara la variable que recrre todas las posicones

        For TotalPosiciones = 0 To posiciones ' RIstruccion para reccorre de un número a otro
            Console.SetCursorPosition(5, 12) ' Instruccion de posicion 
            ' Instruccion de mostrar por pantalla
            Console.Write("Dime el Valor de la posicion: " & TotalPosiciones & ": ")
            Array1(TotalPosiciones) = Val(Console.ReadLine()) ' Instruccion de recogida de valores

        Next

        Console.SetCursorPosition(5, 14) ' Instruccion de posicionamiento
        Console.Write("El Valor Mayor es :" & Array1.Max) ' Intruccion de mostra por pantalla el valor Maximo
        Console.SetCursorPosition(5, 16) ' Instruccion de posicionamiento
        Console.Write("El Valor Menor es: " & Array1.Min) ' Instuccion de mostar en pantalla el valor minimo
        Console.ReadKey() ' Instruccion de espera por parte del progrma
        Borrado() ' Va al mrco
        Menu1() ' Va al menu
    End Sub

    Private Sub AreaTriangulo()
        ' Busqueda del ara de un Tringulo
        Dim Base As Double ' declaracion de una variable
        Dim Altura As Double ' declaracion de variable
        Borrado() ' metodo Borrado
        Marco() 'Metodo Marco
        Console.SetCursorPosition(5, 10) ' instruccion de posicion
        Console.Write("Dime La base del triangulo: ") ' Instruccion de meustra por pantalla
        Base = Console.ReadLine() ' Instruccion de recogida de datos
        Console.SetCursorPosition(5, 12) 'Instruccion de posicionamiento
        Console.Write("Dime la altura del triangulo: ") ' Instrucion de muestra por partalla
        Altura = Console.ReadLine() ' Instruccion de recogida de datos

        Dim Area As Double ' declaración de la variable
        Area = Base * Altura / 2 ' recogida en variable de una poeracion Matematicas

        Console.SetCursorPosition(5, 14) ' Instruccion de poscion
        ' Muatra en pantalla los valores
        Console.Write("El area del triangulo cuya base es: " & Base & " y la alta es: " & Altura & " es: " & Area)
        Console.ReadKey() ' Instruccion de espera de reaccion usuarios
        Borrado() ' Metodo de borrado

        Menu1() ' metodo Menu1 
    End Sub

    Private Sub HolaSenor() ' Metodo HOlaSenor
        Borrado() ' metodo borrado
        Marco() ' MetodoMarco
        Console.SetCursorPosition(10, 10) ' Instruccion de posicion
        Console.Write("¿Comó te llamas? ") ' instruccion de morstra por pantalla
        Dim Nombre As String ' Declaaracion de variable
        Nombre = Console.ReadLine() ' Instrucción de recogida de valor 
        Console.SetCursorPosition(10, 12) ' Instruccion de posicion
        Console.Write("Hola Sr./a. " & Nombre) 'Instruccion de mostrar prtantalla
        Console.ReadKey() ' Instruccion de espera
        Borrado() ' Metodo Borrado
        Menu1() ' Va al metodo Menu1 de nuevo
    End Sub

    Private Sub Salida() ' Metodo Salida
        Borrado() ' Va al metodo borrado
        Marco() ' va al metodo Marco
        Console.SetCursorPosition(10, 10) ' Instrucción de mostrar la posicion
        Console.Write("Gracias por Haberme utilizado") ' Instruccion de mostraren pantalla
        Borrado() ' va al metodo de Borrado
        End
    End Sub

    Sub Borrado() ' Metodo Borrado
        Dim borrado As Integer ' Declaracion de variablr
        For borrado = 0 To 50 ' Instruccion for
            Console.WriteLine() ' instruccion vacio 
            Temporizador() ' método temporizador
        Next
        Console.Clear() ' Boora la pantalla
    End Sub

End Module
