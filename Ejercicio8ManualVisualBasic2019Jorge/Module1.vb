
Module Module1

    Sub Main()
        'Ejercicio8ManualVisualBasic2019Jorge

        Menu() ' va al metodo menu

    End Sub
    Sub Menu() ' metodo menu

        Marco() ' va ha al metodo crear un marco

        ' en la posicion
        Console.SetCursorPosition(28, 1)
        'Muestra 
        Console.Write("menu")
        ' en la posicion

        Console.SetCursorPosition(10, 5)
        'Muestra por pantalla

        Console.Write("0.- Salir del programa")

        'en la posicion muetra por pantalla
        Console.SetCursorPosition(10, 7)
        Console.Write("1.- Generar dibujo alaetorio")

        Dim opcion As Integer ' declaracion de variable
        Console.SetCursorPosition(10, 15) ' en la posicion
        Console.Write("La opcion elegida: ") ' muesta 
        opcion = Val(Console.ReadLine) ' espera el valor y solo recoge la parte númerica de la expresion
        Select Case opcion 'recoge le valor
            Case 0 ' en la opcion 0
                Borrado() ' va al borrado
                Marco() ' Va al marco
                Console.SetCursorPosition(10, 10) ' en la posicion
                Console.Write("Gracas por su visita") 'Se despide
                Console.ReadKey() ' espera a que el usuario de una tecla
                Borrado() ' vuelve a borrar
                End

            Case 1 ' en la opcion 
                Borrado() ' va al metodo borodado
                Marco() ' va la metodo marco
                Randomize(Timer) ' inicuia la semilla 
                Dim fila As Integer ' estas variables filas son distintas al del marco por estar un metodo
                ' solo afecta aqui

                Dim columna As Integer ' esta variable comlumna as distinra a la del marco por estar dentro
                'de aqui 
                Dim contador As Integer ' en esta variable recorreeremos un n veces
                Dim caracter As Double ' valor del caracter
                For contador = 0 To 1000
                    fila = Int(Rnd() * 79 + 1) 'busca  un numero entre Cero y 79 
                    columna = Int(Rnd() * 20 + 1) ' busva un numero entre 0 y 20 
                    caracter = Int(Rnd() * 220 + 32) ' elige  un caracter
                    Console.SetCursorPosition(fila, columna) ' en la posicion

                    ' muestra el caracter

                    Console.Write(Chr(caracter))
                Next


            Case Else ' en cualquier otra opcion
                Borrado() ' va a borrado
                Marco() 'va la marco
                Console.SetCursorPosition(10, 10)
                Console.Write("tecla " & opcion & "  no reconocida")

        End Select
        Console.ReadKey() ' 
    End Sub
    Sub Marco()

        'declaro la variable fila como interger
        Dim fila As Integer
        'declaro columna como interger
        Dim columna As Integer
        ' Incio for next para que en la fila Cero, columna se imprima un caracterer
        ' La primera barraincuales de las variables se pueden cambiar pero de tal manera
        'que siempre se creee un marco que tiene que ser siempre proporcional
        ' los valores 
        For columna = 0 To 80 ' recorre de izquierda a derecha las columnas 
            '  de la pantalla para crear la primerra parte del marco
            Console.SetCursorPosition(columna, 0) ' en la posicion
            Console.Write("*") ' muestra
            Temporizador() ' Va al Metodo temporizador

        Next

        'Columna derecha
        For fila = 0 To 21 ' recorre las filas en el dsado derecho

            Console.SetCursorPosition(80, fila)
            Console.Write("*") ' muestra en la posicion anterior este caracter
            '            Temporizador() ' va al metodo temporizador

        Next

        For columna = 80 To 0 Step -1 ' recorre al reves la filas para crear la parte opuesta del marco
            'este volor se puede modificar segun el valor dedistancia de la pantalla
            Console.SetCursorPosition(columna, 21)
            Console.Write("*")
            Temporizador() ' Va al Metodo temporizador

        Next
        'Columnna izquierda recorre hacia arriba en el dado extermo 0 dela pantalla
        For fila = 21 To 0 Step -1 ' va a hacia atras, los valores inciales estan superditado a la longitud
            ' de la apnatalla

            Console.SetCursorPosition(0, fila) ' en la posicion
            Console.Write("*") ' muestra 
            Temporizador() ' va al metodo temporizador

        Next


    End Sub
    Sub Temporizador() ' metodo temporizador
        Dim tempo As Double
        For tempo = 0 To 100000000 ' este for controla cuanto tarda en pasar a la siguiente intruccion
            ' cuato mas o menos ceros detras de un numero del 1 al 9 haras que el tiempo se alargue o 
            'reduzca el tiempo de espera y que puedes llmamarlo desde cualquier lugar tendras en el
            'mismo tiempo en todos los sitios desde donde lo llammes

        Next

    End Sub
    Sub Borrado() ' metodo borrado
        Dim borra As Integer ' crea una variable
        For borra = 0 To 50 ' recorre de 0 a 50, este volor se puede modificar para rcorre toda la pantalla
            'segun se necesite
            Console.WriteLine() ' Hace un salto de linea

            Temporizador() ' Va al metodo de tiempo llamado Temporizador
        Next ' VUelve has ta borra llega a cincuenta
        Console.Clear()
    End Sub
End Module
