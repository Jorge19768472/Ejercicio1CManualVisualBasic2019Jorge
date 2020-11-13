Module Module1

    Sub Main()

        For i As Integer = 0 To 100 ' crea la varible i e incio el for
            If i Mod 2 <> 0 Then 'mira si el resto es into a cero
                Console.WriteLine(i) ' lo imp,rime por pantalla

            End If ' fin si
        Next ' for
        Console.ReadKey() ' espera respuesta por teclado 
    End Sub

End Module
