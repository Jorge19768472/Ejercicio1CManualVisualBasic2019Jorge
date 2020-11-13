Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arreglo(3) As String ' Arrays con tres posiciones 0, 1, 2 
        arreglo(0) = "hola" ' valor de la p,rinera poscion
        arreglo(1) = "Jorge" 'valor de la segunda posicion
        arreglo(2) = " de vilots" ' valor de la tercera posicion

        MsgBox(arreglo(0) + " " + arreglo(1) + " " + arreglo(1)) ' se mestra los contenido_
        ' de las osiciones 

        Dim arreglos() As Integer ' arrays sin una defincion de cuantos datos adquiriran
        arreglos = New Integer() {1, 2, 3} ' se ponen estos valores al arrys
        ' el msgbox siguiente cadavalor sera sacado com texto al llevar tostring
        MsgBox(arreglos(0).ToString + " " + arreglos(1).ToString + " " + arreglos(2).ToString)

        ReDim Preserve arreglos(2) ' se redimensiona a dos y se conserva los valores de las dos posiciones
        MsgBox(arreglos(0).ToString + " " + arreglos(1).ToString) ' valores guardados

        ReDim arreglos(3) ' volvemos atener tres posiciones
        MsgBox(arreglos(0).ToString + " " + arreglos(1).ToString + " " + arreglos(2).ToString) ' los valores presntados son "0"

        'matrices
        Dim matriz(,) As Integer = {{1, 2, 3}, {4, 5, 6}}
        'se muestra el de la posiicn (1,1)
        MsgBox(matriz(1, 1).ToString)

    End Sub
End Class
