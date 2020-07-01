Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class Registro_Incidencias
    Dim sqlbuscar_matricula As New SqlCommand
    Dim sqldrbuscar_matricula As SqlDataReader
    Dim sw_validar_datos As Integer
    Dim sqlequipo As New SqlCommand
    Dim sqldrequipo As SqlDataReader
    Private Sub Registro_Incidencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub buscar_matricula_Bono()
        sw_validar_datos = 0
        Try
            Me.SqlConnection1.Open()
            sqlbuscar_matricula.CommandText = CommandType.Text
            sqlbuscar_matricula.CommandText = ("Select * from Bono_hojas where bono_hojas.matricula= '" & TBMatricula.Text & "'")
            sqlbuscar_matricula.Connection = Me.SqlConnection1
            sqldrbuscar_matricula = sqlbuscar_matricula.ExecuteReader()
            sqldrbuscar_matricula.Read()
            If sqldrbuscar_matricula.HasRows Then
                sw_validar_datos = 1
                BTNGuardar.Enabled = True
                TBNombre.Enabled = False
                Me.TBNombre.Text = sqldrbuscar_matricula("Nombre")
                Me.CBCarrera.Text = sqldrbuscar_matricula("Carrera")
                Me.CB_Semestre.Text = sqldrbuscar_matricula("Semestre")
                'Me.CB_Hora_Incidencia.Text = sqldrbuscar_matricula("Incidencia")
                'Me.CB_Tipo_Incidencia.Text = sqldrbuscar_matricula("Incidencia")
                'Me.DateTime_Incidencia.TabIndex = sqldrbuscar_matricula("Fecha_Incidencia")
                'Me.TB_Observaciones.Text = sqldrbuscar_matricula("Descripcion_Incidencia")
            Else
                sw_validar_datos = 0
                Me.BTNGuardar.Enabled = True
                Me.TBNombre.Enabled = True
                Me.CBCarrera.Enabled = True
                Me.CB_Semestre.Enabled = True
                '    MsgBox("Alumno no se encuentra registrado..! ")
                '    Me.TBMatricula.Focus()
                '    sqldrbuscar_matricula.Close()
                '    Me.SqlConnection1.Close()
                '    Exit Sub
            End If
            sqldrbuscar_matricula.Close()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub buscar_matricula_Incidencia()

        Try
            Me.SqlConnection1.Open()
            sqlbuscar_matricula.CommandText = CommandType.Text
            sqlbuscar_matricula.CommandText = ("Select * from incidencias where incidencias.matricula= '" & TBMatricula.Text & "'")
            sqlbuscar_matricula.Connection = Me.SqlConnection1
            sqldrbuscar_matricula = sqlbuscar_matricula.ExecuteReader()
            sqldrbuscar_matricula.Read()
            If sqldrbuscar_matricula.HasRows Then
                sw_validar_datos = 2
                BTNGuardar.Enabled = True
                Me.TBNombre.Text = sqldrbuscar_matricula("Nombre")
                Me.CBCarrera.Text = sqldrbuscar_matricula("Carrera")
                Me.CB_Semestre.Text = sqldrbuscar_matricula("Semestre")
                Me.CB_Hora_Incidencia.Text = sqldrbuscar_matricula("Hora_Incidencia")
                Me.CB_Tipo_Incidencia.Text = sqldrbuscar_matricula("Tipo_Incidencia")
                Me.DateTime_Incidencia.Text = sqldrbuscar_matricula("Fecha_Incidencia")
                Me.CB_Hora_Incidencia.Text = sqldrbuscar_matricula("Hora_Incidencia")
                Me.TB_Observaciones.Text = sqldrbuscar_matricula("Descripcion_Incidencia")
            Else
                MsgBox("Favor de capturar los datos de la incidencia..! ")
                Me.TBNombre.Focus()
                'sqldrbuscar_matricula.Close()
                'Me.SqlConnection1.Close()
                'sw_validar_datos = 1
                'Exit Sub
            End If
            sqldrbuscar_matricula.Close()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub registro_incidencia_alumno()
        Dim agregardatos As String
        agregardatos = MsgBox("Esta seguro de Guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        Try
            If agregardatos = vbYes Then
                Me.SqlConnection1.Open()
                Dim Ins_Entrada_Alumno As String = "INSERT INTO Incidencias (Matricula,Nombre,Carrera,Semestre,Hora_Incidencia,Fecha_Incidencia,Tipo_Incidencia,Descripcion_Incidencia) values(@Matricula,@Nombre,@Carrera,@Semestre,@Hora_Incidencia,@Fecha_Incidencia,@Tipo_Incidencia,@Descripcion_Incidencia)"
                Dim ConexA As New SqlClient.SqlCommand(Ins_Entrada_Alumno, Me.SqlConnection1)
                ConexA.Parameters.Add(New SqlParameter("@Matricula", SqlDbType.NChar, 7)).Value = Me.TBMatricula.Text
                ConexA.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar, 50)).Value = Me.TBNombre.Text
                ConexA.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NChar, 1)).Value = Me.CBCarrera.Text
                ConexA.Parameters.Add(New SqlParameter("@Semestre", SqlDbType.NChar, 2)).Value = Me.CB_Semestre.Text
                ConexA.Parameters.Add(New SqlParameter("@Hora_Incidencia", SqlDbType.NChar, 5)).Value = Me.CB_Hora_Incidencia.Text
                ConexA.Parameters.Add(New SqlParameter("@Fecha_Incidencia", SqlDbType.SmallDateTime)).Value = DateTime_Incidencia.Text
                ConexA.Parameters.Add(New SqlParameter("@Tipo_Incidencia", SqlDbType.NVarChar, 50)).Value = CB_Tipo_Incidencia.Text
                ConexA.Parameters.Add(New SqlParameter("@Descripcion_Incidencia", SqlDbType.NVarChar, MaximizeBox)).Value = TB_Observaciones.Text
                ConexA.CommandText = Ins_Entrada_Alumno
                ConexA.ExecuteNonQuery()
                Me.SqlConnection1.Close()
                MsgBox("Datos guardados correctamente", , "Guardar")
                Me.TBMatricula.Focus()
            End If
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub eliminar_incidencia_alumno()
        Dim eliminar_incidencia As String
        eliminar_incidencia = MsgBox("Desea eliminar los datos de Incidencia ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Eliminar")
        Try
            If eliminar_incidencia = vbYes Then
                Me.SqlConnection1.Open()
                Dim sql_elimina_art1 As New SqlCommand
                Dim sqldr_elimina_incidencia As SqlDataReader
                Dim Datos_Incidencia As String = ("DELETE  FROM  Incidencias  WHERE  Incidencias.Matricula = '" & TBMatricula.Text & "'")
                Dim Conex1 As New SqlClient.SqlCommand(Datos_Incidencia, Me.SqlConnection1)
                sqldr_elimina_incidencia = Conex1.ExecuteReader()
                Me.SqlConnection1.Close()
                MsgBox("Datos eliminados correctamente", , "Eliminar")
                Me.TBMatricula.Focus()
            End If

        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Private Sub Combo1_gofocus()
        CB_Tipo_Incidencia.DroppedDown = True
    End Sub
    Private Sub TBMatricula_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles TBMatricula.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            'RadioButtonCarta.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            Call buscar_matricula_Bono()
            Call buscar_matricula_Incidencia()
            If sw_validar_datos = 2 Then
                MsgBox("Ya existe una incidencia para el alumnos")
                Call eliminar_incidencia_alumno()
                Call limpiar_campos()
            Else
                Call Combo1_gofocus()
            End If
            'Me.CB_Tipo_Incidencia.Focus()
            'Me.TBMatricula.Focus()
            'End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub BTNGuardar_Click(sender As Object, e As EventArgs) Handles BTNGuardar.Click
        Call registro_incidencia_alumno()
        Call limpiar_campos()
    End Sub
    Sub limpiar_campos()
        TBNombre.Clear()
        CB_Semestre.Text = ""
        CB_Tipo_Incidencia.Text = ""
        CBCarrera.Text = ""
        CB_Hora_Incidencia.Text = ""
        TB_Observaciones.Text = ""
    End Sub
End Class