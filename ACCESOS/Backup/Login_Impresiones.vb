Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Login_Impresiones
    Private Sub Login_Impresiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
    Dim sql_login_impresiones As New SqlCommand
    Dim sqldr_login_impresiones As SqlDataReader
    Dim codigoUsuario As String
    Dim codigoContraseña As String
    Public SW_USUARIO As Integer = 0
    Public SW_CONTRASEÑA As Integer = 0
    Public USUARIO_IMPRESIONES As String
    Sub Usuario()
        'Try
        Me.SqlConnection1.Open()
        sql_login_impresiones.CommandType = CommandType.Text
        sql_login_impresiones.CommandText = ("select *  from usuarios where Usuarios.CodUserName= '" & TB_Usuario.Text & "'")
        '& "and Area= 'I''" & "'")
        sql_login_impresiones.Connection = Me.SqlConnection1
        sqldr_login_impresiones = sql_login_impresiones.ExecuteReader()
        sqldr_login_impresiones.Read()
        If sqldr_login_impresiones.HasRows = 0 Then
            MsgBox("No existe el usuario")
            SW_USUARIO = 2
            TB_Usuario.Text = ""
            TB_Usuario.Focus()
        Else
            If sqldr_login_impresiones("Area") = "I" Then
                SW_USUARIO = 1
                'Inventario_hojas.Show()
                'Else
                '   MsgBox("No existe el usuario")
                '   TB_Usuario.Focus()
            End If
        End If
        'Catch ex As Exception
        ' MsgBox(ex.ToString)
        ' End Try
        sqldr_login_impresiones.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub password()
        'Try
        Me.SqlConnection1.Open()
        sql_login_impresiones.CommandType = CommandType.Text
        sql_login_impresiones.CommandText = ("select *  from usuarios where Usuarios.CodPassword= '" & TB_Contraseña.Text & "'")
        '& "and Area= 'I''" & "'")
        sql_login_impresiones.Connection = Me.SqlConnection1
        sqldr_login_impresiones = sql_login_impresiones.ExecuteReader()
        sqldr_login_impresiones.Read()
        If sqldr_login_impresiones.HasRows = 0 Then
            MsgBox("No existe contraseña")
            TB_Contraseña.Text = ""
            TB_Contraseña.Focus()
            SW_USUARIO = 2
        Else
            If sqldr_login_impresiones("Area") = "I" Then
                SW_CONTRASEÑA = 1
                'Inventario_hojas.Show()
                'Else
                '   MsgBox("No existe el usuario")
                '   TB_Usuario.Focus()

            End If
        End If
        'Catch ex As Exception
        ' MsgBox(ex.ToString)
        ' End Try
        sqldr_login_impresiones.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub Btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Aceptar.Click
        Call Usuario()
        Call password()
        If Menu_Cetia.sw_inventario = 1 Then
            If SW_USUARIO = 1 And SW_CONTRASEÑA = 1 Then
                'TB_Contraseña.Text = ""
                'TB_Usuario.Text = ""
                Me.Hide()
                Inventario_hojas.Show()
            End If
        End If
        If Menu_Cetia.sw_inventario = 2 Then
            If SW_USUARIO = 1 And SW_CONTRASEÑA = 1 Then
                'TB_Contraseña.Text = ""
                'TB_Usuario.Text = ""
                Me.Hide()
                Registro_Mermas.Show()
            End If
        End If
        If Menu_Cetia.sw_inventario = 3 Then
            If SW_USUARIO = 1 And SW_CONTRASEÑA = 1 Then
                'TB_Contraseña.Text = ""
                'TB_Usuario.Text = ""
                USUARIO_IMPRESIONES = TB_Usuario.Text
                Me.Hide()
                'Registro_Mermas.Show()
                Impresion_Hojas.Show()
            End If
        End If
        'If SW_USUARIO = 1 And SW_CONTRASEÑA = 1 Then
        TB_Contraseña.Text = ""
        TB_Usuario.Text = ""
        ' Me.Hide()
        ' End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class