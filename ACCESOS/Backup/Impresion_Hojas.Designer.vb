﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Impresion_Hojas
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
        Me.GBDatos = New System.Windows.Forms.GroupBox
        Me.TBSemestre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TBCarrera = New System.Windows.Forms.TextBox
        Me.LblCarrera = New System.Windows.Forms.Label
        Me.TBNombre = New System.Windows.Forms.TextBox
        Me.LblNombre = New System.Windows.Forms.Label
        Me.GBClave = New System.Windows.Forms.GroupBox
        Me.LblMatricula = New System.Windows.Forms.Label
        Me.TBMatricula = New System.Windows.Forms.TextBox
        Me.ListViewHistorial = New System.Windows.Forms.ListView
        Me.Matricula = New System.Windows.Forms.ColumnHeader
        Me.Carrera = New System.Windows.Forms.ColumnHeader
        Me.Semestre = New System.Windows.Forms.ColumnHeader
        Me.Hojas_Carta = New System.Windows.Forms.ColumnHeader
        Me.Hojas_Oficio = New System.Windows.Forms.ColumnHeader
        Me.Hojas_Merma = New System.Windows.Forms.ColumnHeader
        Me.Fecha_Registro = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TBTotal = New System.Windows.Forms.TextBox
        Me.DateTimeHojas = New System.Windows.Forms.DateTimePicker
        Me.GroupBoxCarta = New System.Windows.Forms.GroupBox
        Me.TBHojas_Carta = New System.Windows.Forms.TextBox
        Me.GroupBoxOficio = New System.Windows.Forms.GroupBox
        Me.TBHojas_Oficio = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.GroupBoxMermas = New System.Windows.Forms.GroupBox
        Me.TBHojas_Merma = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BTNGuardar = New System.Windows.Forms.Button
        Me.GBDatos.SuspendLayout()
        Me.GBClave.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxCarta.SuspendLayout()
        Me.GroupBoxOficio.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBoxMermas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBDatos
        '
        Me.GBDatos.Controls.Add(Me.TBSemestre)
        Me.GBDatos.Controls.Add(Me.Label1)
        Me.GBDatos.Controls.Add(Me.TBCarrera)
        Me.GBDatos.Controls.Add(Me.LblCarrera)
        Me.GBDatos.Controls.Add(Me.TBNombre)
        Me.GBDatos.Controls.Add(Me.LblNombre)
        Me.GBDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDatos.Location = New System.Drawing.Point(12, 68)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Size = New System.Drawing.Size(566, 107)
        Me.GBDatos.TabIndex = 10
        Me.GBDatos.TabStop = False
        Me.GBDatos.Text = "Datos del Alumno:"
        '
        'TBSemestre
        '
        Me.TBSemestre.Enabled = False
        Me.TBSemestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSemestre.Location = New System.Drawing.Point(242, 72)
        Me.TBSemestre.Name = "TBSemestre"
        Me.TBSemestre.Size = New System.Drawing.Size(48, 20)
        Me.TBSemestre.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Semestre:"
        '
        'TBCarrera
        '
        Me.TBCarrera.Enabled = False
        Me.TBCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCarrera.Location = New System.Drawing.Point(80, 72)
        Me.TBCarrera.Name = "TBCarrera"
        Me.TBCarrera.Size = New System.Drawing.Size(48, 20)
        Me.TBCarrera.TabIndex = 3
        '
        'LblCarrera
        '
        Me.LblCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCarrera.Location = New System.Drawing.Point(16, 74)
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
        'GBClave
        '
        Me.GBClave.Controls.Add(Me.LblMatricula)
        Me.GBClave.Controls.Add(Me.TBMatricula)
        Me.GBClave.Location = New System.Drawing.Point(12, 12)
        Me.GBClave.Name = "GBClave"
        Me.GBClave.Size = New System.Drawing.Size(256, 48)
        Me.GBClave.TabIndex = 9
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
        'ListViewHistorial
        '
        Me.ListViewHistorial.AllowColumnReorder = True
        Me.ListViewHistorial.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Matricula, Me.Carrera, Me.Semestre, Me.Hojas_Carta, Me.Hojas_Oficio, Me.Hojas_Merma, Me.Fecha_Registro})
        Me.ListViewHistorial.FullRowSelect = True
        Me.ListViewHistorial.GridLines = True
        Me.ListViewHistorial.Location = New System.Drawing.Point(12, 274)
        Me.ListViewHistorial.Name = "ListViewHistorial"
        Me.ListViewHistorial.Size = New System.Drawing.Size(793, 286)
        Me.ListViewHistorial.TabIndex = 11
        Me.ListViewHistorial.UseCompatibleStateImageBehavior = False
        Me.ListViewHistorial.View = System.Windows.Forms.View.Details
        '
        'Matricula
        '
        Me.Matricula.Text = "MATRICULA"
        Me.Matricula.Width = 80
        '
        'Carrera
        '
        Me.Carrera.Text = "CARR"
        '
        'Semestre
        '
        Me.Semestre.Text = "SEM"
        '
        'Hojas_Carta
        '
        Me.Hojas_Carta.Text = "CARTA"
        '
        'Hojas_Oficio
        '
        Me.Hojas_Oficio.Text = "OFICIO"
        '
        'Hojas_Merma
        '
        Me.Hojas_Merma.Text = "MERMA"
        '
        'Fecha_Registro
        '
        Me.Fecha_Registro.Text = "FECHA_REGISTRO"
        Me.Fecha_Registro.Width = 110
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBTotal)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(454, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 74)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resto Total:"
        '
        'TBTotal
        '
        Me.TBTotal.Enabled = False
        Me.TBTotal.Location = New System.Drawing.Point(16, 26)
        Me.TBTotal.Multiline = True
        Me.TBTotal.Name = "TBTotal"
        Me.TBTotal.Size = New System.Drawing.Size(102, 28)
        Me.TBTotal.TabIndex = 5
        '
        'DateTimeHojas
        '
        Me.DateTimeHojas.Enabled = False
        Me.DateTimeHojas.Location = New System.Drawing.Point(11, 19)
        Me.DateTimeHojas.Name = "DateTimeHojas"
        Me.DateTimeHojas.Size = New System.Drawing.Size(208, 20)
        Me.DateTimeHojas.TabIndex = 20
        '
        'GroupBoxCarta
        '
        Me.GroupBoxCarta.Controls.Add(Me.TBHojas_Carta)
        Me.GroupBoxCarta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCarta.Location = New System.Drawing.Point(12, 194)
        Me.GroupBoxCarta.Name = "GroupBoxCarta"
        Me.GroupBoxCarta.Size = New System.Drawing.Size(134, 71)
        Me.GroupBoxCarta.TabIndex = 25
        Me.GroupBoxCarta.TabStop = False
        Me.GroupBoxCarta.Text = "Carta:"
        '
        'TBHojas_Carta
        '
        Me.TBHojas_Carta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBHojas_Carta.Location = New System.Drawing.Point(18, 26)
        Me.TBHojas_Carta.Name = "TBHojas_Carta"
        Me.TBHojas_Carta.Size = New System.Drawing.Size(88, 20)
        Me.TBHojas_Carta.TabIndex = 6
        Me.TBHojas_Carta.Text = "0"
        '
        'GroupBoxOficio
        '
        Me.GroupBoxOficio.Controls.Add(Me.TBHojas_Oficio)
        Me.GroupBoxOficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOficio.Location = New System.Drawing.Point(152, 194)
        Me.GroupBoxOficio.Name = "GroupBoxOficio"
        Me.GroupBoxOficio.Size = New System.Drawing.Size(134, 71)
        Me.GroupBoxOficio.TabIndex = 26
        Me.GroupBoxOficio.TabStop = False
        Me.GroupBoxOficio.Text = "Oficio:"
        '
        'TBHojas_Oficio
        '
        Me.TBHojas_Oficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBHojas_Oficio.Location = New System.Drawing.Point(18, 26)
        Me.TBHojas_Oficio.Name = "TBHojas_Oficio"
        Me.TBHojas_Oficio.Size = New System.Drawing.Size(88, 20)
        Me.TBHojas_Oficio.TabIndex = 7
        Me.TBHojas_Oficio.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTimeHojas)
        Me.GroupBox3.Location = New System.Drawing.Point(284, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(294, 50)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha de Captura:"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=CETIA;Integrated Security=Tru" & _
            "e"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'GroupBoxMermas
        '
        Me.GroupBoxMermas.Controls.Add(Me.TBHojas_Merma)
        Me.GroupBoxMermas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxMermas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBoxMermas.Location = New System.Drawing.Point(293, 194)
        Me.GroupBoxMermas.Name = "GroupBoxMermas"
        Me.GroupBoxMermas.Size = New System.Drawing.Size(134, 71)
        Me.GroupBoxMermas.TabIndex = 29
        Me.GroupBoxMermas.TabStop = False
        Me.GroupBoxMermas.Text = "Mermas:"
        '
        'TBHojas_Merma
        '
        Me.TBHojas_Merma.Enabled = False
        Me.TBHojas_Merma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBHojas_Merma.Location = New System.Drawing.Point(18, 26)
        Me.TBHojas_Merma.Name = "TBHojas_Merma"
        Me.TBHojas_Merma.Size = New System.Drawing.Size(88, 20)
        Me.TBHojas_Merma.TabIndex = 8
        Me.TBHojas_Merma.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Green
        Me.GroupBox2.Location = New System.Drawing.Point(584, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(221, 47)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "IMPRESIONES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(55, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "C E T I A"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ACCESOS.My.Resources.Resources.impresora_samsung
        Me.PictureBox1.Location = New System.Drawing.Point(584, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 191)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Image = Global.ACCESOS.My.Resources.Resources.boton_salir
        Me.Button1.Location = New System.Drawing.Point(550, 575)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 55)
        Me.Button1.TabIndex = 31
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTNGuardar
        '
        Me.BTNGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.BTNGuardar.Enabled = False
        Me.BTNGuardar.Image = Global.ACCESOS.My.Resources.Resources.boton_guardar2
        Me.BTNGuardar.Location = New System.Drawing.Point(200, 575)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(68, 58)
        Me.BTNGuardar.TabIndex = 30
        Me.BTNGuardar.UseVisualStyleBackColor = False
        '
        'Impresion_Hojas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(835, 656)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNGuardar)
        Me.Controls.Add(Me.GroupBoxMermas)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBoxOficio)
        Me.Controls.Add(Me.GroupBoxCarta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListViewHistorial)
        Me.Controls.Add(Me.GBDatos)
        Me.Controls.Add(Me.GBClave)
        Me.Name = "Impresion_Hojas"
        Me.Text = "Impresion_Hojas"
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        Me.GBClave.ResumeLayout(False)
        Me.GBClave.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxCarta.ResumeLayout(False)
        Me.GroupBoxCarta.PerformLayout()
        Me.GroupBoxOficio.ResumeLayout(False)
        Me.GroupBoxOficio.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBoxMermas.ResumeLayout(False)
        Me.GroupBoxMermas.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBDatos As System.Windows.Forms.GroupBox
    Friend WithEvents TBSemestre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBCarrera As System.Windows.Forms.TextBox
    Friend WithEvents LblCarrera As System.Windows.Forms.Label
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents GBClave As System.Windows.Forms.GroupBox
    Friend WithEvents LblMatricula As System.Windows.Forms.Label
    Friend WithEvents TBMatricula As System.Windows.Forms.TextBox
    Friend WithEvents ListViewHistorial As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBTotal As System.Windows.Forms.TextBox
    Friend WithEvents DateTimeHojas As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBoxCarta As System.Windows.Forms.GroupBox
    Friend WithEvents TBHojas_Carta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxOficio As System.Windows.Forms.GroupBox
    Friend WithEvents TBHojas_Oficio As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents GroupBoxMermas As System.Windows.Forms.GroupBox
    Friend WithEvents TBHojas_Merma As System.Windows.Forms.TextBox
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents Matricula As System.Windows.Forms.ColumnHeader
    Friend WithEvents Carrera As System.Windows.Forms.ColumnHeader
    Friend WithEvents Semestre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Hojas_Carta As System.Windows.Forms.ColumnHeader
    Friend WithEvents Hojas_Oficio As System.Windows.Forms.ColumnHeader
    Friend WithEvents Hojas_Merma As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fecha_Registro As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
