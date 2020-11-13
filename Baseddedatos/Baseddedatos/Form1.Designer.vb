<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PeliculasDataSet = New Baseddedatos.peliculasDataSet()
        Me.PeliculasDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActorTableAdapter = New Baseddedatos.peliculasDataSetTableAdapters.ActorTableAdapter()
        Me.TableAdapterManager = New Baseddedatos.peliculasDataSetTableAdapters.TableAdapterManager()
        Me.Peliculas_que_tengo_como_las_qu_ANTERIORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Peliculas_que_tengo_como_las_qu_ANTERIORTableAdapter = New Baseddedatos.peliculasDataSetTableAdapters.Peliculas_que_tengo_como_las_qu_ANTERIORTableAdapter()
        Me.PeliculasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeliculasTableAdapter = New Baseddedatos.peliculasDataSetTableAdapters.peliculasTableAdapter()
        CType(Me.PeliculasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeliculasDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Peliculas_que_tengo_como_las_qu_ANTERIORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeliculasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PeliculasDataSet
        '
        Me.PeliculasDataSet.DataSetName = "peliculasDataSet"
        Me.PeliculasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PeliculasDataSetBindingSource
        '
        Me.PeliculasDataSetBindingSource.DataSource = Me.PeliculasDataSet
        Me.PeliculasDataSetBindingSource.Position = 0
        '
        'ActorBindingSource
        '
        Me.ActorBindingSource.DataMember = "Actor"
        Me.ActorBindingSource.DataSource = Me.PeliculasDataSet
        '
        'ActorTableAdapter
        '
        Me.ActorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._Peliculas_que_tengo_como_las_qu___ErroresDeImportaciónTableAdapter = Nothing
        Me.TableAdapterManager.ActorTableAdapter = Me.ActorTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DirectorTableAdapter = Nothing
        Me.TableAdapterManager.Peliculas_que_tengo_como_las_qu_ANTERIORTableAdapter = Nothing
        Me.TableAdapterManager.peliculasTableAdapter = Nothing
        Me.TableAdapterManager.Tabla1TableAdapter = Nothing
        Me.TableAdapterManager.Tabla2TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Baseddedatos.peliculasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Peliculas_que_tengo_como_las_qu_ANTERIORBindingSource
        '
        Me.Peliculas_que_tengo_como_las_qu_ANTERIORBindingSource.DataMember = "Peliculas que tengo como las qu_ANTERIOR"
        Me.Peliculas_que_tengo_como_las_qu_ANTERIORBindingSource.DataSource = Me.PeliculasDataSet
        '
        'Peliculas_que_tengo_como_las_qu_ANTERIORTableAdapter
        '
        Me.Peliculas_que_tengo_como_las_qu_ANTERIORTableAdapter.ClearBeforeFill = True
        '
        'PeliculasBindingSource
        '
        Me.PeliculasBindingSource.DataMember = "peliculas"
        Me.PeliculasBindingSource.DataSource = Me.PeliculasDataSet
        '
        'PeliculasTableAdapter
        '
        Me.PeliculasTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 450)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PeliculasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeliculasDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Peliculas_que_tengo_como_las_qu_ANTERIORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeliculasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PeliculasDataSet As peliculasDataSet
    Friend WithEvents PeliculasDataSetBindingSource As BindingSource
    Friend WithEvents ActorBindingSource As BindingSource
    Friend WithEvents ActorTableAdapter As peliculasDataSetTableAdapters.ActorTableAdapter
    Friend WithEvents TableAdapterManager As peliculasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Peliculas_que_tengo_como_las_qu_ANTERIORBindingSource As BindingSource
    Friend WithEvents Peliculas_que_tengo_como_las_qu_ANTERIORTableAdapter As peliculasDataSetTableAdapters.Peliculas_que_tengo_como_las_qu_ANTERIORTableAdapter
    Friend WithEvents PeliculasBindingSource As BindingSource
    Friend WithEvents PeliculasTableAdapter As peliculasDataSetTableAdapters.peliculasTableAdapter
End Class
