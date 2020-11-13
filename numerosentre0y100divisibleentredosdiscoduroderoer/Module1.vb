Module Module1

    Sub Main()
        Dim i As Integer = 0
        While i <= 100
            If i Mod 2 <> 0 Then
                Console.WriteLine(i)

            End If
            i = i + 1
        End While
        Console.ReadKey()

    End Sub

End Module
