<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro_Clase
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimeClase = New System.Windows.Forms.DateTimePicker()
        Me.GBDatos = New System.Windows.Forms.GroupBox()
        Me.TB_No_Oficio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Nombre_Materia = New System.Windows.Forms.TextBox()
        Me.LblCarrera = New System.Windows.Forms.Label()
        Me.TB_Nombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.GBClave = New System.Windows.Forms.GroupBox()
        Me.TB_No_Empleado = New System.Windows.Forms.TextBox()
        Me.LblMatricula = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CB_Hora_Inicio_Clase = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker_Registro = New System.Windows.Forms.DateTimePicker()
        Me.GBBono = New System.Windows.Forms.GroupBox()
        Me.CB_Salas = New System.Windows.Forms.ComboBox()
        Me.DataGridView_Clase = New System.Windows.Forms.DataGridView()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.TB_Observaciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GBDatos.SuspendLayout()
        Me.GBClave.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBBono.SuspendLayout()
        CType(Me.DataGridView_Clase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = Global.ACCESOS.My.Resources.Resources.boton_salir
        Me.Button1.Location = New System.Drawing.Point(1303, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 55)
        Me.Button1.TabIndex = 52
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTNGuardar
        '
        Me.BTNGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.BTNGuardar.Enabled = False
        Me.BTNGuardar.Image = Global.ACCESOS.My.Resources.Resources.boton_guardar2
        Me.BTNGuardar.Location = New System.Drawing.Point(1296, 41)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(68, 58)
        Me.BTNGuardar.TabIndex = 51
        Me.BTNGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTimeClase)
        Me.GroupBox3.Location = New System.Drawing.Point(312, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 64)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha de Clase:"
        '
        'DateTimeClase
        '
        Me.DateTimeClase.Location = New System.Drawing.Point(11, 29)
        Me.DateTimeClase.Name = "DateTimeClase"
        Me.DateTimeClase.Size = New System.Drawing.Size(239, 20)
        Me.DateTimeClase.TabIndex = 20
        '
        'GBDatos
        '
        Me.GBDatos.Controls.Add(Me.TB_No_Oficio)
        Me.GBDatos.Controls.Add(Me.Label1)
        Me.GBDatos.Controls.Add(Me.TB_Nombre_Materia)
        Me.GBDatos.Controls.Add(Me.LblCarrera)
        Me.GBDatos.Controls.Add(Me.TB_Nombre)
        Me.GBDatos.Controls.Add(Me.LblNombre)
        Me.GBDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDatos.Location = New System.Drawing.Point(22, 104)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Size = New System.Drawing.Size(699, 121)
        Me.GBDatos.TabIndex = 48
        Me.GBDatos.TabStop = False
        Me.GBDatos.Text = "Datos del Maestro:"
        '
        'TB_No_Oficio
        '
        Me.TB_No_Oficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_No_Oficio.Location = New System.Drawing.Point(478, 39)
        Me.TB_No_Oficio.Name = "TB_No_Oficio"
        Me.TB_No_Oficio.Size = New System.Drawing.Size(174, 20)
        Me.TB_No_Oficio.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(537, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "No Oficio:"
        '
        'TB_Nombre_Materia
        '
        Me.TB_Nombre_Materia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Nombre_Materia.Location = New System.Drawing.Point(132, 87)
        Me.TB_Nombre_Materia.Name = "TB_Nombre_Materia"
        Me.TB_Nombre_Materia.Size = New System.Drawing.Size(520, 20)
        Me.TB_Nombre_Materia.TabIndex = 46
        '
        'LblCarrera
        '
        Me.LblCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCarrera.Location = New System.Drawing.Point(16, 89)
        Me.LblCarrera.Name = "LblCarrera"
        Me.LblCarrera.Size = New System.Drawing.Size(122, 16)
        Me.LblCarrera.TabIndex = 2
        Me.LblCarrera.Text = "Nombre de la Materia:"
        '
        'TB_Nombre
        '
        Me.TB_Nombre.Enabled = False
        Me.TB_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Nombre.Location = New System.Drawing.Point(72, 42)
        Me.TB_Nombre.Name = "TB_Nombre"
        Me.TB_Nombre.Size = New System.Drawing.Size(368, 20)
        Me.TB_Nombre.TabIndex = 44
        '
        'LblNombre
        '
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(16, 42)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(64, 16)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        '
        'GBClave
        '
        Me.GBClave.Controls.Add(Me.TB_No_Empleado)
        Me.GBClave.Controls.Add(Me.LblMatricula)
        Me.GBClave.Location = New System.Drawing.Point(22, 31)
        Me.GBClave.Name = "GBClave"
        Me.GBClave.Size = New System.Drawing.Size(258, 51)
        Me.GBClave.TabIndex = 1
        Me.GBClave.TabStop = False
        Me.GBClave.Text = "Clave Maestro:"
        '
        'TB_No_Empleado
        '
        Me.TB_No_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_No_Empleado.Location = New System.Drawing.Point(133, 25)
        Me.TB_No_Empleado.Name = "TB_No_Empleado"
        Me.TB_No_Empleado.Size = New System.Drawing.Size(104, 20)
        Me.TB_No_Empleado.TabIndex = 1
        '
        'LblMatricula
        '
        Me.LblMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMatricula.Location = New System.Drawing.Point(16, 27)
        Me.LblMatricula.Name = "LblMatricula"
        Me.LblMatricula.Size = New System.Drawing.Size(111, 18)
        Me.LblMatricula.TabIndex = 0
        Me.LblMatricula.Text = "No Empleado:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GBDatos)
        Me.GroupBox2.Controls.Add(Me.GBClave)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(743, 245)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Alumno"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CB_Hora_Inicio_Clase)
        Me.GroupBox5.Location = New System.Drawing.Point(595, 36)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(126, 59)
        Me.GroupBox5.TabIndex = 44
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Desde la Hora:"
        '
        'CB_Hora_Inicio_Clase
        '
        Me.CB_Hora_Inicio_Clase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Hora_Inicio_Clase.Items.AddRange(New Object() {"0700", "0750", "0840", "0930", "1020", "1110", "1200", "1250", "1340", "1430", "1520", "1610", "1700", "1750", "1830", "1910", "1950", "2030", "2110"})
        Me.CB_Hora_Inicio_Clase.Location = New System.Drawing.Point(16, 24)
        Me.CB_Hora_Inicio_Clase.Name = "CB_Hora_Inicio_Clase"
        Me.CB_Hora_Inicio_Clase.Size = New System.Drawing.Size(86, 24)
        Me.CB_Hora_Inicio_Clase.TabIndex = 6
        Me.CB_Hora_Inicio_Clase.Tag = ""
        Me.CB_Hora_Inicio_Clase.Text = "0700"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Registro)
        Me.GroupBox1.Location = New System.Drawing.Point(930, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 52)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha de Registro:"
        '
        'DateTimePicker_Registro
        '
        Me.DateTimePicker_Registro.Enabled = False
        Me.DateTimePicker_Registro.Location = New System.Drawing.Point(11, 29)
        Me.DateTimePicker_Registro.Name = "DateTimePicker_Registro"
        Me.DateTimePicker_Registro.Size = New System.Drawing.Size(239, 20)
        Me.DateTimePicker_Registro.TabIndex = 20
        '
        'GBBono
        '
        Me.GBBono.Controls.Add(Me.CB_Salas)
        Me.GBBono.Location = New System.Drawing.Point(772, 12)
        Me.GBBono.Name = "GBBono"
        Me.GBBono.Size = New System.Drawing.Size(126, 63)
        Me.GBBono.TabIndex = 47
        Me.GBBono.TabStop = False
        Me.GBBono.Text = "Salas"
        '
        'CB_Salas
        '
        Me.CB_Salas.Enabled = False
        Me.CB_Salas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Salas.Items.AddRange(New Object() {"IL1", "IL2", "IL3"})
        Me.CB_Salas.Location = New System.Drawing.Point(23, 29)
        Me.CB_Salas.Name = "CB_Salas"
        Me.CB_Salas.Size = New System.Drawing.Size(86, 24)
        Me.CB_Salas.TabIndex = 5
        Me.CB_Salas.Tag = ""
        Me.CB_Salas.Text = "IL2"
        '
        'DataGridView_Clase
        '
        Me.DataGridView_Clase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Clase.Location = New System.Drawing.Point(12, 263)
        Me.DataGridView_Clase.Name = "DataGridView_Clase"
        Me.DataGridView_Clase.Size = New System.Drawing.Size(1271, 421)
        Me.DataGridView_Clase.TabIndex = 54
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=148.234.110.22;Initial Catalog=CETIA;User ID=sa;Password=Facdyc2020"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'TB_Observaciones
        '
        Me.TB_Observaciones.Location = New System.Drawing.Point(764, 142)
        Me.TB_Observaciones.Multiline = True
        Me.TB_Observaciones.Name = "TB_Observaciones"
        Me.TB_Observaciones.Size = New System.Drawing.Size(512, 115)
        Me.TB_Observaciones.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(769, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 19)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Observaciones:"
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.ForeColor = System.Drawing.Color.Red
        Me.Btn_Eliminar.Location = New System.Drawing.Point(1303, 428)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(75, 45)
        Me.Btn_Eliminar.TabIndex = 57
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Registro_Clase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1383, 696)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBBono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_Observaciones)
        Me.Controls.Add(Me.DataGridView_Clase)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Registro_Clase"
        Me.Text = "Registro_Clase"
        Me.GroupBox3.ResumeLayout(False)
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        Me.GBClave.ResumeLayout(False)
        Me.GBClave.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GBBono.ResumeLayout(False)
        CType(Me.DataGridView_Clase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BTNGuardar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DateTimeClase As DateTimePicker
    Friend WithEvents GBDatos As GroupBox
    Friend WithEvents TB_No_Oficio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_Nombre_Materia As TextBox
    Friend WithEvents LblCarrera As Label
    Friend WithEvents TB_Nombre As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents GBClave As GroupBox
    Friend WithEvents LblMatricula As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CB_Hora_Inicio_Clase As ComboBox
    Friend WithEvents GBBono As GroupBox
    Friend WithEvents CB_Salas As ComboBox
    Friend WithEvents DataGridView_Clase As DataGridView
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents TB_No_Empleado As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker_Registro As DateTimePicker
    Friend WithEvents TB_Observaciones As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Eliminar As Button
End Class
