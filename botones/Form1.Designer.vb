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
        Me.BtnUno = New System.Windows.Forms.Button()
        Me.BtnSuma = New System.Windows.Forms.Button()
        Me.Textnum1 = New System.Windows.Forms.TextBox()
        Me.Textnum2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnUno
        '
        Me.BtnUno.Location = New System.Drawing.Point(57, 176)
        Me.BtnUno.Name = "BtnUno"
        Me.BtnUno.Size = New System.Drawing.Size(75, 23)
        Me.BtnUno.TabIndex = 0
        Me.BtnUno.Text = "saludar"
        Me.BtnUno.UseVisualStyleBackColor = True
        '
        'BtnSuma
        '
        Me.BtnSuma.Location = New System.Drawing.Point(57, 89)
        Me.BtnSuma.Name = "BtnSuma"
        Me.BtnSuma.Size = New System.Drawing.Size(75, 23)
        Me.BtnSuma.TabIndex = 1
        Me.BtnSuma.Text = "Suma"
        Me.BtnSuma.UseVisualStyleBackColor = True
        '
        'Textnum1
        '
        Me.Textnum1.Location = New System.Drawing.Point(57, 36)
        Me.Textnum1.Name = "Textnum1"
        Me.Textnum1.Size = New System.Drawing.Size(100, 22)
        Me.Textnum1.TabIndex = 2
        '
        'Textnum2
        '
        Me.Textnum2.Location = New System.Drawing.Point(209, 36)
        Me.Textnum2.Name = "Textnum2"
        Me.Textnum2.Size = New System.Drawing.Size(100, 22)
        Me.Textnum2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Numro 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Numero 2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(209, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "resta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Textnum2)
        Me.Controls.Add(Me.Textnum1)
        Me.Controls.Add(Me.BtnSuma)
        Me.Controls.Add(Me.BtnUno)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUno As Button
    Friend WithEvents BtnSuma As Button
    Friend WithEvents Textnum1 As TextBox
    Friend WithEvents Textnum2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
