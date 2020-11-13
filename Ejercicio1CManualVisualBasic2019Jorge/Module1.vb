Module Module1

	Sub Main()
		'Primerer programa del manuel Viaual basic 2019 Jorge
		' Este es un programa simple de lo que puede hacer en visual basic console
		'declaración de varibles
		Dim Num1 As Double
		Dim Num2 As Double
		Dim resultado As Double
		'Imprimo por pantalla en la posición
		Console.SetCursorPosition(10, 8)
		Console.Write("Dime el primer número: ”)
		'Recoge el primer valor 
		Num1 = Console.ReadLine()
		'Imprimo por pantalla en la posición
		Console.SetCursorPosition(10, 10)
		Console.Write("Dime el segundo número: ”)
		'Recoge el segundo valor 
		Num2 = Console.ReadLine()
		'Hace y muestra los resultados
		resultado = Num1 + Num2
		Console.SetCursorPosition(10, 12)
		Console.WriteLine("La suma de “ & Num1 & “ + “ & Num2 & “ = ” & resultado)
		resultado = Num1 - Num2
		Console.SetCursorPosition(10, 14)
		Console.WriteLine("La Resta de “ & Num1 & “ - “ & Num2 & “ = ” & resultado)
		resultado = Num1 * Num2
		Console.SetCursorPosition(10, 16)
		Console.WriteLine("La Multiplicacion de “ & Num1 & “ * “ & Num2 & “ = ” & resultado)
		resultado = Num1 / Num2
		Console.SetCursorPosition(10, 18)
		Console.WriteLine("La resto de “ & Num1 & “ / “ & Num2 & “ = ” & resultado)
		resultado = Num1 Mod Num2
		Console.SetCursorPosition(10, 20)
		Console.WriteLine("La Mod de “ & Num1 & “ Mod “ & Num2 & “ = ” & resultado)
		Console.ReadKey() 'Espera que el usuario toque alguna tecla
		'Fin del programa
	End Sub

End Module
