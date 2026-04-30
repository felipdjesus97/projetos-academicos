<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consul_Produto
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
        Me.components = New System.ComponentModel.Container()
        Dim Label6 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButAlterar = New System.Windows.Forms.Button()
        Me.excluir = New System.Windows.Forms.TextBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.voltar = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ImgProd = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pesquisar = New System.Windows.Forms.TextBox()
        Label6 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label6.Location = New System.Drawing.Point(22, 37)
        Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(159, 19)
        Label6.TabIndex = 133
        Label6.Text = "Código do Produto:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.BackColor = System.Drawing.Color.Transparent
        Label11.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label11.Location = New System.Drawing.Point(85, 291)
        Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(114, 25)
        Label11.TabIndex = 154
        Label11.Text = "Pesquisar:"
        AddHandler Label11.Click, AddressOf Me.Label11_Click
        '
        'dgv
        '
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(14, 59)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(705, 223)
        Me.dgv.TabIndex = 145
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCadastrar)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(521, 352)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 77)
        Me.GroupBox2.TabIndex = 152
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cadastar Novo Produto"
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCadastrar.FlatAppearance.BorderSize = 2
        Me.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.Location = New System.Drawing.Point(61, 31)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(137, 32)
        Me.btnCadastrar.TabIndex = 131
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButAlterar)
        Me.GroupBox1.Controls.Add(Me.excluir)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Me.btnExcluir)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 77)
        Me.GroupBox1.TabIndex = 151
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Excluir/Alterar Produto"
        '
        'ButAlterar
        '
        Me.ButAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButAlterar.FlatAppearance.BorderSize = 2
        Me.ButAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButAlterar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButAlterar.Location = New System.Drawing.Point(388, 30)
        Me.ButAlterar.Name = "ButAlterar"
        Me.ButAlterar.Size = New System.Drawing.Size(107, 33)
        Me.ButAlterar.TabIndex = 135
        Me.ButAlterar.Text = "Alterar"
        Me.ButAlterar.UseVisualStyleBackColor = True
        '
        'excluir
        '
        Me.excluir.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.excluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.excluir.Location = New System.Drawing.Point(189, 32)
        Me.excluir.Margin = New System.Windows.Forms.Padding(5)
        Me.excluir.Name = "excluir"
        Me.excluir.Size = New System.Drawing.Size(71, 29)
        Me.excluir.TabIndex = 132
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExcluir.FlatAppearance.BorderSize = 2
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Location = New System.Drawing.Point(275, 30)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(107, 33)
        Me.btnExcluir.TabIndex = 131
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(438, 43)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "CONSULTAR PRODUTO"
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
        Me.voltar.Location = New System.Drawing.Point(831, 366)
        Me.voltar.Name = "voltar"
        Me.voltar.Size = New System.Drawing.Size(42, 41)
        Me.voltar.TabIndex = 149
        Me.ToolTip1.SetToolTip(Me.voltar, "Menu Principal")
        Me.voltar.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(828, 410)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 18)
        Me.Label16.TabIndex = 150
        Me.Label16.Text = "Voltar"
        '
        'ImgProd
        '
        Me.ImgProd.BackColor = System.Drawing.Color.White
        Me.ImgProd.ErrorImage = Nothing
        Me.ImgProd.Image = Global.Fantasia_Nova_Diamante.My.Resources.Resources.fun
        Me.ImgProd.InitialImage = Nothing
        Me.ImgProd.Location = New System.Drawing.Point(728, 89)
        Me.ImgProd.Name = "ImgProd"
        Me.ImgProd.Size = New System.Drawing.Size(159, 160)
        Me.ImgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgProd.TabIndex = 146
        Me.ImgProd.TabStop = False
        '
        'pesquisar
        '
        Me.pesquisar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pesquisar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pesquisar.Location = New System.Drawing.Point(203, 290)
        Me.pesquisar.Margin = New System.Windows.Forms.Padding(5)
        Me.pesquisar.Name = "pesquisar"
        Me.pesquisar.Size = New System.Drawing.Size(404, 29)
        Me.pesquisar.TabIndex = 155
        '
        'Consul_Produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 441)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.pesquisar)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.voltar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ImgProd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Consul_Produto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fantasia Nova Diamante"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents excluir As System.Windows.Forms.TextBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents voltar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ImgProd As System.Windows.Forms.PictureBox
    Friend WithEvents ButAlterar As System.Windows.Forms.Button
    Friend WithEvents pesquisar As System.Windows.Forms.TextBox
End Class
