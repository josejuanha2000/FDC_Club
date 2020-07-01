Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Impresion_Hojas
    Dim sqlmatricula As New SqlCommand
    Dim sqldrmatricula As SqlDataReader
    Dim sqlregistro_hojas As New SqlCommand
    Dim sqldr_registro_hojas As SqlDataReader
    Dim sql_Inv_Hojas As New SqlCommand
    Dim sqldr_Inv_Hojas As SqlDataReader
    Dim H_CARTA As Integer = 0
    Dim H_OFICIO As Integer = 0
    Dim RESTO_HOJAS As Integer = 0
    Dim HOJAS_CAPTURADAS As Integer = 0
    Dim TOTAL_HOJAS As Integer = 0
    Dim SW As Integer = 0
    Dim sw_incidencia As Integer = 0
    Dim SW_VALIDAR_MATRICULA As Integer = 0
    Dim Inventario_Existente_Carta As Integer = 0
    Dim Inventario_Existente_Oficio As Integer = 0
    Dim Inventario_Existente_Mermas As Integer = 0
    Dim SW_INVENTARIO As Integer = 0
    Dim sqlbuscar_matricula As New SqlCommand
    Dim sqldrbuscar_matricula As SqlDataReader
    Private Sub Impresion_Hojas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call buscar_matricula()
    End Sub
    Sub buscar_matricula()
        Call limpiar_campos_incidencia()
        Call validacion_existencia_hojas()
        If SW_INVENTARIO = 0 Then
            Call cargar_lisview()
            Try
                Me.SqlConnection1.Open()
                sqlmatricula.CommandText = CommandType.Text
                sqlmatricula.CommandText = ("Select * from Bono_hojas where bono_hojas.matricula= '" & TBMatricula.Text & "'" & "order by Resto_Hojas Desc")
                'sqlmatricula.CommandText = ("Select * from Alumnos where Alumnos.matricula = '" & TBMatricula.Text & "'" & "and Alumnos.Periodo_Escolar = '" & CBPeriodo.Text & "'")
                sqlmatricula.Connection = Me.SqlConnection1
                sqldrmatricula = sqlmatricula.ExecuteReader()
                sqldrmatricula.Read()
                If sqldrmatricula.HasRows Then
                    'Frm_Resultado.TBMatricula.Text = sqldrmatricula("Matricula")
                    'Me.TBMatricula.Text = sqldrmatricula("Matricula")
                    BTNGuardar.Enabled = True
                    Me.TBNombre.Text = sqldrmatricula("Nombre")
                    Me.TBCarrera.Text = sqldrmatricula("Carrera")
                    Me.TBSemestre.Text = sqldrmatricula("Semestre")
                    Me.TBTotal.Text = sqldrmatricula("Resto_hojas")
                    If sqldrmatricula("Resto_hojas") = 0 Then
                        BTNGuardar.Enabled = False
                        MsgBox("Alumno con terminación de Bono")
                        SW_VALIDAR_MATRICULA = 2
                        sqldrmatricula.Close()
                        Me.SqlConnection1.Close()
                        TBHojas_Carta.Focus()
                        'Call LIMPIAR_CAMPOS()
                        'Exit Sub
                    Else
                        SW_VALIDAR_MATRICULA = 3
                    End If
                    'If IsDBNull(sqldrmatricula("Aula")) Then
                    ' Me.TBAula.Text = " "
                    ' Else
                    ' Me.TBAula.Text = sqldrmatricula("Aula")
                    ' End If
                    ' If IsDBNull(sqldrmatricula("turno")) Then
                    ' Me.CBTurno.Text = " "
                Else
                    MsgBox("No existe registro de Alumnos, favor de pedir comprobante.")
                    sqldrmatricula.Close()
                    Me.SqlConnection1.Close()
                    SW_VALIDAR_MATRICULA = 1
                    Call LIMPIAR_CAMPOS()
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            sqldrmatricula.Close()
            Me.SqlConnection1.Close()
            'Call cargar_lisview()
        Else
            Call LIMPIAR_CAMPOS()
        End If
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
                'Me.TBNombre.Text = sqldrbuscar_matricula("Nombre")
                'Me.TBCarrera.Text = sqldrbuscar_matricula("Carrera")
                'Me.TBSemestre.Text = sqldrbuscar_matricula("Semestre")
                Me.TB_Tipo_Incidencia.Text = sqldrbuscar_matricula("Tipo_Incidencia")
                Me.TB_Fecha_Incidencia.Text = sqldrbuscar_matricula("Fecha_Incidencia")
                Me.TB_Hora_Incidencia.Text = sqldrbuscar_matricula("Hora_Incidencia")
                MsgBox("Alumno tiene suspendido el servicio por incidencia, Favor de verificar en Descripcion.! ")
                Me.TB_Descripcion_Incidencia.Text = sqldrbuscar_matricula("Descripcion_Incidencia")
                Me.BTNGuardar.Enabled = False
            End If
            sqldrbuscar_matricula.Close()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub registro_alumno()
        Call CALCULAR_HOJAS()
        Call Inventario_hojas()
        If SW = 1 Then
            Call LIMPIAR_CAMPOS()
            SW = 0
            Exit Sub
        End If
        'Dim agregardatos As String
        ' agregardatos = MsgBox("Esta seguro de Guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        Try
            ' If agregardatos = vbYes Then
            Me.SqlConnection1.Open()
            Dim Ins_Hojas_Alumno As String = "INSERT INTO Registro_Hojas (Matricula,Carrera,Semestre,Hojas_Carta,Hojas_Oficio,Hojas_Merma,Fecha_Registro,Usuario) values(@Matricula,@Carrera,@Semestre,@Hojas_Carta,@Hojas_Oficio,@Hojas_Merma,@Fecha_Registro,@Usuario)"
            Dim ConexA As New SqlClient.SqlCommand(Ins_Hojas_Alumno, Me.SqlConnection1)
            ConexA.Parameters.Add(New SqlParameter("@Matricula", SqlDbType.NChar, 7)).Value = Me.TBMatricula.Text
            'ConexA.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar, 50)).Value = Me.TBNombre.Text
            ConexA.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NChar, 1)).Value = Me.TBCarrera.Text
            ConexA.Parameters.Add(New SqlParameter("@Semestre", SqlDbType.NChar, 2)).Value = Me.TBSemestre.Text
            'ConexA.Parameters.Add(New SqlParameter("@Periodo_Escolar", SqlDbType.NChar, 3)).Value = Me.CBPeriodo.Text
            If Me.TBHojas_Carta.Text = "" Then
                ConexA.Parameters.Add(New SqlParameter("@Hojas_Carta", SqlDbType.Int, 9)).Value = CInt("0")
            Else
                ConexA.Parameters.Add(New SqlParameter("@hojas_Carta", SqlDbType.Int, 9)).Value = CInt(Me.TBHojas_Carta.Text)
            End If
            If Me.TBHojas_Oficio.Text = "" Then
                ConexA.Parameters.Add(New SqlParameter("@Hojas_Oficio", SqlDbType.Int, 9)).Value = CInt("0")
            Else
                ConexA.Parameters.Add(New SqlParameter("@Hojas_Oficio", SqlDbType.Int, 9)).Value = CInt(Me.TBHojas_Oficio.Text)
            End If
            If Me.TBHojas_Merma.Text = "" Then
                ConexA.Parameters.Add(New SqlParameter("@Hojas_Merma", SqlDbType.Int, 9)).Value = CInt("0")
            Else
                ConexA.Parameters.Add(New SqlParameter("@Hojas_Merma", SqlDbType.Int, 9)).Value = CInt(Me.TBHojas_Merma.Text)
            End If
            'ConexA.Parameters.Add(New SqlParameter("@E_mail", SqlDbType.NVarChar, 50)).Value = Me.TBEmail.Text
            'ConexA.Parameters.Add(New SqlParameter("@Oport", SqlDbType.NChar, 1)).Value = Me.CBOportunidad.Text
            'ConexA.Parameters.Add(New SqlParameter("@Horario_Disponible", SqlDbType.NVarChar, 30)).Value = TBHorario.Text
            ConexA.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimeHojas.Text
            ConexA.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.NVarChar, 20)).Value = Login_Impresiones.USUARIO_IMPRESIONES
            'If Me.RadioButtonCarta.Checked = False Then
            ' ConexA.Parameters.Add(New SqlParameter("@Tutoria_Preventiva", SqlDbType.NChar, 1)).Value = "N"
            'Else
            'ConexA.Parameters.Add(New SqlParameter("@Tutoria_Preventiva", SqlDbType.NChar, 1)).Value = "S"
            'End If
            'ConexA.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 1)).Value = "1"
            ConexA.CommandText = Ins_Hojas_Alumno
            ConexA.ExecuteNonQuery()
            Me.SqlConnection1.Close()
            Call ACTUALIZA_BONO_HOJAS()
            'MsgBox("Datos guardados correctamente", , "Guardar")
            Call LIMPIAR_CAMPOS()
            'End If
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub cargar_lisview()
        Try
            Me.SqlConnection1.Open()
            'CBA2.Items.Clear()
            ListViewHistorial.Items.Clear()
            sqlregistro_hojas.CommandType = CommandType.Text
            'sqlsolicitud.CommandText = ("Select Matricula,Nombre,Carrera,Sem,Materia_TP,Materia_TC,Materia_Revision from Solicitud where Solicitud.Matricula =  '" & TBMatricula.Text & "'" & "and Solicitud.Periodo_Escolar='" & CBPeriodo.Text & "'")
            sqlregistro_hojas.CommandText = ("Select Matricula,Carrera,Semestre,Hojas_Carta,Hojas_Oficio,Hojas_Merma,Fecha_Registro from Registro_Hojas where Registro_Hojas.Matricula =  '" & TBMatricula.Text & "'")
            sqlregistro_hojas.Connection = Me.SqlConnection1
            sqldr_registro_hojas = sqlregistro_hojas.ExecuteReader()

            While (sqldr_registro_hojas.Read())
                With ListViewHistorial.Items.Add(sqldr_registro_hojas("Matricula"))
                    '.subitems.add(sqldr_registro_hojas("Nombre"))
                    .subitems.add(sqldr_registro_hojas("Carrera"))
                    .subitems.add(sqldr_registro_hojas("Semestre"))
                    If Not IsDBNull(sqldr_registro_hojas("Hojas_Carta")) Then
                        .subitems.add(sqldr_registro_hojas("Hojas_Carta"))
                    End If
                    If Not IsDBNull(sqldr_registro_hojas("Hojas_Oficio")) Then
                        .subitems.add(sqldr_registro_hojas("Hojas_Oficio"))
                    End If
                    If Not IsDBNull(sqldr_registro_hojas("Hojas_Merma")) Then
                        .subitems.add(sqldr_registro_hojas("Hojas_Merma"))
                    End If
                    .subitems.add(sqldr_registro_hojas("Fecha_Registro"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldr_registro_hojas.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub CALCULAR_HOJAS()
        'Dim H_CARTA As Integer = 0
        'Dim H_OFICIO As Integer = 0
        'Dim TOTOTAL_HOJAS As Integer = 0
        H_CARTA = CInt(TBHojas_Carta.Text)
        H_OFICIO = CInt(TBHojas_Oficio.Text)
        RESTO_HOJAS = CInt(TBTotal.Text)
        HOJAS_CAPTURADAS = H_CARTA + H_OFICIO
        If HOJAS_CAPTURADAS > RESTO_HOJAS Then
            MsgBox("LA EXISTENCIA DE HOJAS NO ES SUFICIENTE: " & HOJAS_CAPTURADAS)
            SW = 1
            TBMatricula.Focus()
            Return
            'TBHojas_Carta.Focus()
        Else
            If HOJAS_CAPTURADAS = 0 Then
                MsgBox("No Existen Hojas Capturadas: " & HOJAS_CAPTURADAS)
                SW = 1
                TBMatricula.Focus()
                Return
            Else
                TOTAL_HOJAS = RESTO_HOJAS - (H_CARTA + H_OFICIO)
                MsgBox("RESTO DE HOJAS: " & TOTAL_HOJAS)
                'SW = "S"
            End If
        End If
    End Sub
    Sub ACTUALIZA_BONO_HOJAS()
        Try
            Me.SqlConnection1.Open()
            Dim Actualiza_Bono_Hojas As String = ("UPDATE Bono_Hojas SET Resto_hojas=@Resto_hojas where Matricula= '" & TBMatricula.Text & "'")
            Dim conex1 As New SqlClient.SqlCommand(Actualiza_Bono_Hojas, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Resto_Hojas", SqlDbType.Int, 9, 0)).Value = TOTAL_HOJAS
            conex1.CommandText = Actualiza_Bono_Hojas
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
            'Call cargar_lisview()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Inventario_hojas()
        Try
            Me.SqlConnection1.Open()
            sql_Inv_Hojas.CommandType = CommandType.Text
            sql_Inv_Hojas.CommandText = ("select *  from Inventario_Hojas")
            sql_Inv_Hojas.Connection = Me.SqlConnection1
            sqldr_Inv_Hojas = sql_Inv_Hojas.ExecuteReader()
            sqldr_Inv_Hojas.Read()
            Inventario_Existente_Carta = (sqldr_Inv_Hojas("Existencia_Carta")) - H_CARTA
            Inventario_Existente_Oficio = (sqldr_Inv_Hojas("Existencia_Oficio")) - H_OFICIO
            MsgBox("EXISTENCIA DE HOJAS CARTA:" & Inventario_Existente_Carta)
            MsgBox("EXISTENCIA DE HOJAS oficio:" & Inventario_Existente_Oficio)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldr_Inv_Hojas.Close()
        Me.SqlConnection1.Close()
        Call ACTUALIZA_EXISTENCIAS_HOJAS()
    End Sub
    Sub validacion_existencia_hojas()
        Try
            Me.SqlConnection1.Open()
            sql_Inv_Hojas.CommandType = CommandType.Text
            sql_Inv_Hojas.CommandText = ("select *  from Inventario_Hojas")
            sql_Inv_Hojas.Connection = Me.SqlConnection1
            sqldr_Inv_Hojas = sql_Inv_Hojas.ExecuteReader()
            sqldr_Inv_Hojas.Read()
            If (sqldr_Inv_Hojas("Existencia_Carta")) = 0 Then
                MsgBox("No EXISTEN HOJAS CARTA EN INVENTARIO...!")
                SW_INVENTARIO = 1
            End If
            If (sqldr_Inv_Hojas("Existencia_Oficio")) = 0 Then
                MsgBox("No EXISTEN HOJAS OFICIO EN INVENTARIO...!")
                SW_INVENTARIO = 1
            End If
            'Inventario_Existente_Carta = (sqldr_Inv_Hojas("Existencia_Carta")) - H_CARTA
            'Inventario_Existente_Oficio = (sqldr_Inv_Hojas("Existencia_Oficio")) - H_OFICIO
            'MsgBox("EXISTENCIA DE HOJAS CARTA:" & Inventario_Existente_Carta)
            'MsgBox("EXISTENCIA DE HOJAS oficio:" & Inventario_Existente_Oficio)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldr_Inv_Hojas.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub ACTUALIZA_EXISTENCIAS_HOJAS()
        Try
            Me.SqlConnection1.Open()
            Dim Actualiza_Bono_Hojas As String = ("UPDATE Inventario_Hojas SET Existencia_Carta=@Existencia_Carta,Existencia_Oficio=@Existencia_Oficio where Area= '" & "1" & "'")
            Dim conex1 As New SqlClient.SqlCommand(Actualiza_Bono_Hojas, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Existencia_Carta", SqlDbType.Int, 4)).Value = Inventario_Existente_Carta
            conex1.Parameters.Add(New SqlParameter("@Existencia_Oficio", SqlDbType.Int, 4)).Value = Inventario_Existente_Oficio
            conex1.CommandText = Actualiza_Bono_Hojas
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
            'Call cargar_lisview()
        Catch es As Exception
            MsgBox(es.ToString)
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
            MsgBox("No se pueden ingresar letra")
        End If
        If Asc(e.KeyChar) = 13 Then

            'Call buscar_incidencia_alumno()

            'If sw_incidencia = 0 Then
            Call buscar_matricula()

            If SW_VALIDAR_MATRICULA = 1 Then
                'Call LIMPIAR_CAMPOS()
                TBMatricula.Focus()
                Return
            Else
                If SW_VALIDAR_MATRICULA = 2 Then
                    TBMatricula.Focus()
                    Return
                Else
                    TBHojas_Carta.Enabled = True
                    TBHojas_Oficio.Enabled = True
                    TBHojas_Merma.Enabled = True
                    TBHojas_Carta.Focus()
                    Call buscar_incidencia_alumno()
                    Me.TBMatricula.Focus()

                End If
            End If

            ''RadioButtonCarta.Focus()
        End If
        'Else

        'TBMatricula.Focus()
        'Return
        'End If

    End Sub
    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click
        Call registro_alumno()
    End Sub
    Public Sub solonumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            'RadioButtonCarta.Focus()
        End If
    End Sub
    Sub LIMPIAR_CAMPOS()
        TBMatricula.Text = ""
        TBNombre.Text = ""
        TBCarrera.Text = ""
        TBSemestre.Text = ""
        TBHojas_Carta.Text = 0
        TBHojas_Oficio.Text = 0
        TBHojas_Merma.Text = 0
        TBTotal.Text = 0
        TBMatricula.Focus()
        ListViewHistorial.Items.Clear()
        TB_Tipo_Incidencia.Text = ""
        TB_Fecha_Incidencia.Text = ""
        TB_Hora_Incidencia.Text = ""
    End Sub
    Sub limpiar_campos_incidencia()
        TB_Tipo_Incidencia.Text = ""
        TB_Descripcion_Incidencia.Text = ""
        TB_Fecha_Incidencia.Text = ""
        TB_Hora_Incidencia.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub


End Class