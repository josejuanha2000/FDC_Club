Imports System.Data
Imports System.DateTime
Imports System.Data.SqlClient
Public Class FrmCompraB
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents LblMatricula As System.Windows.Forms.Label
    Friend WithEvents TBMatricula As System.Windows.Forms.TextBox
    Friend WithEvents GBDatos As System.Windows.Forms.GroupBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblCarrera As System.Windows.Forms.Label
    Friend WithEvents TBCarrera As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GBBono As System.Windows.Forms.GroupBox
    Friend WithEvents TBSem As System.Windows.Forms.TextBox
    Friend WithEvents TBEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents LblEfectivo As System.Windows.Forms.Label
    Friend WithEvents LblResto As System.Windows.Forms.Label
    Friend WithEvents TBTiempor As System.Windows.Forms.TextBox
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents BtnAceptab As System.Windows.Forms.Button
    Friend WithEvents DataTimePago As System.Windows.Forms.DateTimePicker
    Friend WithEvents GBClave As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LblMatricula = New System.Windows.Forms.Label
        Me.TBMatricula = New System.Windows.Forms.TextBox
        Me.GBDatos = New System.Windows.Forms.GroupBox
        Me.TBTiempor = New System.Windows.Forms.TextBox
        Me.LblResto = New System.Windows.Forms.Label
        Me.TBSem = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TBCarrera = New System.Windows.Forms.TextBox
        Me.LblCarrera = New System.Windows.Forms.Label
        Me.TBNombre = New System.Windows.Forms.TextBox
        Me.LblNombre = New System.Windows.Forms.Label
        Me.GBBono = New System.Windows.Forms.GroupBox
        Me.LblEfectivo = New System.Windows.Forms.Label
        Me.TBEfectivo = New System.Windows.Forms.TextBox
        Me.BtnOk = New System.Windows.Forms.Button
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.BtnAceptab = New System.Windows.Forms.Button
        Me.DataTimePago = New System.Windows.Forms.DateTimePicker
        Me.GBClave = New System.Windows.Forms.GroupBox
        Me.GBDatos.SuspendLayout()
        Me.GBBono.SuspendLayout()
        Me.GBClave.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TBMatricula.Text = ""
        '
        'GBDatos
        '
        Me.GBDatos.Controls.Add(Me.TBTiempor)
        Me.GBDatos.Controls.Add(Me.LblResto)
        Me.GBDatos.Controls.Add(Me.TBSem)
        Me.GBDatos.Controls.Add(Me.Label1)
        Me.GBDatos.Controls.Add(Me.TBCarrera)
        Me.GBDatos.Controls.Add(Me.LblCarrera)
        Me.GBDatos.Controls.Add(Me.TBNombre)
        Me.GBDatos.Controls.Add(Me.LblNombre)
        Me.GBDatos.Location = New System.Drawing.Point(24, 72)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Size = New System.Drawing.Size(480, 152)
        Me.GBDatos.TabIndex = 2
        Me.GBDatos.TabStop = False
        Me.GBDatos.Text = "Datos del Alumno:"
        '
        'TBTiempor
        '
        Me.TBTiempor.Enabled = False
        Me.TBTiempor.Location = New System.Drawing.Point(336, 88)
        Me.TBTiempor.Name = "TBTiempor"
        Me.TBTiempor.Size = New System.Drawing.Size(72, 20)
        Me.TBTiempor.TabIndex = 7
        Me.TBTiempor.Text = ""
        '
        'LblResto
        '
        Me.LblResto.Location = New System.Drawing.Point(232, 88)
        Me.LblResto.Name = "LblResto"
        Me.LblResto.Size = New System.Drawing.Size(96, 16)
        Me.LblResto.TabIndex = 6
        Me.LblResto.Text = "Tiempo restante:"
        '
        'TBSem
        '
        Me.TBSem.Location = New System.Drawing.Point(96, 112)
        Me.TBSem.Name = "TBSem"
        Me.TBSem.Size = New System.Drawing.Size(48, 20)
        Me.TBSem.TabIndex = 5
        Me.TBSem.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Semestre:"
        '
        'TBCarrera
        '
        Me.TBCarrera.Location = New System.Drawing.Point(96, 72)
        Me.TBCarrera.Name = "TBCarrera"
        Me.TBCarrera.Size = New System.Drawing.Size(48, 20)
        Me.TBCarrera.TabIndex = 3
        Me.TBCarrera.Text = ""
        '
        'LblCarrera
        '
        Me.LblCarrera.Location = New System.Drawing.Point(16, 72)
        Me.LblCarrera.Name = "LblCarrera"
        Me.LblCarrera.Size = New System.Drawing.Size(64, 16)
        Me.LblCarrera.TabIndex = 2
        Me.LblCarrera.Text = "Carrera:"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(96, 32)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(368, 20)
        Me.TBNombre.TabIndex = 1
        Me.TBNombre.Text = ""
        '
        'LblNombre
        '
        Me.LblNombre.Location = New System.Drawing.Point(16, 32)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(64, 16)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        '
        'GBBono
        '
        Me.GBBono.Controls.Add(Me.LblEfectivo)
        Me.GBBono.Controls.Add(Me.TBEfectivo)
        Me.GBBono.Location = New System.Drawing.Point(520, 72)
        Me.GBBono.Name = "GBBono"
        Me.GBBono.Size = New System.Drawing.Size(160, 152)
        Me.GBBono.TabIndex = 3
        Me.GBBono.TabStop = False
        Me.GBBono.Text = "Bono"
        '
        'LblEfectivo
        '
        Me.LblEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEfectivo.Location = New System.Drawing.Point(24, 64)
        Me.LblEfectivo.Name = "LblEfectivo"
        Me.LblEfectivo.Size = New System.Drawing.Size(16, 24)
        Me.LblEfectivo.TabIndex = 6
        Me.LblEfectivo.Text = "$"
        '
        'TBEfectivo
        '
        Me.TBEfectivo.Location = New System.Drawing.Point(48, 64)
        Me.TBEfectivo.MaxLength = 3
        Me.TBEfectivo.Name = "TBEfectivo"
        Me.TBEfectivo.Size = New System.Drawing.Size(72, 20)
        Me.TBEfectivo.TabIndex = 7
        Me.TBEfectivo.Text = ""
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(520, 32)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(32, 23)
        Me.BtnOk.TabIndex = 4
        Me.BtnOk.Text = "Ok"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=FDCCETSIS02;packet size=4096;integrated security=SSPI;data source=" & _
        """COLMASQLFDC01\FACDYCDES"";persist security info=False;initial catalog=Club"
        '
        'BtnAceptab
        '
        Me.BtnAceptab.Location = New System.Drawing.Point(552, 240)
        Me.BtnAceptab.Name = "BtnAceptab"
        Me.BtnAceptab.Size = New System.Drawing.Size(88, 32)
        Me.BtnAceptab.TabIndex = 5
        Me.BtnAceptab.Text = "Asignar Bono"
        '
        'DataTimePago
        '
        Me.DataTimePago.Enabled = False
        Me.DataTimePago.Location = New System.Drawing.Point(24, 240)
        Me.DataTimePago.Name = "DataTimePago"
        Me.DataTimePago.Size = New System.Drawing.Size(208, 20)
        Me.DataTimePago.TabIndex = 6
        '
        'GBClave
        '
        Me.GBClave.Controls.Add(Me.LblMatricula)
        Me.GBClave.Controls.Add(Me.TBMatricula)
        Me.GBClave.Location = New System.Drawing.Point(288, 16)
        Me.GBClave.Name = "GBClave"
        Me.GBClave.Size = New System.Drawing.Size(216, 48)
        Me.GBClave.TabIndex = 0
        Me.GBClave.TabStop = False
        Me.GBClave.Text = "Clave:"
        '
        'FrmCompraB
        '
        Me.AcceptButton = Me.BtnOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(696, 285)
        Me.Controls.Add(Me.DataTimePago)
        Me.Controls.Add(Me.BtnAceptab)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.GBBono)
        Me.Controls.Add(Me.GBDatos)
        Me.Controls.Add(Me.GBClave)
        Me.Name = "FrmCompraB"
        Me.Text = "Asignación de Bono"
        Me.GBDatos.ResumeLayout(False)
        Me.GBBono.ResumeLayout(False)
        Me.GBClave.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public horas
    Dim BONO As Integer = 20

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Try
            Me.SqlConnection1.Open()
            Dim sql As String = ("select * from alumnos inner join bonos on alumnos.matricula = bonos.matricula where alumnos.matricula = " & TBMatricula.Text)
            Dim calumnos As New SqlClient.SqlCommand(sql, Me.SqlConnection1)
            Dim CveMat As SqlParameter = calumnos.Parameters.Add(New SqlParameter("@matID", SqlDbType.NVarChar, 7))
            calumnos.Parameters("@MatID").Value = Me.TBMatricula.Text
            'Dim qty As Integer = CType(calumnos.ExecuteScalar(), Integer)
            Dim DRAlumnos As SqlClient.SqlDataReader
            DRAlumnos = calumnos.ExecuteReader(CommandBehavior.CloseConnection)
            DRAlumnos.Read()

            ' If TBMatricula.Text = "" Then
            '    MessageBox.Show("Tecle la Matricula del alumno")
            '    Return
            'End If
            TBNombre.Text = DRAlumnos("Nombre")
            TBCarrera.Text = DRAlumnos("Carr")
            TBSem.Text = DRAlumnos("Sem")
            TBTiempor.Text = DRAlumnos("Rest_Tiemp")
            TBEfectivo.Text = "20"
            'Asignación de bono para el alumno
            Me.SqlConnection1.Close()
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox(ex.Source & "; " & ex.Message, _
            MsgBoxStyle.OKOnly, "No se encontro alumno")
            Me.SqlConnection1.Close()
        End Try
    End Sub
    Private Sub BtnAceptab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptab.Click
        Dim fechapago As Date
        fechapago = Today
        Dim bonopag As String
        Dim HORAS As Integer
        Dim pago As Integer = 10
        HORAS = (CInt(TBEfectivo.Text / pago))
        bonopag = "0" + CStr(HORAS) + "00"
        TBTiempor.Text = (bonopag)
        'MessageBox.Show("La fecha actual es: " & fechapago)
        Try
            If MessageBox.Show("Desea Guardar los Cambios:?", "Transactions", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                       MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Me.SqlConnection1.Open()
                Dim sql2 As String = "INSERT INTO Bonos (Matricula,Nombre,carr,sem,REST_TIEMP,fechap) VALUES (@MatID,@Nombre,@Carr,@sem,@REST_TIEMP,@fechap)"
                Dim CMAlumnos As New SqlClient.SqlCommand(sql2, Me.SqlConnection1)
                CMAlumnos.Parameters.Add(New SqlParameter("@MatID", SqlDbType.NVarChar, 7)).Value = TBMatricula.Text
                CMAlumnos.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar, 40)).Value = TBNombre.Text
                CMAlumnos.Parameters.Add(New SqlParameter("@carr", SqlDbType.NVarChar, 1)).Value = TBCarrera.Text
                CMAlumnos.Parameters.Add(New SqlParameter("@sem", SqlDbType.NVarChar, 2)).Value = TBSem.Text
                CMAlumnos.Parameters.Add(New SqlParameter("@REST_TIEMP", SqlDbType.NVarChar, 4)).Value = TBTiempor.Text
                'CMAlumnos.Parameters.Add(New SqlParameter("@FECHAP", SqlDbType.DateTime, 8)).Value = DataTimePago.Text
                CMAlumnos.Parameters.Add(New SqlParameter("@FECHAP", SqlDbType.DateTime, 8)).Value = fechapago.Date
                'CMAlumnos.Parameters.Add(New SqlParameter("@FECHAP", SqlDbType.DateTime, 8)).Value = fechapago.TimeOfDay


                'CMAlumnos.Parameters.Add(New SqlParameter("@FECHAP", SqlDbType.SmallDateTime, 8)).Value = Today
                CMAlumnos.CommandText = sql2
                CMAlumnos.ExecuteNonQuery()
                MessageBox.Show(bonopag & " Horas Asignadas")
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
End Class
