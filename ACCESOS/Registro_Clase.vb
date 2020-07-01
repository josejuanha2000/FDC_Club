Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Registro_Clase
    Dim sqlbuscar_empleado As New SqlCommand
    Dim sqldrbuscar_empleado As SqlDataReader
    Dim sw_validar_datos As Integer
    Dim sqlequipo As New SqlCommand
    Dim sqldrequipo As SqlDataReader
    Dim sw_incidencia As Integer = 0
    Dim SW_REGISTRO As Integer = 0
    '''''Cargar profesor''''
    Dim SqlCommandBuilderEliminar As SqlCommandBuilder
    Dim sql_cmd_profesor As SqlCommand
    Dim sql_Profesor_clase As String
    Dim d_table As DataTable
    Dim d_adapter As SqlDataAdapter
    Dim ds As DataSet
    ''''''cargar prfesor''''''''

    Private Sub Registro_Clase_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Sub buscar_profesor()
        sw_validar_datos = 0
        Try
            Me.SqlConnection1.Open()
            sqlbuscar_empleado.CommandText = CommandType.Text
            sqlbuscar_empleado.CommandText = ("Select * from Profesores where Profesores.No_Empleado= '" & TB_No_empleado.Text & "'")
            'sqlmatricula.CommandText = ("Select * from Alumnos where Alumnos.matricula = '" & TBMatricula.Text & "'" & "and Alumnos.Periodo_Escolar = '" & CBPeriodo.Text & "'")
            sqlbuscar_empleado.Connection = Me.SqlConnection1
            sqldrbuscar_empleado = sqlbuscar_empleado.ExecuteReader()
            sqldrbuscar_empleado.Read()
            If sqldrbuscar_empleado.HasRows Then
                BTNGuardar.Enabled = True
                Me.TB_Nombre.Text = sqldrbuscar_empleado("Nombre")
                'Me.TBCarrera.Text = sqldrbuscar_empleado("Carrera")
                'Me.TBSem.Text = sqldrbuscar_empleado("Semestre")
                'Me.TBResto_Tiempo.Text = sqldrbuscar_matricula("Resto_horas")
                ' Me.TBHoraEntrada.Text = TimeOfDay
            Else
                MsgBox("Maestro no encontrado, Favor de pedir horario..! ")
                Me.TB_No_Empleado.Focus()
                sqldrbuscar_empleado.Close()
                Me.SqlConnection1.Close()
                sw_validar_datos = 1
                Exit Sub
            End If
            sqldrbuscar_empleado.Close()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub validacion_existencia_clase()
        Dim sql_Profesor_registrado As New SqlCommand
        Dim sqldr_profesor_reg As SqlDataReader

        Try
            Me.SqlConnection1.Open()
            sql_Profesor_registrado.CommandType = CommandType.Text
            sql_Profesor_registrado.CommandText = ("Select * from Registro_Clase where  Fecha_Clase='" & Format(DateTimeClase.Value.ToString, "Short Date") & "'" & "AND Hora_Inicio_Clase ='" & CB_Hora_Inicio_Clase.Text & "'")
            '' sql_Profesor_registrado.CommandText = ("Select * from Registro_Clase where Fecha_Clase = '" & Format(DateTimeClase.Value.Date.ToString, "Short Date") & "," & "AND Hora_Inicio_Clase ='" & CB_Hora_Inicio_Clase.Text & "'")
            sql_Profesor_registrado.Connection = Me.SqlConnection1
            sqldr_profesor_reg = sql_Profesor_registrado.ExecuteReader()
            sqldr_profesor_reg.Read()
            If sqldr_profesor_reg.HasRows Then
                SW_REGISTRO = 1
                MsgBox("La Sala ya fue separada por el profesor: " & sqldr_profesor_reg("No_Empleado") & " " & sqldr_profesor_reg("Nombre"))
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'Me.sqldr_profesor_reg.Close()
        Me.SqlConnection1.Close()
    End Sub


    Private Sub Combo1_gofocus()
        CB_Hora_Inicio_Clase.DroppedDown = True
        'CBEquipos.SelectedIndex = -1
    End Sub



    Private Sub TB_No_Empleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_No_Empleado.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False 
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
            'RadioButtonCarta.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            Call buscar_profesor()
            If sw_incidencia = 1 Then
                TB_No_Empleado.Focus()
                Me.BTNGuardar.Enabled = False
                Return
            Else
                'Call buscar_matricula_Bono()
                If sw_validar_datos = 0 Then
                    Call Cargar_profesores_clase()
                    ' Call Combo1_gofocus()
                    Me.CB_Hora_Inicio_Clase.Focus()
                    'Me.BTNGuardar.Focus()

                End If
            End If
        End If
    End Sub
    Sub registro_Profesor()
        'Dim agregardatos As String
        ' agregardatos = MsgBox("Esta seguro de Guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        Try
            Me.SqlConnection1.Open()
            Dim Ins_Entrada_Clase As String = "INSERT INTO Registro_Clase(No_empleado,Nombre,Fecha_Clase,Hora_Inicio_Clase,Nombre_Materia,No_Oficio,Fecha_Registro,Observaciones) values(@No_empleado,@Nombre,@Fecha_Clase,@Hora_Inicio_Clase,@Nombre_Materia,@No_Oficio,@Fecha_Registro,@Observaciones)"
            Dim ConexA As New SqlClient.SqlCommand(Ins_Entrada_Clase, Me.SqlConnection1)
            ConexA.Parameters.Add(New SqlParameter("@No_empleado", SqlDbType.NChar, 7)).Value = Me.TB_No_Empleado.Text
            ConexA.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar, 50)).Value = Me.TB_Nombre.Text
            ConexA.Parameters.Add(New SqlParameter("@Fecha_Clase", SqlDbType.SmallDateTime)).Value = DateTimeClase.Text
            ConexA.Parameters.Add(New SqlParameter("@Hora_Inicio_Clase", SqlDbType.NChar, 4)).Value = Me.CB_Hora_Inicio_Clase.Text
            'ConexA.Parameters.Add(New SqlParameter("@Hora_Fin_Clase", SqlDbType.NChar, 4)).Value = Me.CB_Hora_Fin_Clase.Text
            ConexA.Parameters.Add(New SqlParameter("@Nombre_Materia", SqlDbType.NVarChar, 50)).Value = Me.TB_Nombre_Materia.Text
            ConexA.Parameters.Add(New SqlParameter("@No_Oficio", SqlDbType.NChar, 10)).Value = Me.TB_No_Oficio.Text
            ConexA.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            ConexA.Parameters.Add(New SqlParameter("@Observaciones", SqlDbType.NVarChar, 255)).Value = Me.TB_Observaciones.Text
            ConexA.CommandText = Ins_Entrada_Clase
            ConexA.ExecuteNonQuery()
            Me.SqlConnection1.Close()
            MsgBox("Datos guardados correctamente", , "Guardar")
            Call Cargar_profesores_clase()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Cargar_profesores_clase()

        Try
            Me.SqlConnection1.Open()
            ' sqlregistro_hojas.CommandText = ("Select Matricula,Carrera,Semestre,Hojas_Carta,Hojas_Oficio,Hojas_Merma,Fecha_Registro from Registro_Hojas where Registro_Hojas.Matricula =  '" & TBMatricula.Text & "'")
            sql_Profesor_clase = ("Select * from Registro_Clase where No_empleado= '" & TB_No_Empleado.Text & "'")
            sql_cmd_profesor = New SqlCommand(sql_Profesor_clase, Me.SqlConnection1)
            sql_cmd_profesor.CommandType = CommandType.Text
            sql_cmd_profesor.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(sql_cmd_profesor)
            ds = New System.Data.DataSet
            d_table = New DataTable
            d_adapter.Fill(d_table)
            DataGridView_Clase.DataSource = d_table
            'DataGridView1.DataSource = ds.Tables(0)
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim eliminardatos As String
        eliminardatos = MsgBox("Esta seguro de Eliminar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        If eliminardatos = vbYes Then
            Dim loFila As DataGridViewRow = Me.DataGridView_Clase.CurrentRow()
            DataGridView_Clase.Rows.Remove(loFila)


            SqlCommandBuilderEliminar = New SqlCommandBuilder(d_adapter)
            d_adapter.Update(d_table)
            MsgBox("Datos actualizados correctamente..!", , "Guardar")
        Else
            Call LIMPIAR_CAMPOS()
        End If

        'TBFolio.Focus()


    End Sub

    Sub LIMPIAR_CAMPOS()
        TB_No_Empleado.Text = ""
        TB_Nombre.Text = ""
        TB_Nombre_Materia.Text = ""
        TB_No_Oficio.Text = ""
        TB_Observaciones.Text = ""
        SW_REGISTRO = 0
        'Me.TBHoraEntrada.Text = TimeOfDay
        TB_No_Empleado.Focus()

    End Sub

    Private Sub BTNGuardar_Click(sender As Object, e As EventArgs) Handles BTNGuardar.Click
        Call validacion_existencia_clase()
        If SW_REGISTRO = 0 Then
            Call registro_Profesor()
        Else
            Call LIMPIAR_CAMPOS()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


End Class