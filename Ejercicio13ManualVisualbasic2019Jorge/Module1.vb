Module Module1

    Sub Main()
        ' Plantilla Ejercicio13ManualVisualbasic2019Jorge
        ' En esta plantilla tendrás lo basico para crear un menu
        ' con un marco que podras ver como se crear mas rapido lento
        ' segundo aumentes o bajes el valor del for en el metodo Temprizador
        Ejercicio13ManualVisualbasic2019Jorge()

    End Sub
    Sub Ejercicio13ManualVisualbasic2019Jorge()

        Marco()
        'El menu que haty aqui lo puedes modidicarr a tu gusto 
        'Conserva la numeraracion y sustitulle el resto del texto a tus necesidads
        Console.SetCursorPosition(10, 2)
        Console.Write("Ejercicio13ManualVisualbasic2019Jorge")
        Console.SetCursorPosition(5, 5)
        Console.Write("0.- Salida")
        Console.SetCursorPosition(5, 7)
        Console.Write("1.- Aleatorio Por Nuevo Random")
        Console.SetCursorPosition(5, 9)
        Console.Write("2. -Aleatorio Por Viejo Randon")
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
        'Crea un marco con los cuatro for
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
        Select Case opcion
            Case 0
                ' Va al metodo salido
                Salida()
                Return
            Case 1
                ' Va Al metodo AleatorioNUevoRandom
                AleatorioNuevoRandom()
            Case 2
                'Va al Metodo AleatorioViejoRandom
                AleatorioViejoRandom()

            Case Else

                'Una opcion para Controlar  las ociones no aceptadas
                OpcionErronea()
        End Select
    End Sub

    Private Sub AleatorioViejoRandom()
        Borrado() ' metodo Boorado
        Marco() ' metodo Marco
        Randomize(Timer) ' Crea la semilla para el numero 
        Dim Numero As Integer ' Declaracion dd varialbe
        Dim contador As Integer  ' declaracion de la variable
        For contador = 0 To 10 ' Inicio defor
            Numero = Int(Rnd() * 20 + 1) ' rea el numero y lo recoge en la variable
            Console.SetCursorPosition(10, 5 + contador) ' en la posicon
            Console.WriteLine("Numero alarorio fomar Antigua: " & Numero) ' Muestra el valor 


        Next ' fin for
        Console.ReadKey() ' espera que el usuario responda a algo
        Borrado() ' metodo boorado 
        Ejercicio13ManualVisualbasic2019Jorge() ' Va de nevo al metodo del principio
    End Sub

    Private Sub AleatorioNuevoRandom()

        ' Va al metodo borrado y Marco
        Borrado()
        Marco()
        'Declaracion de Variables
        Dim Aleatorio As New Random
        Dim Numero As Integer
        Dim Contador As Integer
        ' Insstruccion for que recorre de 0 a 10 
        For Contador = 0 To 10
            Numero = Aleatorio.Next(1, 20) 'una forma de busqueda un Numero alatorio  desde 1 a 20
            Console.SetCursorPosition(10, 6 + Contador)
            Console.Write("El Numero: " & Numero)
        Next

        Console.ReadKey() ' espera a que el usuario de alcuna tecla
        Borrado() ' Va al metodo borrado
        Ejercicio13ManualVisualbasic2019Jorge() ' Va de nuevo al mentodo principal

    End Sub

    Private Sub OpcionErronea()
        'En  este Metodo controlamos si los numeros introduciodos no son reconocido por el select Case anterior 
        Borrado()
        Marco()


        Console.SetCursorPosition(10, 10)
        Console.Write("OPcion no reconocida")
        Console.ReadKey() ' espera a que el usuario de alguna tecla
        Borrado() ' Va al metofdo borrado
        ' Vuelve almenu pricipal

        Ejercicio13ManualVisualbasic2019Jorge()
    End Sub

    Private Sub Salida()
        Borrado() 'Va a metodo borrado
        Marco() 'Va al metodo marco
        Console.SetCursorPosition(10, 10) 'En la posicion 
        Console.Write("Gracias pr utilizar la aplicacon") ' Moztrar en la pantalla
        Console.ReadKey() ' Espera a que el usuarion dea cual quier tecla
        Borrado() ' Va almentodo dd pantalla
        End ' Finaliza el programa
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
