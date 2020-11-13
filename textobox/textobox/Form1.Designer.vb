<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.etiquta = New System.Windows.Forms.Label()
        Me.Texto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'etiquta
        '
        Me.etiquta.AutoSize = True
        Me.etiquta.Location = New System.Drawing.Point(54, 40)
        Me.etiquta.Name = "etiquta"
        Me.etiquta.Size = New System.Drawing.Size(103, 17)
        Me.etiquta.TabIndex = 0
        Me.etiquta.Text = "Ponga un texto"
        '
        'Texto
        '
        Me.Texto.Location = New System.Drawing.Point(163, 40)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(315, 22)
        Me.Texto.TabIndex = 1
        Me.Texto.Text = "Hola mundo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Texto)
        Me.Controls.Add(Me.etiquta)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents etiquta As Label
    Friend WithEvents Texto As TextBox
End Class
