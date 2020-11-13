Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim entero As Integer = 1 ' se crea una variable y se le inicialza en 1
        MsgBox(entero) ' se muestra or Msgbox el valor de la variable
        entero = 2 ' Se vuelve a asignar otro numero a la variable
        MsgBox(entero) ' se muestra de nuevo la variable con otro valor
        Dim numero As Double = 123.45 ' varible número asignado como double que acepta decimales
        MsgBox(numero) ' se meustra la variable núero
        numero = 12.5 ' se cambia el valor de la variablr numero
        MsgBox(numero) ' se meustra el valor de la variable numero que hemos cambiado
        Dim texto As String = "hola mundo" ' la variable treto que hemos creADO lleva la frase "hola munodo"
        MsgBox(texto) ' muesta la variable texto con el valor antes asignado
        Dim texto2 As String = " jorge villota" ' en otra variable asignada como texto 
        MsgBox(texto + texto2) ' La unio por el signo suma de las dos variables de texto
        Dim fecha As Date = "5-8-19" ' se puede utilizar vario tipos de separadores como - / 
        ' hay que estar segura como escribes las fechas y que seade forma coorects
        MsgBox(fecha)
        Dim fecha2 As Date = "5-jan-2019"  'fecha  con el nobre del mes
        MsgBox(fecha2) ' se muesta la fecha

    End Sub
End Class