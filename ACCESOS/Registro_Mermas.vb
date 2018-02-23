Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Registro_Mermas
    Dim sql_hojascta As New SqlCommand
    Dim sqldr_hojascta As SqlDataReader
    Dim sql_hojasoficio As New SqlCommand
    Dim sqldr_hojasoficio As SqlDataReader
    Dim sql_hojas As New SqlCommand
    Dim sqldr_hojas As SqlDataReader
    Dim hojas_cta As String = 0
    Dim hojas_oficio As String = 0
    Dim inv_hojas_cta As String = 0
    Dim inv_hojas_oficio As String = 0
    Dim mermas_hojas_carta As String = 0
    Dim mermas_hojas_oficio As String = 0

    Private Sub Registro_Mermas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call carga_hojas_cta()
        Call carga_hojas_oficio()
        Call cargar_inventario_hojas_CARTA()
        Call cargar_inventario_hojas_OFICIO()
    End Sub
    Sub carga_hojas_cta()
        Try
            Me.SqlConnection1.Open()
            sql_hojascta.CommandType = CommandType.Text
            sql_hojascta.CommandText = ("select Hojas_Carta  from Mermas")
            sql_hojascta.Connection = Me.SqlConnection1
            sqldr_hojascta = sql_hojascta.ExecuteReader()
            While sqldr_hojascta.Read = True
                CB_hojas_carta.Items.Add(sqldr_hojascta.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldr_hojascta.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub carga_hojas_oficio()
        Try
            Me.SqlConnection1.Open()
            sql_hojasoficio.CommandType = CommandType.Text
            sql_hojasoficio.CommandText = ("select *  from Mermas")
            sql_hojasoficio.Connection = Me.SqlConnection1
            sqldr_hojasoficio = sql_hojascta.ExecuteReader()
            While sqldr_hojasoficio.Read = True
                CB_Hojas_Oficio.Items.Add(sqldr_hojasoficio.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldr_hojasoficio.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_inventario_hojas_CARTA()
        Try
            Me.SqlConnection1.Open()
            sql_hojas.CommandType = CommandType.Text
            sql_hojas.CommandText = ("select *  from Inventario_Hojas")
            sql_hojas.Connection = Me.SqlConnection1
            sqldr_hojas = sql_hojas.ExecuteReader()
            sqldr_hojas.Read()
            Me.TB_Existencia_cta.Text = (sqldr_hojas("Existencia_Carta"))
            mermas_hojas_carta = (sqldr_hojas("Existencia_Carta"))
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldr_hojas.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_inventario_hojas_OFICIO()
        Try
            Me.SqlConnection1.Open()
            sql_hojas.CommandType = CommandType.Text
            sql_hojas.CommandText = ("select *  from Inventario_Hojas")
            sql_hojas.Connection = Me.SqlConnection1
            sqldr_hojas = sql_hojas.ExecuteReader()
            sqldr_hojas.Read()
            Me.TB_Existencia_Oficio.Text = (sqldr_hojas("Existencia_Oficio"))
            mermas_hojas_oficio = (sqldr_hojas("Existencia_Oficio"))

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldr_hojas.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_hojas_carta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_hojas_carta.SelectedIndexChanged
        Call cargar_inventario_hojas_CARTA()
        hojas_cta = mermas_hojas_carta - CInt(CB_hojas_carta.Text)
        'MsgBox("hojas_cta " & hojas_cta)
        inv_hojas_cta = hojas_cta
        '+ CInt(TB_Existencia_cta.Text)
        TB_Existencia_cta.Text = CStr(inv_hojas_cta)
        'MsgBox("total: " & inv_hojas_cta)
    End Sub
    Private Sub CB_Hojas_Oficio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Hojas_Oficio.SelectedIndexChanged
        Call cargar_inventario_hojas_OFICIO()
        hojas_oficio = mermas_hojas_oficio - CInt(CB_Hojas_Oficio.Text)
        'MsgBox("hojas_oficio " & hojas_oficio)
        inv_hojas_oficio = hojas_oficio
        '+ CInt(TB_Existencia_Oficio.Text)
        'MsgBox("total: " & inv_hojas_oficio)
        TB_Existencia_Oficio.Text = CStr(inv_hojas_oficio)
    End Sub
    Sub Actualizar_Datos_Inventario()
        Try
            Dim Actualizar_Li As String
            Me.SqlConnection1.Open()
            Actualizar_Li = MsgBox("Esta seguro de Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If Actualizar_Li = vbYes Then
                'Dim Actualizar_Datos_Litigio As String = ("UPDATE Solicitud SET Aprobo=@Aprobo,Reprobo=@Reprobo,No_presento=@No_presento,Motivo=@Motivo,Calificacion=@Calificacion,Fecha_Publicacion=@Fecha_Publicacion,Maestro_Revision=@Maestro_Revision,Fecha_Examen=@Fecha_Examen,Fecha_Sig_Oport=@Fecha_Sig_Oport,Fecha_Revision=@Fecha_Revision,Alumno_asistio_Modificacion=@Alumno_asistio_Modificacion,Alumno_Asistio_Acuerdo_NoModificacion=@Alumno_Asistio_Acuerdo_NoModificacion,Alumno_NoAsiste_Desacuerdo=@Alumno_NoAsiste_Desacuerdo,Observaciones=@Observaciones where Matricula= '" & TBMatricula.Text & "'" & "and solicitud.Periodo_Escolar = '" & Frm_Solicitud.CBPeriodo.Text & "'" & "and ID = '" & Frm_Solicitud.TBID.Text & "'")
                Dim Actualizar_Datos_Inventario As String = ("UPDATE Inventario_Hojas SET Existencia_Carta=@Existencia_Carta,Existencia_Oficio=@Existencia_Oficio where Area= '" & "1" & "'")
                Dim conex1 As New SqlClient.SqlCommand(Actualizar_Datos_Inventario, Me.SqlConnection1)
                'conex1 .Parameters.Add(New SqlParameter("@Fecha_Asesoria_L", SqlDbType.SmallDateTime)).Value = DateTimePicker1.Text
                conex1.Parameters.Add(New SqlParameter("@Existencia_Carta", SqlDbType.Int, 4)).Value = Me.TB_Existencia_cta.Text
                conex1.Parameters.Add(New SqlParameter("@Existencia_Oficio", SqlDbType.Int, 4)).Value = Me.TB_Existencia_Oficio.Text
                conex1.CommandText = Actualizar_Datos_Inventario
                conex1.ExecuteNonQuery()
                MsgBox("Datos Actualizados correctamente", , "Guardar")
            End If
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        Call Actualizar_Datos_Inventario()
    End Sub

End Class