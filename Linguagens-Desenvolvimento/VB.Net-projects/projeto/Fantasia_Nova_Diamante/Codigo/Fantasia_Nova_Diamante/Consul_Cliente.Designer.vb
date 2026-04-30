<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consul_Cliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.excluir = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnCadastrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.voltar = New System.Windows.Forms.Button()
        Me.ImgCli = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButAlterar = New System.Windows.Forms.Button()
        Me.pesquisar = New System.Windows.Forms.TextBox()
        Label6 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label6.Location = New System.Drawing.Point(25, 37)
        Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(154, 19)
        Label6.TabIndex = 133
        Label6.Text = "Código do Cliente:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.BackColor = System.Drawing.Color.Transparent
        Label11.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label11.Location = New System.Drawing.Point(41, 297)
        Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(114, 25)
        Label11.TabIndex = 145
        Label11.Text = "Pesquisar:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(789, 411)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 18)
        Me.Label16.TabIndex = 142
        Me.Label16.Text = "Voltar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 43)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "CONSULTAR CLIENTE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv
        '
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(14, 62)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(638, 223)
        Me.dgv.TabIndex = 136
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
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(279, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 33)
        Me.Button1.TabIndex = 131
        Me.Button1.Text = "Excluir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnCadastrar)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(530, 352)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(241, 77)
        Me.GroupBox2.TabIndex = 144
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cadastar Novo Cliente"
        '
        'BtnCadastrar
        '
        Me.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCadastrar.FlatAppearance.BorderSize = 2
        Me.BtnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadastrar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastrar.Location = New System.Drawing.Point(49, 30)
        Me.BtnCadastrar.Name = "BtnCadastrar"
        Me.BtnCadastrar.Size = New System.Drawing.Size(137, 32)
        Me.BtnCadastrar.TabIndex = 131
        Me.BtnCadastrar.Text = "Cadastrar"
        Me.BtnCadastrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.excluir)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 77)
        Me.GroupBox1.TabIndex = 143
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Excluir/Alterar Cliente"
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
        Me.voltar.Location = New System.Drawing.Point(792, 366)
        Me.voltar.Name = "voltar"
        Me.voltar.Size = New System.Drawing.Size(42, 41)
        Me.voltar.TabIndex = 141
        Me.ToolTip1.SetToolTip(Me.voltar, "Menu Principal")
        Me.voltar.UseVisualStyleBackColor = False
        '
        'ImgCli
        '
        Me.ImgCli.BackColor = System.Drawing.Color.White
        Me.ImgCli.ErrorImage = Nothing
        Me.ImgCli.Image = Global.Fantasia_Nova_Diamante.My.Resources.Resources.fun
        Me.ImgCli.InitialImage = Nothing
        Me.ImgCli.Location = New System.Drawing.Point(675, 62)
        Me.ImgCli.Name = "ImgCli"
        Me.ImgCli.Size = New System.Drawing.Size(159, 160)
        Me.ImgCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCli.TabIndex = 137
        Me.ImgCli.TabStop = False
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
        Me.ButAlterar.Location = New System.Drawing.Point(406, 382)
        Me.ButAlterar.Name = "ButAlterar"
        Me.ButAlterar.Size = New System.Drawing.Size(107, 33)
        Me.ButAlterar.TabIndex = 134
        Me.ButAlterar.Text = "Alterar"
        Me.ButAlterar.UseVisualStyleBackColor = True
        '
        'pesquisar
        '
        Me.pesquisar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pesquisar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pesquisar.Location = New System.Drawing.Point(159, 296)
        Me.pesquisar.Margin = New System.Windows.Forms.Padding(5)
        Me.pesquisar.Name = "pesquisar"
        Me.pesquisar.Size = New System.Drawing.Size(404, 29)
        Me.pesquisar.TabIndex = 146
        '
        'Consul_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(846, 441)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.pesquisar)
        Me.Controls.Add(Me.ButAlterar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.voltar)
        Me.Controls.Add(Me.ImgCli)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Consul_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fantasia Nova Diamante"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents excluir As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents voltar As System.Windows.Forms.Button
    Friend WithEvents ImgCli As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ButAlterar As System.Windows.Forms.Button
    Friend WithEvents BtnCadastrar As System.Windows.Forms.Button
    Friend WithEvents pesquisar As System.Windows.Forms.TextBox
End Class
