<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Entrada
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBHoraEntrada = New System.Windows.Forms.TextBox()
        Me.GBBono = New System.Windows.Forms.GroupBox()
        Me.CBSalas = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimeEntrada = New System.Windows.Forms.DateTimePicker()
        Me.GBDatos = New System.Windows.Forms.GroupBox()
        Me.TBSem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBCarrera = New System.Windows.Forms.TextBox()
        Me.LblCarrera = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.GBClave = New System.Windows.Forms.GroupBox()
        Me.LblMatricula = New System.Windows.Forms.Label()
        Me.TBMatricula = New System.Windows.Forms.TextBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CBEquipos = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GBBono.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GBDatos.SuspendLayout()
        Me.GBClave.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBHoraEntrada)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 63)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hora Entrada"
        '
        'TBHoraEntrada
        '
        Me.TBHoraEntrada.Enabled = False
        Me.TBHoraEntrada.Location = New System.Drawing.Point(30, 28)
        Me.TBHoraEntrada.Name = "TBHoraEntrada"
        Me.TBHoraEntrada.Size = New System.Drawing.Size(103, 20)
        Me.TBHoraEntrada.TabIndex = 8
        '
        'GBBono
        '
        Me.GBBono.Controls.Add(Me.CBSalas)
        Me.GBBono.Location = New System.Drawing.Point(40, 181)
        Me.GBBono.Name = "GBBono"
        Me.GBBono.Size = New System.Drawing.Size(126, 55)
        Me.GBBono.TabIndex = 42
        Me.GBBono.TabStop = False
        Me.GBBono.Text = "Salas"
        '
        'CBSalas
        '
        Me.CBSalas.Enabled = False
        Me.CBSalas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSalas.Items.AddRange(New Object() {"IL1", "IL2", "IL3"})
        Me.CBSalas.Location = New System.Drawing.Point(23, 29)
        Me.CBSalas.Name = "CBSalas"
        Me.CBSalas.Size = New System.Drawing.Size(86, 24)
        Me.CBSalas.TabIndex = 13
        Me.CBSalas.Tag = ""
        Me.CBSalas.Text = "IL1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTimeEntrada)
        Me.GroupBox3.Location = New System.Drawing.Point(52, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 52)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha de Captura:"
        '
        'DateTimeEntrada
        '
        Me.DateTimeEntrada.Enabled = False
        Me.DateTimeEntrada.Location = New System.Drawing.Point(11, 29)
        Me.DateTimeEntrada.Name = "DateTimeEntrada"
        Me.DateTimeEntrada.Size = New System.Drawing.Size(239, 20)
        Me.DateTimeEntrada.TabIndex = 20
        '
        'GBDatos
        '
        Me.GBDatos.Controls.Add(Me.TBSem)
        Me.GBDatos.Controls.Add(Me.Label1)
        Me.GBDatos.Controls.Add(Me.TBCarrera)
        Me.GBDatos.Controls.Add(Me.LblCarrera)
        Me.GBDatos.Controls.Add(Me.TBNombre)
        Me.GBDatos.Controls.Add(Me.LblNombre)
        Me.GBDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDatos.Location = New System.Drawing.Point(257, 92)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Size = New System.Drawing.Size(447, 100)
        Me.GBDatos.TabIndex = 40
        Me.GBDatos.TabStop = False
        Me.GBDatos.Text = "Datos del Alumno:"
        '
        'TBSem
        '
        Me.TBSem.Enabled = False
        Me.TBSem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSem.Location = New System.Drawing.Point(227, 77)
        Me.TBSem.Name = "TBSem"
        Me.TBSem.Size = New System.Drawing.Size(48, 20)
        Me.TBSem.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Semestre:"
        '
        'TBCarrera
        '
        Me.TBCarrera.Enabled = False
        Me.TBCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCarrera.Location = New System.Drawing.Point(72, 75)
        Me.TBCarrera.Name = "TBCarrera"
        Me.TBCarrera.Size = New System.Drawing.Size(48, 20)
        Me.TBCarrera.TabIndex = 3
        '
        'LblCarrera
        '
        Me.LblCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCarrera.Location = New System.Drawing.Point(16, 79)
        Me.LblCarrera.Name = "LblCarrera"
        Me.LblCarrera.Size = New System.Drawing.Size(56, 16)
        Me.LblCarrera.TabIndex = 2
        Me.LblCarrera.Text = "Carrera:"
        '
        'TBNombre
        '
        Me.TBNombre.Enabled = False
        Me.TBNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombre.Location = New System.Drawing.Point(72, 42)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(368, 20)
        Me.TBNombre.TabIndex = 1
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
        Me.GBClave.Controls.Add(Me.LblMatricula)
        Me.GBClave.Controls.Add(Me.TBMatricula)
        Me.GBClave.Location = New System.Drawing.Point(491, 35)
        Me.GBClave.Name = "GBClave"
        Me.GBClave.Size = New System.Drawing.Size(213, 51)
        Me.GBClave.TabIndex = 39
        Me.GBClave.TabStop = False
        Me.GBClave.Text = "Clave Alumno:"
        '
        'LblMatricula
        '
        Me.LblMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMatricula.Location = New System.Drawing.Point(16, 30)
        Me.LblMatricula.Name = "LblMatricula"
        Me.LblMatricula.Size = New System.Drawing.Size(80, 18)
        Me.LblMatricula.TabIndex = 0
        Me.LblMatricula.Text = "Matricula:"
        '
        'TBMatricula
        '
        Me.TBMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBMatricula.Location = New System.Drawing.Point(93, 29)
        Me.TBMatricula.MaxLength = 7
        Me.TBMatricula.Name = "TBMatricula"
        Me.TBMatricula.Size = New System.Drawing.Size(107, 20)
        Me.TBMatricula.TabIndex = 1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=148.234.110.22;Initial Catalog=CETIA;User ID=sa;Password=Facdyc2020"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GBBono)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(719, 279)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Alumno"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CBEquipos)
        Me.GroupBox4.Location = New System.Drawing.Point(434, 210)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(126, 55)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Equipos:"
        '
        'CBEquipos
        '
        Me.CBEquipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEquipos.Items.AddRange(New Object() {"1"})
        Me.CBEquipos.Location = New System.Drawing.Point(23, 29)
        Me.CBEquipos.Name = "CBEquipos"
        Me.CBEquipos.Size = New System.Drawing.Size(86, 24)
        Me.CBEquipos.TabIndex = 13
        Me.CBEquipos.Tag = ""
        '
        'Button1
        '
        Me.Button1.Image = Global.ACCESOS.My.Resources.Resources.boton_salir
        Me.Button1.Location = New System.Drawing.Point(12, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 55)
        Me.Button1.TabIndex = 45
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTNGuardar
        '
        Me.BTNGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.BTNGuardar.Enabled = False
        Me.BTNGuardar.Image = Global.ACCESOS.My.Resources.Resources.boton_guardar2
        Me.BTNGuardar.Location = New System.Drawing.Point(647, 289)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(68, 58)
        Me.BTNGuardar.TabIndex = 44
        Me.BTNGuardar.UseVisualStyleBackColor = False
        '
        'Registro_Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(743, 376)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GBDatos)
        Me.Controls.Add(Me.GBClave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Registro_Entrada"
        Me.Text = "Registro de entrada a Salas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBBono.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        Me.GBClave.ResumeLayout(False)
        Me.GBClave.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBHoraEntrada As System.Windows.Forms.TextBox
    Friend WithEvents GBBono As System.Windows.Forms.GroupBox
    Friend WithEvents CBSalas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimeEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents GBDatos As System.Windows.Forms.GroupBox
    Friend WithEvents TBSem As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBCarrera As System.Windows.Forms.TextBox
    Friend WithEvents LblCarrera As System.Windows.Forms.Label
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents GBClave As System.Windows.Forms.GroupBox
    Friend WithEvents LblMatricula As System.Windows.Forms.Label
    Friend WithEvents TBMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CBEquipos As System.Windows.Forms.ComboBox
End Class
