Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Alta_Bono
    Dim sqlbono_matricula As New SqlCommand
    Dim sqldrbono_matricula As SqlDataReader
    Dim SW_VALIDAR_DATOS As Integer
    Sub buscar_matricula_Bono()
        SW_VALIDAR_DATOS = 0
        'Call cargar_lisview()
        Try
            Me.SqlConnection1.Open()
            sqlbono_matricula.CommandText = CommandType.Text
            sqlbono_matricula.CommandText = ("Select * from Bono_hojas where bono_hojas.matricula= '" & TBMatricula.Text & "'")
            'sqlmatricula.CommandText = ("Select * from Alumnos where Alumnos.matricula = '" & TBMatricula.Text & "'" & "and Alumnos.Periodo_Escolar = '" & CBPeriodo.Text & "'")
            sqlbono_matricula.Connection = Me.SqlConnection1
            sqldrbono_matricula = sqlbono_matricula.ExecuteReader()
            sqldrbono_matricula.Read()
            If sqldrbono_matricula.HasRows Then
                'BTNGuardar.Enabled = True
                Me.TBNombre.Text = sqldrbono_matricula("Nombre")
                Me.CBCarrera.Text = sqldrbono_matricula("Carrera")
                Me.CBSemestre.Text = sqldrbono_matricula("Semestre")
                Me.TBTotalH.Text = sqldrbono_matricula("Resto_hojas")
                If Not IsDBNull(sqldrbono_matricula("Folio_Recibo")) Then
                    Me.TBFolio.Text = sqldrbono_matricula("Folio_Recibo")
                Else
                    Me.TBFolio.Text = ""
                End If
                'Me.TBFolio.Text = sqldrbono_matricula("Folio_Recibo")
                If sqldrbono_matricula("Resto_hojas") = 0 Then
                    'BTNGuardar.Enabled = False
                    'SW_VALIDAR_DATOS = 1
                    MsgBox("Alumno con terminación de Bono")
                    sqldrbono_matricula.Close()
                    Me.SqlConnection1.Close()
                    Exit Sub
                Else
                    If sqldrbono_matricula("Resto_hojas") <> 0 Then
                        MsgBox("ALUMNO YA TIENE BONO ASIGNADO")
                        sqldrbono_matricula.Close()
                        Me.SqlConnection1.Close()
                        Exit Sub
                    End If
                End If
            Else
                sqldrbono_matricula.Close()
                Me.SqlConnection1.Close()
                SW_VALIDAR_DATOS = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        'Call cargar_lisview()
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
            If SW_VALIDAR_DATOS = 0 Then
                TBMatricula.Focus()
            Else
                BtnGuardar.Enabled = True
                TBNombre.Enabled = True
                CBSemestre.Enabled = True
                CBCarrera.Enabled = True
                TBTotalHojas.Enabled = True
                TBTotalHoras.Enabled = True
                TBFolio.Enabled = True
                Call LIMPIAR_CAMPOS()
                TBNombre.Focus()
            End If
        End If
    End Sub
    Sub registro_alumno()
        Dim agregardatos As String
        agregardatos = MsgBox("Esta seguro de Guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        Try
            If agregardatos = vbYes Then
                Me.SqlConnection1.Open()
                Dim Ins_Hojas_Alumno As String = "INSERT INTO Bono_Hojas (Matricula,Nombre,Carrera,Semestre,Resto_Hojas,Resto_Horas,Fecha_Registro,Folio_Recibo) values(@Matricula,@Nombre,@Carrera,@Semestre,@Resto_Hojas,@Resto_Horas,@Fecha_Registro,@Folio_Recibo)"
                Dim ConexA As New SqlClient.SqlCommand(Ins_Hojas_Alumno, Me.SqlConnection1)
                ConexA.Parameters.Add(New SqlParameter("@Matricula", SqlDbType.NChar, 7)).Value = Me.TBMatricula.Text
                ConexA.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 50)).Value = Me.TBNombre.Text
                ConexA.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NChar, 1)).Value = Me.CBCarrera.Text
                ConexA.Parameters.Add(New SqlParameter("@Semestre", SqlDbType.NChar, 2)).Value = Me.CBSemestre.Text
                ConexA.Parameters.Add(New SqlParameter("@Resto_Hojas", SqlDbType.Int, 9)).Value = Me.TBTotalHojas.Text
                ConexA.Parameters.Add(New SqlParameter("@Resto_Horas", SqlDbType.Int, 9)).Value = Me.TBTotalHoras.Text
                ConexA.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimeHojas.Text
                ConexA.Parameters.Add(New SqlParameter("@Folio_Recibo", SqlDbType.NChar, 10)).Value = Me.TBFolio.Text
                'If Me.RadioButtonCarta.Checked = False Then
                ' ConexA.Parameters.Add(New SqlParameter("@Tutoria_Preventiva", SqlDbType.NChar, 1)).Value = "N"
                'Else
                'ConexA.Parameters.Add(New SqlParameter("@Tutoria_Preventiva", SqlDbType.NChar, 1)).Value = "S"
                'End If
                'ConexA.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 1)).Value = "1"
                ConexA.CommandText = Ins_Hojas_Alumno
                ConexA.ExecuteNonQuery()
                Me.SqlConnection1.Close()
                'Call ACTUALIZA_BONO_HOJAS()
                MsgBox("Datos guardados correctamente", , "Guardar")
                'Call LIMPIAR_CAMPOS()
            End If
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub LIMPIAR_CAMPOS()
        'BtnGuardar.Enabled = False
        'TBMatricula.Text = ""
        TBNombre.Text = ""
        CBCarrera.Text = ""
        CBSemestre.Text = ""
        TBTotalH.Text = 0
        TBTotalHojas.Text = 0
        TBTotalHoras.Text = 0
        TBFolio.Text = ""
        'TBHojas_Merma.Text = 0
        'TBTotal.Text = 0
        'ListViewHistorial.Items.Clear()
    End Sub
    Sub desactivar_campos()
        BtnGuardar.Enabled = False
        TBNombre.Enabled = False
        CBSemestre.Enabled = False
        CBCarrera.Enabled = False
        TBTotalHojas.Enabled = False
        TBTotalHoras.Enabled = False
        TBFolio.Enabled = False
        TBNombre.Focus()
    End Sub
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If TBTotalHojas.Text = 0 Then
            MsgBox("Asigne numero de HOJAS...", , "Hojas")
            TBTotalHojas.Focus()
            Exit Sub
        Else
            Call registro_alumno()
            Call LIMPIAR_CAMPOS()
            Call desactivar_campos()
            TBMatricula.Focus()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Alta_Bono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class