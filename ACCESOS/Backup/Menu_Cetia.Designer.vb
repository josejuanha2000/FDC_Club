<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Cetia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ImpresionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistroDeImpresionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDeBonoHorasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImpresionesXFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InventarioHojasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PaqueteDeHojasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistroDeMermasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImpresionesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(561, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImpresionesToolStripMenuItem
        '
        Me.ImpresionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDeImpresionesToolStripMenuItem, Me.AltaDeBonoHorasToolStripMenuItem, Me.ImpresionesXFechaToolStripMenuItem, Me.InventarioHojasToolStripMenuItem})
        Me.ImpresionesToolStripMenuItem.Name = "ImpresionesToolStripMenuItem"
        Me.ImpresionesToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ImpresionesToolStripMenuItem.Text = "Impresiones"
        '
        'RegistroDeImpresionesToolStripMenuItem
        '
        Me.RegistroDeImpresionesToolStripMenuItem.Name = "RegistroDeImpresionesToolStripMenuItem"
        Me.RegistroDeImpresionesToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.RegistroDeImpresionesToolStripMenuItem.Text = "Registro de Impresiones"
        '
        'AltaDeBonoHorasToolStripMenuItem
        '
        Me.AltaDeBonoHorasToolStripMenuItem.Name = "AltaDeBonoHorasToolStripMenuItem"
        Me.AltaDeBonoHorasToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AltaDeBonoHorasToolStripMenuItem.Text = "Alta de Bono/Horas"
        '
        'ImpresionesXFechaToolStripMenuItem
        '
        Me.ImpresionesXFechaToolStripMenuItem.Name = "ImpresionesXFechaToolStripMenuItem"
        Me.ImpresionesXFechaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ImpresionesXFechaToolStripMenuItem.Text = "Impresiones x Fecha"
        '
        'InventarioHojasToolStripMenuItem
        '
        Me.InventarioHojasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaqueteDeHojasToolStripMenuItem, Me.RegistroDeMermasToolStripMenuItem})
        Me.InventarioHojasToolStripMenuItem.Name = "InventarioHojasToolStripMenuItem"
        Me.InventarioHojasToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.InventarioHojasToolStripMenuItem.Text = "Inventario"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ACCESOS.My.Resources.Resources.cetia
        Me.PictureBox1.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(551, 415)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PaqueteDeHojasToolStripMenuItem
        '
        Me.PaqueteDeHojasToolStripMenuItem.Name = "PaqueteDeHojasToolStripMenuItem"
        Me.PaqueteDeHojasToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.PaqueteDeHojasToolStripMenuItem.Text = "Paquete de Hojas"
        '
        'RegistroDeMermasToolStripMenuItem
        '
        Me.RegistroDeMermasToolStripMenuItem.Name = "RegistroDeMermasToolStripMenuItem"
        Me.RegistroDeMermasToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.RegistroDeMermasToolStripMenuItem.Text = "Registro de Mermas"
        '
        'Menu_Cetia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 451)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_Cetia"
        Me.Text = "CETIA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ImpresionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeImpresionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeBonoHorasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpresionesXFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioHojasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaqueteDeHojasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeMermasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
