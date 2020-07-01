Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Menu_Cetia
    Public sw_inventario As String = 0
    Private Sub RegistroDeImpresionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeImpresionesToolStripMenuItem.Click
        sw_inventario = 3 'Inventario por cuenta
        Login_Impresiones.Show()
        'Impresion_Hojas.Show()

    End Sub

    Private Sub AltaDeBonoHorasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDeBonoHorasToolStripMenuItem.Click
        'Alta_Bono.Show()
        LoginForm1.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim salir As String
        salir = MsgBox("Esta seguro que desea salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Salir ?")
        If salir = vbYes Then
            End
        End If
    End Sub
    Private Sub PaqueteDeHojasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaqueteDeHojasToolStripMenuItem.Click
        sw_inventario = 1 'paquete de hojas
        Login_Impresiones.Show()
        'If Login_Impresiones.SW_USUARIO = 1 And Login_Impresiones.SW_CONTRASEÑA = 1 Then
        ' Inventario_hojas.Show()
        ' End If
    End Sub
    Private Sub RegistroDeMermasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeMermasToolStripMenuItem.Click
        sw_inventario = 2 'mermas
        Login_Impresiones.Show()
        'Login_Impresiones.Show()
        'If Login_Impresiones.SW_USUARIO = 1 And Login_Impresiones.SW_CONTRASEÑA = 1 Then
        'Registro_Mermas.Show()
        'End If
    End Sub

    Private Sub PrestamoDeSalaL2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrestamoDeSalaL2ToolStripMenuItem.Click
        Registro_Clase.Show()
    End Sub

    Private Sub AccesoASALAL1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccesoASALAL1ToolStripMenuItem.Click
        Registro_Entrada.Show()
    End Sub

    Private Sub IncidenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncidenciasToolStripMenuItem.Click
        Registro_Incidencias.Show()
    End Sub

    Private Sub FechasAgendadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechasAgendadasToolStripMenuItem.Click
        Fechas_Agendadas.Show()

    End Sub
End Class