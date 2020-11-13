Module module1
	Sub main()
		'Programa de suma resta multiplicación y división verificando que los datos dados con los correctos
		'Progrma igual a Ejercicio4ManualVisualbasic2019Jorge
		Console.SetCursorPosition(20, 10) 'Posición del cursor
		Console.Write(“Programa de suma, resta, multiplicación y División”) ' Escribe por pantalla
		Console.SetCursorPosition(10, 12) 'Posición del cursor
		Console.Write(“1.- Suma”) ' Escribe por pantalla
		Console.SetCursorPosition(10, 14) 'Posición del cursor
		Console.Write(“2.- Resta”) ' Escribe por pantalla
		Console.SetCursorPosition(10, 16) 'Posición del cursor
		Console.Write(“3.- multiplicación”) ' Escribe por pantalla
		Console.SetCursorPosition(10, 18) 'Posición del cursor
		Console.Write(“4.- División”) ' Escribe por pantalla
		Console.SetCursorPosition(10, 20) 'Posición del cursor
		Console.Write(“opción a elegir: “) ' Escribe por pantalla

		Dim OpcionAelegir As Integer
		Dim Num1 As Double
		Dim Num2 As Double
		Dim Resultado As Double
		OpcionAelegir = Val(Console.ReadLine()) ' Recoge solo números, las letras la ignora salvo que sean el primer digito
		'Controla si el rango esta fuera de 1 y 4
		If OpcionAelegir < 1 Or OpcionAelegir > 4 Then
			Console.SetCursorPosition(10, 24) 'Posición del cursor
			Console.Write(“opción No valida “) ' Escribe por pantalla

		Else
			If OpcionAelegir = 1 Then
				Console.SetCursorPosition(10, 24) 'Posición del cursor
				Console.Write(“Dime El primer Valor “) ' Escribe por pantalla
				Num1 = CDbl(Console.ReadLine())
				Console.SetCursorPosition(10, 26) 'Posición del cursor
				Console.Write(“Dime El egundo Valor “) ' Escribe por pantalla
				Num2 = CDbl(Console.ReadLine()) ' recoge el valor 
				Resultado = Num1 + Num2
				Console.SetCursorPosition(10, 28) 'Posición del cursor
				Console.Write(“la Suma de “ & Num1 & “ + “ & Num2 & “ = “ & Resultado) ' Escribe por pantalla
			Else
				If OpcionAelegir = 2 Then
					Console.SetCursorPosition(10, 24) 'Posición del cursor
					Console.Write(“Dime El primer Valor “) ' Escribe por pantalla
					Num1 = CDbl(Console.ReadLine())
					Console.SetCursorPosition(10, 26) 'Posición del cursor
					Console.Write(“Dime El segundo Valor “) ' Escribe por pantalla
					Num2 = CDbl(Console.ReadLine()) ' recoge el valor 
					Resultado = Num1 * Num2
					Console.SetCursorPosition(10, 28) 'Posición del cursor
					Console.Write(“la Resta de “ & Num1 & “ - “ & Num2 & “ = “ & Resultado) ' Escribe por pantalla
				Else
					If OpcionAelegir = 3 Then
						Console.SetCursorPosition(10, 24) 'Posición del cursor
						Console.Write(“Dime El primer Valor “) ' Escribe por pantalla
						Num1 = CDbl(Console.ReadLine())
						Console.SetCursorPosition(10, 26) 'Posición del cursor
						Console.Write(“Dime El segundo Valor “) ' Escribe por pantalla
						Num2 = CDbl(Console.ReadLine()) ' recoge el valor 
						Resultado = Num1 * Num2
						Console.SetCursorPosition(10, 28) 'Posición del cursor
						Console.Write(“la Multiolicacion de “ & Num1 & “ * “ & Num2 & “ = “ & Resultado) ' Escribe por pantalla
					Else
						Console.SetCursorPosition(10, 24) 'Posición del cursor
						Console.Write(“Dime El primer Valor “) ' Escribe por pantalla
						Num1 = CDbl(Console.ReadLine())
						Console.SetCursorPosition(10, 26) 'Posición del cursor
						Console.Write(“Dime El egundo Valor “) ' Escribe por pantalla
						Num2 = CDbl(Console.ReadLine()) ' recoge el valor 
						Resultado = Num1 / Num2
						Console.SetCursorPosition(10, 28) 'Posición del cursor
						Console.Write(“la Division de “ & Num1 & “ / “ & Num2 & “ = “ & Resultado) ' Escribe por pantalla

					End If

				End If
			End If
		End If

		Console.ReadKey() ' Espera respuesta del usuario
	End Sub
End Module

