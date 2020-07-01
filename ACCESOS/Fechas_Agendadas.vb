Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Fechas_Agendadas
    Dim sql_fechas_registradas As New SqlCommand
    Dim sqldr_fechas_registradas As SqlDataReader
    Private Sub Fechas_Agendadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim sql_fechas_ocupadas As New SqlCommand
    Dim sql_alumnos_titulados As String
    Dim d_table As DataTable
    Private d_adapter As SqlDataAdapter
    Dim ds2 As DataSet

    Sub Cargar_Fechas_Ocupadas()
        Dim ds As DataSet
        Try
            Me.SqlConnection1.Open()
            'sql_alumnos_titulados = ("Select * from AlumnosTitulados where Periodo_Escolar= '" & CB_Periodo.Text & "'")
            sql_alumnos_titulados = ("Select * from Registro_Clase where  Fecha_Clase >='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "' " & "AND Fecha_Clase<='" & Format(DateTimePicker2.Value.Date.ToString, "Short Date") & "' " & "Order by Nombre")

            sql_fechas_ocupadas = New SqlCommand(sql_alumnos_titulados, Me.SqlConnection1)
            sql_fechas_ocupadas.CommandType = CommandType.Text
            sql_fechas_ocupadas.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(sql_fechas_ocupadas)
            ds = New System.Data.DataSet
            d_table = New DataTable
            d_adapter.Fill(d_table)
            DataGridView1.DataSource = d_table
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub ButtonDerecho_Click(sender As Object, e As EventArgs) Handles ButtonDerecho.Click
        Call Cargar_Fechas_Ocupadas()

    End Sub
End Class