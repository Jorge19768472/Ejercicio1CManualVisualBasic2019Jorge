Public Class ForCalculadora
    Dim a As Integer, i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        MsgBox("hola")
        a = InputBox("años") ' una pregunta

        ' Depenciendo que respondes el for pone tatos mensajes como valor de años dados en ls varible a

        For i = a To 1 Step -1
            MsgBox(i)
        Next i
        'Segun el rango respondera con una selección 
        Select Case a
            Case <= 0
                MsgBox("años " & a & " no has nacido todavia")
            Case > 0
                MsgBox("años " & a & "me algro que hayas nacido")


        End Select
        ' una resta 
        a = a - 1
        ' La  variable a sale por mensaje con un valor menos del introducido en la pregunta
        MsgBox(a)
    End Sub

End Class
