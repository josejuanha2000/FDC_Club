<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Incidencias
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTime_Incidencia = New System.Windows.Forms.DateTimePicker()
        Me.GBDatos = New System.Windows.Forms.GroupBox()
        Me.CBCarrera = New System.Windows.Forms.ComboBox()
        Me.CB_Semestre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblCarrera = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.GBClave = New System.Windows.Forms.GroupBox()
        Me.TBMatricula = New System.Windows.Forms.TextBox()
        Me.LblMatricula = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_Observaciones = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CB_Tipo_Incidencia = New System.Windows.Forms.ComboBox()
        Me.GBBono = New System.Windows.Forms.GroupBox()
        Me.CB_Hora_Incidencia = New System.Windows.Forms.ComboBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.GroupBox3.SuspendLayout()
        Me.GBDatos.SuspendLayout()
        Me.GBClave.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GBBono.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = Global.ACCESOS.My.Resources.Resources.boton_salir
        Me.Button1.Location = New System.Drawing.Point(12, 551)
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
        Me.BTNGuardar.Location = New System.Drawing.Point(713, 551)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(68, 58)
        Me.BTNGuardar.TabIndex = 51
        Me.BTNGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTime_Incidencia)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 52)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha de Incidencia"
        '
        'DateTime_Incidencia
        '
        Me.DateTime_Incidencia.Location = New System.Drawing.Point(11, 24)
        Me.DateTime_Incidencia.Name = "DateTime_Incidencia"
        Me.DateTime_Incidencia.Size = New System.Drawing.Size(239, 20)
        Me.DateTime_Incidencia.TabIndex = 20
        '
        'GBDatos
        '
        Me.GBDatos.Controls.Add(Me.CBCarrera)
        Me.GBDatos.Controls.Add(Me.CB_Semestre)
        Me.GBDatos.Controls.Add(Me.Label1)
        Me.GBDatos.Controls.Add(Me.LblCarrera)
        Me.GBDatos.Controls.Add(Me.TBNombre)
        Me.GBDatos.Controls.Add(Me.LblNombre)
        Me.GBDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDatos.Location = New System.Drawing.Point(55, 112)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Size = New System.Drawing.Size(544, 100)
        Me.GBDatos.TabIndex = 48
        Me.GBDatos.TabStop = False
        Me.GBDatos.Text = "Datos del Alumno:"
        '
        'CBCarrera
        '
        Me.CBCarrera.Enabled = False
        Me.CBCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCarrera.Items.AddRange(New Object() {"1", "2"})
        Me.CBCarrera.Location = New System.Drawing.Point(65, 67)
        Me.CBCarrera.Name = "CBCarrera"
        Me.CBCarrera.Size = New System.Drawing.Size(63, 24)
        Me.CBCarrera.TabIndex = 51
        Me.CBCarrera.Tag = ""
        Me.CBCarrera.Text = "1"
        '
        'CB_Semestre
        '
        Me.CB_Semestre.Enabled = False
        Me.CB_Semestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Semestre.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10"})
        Me.CB_Semestre.Location = New System.Drawing.Point(215, 67)
        Me.CB_Semestre.Name = "CB_Semestre"
        Me.CB_Semestre.Size = New System.Drawing.Size(86, 24)
        Me.CB_Semestre.TabIndex = 1
        Me.CB_Semestre.Tag = ""
        Me.CB_Semestre.Text = "01"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Semestre:"
        '
        'LblCarrera
        '
        Me.LblCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCarrera.Location = New System.Drawing.Point(16, 71)
        Me.LblCarrera.Name = "LblCarrera"
        Me.LblCarrera.Size = New System.Drawing.Size(56, 16)
        Me.LblCarrera.TabIndex = 2
        Me.LblCarrera.Text = "Carrera:"
        '
        'TBNombre
        '
        Me.TBNombre.Enabled = False
        Me.TBNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombre.Location = New System.Drawing.Point(72, 31)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(368, 20)
        Me.TBNombre.TabIndex = 2
        '
        'LblNombre
        '
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(16, 31)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(64, 16)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        '
        'GBClave
        '
        Me.GBClave.Controls.Add(Me.TBMatricula)
        Me.GBClave.Controls.Add(Me.LblMatricula)
        Me.GBClave.Location = New System.Drawing.Point(479, 28)
        Me.GBClave.Name = "GBClave"
        Me.GBClave.Size = New System.Drawing.Size(213, 51)
        Me.GBClave.TabIndex = 47
        Me.GBClave.TabStop = False
        Me.GBClave.Text = "Clave Alumno:"
        '
        'TBMatricula
        '
        Me.TBMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBMatricula.Location = New System.Drawing.Point(90, 22)
        Me.TBMatricula.MaxLength = 7
        Me.TBMatricula.Name = "TBMatricula"
        Me.TBMatricula.Size = New System.Drawing.Size(110, 20)
        Me.TBMatricula.TabIndex = 6
        '
        'LblMatricula
        '
        Me.LblMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMatricula.Location = New System.Drawing.Point(11, 23)
        Me.LblMatricula.Name = "LblMatricula"
        Me.LblMatricula.Size = New System.Drawing.Size(81, 18)
        Me.LblMatricula.TabIndex = 0
        Me.LblMatricula.Text = "Matricula:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GBBono)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GBClave)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(719, 503)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Alumno"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_Observaciones)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(48, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 203)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Observaciones"
        '
        'TB_Observaciones
        '
        Me.TB_Observaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Observaciones.Location = New System.Drawing.Point(19, 30)
        Me.TB_Observaciones.Multiline = True
        Me.TB_Observaciones.Name = "TB_Observaciones"
        Me.TB_Observaciones.Size = New System.Drawing.Size(612, 152)
        Me.TB_Observaciones.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CB_Tipo_Incidencia)
        Me.GroupBox4.Location = New System.Drawing.Point(48, 194)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(234, 79)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Incidencia:"
        '
        'CB_Tipo_Incidencia
        '
        Me.CB_Tipo_Incidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Tipo_Incidencia.Items.AddRange(New Object() {"Ficha de Acceso", "Cable HDMI", "Bocinas", "Apuntador", "Teclado", "Mouse", "Otros "})
        Me.CB_Tipo_Incidencia.Location = New System.Drawing.Point(21, 31)
        Me.CB_Tipo_Incidencia.Name = "CB_Tipo_Incidencia"
        Me.CB_Tipo_Incidencia.Size = New System.Drawing.Size(207, 24)
        Me.CB_Tipo_Incidencia.TabIndex = 6
        Me.CB_Tipo_Incidencia.Tag = ""
        Me.CB_Tipo_Incidencia.Text = "Seleccione Incidencia..."
        '
        'GBBono
        '
        Me.GBBono.Controls.Add(Me.CB_Hora_Incidencia)
        Me.GBBono.Location = New System.Drawing.Point(445, 204)
        Me.GBBono.Name = "GBBono"
        Me.GBBono.Size = New System.Drawing.Size(126, 55)
        Me.GBBono.TabIndex = 42
        Me.GBBono.TabStop = False
        Me.GBBono.Text = "Hora Incidencia"
        '
        'CB_Hora_Incidencia
        '
        Me.CB_Hora_Incidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Hora_Incidencia.Items.AddRange(New Object() {"07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30"})
        Me.CB_Hora_Incidencia.Location = New System.Drawing.Point(21, 21)
        Me.CB_Hora_Incidencia.Name = "CB_Hora_Incidencia"
        Me.CB_Hora_Incidencia.Size = New System.Drawing.Size(86, 24)
        Me.CB_Hora_Incidencia.TabIndex = 5
        Me.CB_Hora_Incidencia.Tag = ""
        Me.CB_Hora_Incidencia.Text = "07:00"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=148.234.110.22;Initial Catalog=CETIA;User ID=sa;Password=Facdyc2020"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Registro_Incidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(810, 621)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNGuardar)
        Me.Controls.Add(Me.GBDatos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Registro_Incidencias"
        Me.Text = "Registro_Incidencias"
        Me.GroupBox3.ResumeLayout(False)
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        Me.GBClave.ResumeLayout(False)
        Me.GBClave.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GBBono.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTime_Incidencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents GBDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblCarrera As System.Windows.Forms.Label
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents GBClave As System.Windows.Forms.GroupBox
    Friend WithEvents LblMatricula As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GBBono As System.Windows.Forms.GroupBox
    Friend WithEvents CB_Hora_Incidencia As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_Observaciones As System.Windows.Forms.TextBox
    Friend WithEvents CB_Tipo_Incidencia As System.Windows.Forms.ComboBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents CB_Semestre As System.Windows.Forms.ComboBox
    Friend WithEvents TBMatricula As System.Windows.Forms.TextBox
    Friend WithEvents CBCarrera As System.Windows.Forms.ComboBox
End Class
