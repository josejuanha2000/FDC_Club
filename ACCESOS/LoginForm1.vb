Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class LoginForm1
    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Me.Close()
        Dim dts As New Datos2
        Dim func As New Funciones2
        Try
            dts.fdcusername = UsernameTextBox.Text
            dts.fdcpassword = PasswordTextBox.Text
            If func.validar(dts) = True Then
                Dim ALTA_B As New Alta_Bono
                Call Alta_Bono.Show()
                'SplashScreen1.Show()
                Me.Hide()
            Else
                MsgBox("Login failed")
                PasswordTextBox.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

   
End Class
