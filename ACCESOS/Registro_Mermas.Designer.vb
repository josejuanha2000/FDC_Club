<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Mermas
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
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_Hojas_Oficio = New System.Windows.Forms.ComboBox()
        Me.CB_hojas_carta = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_Existencia_Oficio = New System.Windows.Forms.TextBox()
        Me.TB_Existencia_cta = New System.Windows.Forms.TextBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(236, 262)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(149, 33)
        Me.BtnActualizar.TabIndex = 12
        Me.BtnActualizar.Text = "Actualiar Inventario"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CB_Hojas_Oficio)
        Me.GroupBox2.Controls.Add(Me.CB_hojas_carta)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(118, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 90)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mermas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(243, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Oficio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Carta:"
        '
        'CB_Hojas_Oficio
        '
        Me.CB_Hojas_Oficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Hojas_Oficio.FormattingEnabled = True
        Me.CB_Hojas_Oficio.Location = New System.Drawing.Point(208, 53)
        Me.CB_Hojas_Oficio.Name = "CB_Hojas_Oficio"
        Me.CB_Hojas_Oficio.Size = New System.Drawing.Size(106, 28)
        Me.CB_Hojas_Oficio.TabIndex = 1
        Me.CB_Hojas_Oficio.Text = "0"
        '
        'CB_hojas_carta
        '
        Me.CB_hojas_carta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_hojas_carta.FormattingEnabled = True
        Me.CB_hojas_carta.Location = New System.Drawing.Point(30, 54)
        Me.CB_hojas_carta.Name = "CB_hojas_carta"
        Me.CB_hojas_carta.Size = New System.Drawing.Size(101, 28)
        Me.CB_hojas_carta.TabIndex = 0
        Me.CB_hojas_carta.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_Existencia_Oficio)
        Me.GroupBox1.Controls.Add(Me.TB_Existencia_cta)
        Me.GroupBox1.Location = New System.Drawing.Point(118, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 69)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Existencia:"
        '
        'TB_Existencia_Oficio
        '
        Me.TB_Existencia_Oficio.Enabled = False
        Me.TB_Existencia_Oficio.Location = New System.Drawing.Point(203, 30)
        Me.TB_Existencia_Oficio.Name = "TB_Existencia_Oficio"
        Me.TB_Existencia_Oficio.Size = New System.Drawing.Size(108, 20)
        Me.TB_Existencia_Oficio.TabIndex = 9
        '
        'TB_Existencia_cta
        '
        Me.TB_Existencia_cta.Enabled = False
        Me.TB_Existencia_cta.Location = New System.Drawing.Point(25, 30)
        Me.TB_Existencia_cta.Name = "TB_Existencia_cta"
        Me.TB_Existencia_cta.Size = New System.Drawing.Size(103, 20)
        Me.TB_Existencia_cta.TabIndex = 8
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=148.234.110.22;Initial Catalog=LIBRO_OFICIOS;User ID=sa"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Registro_Mermas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 351)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registro_Mermas"
        Me.Text = "Mermas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CB_Hojas_Oficio As System.Windows.Forms.ComboBox
    Friend WithEvents CB_hojas_carta As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_Existencia_Oficio As System.Windows.Forms.TextBox
    Friend WithEvents TB_Existencia_cta As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
End Class
