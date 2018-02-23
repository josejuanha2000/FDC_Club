Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Funciones2
    Inherits Conexion2
    Dim cmd As New SqlCommand
    Public Shared usuariotut As String
    Public Function validar(ByVal dts As Datos2) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("validar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@log", dts.fdcusername)
            cmd.Parameters.AddWithValue("@pas", dts.fdcpassword)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                'RegistroAlumnos.TBUsuario.Text = dr("CodUserName")

                Variable_Usuario.usuario = dr("CodUserName")
                Dim recibe_variable_usuario As New Alta_Bono

                'recibe_variable_usuario.Show()
                'Dim usuariotutoria As String = dr("CodUserName")
                'FRMREQMAT.TBDepto.Text = dr("Departamento")
                'FRMREQMAT.TBTitular.Text = dr("Titular")
                'FrmJefes.TBDepto.Text = dr("Departamento")
                'FrmJefes.TBTitular.Text = dr("Titular")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class
