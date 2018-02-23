Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Renta_Equipo
    Dim sqlbuscar_matricula As New SqlCommand
    Dim sqldrbuscar_matricula As SqlDataReader
    Dim sqlsala As New SqlCommand
    Dim sqldrsala As SqlDataReader
    Dim sqlpc_ocupadas As New SqlCommand
    Dim sqldrpc_ocupadas As SqlDataReader
    Dim sw_validar_datos As Integer
    Private Sub Renta_Equipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                'BTNGuardar.Enabled = True
                Me.TBNombre.Text = sqldrbuscar_matricula("Nombre")
                Me.TBCarrera.Text = sqldrbuscar_matricula("Carrera")
                Me.TBSem.Text = sqldrbuscar_matricula("Semestre")
                'Me.TBResto_Tiempo.Text = sqldrbuscar_matricula("Resto_horas")
                If Not IsDBNull(sqldrbuscar_matricula("Resto_Horas")) Then
                    Me.TBResto_Tiempo.Text = sqldrbuscar_matricula("Resto_Horas")
                Else
                    Me.TBResto_Tiempo.Text = ""
                End If

                Me.TBHoraEntrada.Text = TimeOfDay
                If Not IsDBNull(sqldrbuscar_matricula("Folio_Recibo")) Then
                    Me.TBFolio_Recibo.Text = sqldrbuscar_matricula("Folio_Recibo")
                Else
                    Me.TBFolio_Recibo.Text = ""
                End If
                If sqldrbuscar_matricula("Resto_horas") = 0 Then
                    MsgBox("Alumno no cuenta con horas renta")
                    Me.TBMatricula.Focus()
                    sqldrbuscar_matricula.Close()
                    Me.SqlConnection1.Close()
                    sw_validar_datos = 1
                    Exit Sub
                End If
            Else
                MsgBox("Alumno  no encuentrado, ")
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
    Sub Salas()
        Me.SqlConnection1.Open()
        sqlsala.CommandText = CommandType.Text
        sqlsala.CommandText = ("Select Sala,Cantidad_Pc  from Salas_Cetia where Salas_Cetia.Sala= '" & CBSalas.Text & "'")
        'sqlmatricula.CommandText = ("Select * from Alumnos where Alumnos.matricula = '" & TBMatricula.Text & "'" & "and Alumnos.Periodo_Escolar = '" & CBPeriodo.Text & "'")
        sqlsala.Connection = Me.SqlConnection1
        sqldrsala = sqlsala.ExecuteReader()
        sqldrsala.Read()
        While sqldrsala.Read()

        End While

    End Sub
    Sub pc_ocupadas()
        Try
            Me.SqlConnection1.Open()
            sqlpc_ocupadas.CommandText = CommandType.Text
            sqlpc_ocupadas.CommandText = ("Select Sala,No_PC,Hora_Entrada from Renta_Equipo where Renta_Equipo.sala='" & CBSalas.Text & "'")
            'sqlpc_ocupadas.CommandText = ("Select  * from Renta_Equipo  where Renta_Equipo.sala='" & CBSalas.Text & "'" & "ORDER BY SALA DESC")
            'sqlmatricula.CommandText = ("Select * from Alumnos where Alumnos.matricula = '" & TBMatricula.Text & "'" & "and Alumnos.Periodo_Escolar = '" & CBPeriodo.Text & "'")
            sqlpc_ocupadas.Connection = Me.SqlConnection1

            'sqldrpc_ocupadas = sqlpc_ocupadas.ExecuteReader
            'sqldrpc_ocupadas.Read()

            Dim Equipo_pc As String = "Btn"
            Dim CONT_EQ As Integer = 0
            'Dim desactivar_pc As String
            Dim recordcount As Integer = 0
            Dim da As New SqlDataAdapter
            Dim dt As New DataTable
            da = New SqlDataAdapter(sqlpc_ocupadas)
            'dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                If recordcount >= 1 Then
                    sqldrpc_ocupadas = sqlpc_ocupadas.ExecuteReader
                    sqldrpc_ocupadas.Read()
                    'MsgBox("No_pc")
                    ' MsgBox(CONT_EQ)
                End If
                recordcount = recordcount + 1
            Next

            While sqldrpc_ocupadas.Read = True
                If sqldrpc_ocupadas("No_PC") <> 0 And Not IsDBNull(sqldrpc_ocupadas("Hora_Entrada")) Then
                    'desactivar_pc = Equipo_pc + Str(CONT_EQ) + ".enable" + " = False"
                    CONT_EQ = sqldrpc_ocupadas("No_pc")
                    'Dim pc As String = Equipo_pc + Str(CONT_EQ)
                    If CONT_EQ = 1 Then
                        Btn1.Enabled = False
                    End If
                    If CONT_EQ = 2 Then
                        Btn2.Enabled = False
                    End If
                    If CONT_EQ = 3 Then
                        Btn3.Enabled = False
                    End If
                    If CONT_EQ = 4 Then
                        Btn4.Enabled = False
                    End If
                    If CONT_EQ = 5 Then
                        Btn5.Enabled = False
                    End If
                    If CONT_EQ = 6 Then
                        Btn6.Enabled = False
                    End If

                    'CONT_EQ = CONT_EQ + 1
                    'Dim SALA As Integer
                    'Select Case SALA
                    '    Case 1
                    'Btn1.Enabled = False
                    '    Case 2
                    'Btn1.Enabled = False
                    'End Select
                    'MsgBox(desactivar_pc)
                    MsgBox(CONT_EQ)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

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
            Call buscar_matricula_Bono()
            If sw_validar_datos = 0 Then
                Me.CBSalas.Focus()
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
    End Sub
    Sub pc_asignadas()
        Call desahabilitar_controles()
        Try
            Me.SqlConnection1.Open()
            sqlpc_ocupadas.CommandText = CommandType.Text
            sqlpc_ocupadas.CommandText = ("Select Sala,No_PC,Hora_Entrada from Renta_Equipo where Renta_Equipo.sala='" & CBSalas.Text & "'")
            'sqlpc_ocupadas.CommandText = ("Select  * from Renta_Equipo  where Renta_Equipo.sala='" & CBSalas.Text & "'" & "ORDER BY SALA DESC")
            'sqlmatricula.CommandText = ("Select * from Alumnos where Alumnos.matricula = '" & TBMatricula.Text & "'" & "and Alumnos.Periodo_Escolar = '" & CBPeriodo.Text & "'")
            sqlpc_ocupadas.Connection = Me.SqlConnection1
            sqldrpc_ocupadas = sqlpc_ocupadas.ExecuteReader
            'sqldrpc_ocupadas.Read()
            Dim Equipo_pc As String = "Btn"
            Dim CONT_EQ As Integer = 0
            'Dim desactivar_pc As String
            Dim recordcount As Integer = 0
            Dim da As New SqlDataAdapter
            Dim dt As New DataTable
            da = New SqlDataAdapter(sqlpc_ocupadas)
            'da.Fill(dt)
            Dim eq As Integer = 0
            While sqldrpc_ocupadas.Read()
                ' If (dt.Rows.Count > 0) Then
                If sqldrpc_ocupadas("No_PC") <> 0 And Not IsDBNull(sqldrpc_ocupadas("Hora_Entrada")) Then
                    'desactivar_pc = Equipo_pc + Str(CONT_EQ) + ".enable" + " = False"
                    CONT_EQ = sqldrpc_ocupadas("No_pc")
                    'Dim pc As String = Equipo_pc + Str(CONT_EQ)
                    ' equipo_pc & cont_eq &".enabled= false

                    If CONT_EQ = 1 Then
                        Btn1.Enabled = False
                    End If
                    If CONT_EQ = 2 Then
                        Btn2.Enabled = False
                    End If
                    If CONT_EQ = 3 Then
                        Btn3.Enabled = False
                    End If
                    If CONT_EQ = 4 Then
                        Btn4.Enabled = False
                    End If
                    If CONT_EQ = 5 Then
                        Btn5.Enabled = False
                    End If
                    If CONT_EQ = 6 Then
                        Btn6.Enabled = False
                    End If
                    'i += 2
                    'CONT_EQ = CONT_EQ + 1
                    'Dim SALA As Integer
                    'Select Case SALA
                    '    Case 1
                    'Btn1.Enabled = False
                    '    Case 2
                    'Btn1.Enabled = False
                    'End Select
                    'MsgBox(desactivar_pc)
                    MsgBox(CONT_EQ)
                    'MsgBox(i)
                End If
                ' End If
            End While
            sqldrpc_ocupadas.Close()
            SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub desahabilitar_controles()
        For Each c As Control In Me.GroupBoxEquipos.Controls
            If TypeOf c Is Button Then
                c.Enabled = True
            End If
        Next
    End Sub

    Private Sub CBSalas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBSalas.SelectedIndexChanged
        Call pc_asignadas()
    End Sub
    Sub equipo_asignadas()
        Try
            Me.SqlConnection1.Open()
            sqlpc_ocupadas.CommandText = CommandType.Text
            sqlpc_ocupadas.CommandText = ("Select Sala,No_PC,Hora_Entrada from Renta_Equipo where Renta_Equipo.sala='" & CBSalas.Text & "'")
            'sqlpc_ocupadas.CommandText = ("Select  * from Renta_Equipo  where Renta_Equipo.sala='" & CBSalas.Text & "'" & "ORDER BY SALA DESC")
            'sqlmatricula.CommandText = ("Select * from Alumnos where Alumnos.matricula = '" & TBMatricula.Text & "'" & "and Alumnos.Periodo_Escolar = '" & CBPeriodo.Text & "'")
            sqlpc_ocupadas.Connection = Me.SqlConnection1
            sqldrpc_ocupadas = sqlpc_ocupadas.ExecuteReader
            'sqldrpc_ocupadas.Read()
            Dim Equipo_pc As String = "Btn"
            Dim CONT_EQ As Integer = 0
            'Dim desactivar_pc As String
            Dim recordcount As Integer = 0
            Dim da As New SqlDataAdapter
            Dim dt As New DataTable
            da = New SqlDataAdapter(sqlpc_ocupadas)
            'da.Fill(dt)
            Dim i As Integer = 0
            While sqldrpc_ocupadas.Read()
                ' If (dt.Rows.Count > 0) Then
                If sqldrpc_ocupadas("No_PC") <> 0 And Not IsDBNull(sqldrpc_ocupadas("Hora_Entrada")) Then
                    'desactivar_pc = Equipo_pc + Str(CONT_EQ) + ".enable" + " = False"
                    CONT_EQ = sqldrpc_ocupadas("No_pc")
                    'Dim pc As String = Equipo_pc + Str(CONT_EQ)

                    If CONT_EQ = 1 Then
                        Btn1.Enabled = False
                    End If
                    If CONT_EQ = 2 Then
                        Btn2.Enabled = False
                    End If
                    If CONT_EQ = 3 Then
                        Btn3.Enabled = False
                    End If
                    If CONT_EQ = 4 Then
                        Btn4.Enabled = False
                    End If
                    If CONT_EQ = 5 Then
                        Btn5.Enabled = False
                    End If
                    If CONT_EQ = 6 Then
                        Btn6.Enabled = False
                    End If

                    'i += 2

                    'CONT_EQ = CONT_EQ + 1
                    'Dim SALA As Integer
                    'Select Case SALA
                    '    Case 1
                    'Btn1.Enabled = False
                    '    Case 2
                    'Btn1.Enabled = False
                    'End Select
                    'MsgBox(desactivar_pc)
                    MsgBox(CONT_EQ)
                    'MsgBox(i)
                End If
                ' End If
            End While
            sqldrpc_ocupadas.Close()
            SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    
End Class