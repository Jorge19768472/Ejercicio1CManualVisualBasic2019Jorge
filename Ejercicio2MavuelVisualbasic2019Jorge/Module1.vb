Module Module1

	Sub Main()
		'Ejercio2ManualVisualBasic2019Jorge
		'Programa para sumar, restar, multiplicar, dividir y el resto utilizando if then anidados
		Dim Num1 As Double 'Primera variable declarada
		Dim Num2 As Double 'Segunda variable declarada
		Dim Resultado As Double 'Tercera variable declarada
		Console.SetCursorPosition(10, 10) 'Posición del cursor
		Console.Write(“Dime un valor”) ' Escribe por pantalla
		Num1 = Console.ReadLine() 'recoge el valor en Num1
		Console.SetCursorPosition(10, 12) 'Posición del cursor
		Console.Write(“Dime otro valor”) ' Escribe por pantalla
		Num2 = Console.ReadLine() 'recoge el valor en Num2
		Dim OpcionAelegir As String 'Variable para recoger si sumas, restas, multoplicas, divides o resto
		Console.SetCursorPosition(10, 14) 'Posición del cursor
		Console.Write(“menú de operación”) ' Escribe por pantalla
		Console.SetCursorPosition(10, 16) 'Posición del cursor
		Console.Write(“Suma ‘ S ’ o ‘ s ’ ”) ' Escribe por pantalla
		Console.SetCursorPosition(10, 16) 'Posición del cursor
		Console.Write(“Resta ‘ R ’ o ‘ r ’ ”) ' Escribe por pantalla
		Console.SetCursorPosition(10, 18) 'Posición del cursor
		Console.Write(“Multiplicacion ‘ M ’ o ‘ m ’ ”) ' Escribe por pantalla
		Console.SetCursorPosition(10, 20) 'Posición del cursor
		Console.Write(“División ‘ D ’ o ‘ d ’ ”) ' Escribe por pantalla
		Console.SetCursorPosition(10, 22) 'Posición del cursor
		Console.Write(“Elige opcion: ”) ' Escribe por pantalla


		OpcionAelegir = Console.ReadLine() 'recoge el valor en OpcionAelegir
		If OpcionAelegir = "S" Or OpcionAelegir = "s" Then
			Resultado = Num1 + Num2


			Console.SetCursorPosition(10, 24) 'Posición del cursor
			Console.Write(“La suma de “ & Num1 & ” + “ & Num2 & “ = “ & Resultado) ' Escribe por pantalla
		Else
			If OpcionAelegir = "R" Or OpcionAelegir = "r" Then
				Resultado = Num1 - Num2
				Console.SetCursorPosition(10, 24) 'Posición del cursor
				Console.Write(“La resta de “ & Num1 & ” - “ & Num2 & “ = “ & Resultado) ' Escribe por pantalla
			Else
				If OpcionAelegir = "M" Or OpcionAelegir = "m" Then
					Resultado = Num1 * Num2
					Console.SetCursorPosition(10, 24) 'Posición del cursor
					Console.Write(“La suma de “ & Num1 & ” * “ & Num2 & “ = “ & Resultado) ' Escribe por pantalla
				Else
					If OpcionAelegir = "D" Or OpcionAelegir = "d" Then
						Resultado = Num1 / Num2
						Console.SetCursorPosition(10, 24) 'Posición del cursor
						Console.Write(“La division de “ & Num1 & ” / “ & Num2 & “ = “ & Resultado) ' Escribe por pantalla
					Else
						Console.SetCursorPosition(10, 22) 'Posición del cursor
						Console.Write(“Tecla no reconocida por el sistema") ' Escribe por pantalla

					End If
				End If
			End If
		End If


		Console.ReadKey() ' Espera que el usuario responda cin cualquier tecla

	End Sub

End Module
