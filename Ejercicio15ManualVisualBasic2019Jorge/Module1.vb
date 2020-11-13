Module Module1

    Sub Main()
        ' Plantilla Ejercicio15ManualVisualBasic2019Jorge
        ' En esta plantilla tendrás lo basico para crear un menu
        ' con un marco que podras ver como se crear mas rapido lento
        ' segundo aumentes o bajes el valor del for en el metodo Temprizador
        Ejercicio15ManualVisualBasic2019Jorge()

    End Sub
    Sub Ejercicio15ManualVisualBasic2019Jorge()

        Marco()
        'El menu que haty aqui lo puedes modidicarr a tu gusto 
        'Conserva la numeraracion y sustitulle el resto del texto a tus necesidads
        Console.SetCursorPosition(10, 2)
        Console.Write("Ejercicio15ManualVisualBasic2019Jorge")
        Console.SetCursorPosition(5, 5)
        Console.Write("0.- Salida")
        Console.SetCursorPosition(5, 7)
        Console.Write("1.- Perietro de una circuferncia")
        Console.SetCursorPosition(5, 9)
        Console.Write("2. -Area de una circuferencia")
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


    End Sub
    Sub Marco()
        ' el marco
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
        ' este codigo distribuye el resto de opcines de codigo
        ' declara adeeás las variables que se van a utuilzar desde ese punto
        Dim Verdad As Boolean
        Dim Radio As Double
        Dim Perimetro As Double
        Dim Area As Double
        Select Case opcion
            Case 0
                Salida()
                Return
            Case 1
                ' metodo con parametros
                PerimetroDeUnaCircunferancia(opcion, Verdad, Radio, Perimetro)
            Case 2
                ' Metodo con parametros
                AreaDeCircunferencia(opcion, Verdad, Radio, Area)
            Case Else

                'Una opcion para Controlar  las ociones no aceptadas
                OpcionErronea()
        End Select
    End Sub

    Private Sub AreaDeCircunferencia(opcion As Object, ByRef Verdad As Boolean, ByRef Radio As Double, ByRef Area As Double)
        Borrado()
        Marco()
        ' recoge el datos, si el dato es correcto hace la operacion si no da un error controlado
        Do
            Try
                Console.SetCursorPosition(10, 5)
                Console.Write("La opcion elegida: " & opcion)
                Console.SetCursorPosition(10, 7)
                Console.Write("Dime el valor del radio y te dire el Area del circunferencia: ")
                Radio = Console.ReadLine()
                Area = Math.PI * Radio ^ 2
                Console.SetCursorPosition(3, 9)
                Console.WriteLine("El area de la circuferacia: " & Radio & " es: " & Format(Area, "###,###0.00 unidades"))

                Verdad = True

            Catch ex As Exception
                Console.SetCursorPosition(10, 10)
                Console.Write(ex.Message)


                Verdad = False
            End Try
        Loop Until Verdad = True

        'Aqui metes nevo codigo
        Borrado()
        Ejercicio15ManualVisualBasic2019Jorge()

    End Sub

    Private Sub PerimetroDeUnaCircunferancia(opcion As Object, ByRef Verdad As Boolean, ByRef Radio As Double, ByRef Perimetro As Double)
        Borrado()
        Marco()
        ' control de datos permitidos, si son aceptado se hace la operación y si no dará un error controlado
        Do
            Try
                Console.SetCursorPosition(10, 5)
                Console.Write("La opcion elegida: " & opcion)
                Console.SetCursorPosition(5, 7)
                Console.Write("Dime el Radio y te dire el perimetro de la circunferencia: ")
                Radio = Console.ReadLine()
                Perimetro = 2 * Math.PI * Radio
                Console.SetCursorPosition(10, 10)
                Console.Write("El perimetro de la circunferencia cuyo tadio es : " & Radio & " es " & Format(Perimetro, "###,##0.00 unidades"))

                Console.ReadKey()

                Verdad = True

            Catch ex As Exception
                Console.SetCursorPosition(10, 12)
                Console.Write(ex.Message)
                Console.ReadKey()


                Verdad = False

            End Try
        Loop Until Verdad = True

        Borrado()
        Ejercicio15ManualVisualBasic2019Jorge()
        ' Aqui meter nuevo codigo
    End Sub

    Private Sub OpcionErronea()
        'En  este Metodo controlamos si los numeros introduciodos no son reconocido por el select Case anterior 
        Borrado()
        Marco()


        Console.SetCursorPosition(10, 10)
        Console.Write("OPcion no reconocida")
        Console.ReadKey()
        Borrado()

        Ejercicio15ManualVisualBasic2019Jorge()
    End Sub

    Private Sub Salida()
        ' metodo salida
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
