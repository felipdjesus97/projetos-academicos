<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label11 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComboBoxData = New System.Windows.Forms.ComboBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.voltar = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.totVendas_txt = New System.Windows.Forms.TextBox()
        Label11 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.BackColor = System.Drawing.Color.Transparent
        Label11.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label11.Location = New System.Drawing.Point(14, 73)
        Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(180, 25)
        Label11.TabIndex = 176
        Label11.Text = "Selecionar Data:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label2.Location = New System.Drawing.Point(351, 70)
        Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(278, 25)
        Label2.TabIndex = 177
        Label2.Text = "Valor Total em Vendas R$:"
        '
        'ComboBoxData
        '
        Me.ComboBoxData.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxData.FormattingEnabled = True
        Me.ComboBoxData.Items.AddRange(New Object() {""})
        Me.ComboBoxData.Location = New System.Drawing.Point(202, 69)
        Me.ComboBoxData.Name = "ComboBoxData"
        Me.ComboBoxData.Size = New System.Drawing.Size(128, 33)
        Me.ComboBoxData.TabIndex = 175
        '
        'dgv
        '
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(12, 108)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(738, 228)
        Me.dgv.TabIndex = 171
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 43)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "HISTÓRICO DE VENDAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'voltar
        '
        Me.voltar.BackColor = System.Drawing.Color.Transparent
        Me.voltar.BackgroundImage = Global.Fantasia_Nova_Diamante.My.Resources.Resources.sair_318_100261
        Me.voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.voltar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.voltar.FlatAppearance.BorderSize = 0
        Me.voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.voltar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.voltar.Location = New System.Drawing.Point(707, 346)
        Me.voltar.Name = "voltar"
        Me.voltar.Size = New System.Drawing.Size(42, 41)
        Me.voltar.TabIndex = 172
        Me.voltar.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(704, 390)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 18)
        Me.Label16.TabIndex = 173
        Me.Label16.Text = "Voltar"
        '
        'totVendas_txt
        '
        Me.totVendas_txt.Enabled = False
        Me.totVendas_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totVendas_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.totVendas_txt.Location = New System.Drawing.Point(632, 69)
        Me.totVendas_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.totVendas_txt.Name = "totVendas_txt"
        Me.totVendas_txt.Size = New System.Drawing.Size(118, 29)
        Me.totVendas_txt.TabIndex = 178
        '
        'Historico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(769, 413)
        Me.Controls.Add(Me.totVendas_txt)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.ComboBoxData)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.voltar)
        Me.Controls.Add(Me.Label16)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Historico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fantasia Nova Diamante"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxData As System.Windows.Forms.ComboBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents voltar As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents totVendas_txt As System.Windows.Forms.TextBox
End Class
