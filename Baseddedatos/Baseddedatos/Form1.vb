Public Class Form1
    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PeliculasDataSet.peliculas' Puede moverla o quitarla según sea necesario.
        Me.PeliculasTableAdapter.Fill(Me.PeliculasDataSet.peliculas)
        'TODO: esta línea de código carga datos en la tabla 'PeliculasDataSet.Peliculas_que_tengo_como_las_qu_ANTERIOR' Puede moverla o quitarla según sea necesario.
        Me.Peliculas_que_tengo_como_las_qu_ANTERIORTableAdapter.Fill(Me.PeliculasDataSet.Peliculas_que_tengo_como_las_qu_ANTERIOR)
        'TODO: esta línea de código carga datos en la tabla 'PeliculasDataSet.Actor' Puede moverla o quitarla según sea necesario.
        Me.ActorTableAdapter.Fill(Me.PeliculasDataSet.Actor)

    End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Peliculas_que_tengo_como_las_qu_ANTERIORDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub IdTextBox_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ActorLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ActorTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PeliculaTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Fecha_defuncionLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Fecha_nacimentoDateTimePicker_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Fecha_nacimentoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Fecha_defuncionDateTimePicker_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PeliculaLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IdLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PeliculasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub
End Class
