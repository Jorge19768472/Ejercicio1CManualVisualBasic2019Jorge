Module Module1
    Public Class Persona
        ' Gragmrento de clase
        ' declaracion e variables
        Private nombre As String
        Private edad As Integer
        Public Sub Inicializar()
            ' incilza las variales dentro del a clase Persona
            Console.SetCursorPosition(10, 7)
            Console.Write("Ingrese  un nombre: ")
            nombre = Console.ReadLine()
            Console.SetCursorPosition(10, 9)
            Console.Write("Ingrese  la edad: ")
            edad = Console.ReadLine()

        End Sub
        Public Sub Imprimir()
            ' sub de la clase Imprimerir
            Console.SetCursorPosition(10, 12)
            Console.Write("Nombre: " & nombre)
            Console.SetCursorPosition(10, 14)
            Console.Write("edad: " & edad)
        End Sub
        Public Sub esMayorEdad()
            ' compruba la edad 
            If edad > 18 Then
                Console.SetCursorPosition(10, 12)
                Console.Write("Es mayor de edad")
            Else
                Console.SetCursorPosition(10, 12)
                Console.Write("No Es mayor de edad")
            End If

        End Sub
    End Class
    Public Class Trianulo
        'clase de triangulos
        Private lado1 As Integer
        Private lado2 As Integer
        Private lado3 As Integer
        Public Sub Inicializar()
            'se enecialidacion 
            Console.SetCursorPosition(10, 7)
            Console.Write("Medida lado 1: ")
            lado1 = Console.ReadLine()
            Console.SetCursorPosition(10, 9)
            Console.Write("Medida lado 2: ")
            lado2 = Console.ReadLine()
            Console.SetCursorPosition(10, 11)
            Console.Write("Medida lado 3: ")
            lado3 = Console.ReadLine()

        End Sub
        Public Sub LadoMayor()

            ' sub Lado <myor
            Console.SetCursorPosition(10, 13)
            If lado1 > lado2 And lado1 > lado3 Then
                Console.Write("el Lado mayor es lado 1 " & lado1)

            Else
                If lado2 > lado3 Then
                    Console.Write("El dado Mayor es el lado 2: " & lado2)
                Else
                    Console.Write("El dado Mayor es el lado 3: " & lado3)
                End If
            End If
        End Sub

        Public Sub EsEquilatero()
            'sub es quilatero busca el triangulo sie equilador
            Console.SetCursorPosition(10, 15)
            If lado1 = lado2 And lado1 = lado3 Then
                Console.Write("Es un triangulo Equilatero: ")
            Else
                Console.Write(" No es un triangulo Equilatero: ")
            End If
        End Sub
    End Class
    Sub Main()
        ' Plantilla Ejercicio17ManualVisualBasic2019Jorge

        ' En esta plantilla tendrás lo basico para crear un menu
        ' con un marco que podras ver como se crear mas rapido lento
        ' segundo aumentes o bajes el valor del for en el metodo Temprizador
        ' Codigo añadido desde:
        ' http://www.tutorialesprogramacionya.com/visualbasicya/detalleconcepto.php?punto=13&codigo=13&inicio=0
        Ejercicio17ManualVisualBasic2019Jorge()

    End Sub
    Sub Ejercicio17ManualVisualBasic2019Jorge()

        Marco()
        'El menu que haty aqui lo puedes modidicarr a tu gusto 
        'Conserva la numeraracion y sustitulle el resto del texto a tus necesidads
        Console.SetCursorPosition(10, 2)
        Console.Write("Ejercicio17ManualVisualBasic2019Jorge")
        Console.SetCursorPosition(5, 5)
        Console.Write("0.- Salida")
        Console.SetCursorPosition(5, 7)
        Console.Write("1.- Nombre y edad introducción de datos por programacion clase")
        Console.SetCursorPosition(5, 9)
        Console.Write("2.- lados de un triangolo y si es equilatoreo  programacion por clase ")
        'Adrir mas opciones segun vuestras necesidades

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
        ' Declarcion de varianles y distribucion a otras pAERTES DEL CODIGO
        Dim Per1 As Persona
        Dim Triangulo1 As New Trianulo
        Dim Verdad As Boolean

        Select Case opcion
            Case 0
                Salida()
                Return
            Case 1
                ' por clases, ambas creadas por el Ide Vusaul studio 2019 prpuesto
                CodigoPorClase(opcion, Per1, Verdad)' Aqui meter nuevo codigo
            Case 2
                ' Va por clase y funcion propuesto pr el Ide Visual Studo
                Verdad = ProgracionPorClaseTriangulo(opcion, Triangulo1)
            Case Else

                'Una opcion para Controlar  las ociones no aceptadas
                OpcionErronea()
        End Select
    End Sub

    Private Function ProgracionPorClaseTriangulo(opcion As Object, Triangulo1 As Trianulo) As Boolean
        ' Funcion creado preada por el Ide De BVisual Studio 2019

        Dim Verdad As Boolean

        Borrado()
        Marco()
        Do
            Try
                Console.SetCursorPosition(10, 5)
                Console.Write("Has pulsado la ocipn: " & opcion)

                Triangulo1.Inicializar()
                Triangulo1.LadoMayor()
                Triangulo1.EsEquilatero()


                Verdad = True
                Console.ReadKey()
                Borrado()


                Ejercicio17ManualVisualBasic2019Jorge()

            Catch ex As Exception

                Console.SetCursorPosition(10, 17)
                Console.Write(ex.Message)
                Console.ReadKey()

                Verdad = False

            End Try
        Loop Until Verdad = True

        'Aqui metes nevo codigo

        Return Verdad
    End Function

    Private Sub CodigoPorClase(opcion As Object, ByRef Per1 As Persona, ByRef Verdad As Boolean)
        ' Metodo prpuesto pr el IDe visual studio la Encapsualr el fragmento, esto es el resultdo
        Borrado()

        Marco()

        Do
            Try

                Console.SetCursorPosition(10, 5)
                Console.Write("Has pulsado la opcion: " & opcion)
                Per1 = New Persona
                Per1.Inicializar()
                Per1.Imprimir()
                Per1.esMayorEdad()




                Verdad = True
                Console.ReadKey()
                Borrado()

                Ejercicio17ManualVisualBasic2019Jorge()

            Catch ex As Exception
                Console.SetCursorPosition(10, 17)
                Console.Write(ex.Message)


                Verdad = False
            End Try
        Loop Until Verdad = True
    End Sub

    Private Sub OpcionErronea()
        'En  este Metodo controlamos si los numeros introduciodos no son reconocido por el select Case anterior 
        Borrado()
        Marco()


        Console.SetCursorPosition(10, 10)
        Console.Write("OPcion no reconocida")
        Console.ReadKey()
        Borrado()

        Ejercicio17ManualVisualBasic2019Jorge()
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
