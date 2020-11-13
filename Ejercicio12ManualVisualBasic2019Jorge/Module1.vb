Module Module1

    Sub Main()
        ' Plantilla Ejercicio12ManualVisualBasic2019Jorge
        ' En esta plantilla tendrás lo basico para crear un menu
        ' con un marco que podras ver como se crear mas rapido lento
        ' segundo aumentes o bajes el valor del for en el metodo Temprizador
        Ejercicio12ManualVisualBasic2019Jorge()

    End Sub
    Sub Ejercicio12ManualVisualBasic2019Jorge()

        Marco()
        'El menu que haty aqui lo puedes modidicarr a tu gusto 
        'Conserva la numeraracion y sustitulle el resto del texto a tus necesidads
        Console.SetCursorPosition(10, 2)
        Console.Write("Ejercicio12ManualVisualBasic2019Jorge")
        Console.SetCursorPosition(5, 5)
        Console.Write("0.- Salida")
        Console.SetCursorPosition(5, 7)
        Console.Write("1.- Funcion Sqr")
        Console.SetCursorPosition(5, 9)
        Console.Write("2. -Formatos  de numeros")
        'Añadrir mas opciones segun vuestras necesidades

        Dim Opcion As Integer
        Dim verdad As Boolean
        ' el sigyiente codigo controla que se introduzca un valor correcto
        Do
            Try
                Console.SetCursorPosition(10, 15)
                Console.Write("elija opcion: ")
                Opcion = Console.ReadLine()
                Eleccion(Opcion)
                verdad = True

            Catch ex As Exception
                Console.SetCursorPosition(10, 17)
                Console.Write("valor introducido no valido")
                verdad = False

            End Try

        Loop Until verdad = True
        Ejercicio12ManualVisualBasic2019Jorge()


    End Sub
    Sub Marco()
        Dim Fila As Integer
        Dim Columna As Integer
        For Columna = 0 To 80
            Console.SetCursorPosition(Columna, 0)
            Console.Write("*")
            Temporizador()

        Next
        For Fila = 0 To 21
            Console.SetCursorPosition(80, Fila)
            Console.Write("*")
            Temporizador()

        Next
        For Columna = 80 To 0 Step -1

            Console.SetCursorPosition(Columna, 21)
            Console.Write("*")
            Temporizador()

        Next
        For Fila = 21 To 0 Step -1
            Console.SetCursorPosition(0, Fila)
            Console.Write("*")
            Temporizador()

        Next

    End Sub
    Sub Temporizador()
        ' Este pequello codigo hace la vez de temporizador 
        Dim tempo As Double
        For tempo = 0 To 100000000

        Next
    End Sub
    Sub Eleccion(opcion)
        ' este codigo distribulle el resto de opcines de codigo
        Select Case opcion
            Case 0
                Salida()
                Return
            Case 1
                LaRaizde(opcion)

            Case 2
                SalidaDeFormato()
            Case Else

                'Una opcion para Controlar  las ociones no aceptadas
                OpcionErronea()
        End Select
    End Sub

    Private Sub SalidaDeFormato()

        'En este codigo encuestras la entrada da datos
        ' Te vulve a pedir los datos hasta que les des uno valido
        ' y ademas te muestra opr salida uun tipo de formato, en este caso de moneda
        Borrado()
        Marco()
        Dim moneda As Double
        Dim verdad As Boolean
        Do
            Try
                Console.SetCursorPosition(10, 10)
                Console.Write("Dime el valor: ")
                moneda = Console.ReadLine()
                Console.SetCursorPosition(10, 11)
                Console.Write(" la moneda:" & Format(moneda, "#,###.0# euros"))
                Console.ReadKey()
                verdad = True

            Catch ex As Exception
                Console.SetCursorPosition(10, 12)
                Console.Write("valor introduciodo no es valido: ")
                Console.ReadKey()

            End Try
        Loop Until verdad = True


        Borrado()
        Ejercicio12ManualVisualBasic2019Jorge()

    End Sub

    Private Sub LaRaizde(opcion As Object)
        'En este codigo contraras como se da por pantalla la raiz de un valor dado
        ' Como la repeticion hasta que el valor sea correcto
        Borrado()
        Marco()
        Console.SetCursorPosition(5, 5)
        Console.Write("Has elegiosdo la opcion: " & opcion)
        Dim verdad As Boolean
        Dim valor As Double
        Dim raiz As Double

        Do
            Try
                Console.SetCursorPosition(5, 10)
                Console.Write("Dime el valor que del que quiera la raiz cuadrada: ")
                raiz = Console.ReadLine()

                valor = Math.Sqrt(raiz)
                Console.SetCursorPosition(5, 11)
                Console.Write("La raiz Cuatrada de:" & raiz & " Es: " & valor)
                verdad = True
                Console.ReadKey()

            Catch ex As Exception
                Console.SetCursorPosition(5, 12)
                Console.Write("Valor introducido no es valido")
                Console.ReadKey()

                verdad = False

            End Try



        Loop Until verdad = True
        ' Aqui meter nuevo codigo
        Borrado()
    End Sub

    Private Sub OpcionErronea()
        'En  este Metodo controlamos si los numeros introduciodos no son reconocido por el select Case anterior 
        Borrado()
        Marco()


        Console.SetCursorPosition(10, 10)
        Console.Write("OPcion no reconocida")
        Console.ReadKey()
        Borrado()

        Ejercicio12ManualVisualBasic2019Jorge()
    End Sub

    Private Sub Salida()
        Borrado()
        Marco()
        Console.SetCursorPosition(10, 10)
        Console.Write("Gracias pr utilizar la aplicacon")
        Console.ReadKey()
        Borrado()
        End
    End Sub

    Sub Borrado()
        ' este cdigo hace una subifda de pantalla imitando un borrado hasta el efectvo
        Dim Borra As Integer
        For Borra = 0 To 50
            Console.WriteLine()
            Temporizador()

        Next
        Console.Clear()

    End Sub
End Module
