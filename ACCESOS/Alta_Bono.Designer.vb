<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_Bono
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DateTimeHojas = New System.Windows.Forms.DateTimePicker
        Me.GBDatos = New System.Windows.Forms.GroupBox
        Me.CBSemestre = New System.Windows.Forms.ComboBox
        Me.CBCarrera = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TBTotalH = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblCarrera = New System.Windows.Forms.Label
        Me.TBNombre = New System.Windows.Forms.TextBox
        Me.LblNombre = New System.Windows.Forms.Label
        Me.GBClave = New System.Windows.Forms.GroupBox
        Me.LblMatricula = New System.Windows.Forms.Label
        Me.TBMatricula = New System.Windows.Forms.TextBox
        Me.GroupBoxMermas = New System.Windows.Forms.GroupBox
        Me.TBFolio = New System.Windows.Forms.TextBox
        Me.GroupBoxOficio = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TBTotalHoras = New System.Windows.Forms.TextBox
        Me.GroupBoxCarta = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TBTotalHojas = New System.Windows.Forms.TextBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        Me.GBDatos.SuspendLayout()
        Me.GBClave.SuspendLayout()
        Me.GroupBoxMermas.SuspendLayout()
        Me.GroupBoxOficio.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxCarta.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTimeHojas)
        Me.GroupBox3.Location = New System.Drawing.Point(294, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 52)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha de Captura:"
        '
        'DateTimeHojas
        '
        Me.DateTimeHojas.Enabled = False
        Me.DateTimeHojas.Location = New System.Drawing.Point(11, 19)
        Me.DateTimeHojas.Name = "DateTimeHojas"
        Me.DateTimeHojas.Size = New System.Drawing.Size(239, 20)
        Me.DateTimeHojas.TabIndex = 20
        '
        'GBDatos
        '
        Me.GBDatos.Controls.Add(Me.CBSemestre)
        Me.GBDatos.Controls.Add(Me.CBCarrera)
        Me.GBDatos.Controls.Add(Me.Label5)
        Me.GBDatos.Controls.Add(Me.TBTotalH)
        Me.GBDatos.Controls.Add(Me.Label4)
        Me.GBDatos.Controls.Add(Me.Label3)
        Me.GBDatos.Controls.Add(Me.Label2)
        Me.GBDatos.Controls.Add(Me.Label1)
        Me.GBDatos.Controls.Add(Me.LblCarrera)
        Me.GBDatos.Controls.Add(Me.TBNombre)
        Me.GBDatos.Controls.Add(Me.LblNombre)
        Me.GBDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDatos.ForeColor = System.Drawing.Color.Navy
        Me.GBDatos.Location = New System.Drawing.Point(22, 68)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Size = New System.Drawing.Size(528, 140)
        Me.GBDatos.TabIndex = 29
        Me.GBDatos.TabStop = False
        Me.GBDatos.Text = "Datos del Alumno:"
        '
        'CBSemestre
        '
        Me.CBSemestre.Enabled = False
        Me.CBSemestre.FormattingEnabled = True
        Me.CBSemestre.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "P"})
        Me.CBSemestre.Location = New System.Drawing.Point(232, 98)
        Me.CBSemestre.Name = "CBSemestre"
        Me.CBSemestre.Size = New System.Drawing.Size(53, 21)
        Me.CBSemestre.TabIndex = 5
        '
        'CBCarrera
        '
        Me.CBCarrera.Enabled = False
        Me.CBCarrera.FormattingEnabled = True
        Me.CBCarrera.Items.AddRange(New Object() {"D", "C"})
        Me.CBCarrera.Location = New System.Drawing.Point(70, 100)
        Me.CBCarrera.Name = "CBCarrera"
        Me.CBCarrera.Size = New System.Drawing.Size(53, 21)
        Me.CBCarrera.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(315, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Hojas:"
        '
        'TBTotalH
        '
        Me.TBTotalH.Enabled = False
        Me.TBTotalH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTotalH.Location = New System.Drawing.Point(391, 101)
        Me.TBTotalH.Name = "TBTotalH"
        Me.TBTotalH.Size = New System.Drawing.Size(88, 20)
        Me.TBTotalH.TabIndex = 9
        Me.TBTotalH.Text = "0"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(388, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Materno"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Paterno"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Semestre:"
        '
        'LblCarrera
        '
        Me.LblCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCarrera.Location = New System.Drawing.Point(16, 101)
        Me.LblCarrera.Name = "LblCarrera"
        Me.LblCarrera.Size = New System.Drawing.Size(56, 16)
        Me.LblCarrera.TabIndex = 2
        Me.LblCarrera.Text = "Carrera:"
        '
        'TBNombre
        '
        Me.TBNombre.Enabled = False
        Me.TBNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombre.Location = New System.Drawing.Point(80, 32)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(411, 20)
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
        'GBClave
        '
        Me.GBClave.Controls.Add(Me.LblMatricula)
        Me.GBClave.Controls.Add(Me.TBMatricula)
        Me.GBClave.Location = New System.Drawing.Point(22, 12)
        Me.GBClave.Name = "GBClave"
        Me.GBClave.Size = New System.Drawing.Size(253, 50)
        Me.GBClave.TabIndex = 28
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
        Me.TBMatricula.Size = New System.Drawing.Size(101, 20)
        Me.TBMatricula.TabIndex = 1
        '
        'GroupBoxMermas
        '
        Me.GroupBoxMermas.Controls.Add(Me.TBFolio)
        Me.GroupBoxMermas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxMermas.Location = New System.Drawing.Point(416, 246)
        Me.GroupBoxMermas.Name = "GroupBoxMermas"
        Me.GroupBoxMermas.Size = New System.Drawing.Size(134, 61)
        Me.GroupBoxMermas.TabIndex = 33
        Me.GroupBoxMermas.TabStop = False
        Me.GroupBoxMermas.Text = "FOLIO:"
        '
        'TBFolio
        '
        Me.TBFolio.Enabled = False
        Me.TBFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBFolio.Location = New System.Drawing.Point(18, 26)
        Me.TBFolio.Name = "TBFolio"
        Me.TBFolio.Size = New System.Drawing.Size(88, 20)
        Me.TBFolio.TabIndex = 8
        Me.TBFolio.Text = "0"
        '
        'GroupBoxOficio
        '
        Me.GroupBoxOficio.Controls.Add(Me.PictureBox2)
        Me.GroupBoxOficio.Controls.Add(Me.TBTotalHoras)
        Me.GroupBoxOficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOficio.Location = New System.Drawing.Point(194, 236)
        Me.GroupBoxOficio.Name = "GroupBoxOficio"
        Me.GroupBoxOficio.Size = New System.Drawing.Size(134, 158)
        Me.GroupBoxOficio.TabIndex = 32
        Me.GroupBoxOficio.TabStop = False
        Me.GroupBoxOficio.Text = "Cant. Horas:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ACCESOS.My.Resources.Resources.reloj
        Me.PictureBox2.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(122, 96)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'TBTotalHoras
        '
        Me.TBTotalHoras.Enabled = False
        Me.TBTotalHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTotalHoras.Location = New System.Drawing.Point(25, 128)
        Me.TBTotalHoras.Name = "TBTotalHoras"
        Me.TBTotalHoras.Size = New System.Drawing.Size(88, 22)
        Me.TBTotalHoras.TabIndex = 7
        Me.TBTotalHoras.Text = "0"
        '
        'GroupBoxCarta
        '
        Me.GroupBoxCarta.Controls.Add(Me.PictureBox1)
        Me.GroupBoxCarta.Controls.Add(Me.TBTotalHojas)
        Me.GroupBoxCarta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCarta.Location = New System.Drawing.Point(22, 236)
        Me.GroupBoxCarta.Name = "GroupBoxCarta"
        Me.GroupBoxCarta.Size = New System.Drawing.Size(134, 158)
        Me.GroupBoxCarta.TabIndex = 31
        Me.GroupBoxCarta.TabStop = False
        Me.GroupBoxCarta.Text = "Cant. Hojas:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ACCESOS.My.Resources.Resources.Hojas
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 96)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'TBTotalHojas
        '
        Me.TBTotalHojas.Enabled = False
        Me.TBTotalHojas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTotalHojas.Location = New System.Drawing.Point(23, 128)
        Me.TBTotalHojas.Name = "TBTotalHojas"
        Me.TBTotalHojas.Size = New System.Drawing.Size(88, 22)
        Me.TBTotalHojas.TabIndex = 6
        Me.TBTotalHojas.Text = "0"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=CETIA;Integrated Security=Tru" & _
            "e"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Button1
        '
        Me.Button1.Image = Global.ACCESOS.My.Resources.Resources.boton_salir
        Me.Button1.Location = New System.Drawing.Point(385, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 55)
        Me.Button1.TabIndex = 35
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Image = Global.ACCESOS.My.Resources.Resources.boton_guardar2
        Me.BtnGuardar.Location = New System.Drawing.Point(117, 425)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(93, 55)
        Me.BtnGuardar.TabIndex = 34
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Alta_Bono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(600, 492)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GroupBoxMermas)
        Me.Controls.Add(Me.GroupBoxOficio)
        Me.Controls.Add(Me.GroupBoxCarta)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GBDatos)
        Me.Controls.Add(Me.GBClave)
        Me.Name = "Alta_Bono"
        Me.Text = "Asignacion de Bono"
        Me.GroupBox3.ResumeLayout(False)
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        Me.GBClave.ResumeLayout(False)
        Me.GBClave.PerformLayout()
        Me.GroupBoxMermas.ResumeLayout(False)
        Me.GroupBoxMermas.PerformLayout()
        Me.GroupBoxOficio.ResumeLayout(False)
        Me.GroupBoxOficio.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxCarta.ResumeLayout(False)
        Me.GroupBoxCarta.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimeHojas As System.Windows.Forms.DateTimePicker
    Friend WithEvents GBDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblCarrera As System.Windows.Forms.Label
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents GBClave As System.Windows.Forms.GroupBox
    Friend WithEvents LblMatricula As System.Windows.Forms.Label
    Friend WithEvents TBMatricula As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxMermas As System.Windows.Forms.GroupBox
    Friend WithEvents TBFolio As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxOficio As System.Windows.Forms.GroupBox
    Friend WithEvents TBTotalHoras As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxCarta As System.Windows.Forms.GroupBox
    Friend WithEvents TBTotalHojas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBTotalH As System.Windows.Forms.TextBox
    Friend WithEvents CBCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents CBSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
