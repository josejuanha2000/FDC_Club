Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Registro_Entrada
    Dim sqlbuscar_matricula As New SqlCommand
    Dim sqldrbuscar_matricula As SqlDataReader
    Dim sw_validar_datos As Integer
    Dim sqlequipo As New SqlCommand
    Dim sqldrequipo As SqlDataReader
    Dim sw_incidencia As Integer = 0
    Private Sub Registro_Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Equipos_SALA_L1()

        Me.TBHoraEntrada.Text = TimeOfDay
    End Sub
    Sub buscar_matricula_Bono()
        sw_validar_datos = 0
        Try
            Me.SqlConnection1.Open()
            sqlbuscar_matricula.CommandText = CommandType.Text
            sqlbuscar_matricula.CommandText = ("Select * from Bono_hojas where bono_hojas.matricula= '" & TBMatricula.Text & "'")
            'sqlmatricula.CommandText = ("Select * from Alumnos where Alumnos.matricula = '" & TBMatricula.Text & "'" & "and Alumnos.Periodo_Escolar = '" & CBPeriodo.Text & "'")
            sqlbuscar_matricula.Connection = Me.SqlConnection1
            sqldrbuscar_matricula = sqlbuscar_matricula.ExecuteReader()
            sqldrbuscar_matricula.Read()
            If sqldrbuscar_matricula.HasRows Then
                BTNGuardar.Enabled = True
                Me.TBNombre.Text = sqldrbuscar_matricula("Nombre")
                Me.TBCarrera.Text = sqldrbuscar_matricula("Carrera")
                Me.TBSem.Text = sqldrbuscar_matricula("Semestre")
                'Me.TBResto_Tiempo.Text = sqldrbuscar_matricula("Resto_horas")
                Me.TBHoraEntrada.Text = TimeOfDay
            Else
                MsgBox("Alumno no encuentrado, Favor de pedir comprovante..! ")
                Me.TBMatricula.Focus()
                sqldrbuscar_matricula.Close()
                Me.SqlConnection1.Close()
                sw_validar_datos = 1
                Exit Sub
            End If
            sqldrbuscar_matricula.Close()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
   Sub buscar_incidencia_alumno()
        sw_incidencia = 0
        Try
            Me.SqlConnection1.Open()
            sqlbuscar_matricula.CommandText = CommandType.Text
            sqlbuscar_matricula.CommandText = ("Select * from Incidencias where incidencias.matricula= '" & TBMatricula.Text & "'")
            sqlbuscar_matricula.Connection = Me.SqlConnection1
            sqldrbuscar_matricula = sqlbuscar_matricula.ExecuteReader()
            sqldrbuscar_matricula.Read()
            If sqldrbuscar_matricula.HasRows Then
                sw_incidencia = 1
                BTNGuardar.Enabled = True
                Me.TBNombre.Text = sqldrbuscar_matricula("Nombre")
                Me.TBCarrera.Text = sqldrbuscar_matricula("Carrera")
                Me.TBSem.Text = sqldrbuscar_matricula("Semestre")
                ' Me.TB_Tipo_Incidencia.Text = sqldrbuscar_matricula("Tipo_Incidencia")
                ''Me.TB_Fecha_Incidencia.Text = sqldrbuscar_matricula("Fecha_Incidencia")
                'Me.TB_Hora_Incidencia.Text = sqldrbuscar_matricula("Hora_Incidencia")
                MsgBox("Alumno tiene suspendido el servicio por incidencia, Favor de verificar en Descripcion.! ")
                'Me.TB_Descripcion_Incidencia.Text = sqldrbuscar_matricula("Descripcion_Incidencia")
            End If
            sqldrbuscar_matricula.Close()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    

    Sub Equipos_SALA_L1()
        Try
            Me.SqlConnection1.Open()
            sqlequipo.CommandText = CommandType.Text
            sqlequipo.CommandText = ("Select No_pc  from Equipos_L1" & CBEquipos.Text)
            sqlequipo.Connection = Me.SqlConnection1
            sqldrequipo = sqlequipo.ExecuteReader()
            sqldrequipo.Read()
            While sqldrequipo.Read()
                CBEquipos.Items.Add(sqldrequipo.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrequipo.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub registro_alumno()
        'Dim agregardatos As String
        ' agregardatos = MsgBox("Esta seguro de Guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        Try
            Me.SqlConnection1.Open()
            Dim Ins_Entrada_Alumno As String = "INSERT INTO Renta_Equipo (Matricula,Nombre,Carrera,Semestre,Sala,Hora_Entrada,Fecha_Registro,No_Pc) values(@Matricula,@Nombre,@Carrera,@Semestre,@Sala,@Hora_Entrada,@Fecha_Registro,@No_Pc)"
            Dim ConexA As New SqlClient.SqlCommand(Ins_Entrada_Alumno, Me.SqlConnection1)
            ConexA.Parameters.Add(New SqlParameter("@Matricula", SqlDbType.NChar, 7)).Value = Me.TBMatricula.Text
            ConexA.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar, 50)).Value = Me.TBNombre.Text
            ConexA.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NChar, 1)).Value = Me.TBCarrera.Text
            ConexA.Parameters.Add(New SqlParameter("@Semestre", SqlDbType.NChar, 2)).Value = Me.TBSem.Text
            ConexA.Parameters.Add(New SqlParameter("@Sala", SqlDbType.NChar, 3)).Value = Me.CBSalas.Text
            ConexA.Parameters.Add(New SqlParameter("@Hora_Entrada", SqlDbType.NVarChar, 15)).Value = Me.TBHoraEntrada.Text
            ConexA.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimeEntrada.Text
            ConexA.Parameters.Add(New SqlParameter("@No_Pc", SqlDbType.NVarChar, 2)).Value = CBEquipos.Text
            'ConexA.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.NVarChar, 20)).Value = Login_Impresiones.USUARIO_IMPRESIONES
            ConexA.CommandText = Ins_Entrada_Alumno
            ConexA.ExecuteNonQuery()
            Me.SqlConnection1.Close()
            MsgBox("Datos guardados correctamente", , "Guardar")
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Private Sub Combo1_gofocus()
        CBEquipos.DroppedDown = True
        'CBEquipos.SelectedIndex = -1
    End Sub
    Private Sub TBMatricula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBMatricula.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            'RadioButtonCarta.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            Call buscar_incidencia_alumno()
            If sw_incidencia = 1 Then
                TBMatricula.Focus()
                Me.BTNGuardar.Enabled = False
                Return
            Else
                Call buscar_matricula_Bono()
                If sw_validar_datos = 0 Then
                    Call Combo1_gofocus()
                    Me.CBEquipos.Focus()
                    'Me.BTNGuardar.Focus()
                Else
                    ' BtnGuardar.Enabled = True
                    ' TBNombre.Enabled = True
                    ' CBSemestre.Enabled = True
                    ' CBCarrera.Enabled = True
                    ' TBTotalHojas.Enabled = True
                    ' TBTotalHoras.Enabled = True
                    ' TBFolio.Enabled = True
                    ' Call LIMPIAR_CAMPOS()
                    ' TBNombre.Focus()
                End If
            End If
        End If
    End Sub
    Sub LIMPIAR_CAMPOS()
        TBMatricula.Text = ""
        TBNombre.Text = ""
        TBCarrera.Text = ""
        TBSem.Text = ""
        Me.TBHoraEntrada.Text = TimeOfDay
        TBMatricula.Focus()

    End Sub
    Private Sub BTNGuardar_Click(sender As Object, e As EventArgs) Handles BTNGuardar.Click
        Call registro_alumno()
        Call LIMPIAR_CAMPOS()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class