Module Module1

    Sub Main()
        Console.WriteLine(vbCrLf + "¿Cual estu nombre ?") ' te pregunta por pantalla el nombre
        Dim name = Console.ReadLine() ' recoge lo que has dicho
        Dim currentDate = DateTime.Now ' Recoger en una variable la hora y el dia
        Console.WriteLine($" {vbCrLf} hola, {name},on {currentDate:d} at {currentDate:t }") ' muestra por pantalla el nombre uesto como la fecha y hora
        Console.WriteLine(vbCrLf + "Pulsa cualquier tecla para salir...") ' muestra que esta esperando cual quier tecla para cerrar la aplicaión
        Console.ReadKey(True) ' espera respuesta
    End Sub
End Module
