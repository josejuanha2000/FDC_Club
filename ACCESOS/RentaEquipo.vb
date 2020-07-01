Imports System.Data
Imports System.DateTime
Imports System.Timers
Imports System.Data.SqlClient
Public Class RentaEquipo
    Inherits System.Windows.Forms.Form
    Public Property TimeOfDay() As DateTime
        Get
        End Get
        Set(ByVal Value As DateTime)
        End Set
    End Property
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents DataTimePago As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents GBBono As System.Windows.Forms.GroupBox
    Friend WithEvents GBDatos As System.Windows.Forms.GroupBox
    Friend WithEvents TBTiempor As System.Windows.Forms.TextBox
    Friend WithEvents TBSem As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBCarrera As System.Windows.Forms.TextBox
    Friend WithEvents LblCarrera As System.Windows.Forms.Label
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents GBClave As System.Windows.Forms.GroupBox
    Friend WithEvents LblMatricula As System.Windows.Forms.Label
    Friend WithEvents TBMatricula As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents CBSalas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxEquipos As System.Windows.Forms.GroupBox
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents Btn4 As System.Windows.Forms.Button
    Friend WithEvents Bn5 As System.Windows.Forms.Button
    Friend WithEvents Btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents Btn8 As System.Windows.Forms.Button
    Friend WithEvents Btn9 As System.Windows.Forms.Button
    Friend WithEvents Btn10 As System.Windows.Forms.Button
    Friend WithEvents Btn11 As System.Windows.Forms.Button
    Friend WithEvents Btn12 As System.Windows.Forms.Button
    Friend WithEvents Btn13 As System.Windows.Forms.Button
    Friend WithEvents Btn14 As System.Windows.Forms.Button
    Friend WithEvents Btn15 As System.Windows.Forms.Button
    Friend WithEvents Btn16 As System.Windows.Forms.Button
    Friend WithEvents Btn17 As System.Windows.Forms.Button
    Friend WithEvents Btn18 As System.Windows.Forms.Button
    Friend WithEvents Btn19 As System.Windows.Forms.Button
    Friend WithEvents Btn20 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn30 As System.Windows.Forms.Button
    Friend WithEvents Btn29 As System.Windows.Forms.Button
    Friend WithEvents Btn28 As System.Windows.Forms.Button
    Friend WithEvents Btn27 As System.Windows.Forms.Button
    Friend WithEvents Btn26 As System.Windows.Forms.Button
    Friend WithEvents Btn25 As System.Windows.Forms.Button
    Friend WithEvents Btn24 As System.Windows.Forms.Button
    Friend WithEvents Btn23 As System.Windows.Forms.Button
    Friend WithEvents Btn22 As System.Windows.Forms.Button
    Friend WithEvents Btn21 As System.Windows.Forms.Button
    Friend WithEvents Btn40 As System.Windows.Forms.Button
    Friend WithEvents Btn39 As System.Windows.Forms.Button
    Friend WithEvents Btn38 As System.Windows.Forms.Button
    Friend WithEvents Btn37 As System.Windows.Forms.Button
    Friend WithEvents Btn36 As System.Windows.Forms.Button
    Friend WithEvents Btn35 As System.Windows.Forms.Button
    Friend WithEvents Btn34 As System.Windows.Forms.Button
    Friend WithEvents Btn33 As System.Windows.Forms.Button
    Friend WithEvents Btn32 As System.Windows.Forms.Button
    Friend WithEvents Btn31 As System.Windows.Forms.Button
    Friend WithEvents TBHS As System.Windows.Forms.TextBox
    Friend WithEvents TBHE As System.Windows.Forms.TextBox
    Friend WithEvents Btn60 As System.Windows.Forms.Button
    Friend WithEvents Btn59 As System.Windows.Forms.Button
    Friend WithEvents Btn58 As System.Windows.Forms.Button
    Friend WithEvents Btn57 As System.Windows.Forms.Button
    Friend WithEvents Btn56 As System.Windows.Forms.Button
    Friend WithEvents Btn55 As System.Windows.Forms.Button
    Friend WithEvents Btn54 As System.Windows.Forms.Button
    Friend WithEvents Btn53 As System.Windows.Forms.Button
    Friend WithEvents Btn52 As System.Windows.Forms.Button
    Friend WithEvents Btn51 As System.Windows.Forms.Button
    Friend WithEvents Btn50 As System.Windows.Forms.Button
    Friend WithEvents Btn49 As System.Windows.Forms.Button
    Friend WithEvents Btn48 As System.Windows.Forms.Button
    Friend WithEvents Btn47 As System.Windows.Forms.Button
    Friend WithEvents Btn46 As System.Windows.Forms.Button
    Friend WithEvents Btn45 As System.Windows.Forms.Button
    Friend WithEvents Btn44 As System.Windows.Forms.Button
    Friend WithEvents Btn43 As System.Windows.Forms.Button
    Friend WithEvents Btn42 As System.Windows.Forms.Button
    Friend WithEvents Btn41 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ASIGNA As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataTimePago = New System.Windows.Forms.DateTimePicker()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.GBBono = New System.Windows.Forms.GroupBox()
        Me.CBSalas = New System.Windows.Forms.ComboBox()
        Me.GBDatos = New System.Windows.Forms.GroupBox()
        Me.TBSem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBCarrera = New System.Windows.Forms.TextBox()
        Me.LblCarrera = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TBTiempor = New System.Windows.Forms.TextBox()
        Me.GBClave = New System.Windows.Forms.GroupBox()
        Me.LblMatricula = New System.Windows.Forms.Label()
        Me.TBMatricula = New System.Windows.Forms.TextBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxEquipos = New System.Windows.Forms.GroupBox()
        Me.Btn60 = New System.Windows.Forms.Button()
        Me.Btn59 = New System.Windows.Forms.Button()
        Me.Btn58 = New System.Windows.Forms.Button()
        Me.Btn57 = New System.Windows.Forms.Button()
        Me.Btn56 = New System.Windows.Forms.Button()
        Me.Btn55 = New System.Windows.Forms.Button()
        Me.Btn54 = New System.Windows.Forms.Button()
        Me.Btn53 = New System.Windows.Forms.Button()
        Me.Btn52 = New System.Windows.Forms.Button()
        Me.Btn51 = New System.Windows.Forms.Button()
        Me.Btn50 = New System.Windows.Forms.Button()
        Me.Btn49 = New System.Windows.Forms.Button()
        Me.Btn48 = New System.Windows.Forms.Button()
        Me.Btn47 = New System.Windows.Forms.Button()
        Me.Btn46 = New System.Windows.Forms.Button()
        Me.Btn45 = New System.Windows.Forms.Button()
        Me.Btn44 = New System.Windows.Forms.Button()
        Me.Btn43 = New System.Windows.Forms.Button()
        Me.Btn42 = New System.Windows.Forms.Button()
        Me.Btn41 = New System.Windows.Forms.Button()
        Me.Btn40 = New System.Windows.Forms.Button()
        Me.Btn39 = New System.Windows.Forms.Button()
        Me.Btn38 = New System.Windows.Forms.Button()
        Me.Btn37 = New System.Windows.Forms.Button()
        Me.Btn36 = New System.Windows.Forms.Button()
        Me.Btn35 = New System.Windows.Forms.Button()
        Me.Btn34 = New System.Windows.Forms.Button()
        Me.Btn33 = New System.Windows.Forms.Button()
        Me.Btn32 = New System.Windows.Forms.Button()
        Me.Btn31 = New System.Windows.Forms.Button()
        Me.Btn30 = New System.Windows.Forms.Button()
        Me.Btn29 = New System.Windows.Forms.Button()
        Me.Btn28 = New System.Windows.Forms.Button()
        Me.Btn27 = New System.Windows.Forms.Button()
        Me.Btn26 = New System.Windows.Forms.Button()
        Me.Btn25 = New System.Windows.Forms.Button()
        Me.Btn24 = New System.Windows.Forms.Button()
        Me.Btn23 = New System.Windows.Forms.Button()
        Me.Btn22 = New System.Windows.Forms.Button()
        Me.Btn21 = New System.Windows.Forms.Button()
        Me.Btn20 = New System.Windows.Forms.Button()
        Me.Btn19 = New System.Windows.Forms.Button()
        Me.Btn18 = New System.Windows.Forms.Button()
        Me.Btn17 = New System.Windows.Forms.Button()
        Me.Btn16 = New System.Windows.Forms.Button()
        Me.Btn15 = New System.Windows.Forms.Button()
        Me.Btn14 = New System.Windows.Forms.Button()
        Me.Btn13 = New System.Windows.Forms.Button()
        Me.Btn12 = New System.Windows.Forms.Button()
        Me.Btn11 = New System.Windows.Forms.Button()
        Me.Btn10 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Bn5 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TBHE = New System.Windows.Forms.TextBox()
        Me.ASIGNA = New System.Windows.Forms.Button()
        Me.TBHS = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GBBono.SuspendLayout()
        Me.GBDatos.SuspendLayout()
        Me.GBClave.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxEquipos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataTimePago
        '
        Me.DataTimePago.Enabled = False
        Me.DataTimePago.Location = New System.Drawing.Point(316, 27)
        Me.DataTimePago.Name = "DataTimePago"
        Me.DataTimePago.Size = New System.Drawing.Size(208, 20)
        Me.DataTimePago.TabIndex = 12
        '
        'BtnOk
        '
        Me.BtnOk.Enabled = False
        Me.BtnOk.Location = New System.Drawing.Point(208, 16)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(32, 23)
        Me.BtnOk.TabIndex = 10
        Me.BtnOk.Text = "Ok"
        '
        'GBBono
        '
        Me.GBBono.Controls.Add(Me.CBSalas)
        Me.GBBono.Location = New System.Drawing.Point(12, 179)
        Me.GBBono.Name = "GBBono"
        Me.GBBono.Size = New System.Drawing.Size(126, 52)
        Me.GBBono.TabIndex = 9
        Me.GBBono.TabStop = False
        Me.GBBono.Text = "Salas"
        '
        'CBSalas
        '
        Me.CBSalas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSalas.Items.AddRange(New Object() {"L1", "L2", "L3"})
        Me.CBSalas.Location = New System.Drawing.Point(17, 19)
        Me.CBSalas.Name = "CBSalas"
        Me.CBSalas.Size = New System.Drawing.Size(86, 24)
        Me.CBSalas.TabIndex = 13
        Me.CBSalas.Tag = ""
        Me.CBSalas.Text = "L1"
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
        Me.GBDatos.Location = New System.Drawing.Point(10, 64)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Size = New System.Drawing.Size(514, 109)
        Me.GBDatos.TabIndex = 8
        Me.GBDatos.TabStop = False
        Me.GBDatos.Text = "Datos del Alumno:"
        '
        'TBSem
        '
        Me.TBSem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSem.Location = New System.Drawing.Point(227, 65)
        Me.TBSem.Name = "TBSem"
        Me.TBSem.Size = New System.Drawing.Size(48, 20)
        Me.TBSem.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Semestre:"
        '
        'TBCarrera
        '
        Me.TBCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCarrera.Location = New System.Drawing.Point(80, 68)
        Me.TBCarrera.Name = "TBCarrera"
        Me.TBCarrera.Size = New System.Drawing.Size(48, 20)
        Me.TBCarrera.TabIndex = 3
        '
        'LblCarrera
        '
        Me.LblCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCarrera.Location = New System.Drawing.Point(16, 68)
        Me.LblCarrera.Name = "LblCarrera"
        Me.LblCarrera.Size = New System.Drawing.Size(56, 16)
        Me.LblCarrera.TabIndex = 2
        Me.LblCarrera.Text = "Carrera:"
        '
        'TBNombre
        '
        Me.TBNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombre.Location = New System.Drawing.Point(72, 32)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(368, 20)
        Me.TBNombre.TabIndex = 1
        '
        'LblNombre
        '
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(16, 32)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(64, 16)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        '
        'TBTiempor
        '
        Me.TBTiempor.Enabled = False
        Me.TBTiempor.Location = New System.Drawing.Point(15, 19)
        Me.TBTiempor.Name = "TBTiempor"
        Me.TBTiempor.Size = New System.Drawing.Size(72, 20)
        Me.TBTiempor.TabIndex = 7
        '
        'GBClave
        '
        Me.GBClave.Controls.Add(Me.LblMatricula)
        Me.GBClave.Controls.Add(Me.TBMatricula)
        Me.GBClave.Controls.Add(Me.BtnOk)
        Me.GBClave.Location = New System.Drawing.Point(12, 10)
        Me.GBClave.Name = "GBClave"
        Me.GBClave.Size = New System.Drawing.Size(256, 48)
        Me.GBClave.TabIndex = 7
        Me.GBClave.TabStop = False
        Me.GBClave.Text = "Clave:"
        '
        'LblMatricula
        '
        Me.LblMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMatricula.Location = New System.Drawing.Point(16, 16)
        Me.LblMatricula.Name = "LblMatricula"
        Me.LblMatricula.Size = New System.Drawing.Size(72, 16)
        Me.LblMatricula.TabIndex = 0
        Me.LblMatricula.Text = "Matricula:"
        '
        'TBMatricula
        '
        Me.TBMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBMatricula.Location = New System.Drawing.Point(112, 16)
        Me.TBMatricula.MaxLength = 7
        Me.TBMatricula.Name = "TBMatricula"
        Me.TBMatricula.Size = New System.Drawing.Size(88, 20)
        Me.TBMatricula.TabIndex = 1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=148.234.110.22;Initial Catalog=CETIA;User ID=sa;Password=Facdyc2020"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBTiempor)
        Me.GroupBox1.Location = New System.Drawing.Point(196, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 48)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tiempo Bono"
        '
        'GroupBoxEquipos
        '
        Me.GroupBoxEquipos.Controls.Add(Me.Btn60)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn59)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn58)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn57)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn56)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn55)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn54)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn53)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn52)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn51)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn50)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn49)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn48)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn47)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn46)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn45)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn44)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn43)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn42)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn41)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn40)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn39)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn38)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn37)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn36)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn35)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn34)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn33)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn32)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn31)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn30)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn29)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn28)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn27)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn26)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn25)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn24)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn23)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn22)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn21)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn20)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn19)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn18)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn17)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn16)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn15)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn14)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn13)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn12)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn11)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn10)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn9)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn8)
        Me.GroupBoxEquipos.Controls.Add(Me.btn7)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn6)
        Me.GroupBoxEquipos.Controls.Add(Me.Bn5)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn4)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn3)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn2)
        Me.GroupBoxEquipos.Controls.Add(Me.Btn1)
        Me.GroupBoxEquipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxEquipos.Location = New System.Drawing.Point(12, 242)
        Me.GroupBoxEquipos.Name = "GroupBoxEquipos"
        Me.GroupBoxEquipos.Size = New System.Drawing.Size(684, 352)
        Me.GroupBoxEquipos.TabIndex = 13
        Me.GroupBoxEquipos.TabStop = False
        Me.GroupBoxEquipos.Text = "Equipos:"
        '
        'Btn60
        '
        Me.Btn60.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn60.Location = New System.Drawing.Point(600, 285)
        Me.Btn60.Name = "Btn60"
        Me.Btn60.Size = New System.Drawing.Size(58, 48)
        Me.Btn60.TabIndex = 59
        Me.Btn60.Text = "60"
        Me.Btn60.UseVisualStyleBackColor = False
        '
        'Btn59
        '
        Me.Btn59.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn59.Location = New System.Drawing.Point(536, 285)
        Me.Btn59.Name = "Btn59"
        Me.Btn59.Size = New System.Drawing.Size(58, 48)
        Me.Btn59.TabIndex = 58
        Me.Btn59.Text = "59"
        Me.Btn59.UseVisualStyleBackColor = False
        '
        'Btn58
        '
        Me.Btn58.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn58.Location = New System.Drawing.Point(471, 285)
        Me.Btn58.Name = "Btn58"
        Me.Btn58.Size = New System.Drawing.Size(58, 48)
        Me.Btn58.TabIndex = 57
        Me.Btn58.Text = "58"
        Me.Btn58.UseVisualStyleBackColor = False
        '
        'Btn57
        '
        Me.Btn57.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn57.Location = New System.Drawing.Point(407, 285)
        Me.Btn57.Name = "Btn57"
        Me.Btn57.Size = New System.Drawing.Size(58, 48)
        Me.Btn57.TabIndex = 56
        Me.Btn57.Text = "57"
        Me.Btn57.UseVisualStyleBackColor = False
        '
        'Btn56
        '
        Me.Btn56.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn56.Location = New System.Drawing.Point(343, 285)
        Me.Btn56.Name = "Btn56"
        Me.Btn56.Size = New System.Drawing.Size(58, 48)
        Me.Btn56.TabIndex = 55
        Me.Btn56.Text = "56"
        Me.Btn56.UseVisualStyleBackColor = False
        '
        'Btn55
        '
        Me.Btn55.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn55.Location = New System.Drawing.Point(280, 285)
        Me.Btn55.Name = "Btn55"
        Me.Btn55.Size = New System.Drawing.Size(58, 48)
        Me.Btn55.TabIndex = 54
        Me.Btn55.Text = "55"
        Me.Btn55.UseVisualStyleBackColor = False
        '
        'Btn54
        '
        Me.Btn54.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn54.Location = New System.Drawing.Point(216, 285)
        Me.Btn54.Name = "Btn54"
        Me.Btn54.Size = New System.Drawing.Size(58, 48)
        Me.Btn54.TabIndex = 53
        Me.Btn54.Text = "54"
        Me.Btn54.UseVisualStyleBackColor = False
        '
        'Btn53
        '
        Me.Btn53.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn53.Location = New System.Drawing.Point(153, 285)
        Me.Btn53.Name = "Btn53"
        Me.Btn53.Size = New System.Drawing.Size(58, 48)
        Me.Btn53.TabIndex = 52
        Me.Btn53.Text = "53"
        Me.Btn53.UseVisualStyleBackColor = False
        '
        'Btn52
        '
        Me.Btn52.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn52.Location = New System.Drawing.Point(90, 285)
        Me.Btn52.Name = "Btn52"
        Me.Btn52.Size = New System.Drawing.Size(58, 48)
        Me.Btn52.TabIndex = 51
        Me.Btn52.Text = "52"
        Me.Btn52.UseVisualStyleBackColor = False
        '
        'Btn51
        '
        Me.Btn51.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn51.Location = New System.Drawing.Point(26, 285)
        Me.Btn51.Name = "Btn51"
        Me.Btn51.Size = New System.Drawing.Size(58, 48)
        Me.Btn51.TabIndex = 50
        Me.Btn51.Text = "51"
        Me.Btn51.UseVisualStyleBackColor = False
        '
        'Btn50
        '
        Me.Btn50.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn50.Location = New System.Drawing.Point(600, 233)
        Me.Btn50.Name = "Btn50"
        Me.Btn50.Size = New System.Drawing.Size(58, 48)
        Me.Btn50.TabIndex = 49
        Me.Btn50.Text = "50"
        Me.Btn50.UseVisualStyleBackColor = False
        '
        'Btn49
        '
        Me.Btn49.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn49.Location = New System.Drawing.Point(535, 233)
        Me.Btn49.Name = "Btn49"
        Me.Btn49.Size = New System.Drawing.Size(58, 48)
        Me.Btn49.TabIndex = 48
        Me.Btn49.Text = "49"
        Me.Btn49.UseVisualStyleBackColor = False
        '
        'Btn48
        '
        Me.Btn48.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn48.Location = New System.Drawing.Point(470, 233)
        Me.Btn48.Name = "Btn48"
        Me.Btn48.Size = New System.Drawing.Size(58, 48)
        Me.Btn48.TabIndex = 47
        Me.Btn48.Text = "48"
        Me.Btn48.UseVisualStyleBackColor = False
        '
        'Btn47
        '
        Me.Btn47.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn47.Location = New System.Drawing.Point(406, 233)
        Me.Btn47.Name = "Btn47"
        Me.Btn47.Size = New System.Drawing.Size(58, 48)
        Me.Btn47.TabIndex = 46
        Me.Btn47.Text = "47"
        Me.Btn47.UseVisualStyleBackColor = False
        '
        'Btn46
        '
        Me.Btn46.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn46.Location = New System.Drawing.Point(342, 233)
        Me.Btn46.Name = "Btn46"
        Me.Btn46.Size = New System.Drawing.Size(58, 48)
        Me.Btn46.TabIndex = 45
        Me.Btn46.Text = "46"
        Me.Btn46.UseVisualStyleBackColor = False
        '
        'Btn45
        '
        Me.Btn45.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn45.Location = New System.Drawing.Point(279, 233)
        Me.Btn45.Name = "Btn45"
        Me.Btn45.Size = New System.Drawing.Size(58, 48)
        Me.Btn45.TabIndex = 44
        Me.Btn45.Text = "45"
        Me.Btn45.UseVisualStyleBackColor = False
        '
        'Btn44
        '
        Me.Btn44.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn44.Location = New System.Drawing.Point(215, 233)
        Me.Btn44.Name = "Btn44"
        Me.Btn44.Size = New System.Drawing.Size(58, 48)
        Me.Btn44.TabIndex = 43
        Me.Btn44.Text = "44"
        Me.Btn44.UseVisualStyleBackColor = False
        '
        'Btn43
        '
        Me.Btn43.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn43.Location = New System.Drawing.Point(152, 233)
        Me.Btn43.Name = "Btn43"
        Me.Btn43.Size = New System.Drawing.Size(58, 48)
        Me.Btn43.TabIndex = 42
        Me.Btn43.Text = "43"
        Me.Btn43.UseVisualStyleBackColor = False
        '
        'Btn42
        '
        Me.Btn42.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn42.Location = New System.Drawing.Point(89, 233)
        Me.Btn42.Name = "Btn42"
        Me.Btn42.Size = New System.Drawing.Size(58, 48)
        Me.Btn42.TabIndex = 41
        Me.Btn42.Text = "42"
        Me.Btn42.UseVisualStyleBackColor = False
        '
        'Btn41
        '
        Me.Btn41.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn41.Location = New System.Drawing.Point(26, 233)
        Me.Btn41.Name = "Btn41"
        Me.Btn41.Size = New System.Drawing.Size(58, 48)
        Me.Btn41.TabIndex = 40
        Me.Btn41.Text = "41"
        Me.Btn41.UseVisualStyleBackColor = False
        '
        'Btn40
        '
        Me.Btn40.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn40.Location = New System.Drawing.Point(600, 181)
        Me.Btn40.Name = "Btn40"
        Me.Btn40.Size = New System.Drawing.Size(58, 48)
        Me.Btn40.TabIndex = 39
        Me.Btn40.Text = "40"
        Me.Btn40.UseVisualStyleBackColor = False
        '
        'Btn39
        '
        Me.Btn39.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn39.Location = New System.Drawing.Point(536, 181)
        Me.Btn39.Name = "Btn39"
        Me.Btn39.Size = New System.Drawing.Size(58, 48)
        Me.Btn39.TabIndex = 38
        Me.Btn39.Text = "39"
        Me.Btn39.UseVisualStyleBackColor = False
        '
        'Btn38
        '
        Me.Btn38.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn38.Location = New System.Drawing.Point(471, 181)
        Me.Btn38.Name = "Btn38"
        Me.Btn38.Size = New System.Drawing.Size(58, 48)
        Me.Btn38.TabIndex = 37
        Me.Btn38.Text = "38"
        Me.Btn38.UseVisualStyleBackColor = False
        '
        'Btn37
        '
        Me.Btn37.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn37.Location = New System.Drawing.Point(407, 181)
        Me.Btn37.Name = "Btn37"
        Me.Btn37.Size = New System.Drawing.Size(58, 48)
        Me.Btn37.TabIndex = 36
        Me.Btn37.Text = "37"
        Me.Btn37.UseVisualStyleBackColor = False
        '
        'Btn36
        '
        Me.Btn36.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn36.Location = New System.Drawing.Point(343, 181)
        Me.Btn36.Name = "Btn36"
        Me.Btn36.Size = New System.Drawing.Size(58, 48)
        Me.Btn36.TabIndex = 35
        Me.Btn36.Text = "36"
        Me.Btn36.UseVisualStyleBackColor = False
        '
        'Btn35
        '
        Me.Btn35.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn35.Location = New System.Drawing.Point(280, 181)
        Me.Btn35.Name = "Btn35"
        Me.Btn35.Size = New System.Drawing.Size(58, 48)
        Me.Btn35.TabIndex = 34
        Me.Btn35.Text = "35"
        Me.Btn35.UseVisualStyleBackColor = False
        '
        'Btn34
        '
        Me.Btn34.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn34.Location = New System.Drawing.Point(216, 181)
        Me.Btn34.Name = "Btn34"
        Me.Btn34.Size = New System.Drawing.Size(58, 48)
        Me.Btn34.TabIndex = 33
        Me.Btn34.Text = "34"
        Me.Btn34.UseVisualStyleBackColor = False
        '
        'Btn33
        '
        Me.Btn33.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn33.Location = New System.Drawing.Point(153, 181)
        Me.Btn33.Name = "Btn33"
        Me.Btn33.Size = New System.Drawing.Size(58, 48)
        Me.Btn33.TabIndex = 32
        Me.Btn33.Text = "33"
        Me.Btn33.UseVisualStyleBackColor = False
        '
        'Btn32
        '
        Me.Btn32.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn32.Location = New System.Drawing.Point(90, 181)
        Me.Btn32.Name = "Btn32"
        Me.Btn32.Size = New System.Drawing.Size(58, 48)
        Me.Btn32.TabIndex = 31
        Me.Btn32.Text = "32"
        Me.Btn32.UseVisualStyleBackColor = False
        '
        'Btn31
        '
        Me.Btn31.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn31.Location = New System.Drawing.Point(26, 181)
        Me.Btn31.Name = "Btn31"
        Me.Btn31.Size = New System.Drawing.Size(58, 48)
        Me.Btn31.TabIndex = 30
        Me.Btn31.Text = "31"
        Me.Btn31.UseVisualStyleBackColor = False
        '
        'Btn30
        '
        Me.Btn30.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn30.Location = New System.Drawing.Point(600, 129)
        Me.Btn30.Name = "Btn30"
        Me.Btn30.Size = New System.Drawing.Size(58, 48)
        Me.Btn30.TabIndex = 29
        Me.Btn30.Text = "30"
        Me.Btn30.UseVisualStyleBackColor = False
        '
        'Btn29
        '
        Me.Btn29.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn29.Location = New System.Drawing.Point(536, 129)
        Me.Btn29.Name = "Btn29"
        Me.Btn29.Size = New System.Drawing.Size(58, 48)
        Me.Btn29.TabIndex = 28
        Me.Btn29.Text = "29"
        Me.Btn29.UseVisualStyleBackColor = False
        '
        'Btn28
        '
        Me.Btn28.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn28.Location = New System.Drawing.Point(471, 129)
        Me.Btn28.Name = "Btn28"
        Me.Btn28.Size = New System.Drawing.Size(58, 48)
        Me.Btn28.TabIndex = 27
        Me.Btn28.Text = "28"
        Me.Btn28.UseVisualStyleBackColor = False
        '
        'Btn27
        '
        Me.Btn27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn27.Location = New System.Drawing.Point(407, 129)
        Me.Btn27.Name = "Btn27"
        Me.Btn27.Size = New System.Drawing.Size(58, 48)
        Me.Btn27.TabIndex = 26
        Me.Btn27.Text = "27"
        Me.Btn27.UseVisualStyleBackColor = False
        '
        'Btn26
        '
        Me.Btn26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn26.Location = New System.Drawing.Point(343, 129)
        Me.Btn26.Name = "Btn26"
        Me.Btn26.Size = New System.Drawing.Size(58, 48)
        Me.Btn26.TabIndex = 25
        Me.Btn26.Text = "26"
        Me.Btn26.UseVisualStyleBackColor = False
        '
        'Btn25
        '
        Me.Btn25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn25.Location = New System.Drawing.Point(280, 129)
        Me.Btn25.Name = "Btn25"
        Me.Btn25.Size = New System.Drawing.Size(58, 48)
        Me.Btn25.TabIndex = 24
        Me.Btn25.Text = "25"
        Me.Btn25.UseVisualStyleBackColor = False
        '
        'Btn24
        '
        Me.Btn24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn24.Location = New System.Drawing.Point(216, 129)
        Me.Btn24.Name = "Btn24"
        Me.Btn24.Size = New System.Drawing.Size(58, 48)
        Me.Btn24.TabIndex = 23
        Me.Btn24.Text = "24"
        Me.Btn24.UseVisualStyleBackColor = False
        '
        'Btn23
        '
        Me.Btn23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn23.Location = New System.Drawing.Point(153, 129)
        Me.Btn23.Name = "Btn23"
        Me.Btn23.Size = New System.Drawing.Size(58, 48)
        Me.Btn23.TabIndex = 22
        Me.Btn23.Text = "23"
        Me.Btn23.UseVisualStyleBackColor = False
        '
        'Btn22
        '
        Me.Btn22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn22.Location = New System.Drawing.Point(90, 129)
        Me.Btn22.Name = "Btn22"
        Me.Btn22.Size = New System.Drawing.Size(58, 48)
        Me.Btn22.TabIndex = 21
        Me.Btn22.Text = "22"
        Me.Btn22.UseVisualStyleBackColor = False
        '
        'Btn21
        '
        Me.Btn21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn21.Location = New System.Drawing.Point(26, 129)
        Me.Btn21.Name = "Btn21"
        Me.Btn21.Size = New System.Drawing.Size(58, 48)
        Me.Btn21.TabIndex = 20
        Me.Btn21.Text = "21"
        Me.Btn21.UseVisualStyleBackColor = False
        '
        'Btn20
        '
        Me.Btn20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn20.Location = New System.Drawing.Point(600, 77)
        Me.Btn20.Name = "Btn20"
        Me.Btn20.Size = New System.Drawing.Size(58, 48)
        Me.Btn20.TabIndex = 19
        Me.Btn20.Text = "20"
        Me.Btn20.UseVisualStyleBackColor = False
        '
        'Btn19
        '
        Me.Btn19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn19.Location = New System.Drawing.Point(536, 77)
        Me.Btn19.Name = "Btn19"
        Me.Btn19.Size = New System.Drawing.Size(58, 48)
        Me.Btn19.TabIndex = 18
        Me.Btn19.Text = "19"
        Me.Btn19.UseVisualStyleBackColor = False
        '
        'Btn18
        '
        Me.Btn18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn18.Location = New System.Drawing.Point(471, 77)
        Me.Btn18.Name = "Btn18"
        Me.Btn18.Size = New System.Drawing.Size(58, 48)
        Me.Btn18.TabIndex = 17
        Me.Btn18.Text = "18"
        Me.Btn18.UseVisualStyleBackColor = False
        '
        'Btn17
        '
        Me.Btn17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn17.Location = New System.Drawing.Point(407, 77)
        Me.Btn17.Name = "Btn17"
        Me.Btn17.Size = New System.Drawing.Size(58, 48)
        Me.Btn17.TabIndex = 16
        Me.Btn17.Text = "17"
        Me.Btn17.UseVisualStyleBackColor = False
        '
        'Btn16
        '
        Me.Btn16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn16.Location = New System.Drawing.Point(343, 77)
        Me.Btn16.Name = "Btn16"
        Me.Btn16.Size = New System.Drawing.Size(58, 48)
        Me.Btn16.TabIndex = 15
        Me.Btn16.Text = "16"
        Me.Btn16.UseVisualStyleBackColor = False
        '
        'Btn15
        '
        Me.Btn15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn15.Location = New System.Drawing.Point(280, 77)
        Me.Btn15.Name = "Btn15"
        Me.Btn15.Size = New System.Drawing.Size(58, 48)
        Me.Btn15.TabIndex = 14
        Me.Btn15.Text = "15"
        Me.Btn15.UseVisualStyleBackColor = False
        '
        'Btn14
        '
        Me.Btn14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn14.Location = New System.Drawing.Point(216, 77)
        Me.Btn14.Name = "Btn14"
        Me.Btn14.Size = New System.Drawing.Size(58, 48)
        Me.Btn14.TabIndex = 13
        Me.Btn14.Text = "14"
        Me.Btn14.UseVisualStyleBackColor = False
        '
        'Btn13
        '
        Me.Btn13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn13.Location = New System.Drawing.Point(153, 77)
        Me.Btn13.Name = "Btn13"
        Me.Btn13.Size = New System.Drawing.Size(58, 48)
        Me.Btn13.TabIndex = 12
        Me.Btn13.Text = "13"
        Me.Btn13.UseVisualStyleBackColor = False
        '
        'Btn12
        '
        Me.Btn12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn12.Location = New System.Drawing.Point(90, 77)
        Me.Btn12.Name = "Btn12"
        Me.Btn12.Size = New System.Drawing.Size(58, 48)
        Me.Btn12.TabIndex = 11
        Me.Btn12.Text = "12"
        Me.Btn12.UseVisualStyleBackColor = False
        '
        'Btn11
        '
        Me.Btn11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn11.Location = New System.Drawing.Point(26, 77)
        Me.Btn11.Name = "Btn11"
        Me.Btn11.Size = New System.Drawing.Size(58, 48)
        Me.Btn11.TabIndex = 10
        Me.Btn11.Text = "11"
        Me.Btn11.UseVisualStyleBackColor = False
        '
        'Btn10
        '
        Me.Btn10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn10.Location = New System.Drawing.Point(599, 26)
        Me.Btn10.Name = "Btn10"
        Me.Btn10.Size = New System.Drawing.Size(58, 48)
        Me.Btn10.TabIndex = 9
        Me.Btn10.Text = "10"
        Me.Btn10.UseVisualStyleBackColor = False
        '
        'Btn9
        '
        Me.Btn9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.Location = New System.Drawing.Point(535, 26)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(58, 48)
        Me.Btn9.TabIndex = 8
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = False
        '
        'Btn8
        '
        Me.Btn8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.Location = New System.Drawing.Point(470, 26)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(58, 48)
        Me.Btn8.TabIndex = 7
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(407, 26)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(58, 48)
        Me.btn7.TabIndex = 6
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'Btn6
        '
        Me.Btn6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.Location = New System.Drawing.Point(344, 26)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(58, 48)
        Me.Btn6.TabIndex = 5
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = False
        '
        'Bn5
        '
        Me.Bn5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bn5.Location = New System.Drawing.Point(280, 26)
        Me.Bn5.Name = "Bn5"
        Me.Bn5.Size = New System.Drawing.Size(58, 48)
        Me.Bn5.TabIndex = 4
        Me.Bn5.Text = "5"
        Me.Bn5.UseVisualStyleBackColor = False
        '
        'Btn4
        '
        Me.Btn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Location = New System.Drawing.Point(216, 26)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(58, 48)
        Me.Btn4.TabIndex = 3
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Location = New System.Drawing.Point(154, 26)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(58, 48)
        Me.Btn3.TabIndex = 2
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Location = New System.Drawing.Point(90, 26)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(58, 48)
        Me.Btn2.TabIndex = 1
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Location = New System.Drawing.Point(26, 26)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(58, 48)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Tag = ""
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(595, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TBHE)
        Me.GroupBox3.Location = New System.Drawing.Point(322, 183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(94, 48)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hora Entrada"
        '
        'TBHE
        '
        Me.TBHE.Enabled = False
        Me.TBHE.Location = New System.Drawing.Point(6, 19)
        Me.TBHE.Name = "TBHE"
        Me.TBHE.Size = New System.Drawing.Size(72, 20)
        Me.TBHE.TabIndex = 8
        '
        'ASIGNA
        '
        Me.ASIGNA.Location = New System.Drawing.Point(595, 95)
        Me.ASIGNA.Name = "ASIGNA"
        Me.ASIGNA.Size = New System.Drawing.Size(80, 24)
        Me.ASIGNA.TabIndex = 17
        Me.ASIGNA.Text = "ASIGNA"
        '
        'TBHS
        '
        Me.TBHS.Enabled = False
        Me.TBHS.Location = New System.Drawing.Point(10, 18)
        Me.TBHS.Name = "TBHS"
        Me.TBHS.Size = New System.Drawing.Size(72, 20)
        Me.TBHS.TabIndex = 15
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TBHS)
        Me.GroupBox4.Location = New System.Drawing.Point(430, 183)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(94, 48)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hora Salida"
        '
        'RentaEquipo
        '
        Me.AcceptButton = Me.BtnOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(768, 620)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ASIGNA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBoxEquipos)
        Me.Controls.Add(Me.DataTimePago)
        Me.Controls.Add(Me.GBBono)
        Me.Controls.Add(Me.GBDatos)
        Me.Controls.Add(Me.GBClave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "RentaEquipo"
        Me.Text = "Renta de Equipo"
        Me.GBBono.ResumeLayout(False)
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        Me.GBClave.ResumeLayout(False)
        Me.GBClave.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxEquipos.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        'VALIDA QUE YA EXISTA EL ALUMNO REGISTRADO EN RENTA DE EQUIPO
        Dim SW As String = "1"
        Dim fecharhoy As Date

        'Dim fechar As Date
        'Dim fecharenta As Date
        'Dim matriculaa As String
        'Dim numiro As String

        'Dim d As String = Format(departDate, "DD/MM/YYYY")
        fecharhoy = Today
        'fecharhoyr = Today
        'Dim fecharhoyr = Format(Today, "yyyy-MM-dd")

        'fecharhoy = Format("yyyy/mm/dd/")
        'fecharhoy = Format(DATE, "yyyy/mm/dd/")
        'Dim LValue As String
        'LValue = Format(Date, "yyyy/mm/dd")
        'MsgBox("Hora de hoy: " & fecharhoy)
        'MsgBox("Hora de hoyr: " & fecharhoyr)
        'MsgBox("FECHA actual: " & Today)

        Try
            'VERIFICA SI EL ALUMNO ESTA REGISTRADO EN SALA DE RENTA
            Me.SqlConnection1.Open()
            'Dim sqlr As String = ("select * from rentaeq where rentaeq.matricula=@matid ")
            'Dim sqlr As String = ("select * from rentaeq where matricula = " & TBMatricula.Text & " And rentaeq.fechar = " & fecharhoy)
            'Dim sqlr As String = ("select * from rentaeq where matricula = " & TBMatricula.Text & " And convert(char(10),rentaeq.fechar,101) =  " & fecharhoy)
            'Dim sqlr As String = ("select * from rentaeq where rentaeq.matricula =  @MATID and rentaeq.fechar=  '2010 - 8 - 25'")
            Dim sqlr As String = ("select * from rentaeq where rentaeq.matricula =  @MATID and rentaeq.fechar = " & "@fecID")
            Dim CMAr As New SqlClient.SqlCommand(sqlr, Me.SqlConnection1)
            'Dim FECr As New SqlClient.SqlCommand(sqlr, Me.SqlConnection1)
            Dim CveMatricula As SqlParameter = CMAr.Parameters.Add(New SqlParameter("@matID", SqlDbType.NVarChar, 7))
            Dim Cvefecha As SqlParameter = CMAr.Parameters.Add(New SqlParameter("@fecID", SqlDbType.DateTime, 8))
            CMAr.Parameters("@MatID").Value = Me.TBMatricula.Text
            CMAr.Parameters("@FecID").Value = Format(Today, "yyyy-MM-dd")
            Dim DRAlumR As SqlClient.SqlDataReader
            DRAlumR = CMAr.ExecuteReader(CommandBehavior.CloseConnection)
            DRAlumR.Read()
            If Not DRAlumR.Read() Then
                DRAlumR.Close()
                Me.SqlConnection1.Close()
                Try
                    '''''VERIFICA SI EL ALUMNO TIENE BONO
                    Me.SqlConnection1.Open()
                    Dim sql As String = ("select * from alumnos inner join bonos on alumnos.matricula = bonos.matricula where alumnos.matricula = " & TBMatricula.Text)
                    Dim calumnos As New SqlClient.SqlCommand(sql, Me.SqlConnection1)
                    Dim CveMat As SqlParameter = calumnos.Parameters.Add(New SqlParameter("@matID", SqlDbType.NVarChar, 7))
                    calumnos.Parameters("@MatID").Value = Me.TBMatricula.Text
                    Dim DRAlumnos As SqlClient.SqlDataReader
                    DRAlumnos = calumnos.ExecuteReader(CommandBehavior.CloseConnection)
                    DRAlumnos.Read()

                    If Not DRAlumnos.Read() Then
                        MsgBox("Alumno no tiene bono asignado...!")

                    Else  'ASIGNA EQUIPO

                        Do While CMAr.Parameters("@FecID").Value = Format(Today, "yyyy-MM-dd")
                            'TBNombre.Text = DRAlumnos("Nombre")

                            If DRAlumR("num_micro") = 1 Then
                                Btn1.Enabled = False
                                MsgBox("Desactiva equipo...!")
                            Else
                                Btn1.Enabled = True
                            End If
                            If DRAlumR("num_micro").Value = "2" Then
                                Btn2.Enabled = False
                            Else
                                Btn2.Enabled = True
                            End If
                            If DRAlumR("num_micro").Value = "3" Then
                                Btn3.Enabled = False
                            Else
                                Btn3.Enabled = True
                            End If
                        Loop
                        'Dim numicro As Integer
                        'Dim micro(10) As String

                        'For numicro = 1 To 10
                        'If numicro = 1 Then
                        'Btn1.Enabled = True
                        'ElseIf numicro = 2 Then
                        '    Btn2.Enabled = True
                        'ElseIf numicro = 3 Then
                        '    Btn3.Enabled = True
                        'ElseIf numicro = 4 Then
                        '    btn4.Enabled = True
                        'ElseIf numicro = 5 Then
                        '    btn5.Enabled = True
                        'End If
                        'Next
                        MsgBox("Asignar equipo...!")
                        TBNombre.Text = DRAlumnos("Nombre")
                        TBCarrera.Text = DRAlumnos("Carr")
                        TBSem.Text = DRAlumnos("Sem")
                        TBTiempor.Text = DRAlumnos("Rest_Tiemp")
                        'TBEfectivo.Text = "20"
                        'Asignación de bono para el alumno
                    End If
                Catch ex As Exception
                    'MsgBox(ex.ToString)
                    MsgBox(ex.Source & "; " & ex.Message, _
                    MsgBoxStyle.OkOnly, "No se encontro alumno")
                End Try
                Me.SqlConnection1.Close()
                DRAlumR.Close()
            Else   'SE DA DE BAJA EL ALUMNOS EN SALA
                '
                '
                'matriculaa = DRAlumR("matricula")
                MsgBox("Alumno dado de baja...!")
                'fecharenta = DRAlumR("fechar")
                TBNombre.Text = DRAlumR("Nombre")
                TBCarrera.Text = DRAlumR("Carr")
                TBSem.Text = DRAlumR("Sem")
                TBHE.Text = DRAlumR("H_ENTRADA")
                MsgBox("Hora de Entrada: " & TBHE.Text)

            End If
            'TBHS.Text = DRAlumR("H_SALIDA")
            'HS = DRAlumR("H_SALIDA")
            'If DRAlumR("SALA") = "L1" Then
            'MsgBox("Hora de Salida: " & CBSalas.Text)
            'End If
            'If DRAlumR("h_salida") Is "NULL" Then
            'MsgBox("Baja de alumno accesos: " & TimeString)
            'Else
            '    MsgBox("Asignar Equipo: " & TimeString)
            ' End If
            'MsgBox("Fecha actual: " & fecharhoy)
            'Do While DRAlumR("matricula") = TBMatricula.Text And DRAlumR("fechar") = fecharhoy
            'If DRAlumR("fechar") = fecharhoy Then
            'MsgBox("Hora de Salida:" & HS)
            'Else
            'Loop
            'End If
            'If IsDBNull(DRAlumR("H_SALIDA")) 
            'MsgBox("Hora de Salida: " & HS)
            'SW = "2"
            'DRAlumR.Close()
            'Me.SqlConnection1.Close()
            'End If
            DRAlumR.Close()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        'VALIDA QUE EL ALUMNO EXISTA EN ALUMNOS Y TENGA BONO REGISTRADO O COMPRADO
    End Sub

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        'Dim MyTime As Date
        Dim fecharenta As Date
        fecharenta = Today
        'Dim myhora As Date
        Dim Numicro As String = "1"
        Dim sal As String

        'MyTime = TimeOfDay
        'fecharenta = TimeString
        'MessageBox.Show("La hora actual es: " & MyTime)
        'MsgBox("The current time is " & myhora)
        'MsgBox("The current time is " & TimeString)
        'MsgBox("Fecha del sistema es:" & fecharenta)
        Try
            If MessageBox.Show("Desea Guardar los Cambios:?", "Transactions", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                       MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Me.SqlConnection1.Open()
                Dim sql2 As String = "INSERT INTO RENTAEQ (Fechar,Matricula,Nombre,Carr,Sem,Num_Micro,Sala,H_Entrada) VALUES (@Fechar,@MatID,@Nombre,@Carr,@sem,@Num_Micro,@Sala,@H_Entrada)"
                Dim CMAlumnos As New SqlClient.SqlCommand(sql2, Me.SqlConnection1)
                CMAlumnos.Parameters.Add(New SqlParameter("@FECHAR", SqlDbType.DateTime, 8)).Value = fecharenta.Date
                CMAlumnos.Parameters.Add(New SqlParameter("@MatID", SqlDbType.NVarChar, 7)).Value = TBMatricula.Text
                CMAlumnos.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar, 40)).Value = TBNombre.Text
                CMAlumnos.Parameters.Add(New SqlParameter("@Carr", SqlDbType.NVarChar, 1)).Value = TBCarrera.Text
                CMAlumnos.Parameters.Add(New SqlParameter("@Sem", SqlDbType.NVarChar, 2)).Value = TBSem.Text
                CMAlumnos.Parameters.Add(New SqlParameter("@Num_Micro", SqlDbType.NVarChar, 2)).Value = Numicro
                CMAlumnos.Parameters.Add(New SqlParameter("@Sala", SqlDbType.NVarChar, 2)).Value = CBSalas.Text
                CMAlumnos.Parameters.Add(New SqlParameter("@H_Entrada", SqlDbType.NVarChar, 5)).Value = TimeString
                CMAlumnos.CommandText = sql2
                CMAlumnos.ExecuteNonQuery()
                'MsgBox("Fecha del sistema es:" & fecharenta)
                sal = CBSalas.Text
                MessageBox.Show("Hora de Entrada: " & TimeString + _
                " Sala: " & CBSalas.Text + " Micro: " & Numicro, "Asignado:")
                Me.SqlConnection1.Close()
            Else
                Me.TBNombre.Text = " "
                Me.TBCarrera.Text = " "
                Me.TBSem.Text = " "
                Me.TBTiempor.Text = " "
                Me.SqlConnection1.Close()
                Me.TabIndex = 1
                'BtnAceptab.TabIndex = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            'MessageBox.Show("Matricula no existe: " & Me.TBMatricula.Text)
            Me.SqlConnection1.Close()
        End Try
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        Dim today As System.DateTime
        Dim duration As System.TimeSpan
        Dim answer As System.DateTime
        today = System.DateTime.Now
        duration = New System.TimeSpan(36, 0, 0, 0)
        answer = today.Add(duration)
        System.Console.WriteLine("{0:dddd}", answer)
        MessageBox.Show("La hora actual es: " & today)


    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        Dim d1 As DateTime = DateTime.Now
        Dim window As Integer = 10
        Dim d6 As DateTime = d1.AddHours(2).AddSeconds((2 * window))
        MessageBox.Show("La hora actual es: " & d6)

    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        Dim MyTime As Date
        MyTime = TimeOfDay
        MessageBox.Show("La hora actual es: " & MyTime)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fechar As Date
        fechar = Today
        Try
            'Dim HS As String
            Me.SqlConnection1.Open()
            Dim sqlr As String = ("select * from rentaeq where matricula = " & TBMatricula.Text)
            Dim CMAr As New SqlClient.SqlCommand(sqlr, Me.SqlConnection1)
            Dim CveMatricula As SqlParameter = CMAr.Parameters.Add(New SqlParameter("@matID", SqlDbType.NVarChar, 7))
            CMAr.Parameters("@MatID").Value = Me.TBMatricula.Text
            Dim DRAlumR As SqlClient.SqlDataReader
            DRAlumR = CMAr.ExecuteReader(CommandBehavior.CloseConnection)
            DRAlumR.Read()

            TBNombre.Text = DRAlumR("Nombre")
            TBCarrera.Text = DRAlumR("Carr")
            TBSem.Text = DRAlumR("Sem")
            TBHE.Text = DRAlumR("H_ENTRADA")
            'TBHS.Text = DRAlumR("H_SALIDA")
            'HS = DRAlumR("H_SALIDA")
            'If DRAlumR("SALA") = "L1" Then
            'MsgBox("Hora de Salida: " & CBSalas.Text)
            'End If

            If IsDBNull(DRAlumR("H_SALIDA")) And DRAlumR("FECHAR") = fechar Then
                'MsgBox("Hora de Salida: " & HS)
            End If


            'If DRAlumR("h_salida") Is "NULL" Then
            'MsgBox("Baja de alumno accesos: " & TimeString)
            'Else
            '    MsgBox("Asignar Equipo: " & TimeString)
            ' End If

            'TBTiempor.Text = DRAlumR("Rest_Tiemp")
            'TBNombre.Text = DRAlumR("Nombre")
            'If CMArental.Parameters("@MatID").Value = TBMatricula.Text Then
            'If DRAlumR("fechar") = fecharenta Then _
            'If DRAlumR("H_SALIDA") = "" Then
            'MsgBox("Hora de salida: " & TimeString)
            'MsgBox("MATRICULA:" & TBMatricula.Text)
            'Else
            '    MsgBox("Asignar Equipo: " & TimeString)
            'End If
            DRAlumR.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.SqlConnection1.Close()
        End Try

    End Sub

    Private Sub ASIGNA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASIGNA.Click
        Dim fecharhoy As Date
        'Dim fechar As Date
        'Dim fecharenta As Date
        'Dim matriculaa As String
        'Dim numiro As String
        fecharhoy = Today
        'Dim fecharhoyr = Format(Today, "yyyy/MM/dd")
        Try
            ' Verifica si existe bono
            Me.SqlConnection1.Open()
            Dim sql As String = ("select * from alumnos inner join bonos on alumnos.matricula = bonos.matricula where alumnos.matricula = " & TBMatricula.Text)
            Dim calumnos As New SqlClient.SqlCommand(sql, Me.SqlConnection1)
            Dim CveMat As SqlParameter = calumnos.Parameters.Add(New SqlParameter("@matID", SqlDbType.NVarChar, 7))
            calumnos.Parameters("@MatID").Value = Me.TBMatricula.Text
            Dim DRAlumnos As SqlClient.SqlDataReader
            DRAlumnos = calumnos.ExecuteReader(CommandBehavior.CloseConnection)
            DRAlumnos.Read()
            If Not DRAlumnos.Read() Then
                MsgBox("Alumno no tiene bono asignado...!")
            Else

                TBNombre.Text = DRAlumnos("Nombre")
                TBCarrera.Text = DRAlumnos("Carr")
                TBSem.Text = DRAlumnos("Sem")
                TBTiempor.Text = DRAlumnos("Rest_Tiemp")
            End If

            DRAlumnos.Close()
            Me.SqlConnection1.Close()
        Catch ex As Exception

            'MsgBox(ex.ToString)
            MsgBox(ex.Source & "; " & ex.Message, _
            MsgBoxStyle.OkOnly, "No se encontro alumno")

        End Try

        Try
            'Me.SqlConnection1.Close()
            Me.SqlConnection1.Open()
            'VERIFICA SI EL ALUMNO ESTA REGISTRADO EN SALA DE RENTA
            'Dim sqlr As String = ("select * from rentaeq where rentaeq.matricula =  @MATID and rentaeq.fechar = " & "@fecID")
            Dim sqlr As String = ("select * from rentaeq where rentaeq.matricula =  @MATID ")

            'Dim sqlr As String = ("select * from rentaeq where rentaeq.matricula =  @MATID and rentaeq.fechar = " & "fecharhoyr")

            'Dim sqlr As String = ("select * from rentaeq where rentaeq.matricula =  TBMatricula.Text and rentaeq.fechar = " & Format(Today, "dd/MM/yyyy"))
            'Dim sqlr As String = ("select * from rentaeq where rentaeq.matricula =  " & TBMatricula.Text)

            Dim CMAr As New SqlClient.SqlCommand(sqlr, Me.SqlConnection1)
            Dim FECr As New SqlClient.SqlCommand(sqlr, Me.SqlConnection1)

            Dim CveMatricula As SqlParameter = CMAr.Parameters.Add(New SqlParameter("@matID", SqlDbType.NVarChar, 7))
            Dim Cvefecha As SqlParameter = FECr.Parameters.Add(New SqlParameter("@fecID", SqlDbType.DateTime, 8))
            'Dim Numicro As SqlParameter = CMAr.Parameters.Add(New SqlParameter("numicroID", SqlDbType.NVarChar, 1))
            CMAr.Parameters("@MatID").Value = Me.TBMatricula.Text
            FECr.Parameters("@FecID").Value = Format(Today, "dd-MM-yyyy")

            Dim DRAlumR As SqlClient.SqlDataReader
            'Dim DRAlumR As SqlClient.SqlDataReader

            DRAlumR = CMAr.ExecuteReader(CommandBehavior.CloseConnection)
            DRAlumR = FECr.ExecuteReader(CommandBehavior.CloseConnection)

            DRAlumR.Read()
            If Not DRAlumR.Read() Then
                'ASIGNA EQUIPO DISPONIBLE
                'Do While CMAr.Parameters("@FecID").Value = Format(Today, "yyyy-MM-dd")
                'Do While DRAlumR("fechar") = Format(Today, "dd-MM-yyyy")
                'Do While DRAlumR("Fechar") = Format(Today, "dd-MM-yyyy")

                'Do While CMAr.Parameters("@Matid").Value = Me.TBMatricula.Text
                'Do While CMAr.Parameters("@fecid").Value = Format(Today, "dd-MM-yyyy")

                'Dim fecharhoyDIA = Format(Today, "dd-MM-yyyy")

                'Do While CMAr.Parameters("@fecid").Value = fecharhoyDIA

                Do While DRAlumR.Read = True

                    MsgBox("si do while...!")
                    MessageBox.Show("numero de equipo:" + "num_micro")

                    'nm = DRAlumR("num_micro")
                    'MsgBox("numero de micro: " & nm)
                    'TBNombre.Text = DRAlumnos("Nombre")
                    'Dim y As Integer = 5
                    'For y = 0 To 5
                    'MessageBox.Show("numero de equipo:" + CStr(y))
                    Select Case DRAlumR("num_micro")

                    End Select

                    If DRAlumR("num_micro") = 1 Then
                        Btn1.Enabled = False
                        MsgBox("Desactiva equipo...!")

                        'Else
                        '   Btn1.Enabled = True
                    End If
                    If DRAlumR("num_micro").Value = "2" Then
                        Btn2.Enabled = False
                        'Else
                        '   Btn2.Enabled = True
                    End If
                    If DRAlumR("num_micro").Value = "3" Then
                        Btn3.Enabled = False
                    Else
                        Btn3.Enabled = True
                    End If
                    'Next
                Loop
            Else
                MsgBox("Baja de alumno en sala...!")
            End If
            'ASIGNA EQUIPO
            ''''''''''''''''''''''''''''''
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub


    Private Sub RentaEquipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

   
End Class
