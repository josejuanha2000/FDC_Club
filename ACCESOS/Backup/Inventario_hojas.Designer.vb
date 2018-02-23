<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario_hojas
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
        Me.CB_hojas_carta = New System.Windows.Forms.ComboBox
        Me.CB_Hojas_Oficio = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TB_Existencia_Oficio = New System.Windows.Forms.TextBox
        Me.TB_Existencia_cta = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.BtnActualizar = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB_hojas_carta
        '
        Me.CB_hojas_carta.FormattingEnabled = True
        Me.CB_hojas_carta.Location = New System.Drawing.Point(29, 56)
        Me.CB_hojas_carta.Name = "CB_hojas_carta"
        Me.CB_hojas_carta.Size = New System.Drawing.Size(111, 24)
        Me.CB_hojas_carta.TabIndex = 0
        Me.CB_hojas_carta.Text = "0"
        '
        'CB_Hojas_Oficio
        '
        Me.CB_Hojas_Oficio.FormattingEnabled = True
        Me.CB_Hojas_Oficio.Location = New System.Drawing.Point(207, 55)
        Me.CB_Hojas_Oficio.Name = "CB_Hojas_Oficio"
        Me.CB_Hojas_Oficio.Size = New System.Drawing.Size(119, 24)
        Me.CB_Hojas_Oficio.TabIndex = 1
        Me.CB_Hojas_Oficio.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Carta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(242, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Oficio:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_Existencia_Oficio)
        Me.GroupBox1.Controls.Add(Me.TB_Existencia_cta)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(54, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 69)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Existencia:"
        '
        'TB_Existencia_Oficio
        '
        Me.TB_Existencia_Oficio.Enabled = False
        Me.TB_Existencia_Oficio.Location = New System.Drawing.Point(203, 30)
        Me.TB_Existencia_Oficio.Name = "TB_Existencia_Oficio"
        Me.TB_Existencia_Oficio.Size = New System.Drawing.Size(119, 22)
        Me.TB_Existencia_Oficio.TabIndex = 9
        '
        'TB_Existencia_cta
        '
        Me.TB_Existencia_cta.Enabled = False
        Me.TB_Existencia_cta.Location = New System.Drawing.Point(25, 30)
        Me.TB_Existencia_cta.Name = "TB_Existencia_cta"
        Me.TB_Existencia_cta.Size = New System.Drawing.Size(111, 22)
        Me.TB_Existencia_cta.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CB_Hojas_Oficio)
        Me.GroupBox2.Controls.Add(Me.CB_hojas_carta)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(54, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 90)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Paq. de hojas"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=CETIA;Integrated Security=Tru" & _
            "e"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(414, 254)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(112, 33)
        Me.BtnActualizar.TabIndex = 9
        Me.BtnActualizar.Text = "Actualiar Inventario"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 303)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(514, 186)
        Me.DataGridView1.TabIndex = 10
        '
        'Inventario_hojas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 507)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Inventario_hojas"
        Me.Text = "Inventario_hojas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CB_hojas_carta As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Hojas_Oficio As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_Existencia_Oficio As System.Windows.Forms.TextBox
    Friend WithEvents TB_Existencia_cta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
