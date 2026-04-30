<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cad_Estoque
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
        Dim Label14 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim UsuárioLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.Pic_Prod_Img = New System.Windows.Forms.PictureBox()
        Me.Qnt_txt = New System.Windows.Forms.NumericUpDown()
        Me.voltar = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Cod_txt = New System.Windows.Forms.TextBox()
        Me.Val_Compra_txt = New System.Windows.Forms.TextBox()
        Me.Fabricante_txt = New System.Windows.Forms.TextBox()
        Me.Nome_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Val_Venda_txt = New System.Windows.Forms.TextBox()
        Me.Porcentagem_txt = New System.Windows.Forms.TextBox()
        Me.ButAlterar = New System.Windows.Forms.Button()
        Me.Qnt_Minima_txt = New System.Windows.Forms.NumericUpDown()
        Label14 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        UsuárioLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.Pic_Prod_Img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qnt_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qnt_Minima_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.BackColor = System.Drawing.Color.Transparent
        Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label14.Location = New System.Drawing.Point(139, 79)
        Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(71, 19)
        Label14.TabIndex = 134
        Label14.Text = "Código:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.BackColor = System.Drawing.Color.Transparent
        Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label13.Location = New System.Drawing.Point(40, 314)
        Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(171, 19)
        Label13.TabIndex = 132
        Label13.Text = "Quantidade Mínima:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.BackColor = System.Drawing.Color.Transparent
        Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label9.Location = New System.Drawing.Point(102, 155)
        Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(108, 19)
        Label9.TabIndex = 131
        Label9.Text = "Quantidade:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label4.Location = New System.Drawing.Point(113, 275)
        Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(97, 19)
        Label4.TabIndex = 129
        Label4.Text = "Fabricante:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label2.Location = New System.Drawing.Point(40, 197)
        Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(170, 19)
        Label2.TabIndex = 127
        Label2.Text = "Valor de Compra R$:"
        '
        'UsuárioLabel
        '
        UsuárioLabel.AutoSize = True
        UsuárioLabel.BackColor = System.Drawing.Color.Transparent
        UsuárioLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuárioLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        UsuárioLabel.Location = New System.Drawing.Point(61, 118)
        UsuárioLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        UsuárioLabel.Name = "UsuárioLabel"
        UsuárioLabel.Size = New System.Drawing.Size(149, 19)
        UsuárioLabel.TabIndex = 125
        UsuárioLabel.Text = "Nome do Produto:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label3.Location = New System.Drawing.Point(51, 352)
        Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(158, 19)
        Label3.TabIndex = 145
        Label3.Text = "Valor de Venda R$:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label6.Location = New System.Drawing.Point(136, 236)
        Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(73, 19)
        Label6.TabIndex = 151
        Label6.Text = "Lucro %:"
        '
        'Pic_Prod_Img
        '
        Me.Pic_Prod_Img.BackColor = System.Drawing.Color.White
        Me.Pic_Prod_Img.ErrorImage = Nothing
        Me.Pic_Prod_Img.Image = Global.Fantasia_Nova_Diamante.My.Resources.Resources.fun
        Me.Pic_Prod_Img.InitialImage = Nothing
        Me.Pic_Prod_Img.Location = New System.Drawing.Point(600, 74)
        Me.Pic_Prod_Img.Name = "Pic_Prod_Img"
        Me.Pic_Prod_Img.Size = New System.Drawing.Size(159, 160)
        Me.Pic_Prod_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Prod_Img.TabIndex = 143
        Me.Pic_Prod_Img.TabStop = False
        '
        'Qnt_txt
        '
        Me.Qnt_txt.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qnt_txt.Location = New System.Drawing.Point(219, 150)
        Me.Qnt_txt.Name = "Qnt_txt"
        Me.Qnt_txt.Size = New System.Drawing.Size(61, 29)
        Me.Qnt_txt.TabIndex = 142
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
        Me.voltar.Location = New System.Drawing.Point(758, 401)
        Me.voltar.Name = "voltar"
        Me.voltar.Size = New System.Drawing.Size(42, 41)
        Me.voltar.TabIndex = 136
        Me.ToolTip1.SetToolTip(Me.voltar, "Menu Principal")
        Me.voltar.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(755, 445)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 18)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "Voltar"
        '
        'Cod_txt
        '
        Me.Cod_txt.Enabled = False
        Me.Cod_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cod_txt.Location = New System.Drawing.Point(219, 74)
        Me.Cod_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Cod_txt.Name = "Cod_txt"
        Me.Cod_txt.Size = New System.Drawing.Size(61, 29)
        Me.Cod_txt.TabIndex = 135
        '
        'Val_Compra_txt
        '
        Me.Val_Compra_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Val_Compra_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Val_Compra_txt.Location = New System.Drawing.Point(218, 192)
        Me.Val_Compra_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Val_Compra_txt.MaxLength = 10
        Me.Val_Compra_txt.Name = "Val_Compra_txt"
        Me.Val_Compra_txt.Size = New System.Drawing.Size(101, 29)
        Me.Val_Compra_txt.TabIndex = 130
        Me.Val_Compra_txt.Text = "0"
        '
        'Fabricante_txt
        '
        Me.Fabricante_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fabricante_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Fabricante_txt.Location = New System.Drawing.Point(218, 270)
        Me.Fabricante_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Fabricante_txt.MaxLength = 25
        Me.Fabricante_txt.Name = "Fabricante_txt"
        Me.Fabricante_txt.Size = New System.Drawing.Size(246, 29)
        Me.Fabricante_txt.TabIndex = 128
        '
        'Nome_txt
        '
        Me.Nome_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Nome_txt.Location = New System.Drawing.Point(219, 113)
        Me.Nome_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Nome_txt.MaxLength = 50
        Me.Nome_txt.Name = "Nome_txt"
        Me.Nome_txt.Size = New System.Drawing.Size(302, 29)
        Me.Nome_txt.TabIndex = 126
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 43)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "CADASTRAR PRODUTO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Fantasia_Nova_Diamante.My.Resources.Resources.limpar
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(444, 392)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 140
        Me.ToolTip1.SetToolTip(Me.Button2, "Limpar")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Fantasia_Nova_Diamante.My.Resources.Resources.salvar
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(355, 394)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 47)
        Me.Button1.TabIndex = 138
        Me.ToolTip1.SetToolTip(Me.Button1, "Salvar")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(600, 240)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(159, 33)
        Me.Button4.TabIndex = 144
        Me.Button4.Text = "Carregar Imagem..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(441, 444)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 18)
        Me.Label18.TabIndex = 141
        Me.Label18.Text = "Limpar"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(352, 444)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 18)
        Me.Label17.TabIndex = 139
        Me.Label17.Text = "Salvar"
        '
        'Val_Venda_txt
        '
        Me.Val_Venda_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Val_Venda_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Val_Venda_txt.Location = New System.Drawing.Point(219, 347)
        Me.Val_Venda_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Val_Venda_txt.MaxLength = 10
        Me.Val_Venda_txt.Name = "Val_Venda_txt"
        Me.Val_Venda_txt.Size = New System.Drawing.Size(101, 29)
        Me.Val_Venda_txt.TabIndex = 146
        Me.Val_Venda_txt.Text = "0"
        '
        'Porcentagem_txt
        '
        Me.Porcentagem_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Porcentagem_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Porcentagem_txt.Location = New System.Drawing.Point(219, 231)
        Me.Porcentagem_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Porcentagem_txt.MaxLength = 3
        Me.Porcentagem_txt.Name = "Porcentagem_txt"
        Me.Porcentagem_txt.Size = New System.Drawing.Size(46, 29)
        Me.Porcentagem_txt.TabIndex = 148
        Me.Porcentagem_txt.Text = "0"
        '
        'ButAlterar
        '
        Me.ButAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButAlterar.FlatAppearance.BorderSize = 2
        Me.ButAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButAlterar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButAlterar.Location = New System.Drawing.Point(273, 232)
        Me.ButAlterar.Name = "ButAlterar"
        Me.ButAlterar.Size = New System.Drawing.Size(86, 29)
        Me.ButAlterar.TabIndex = 149
        Me.ButAlterar.Text = "Calcular"
        Me.ButAlterar.UseVisualStyleBackColor = True
        '
        'Qnt_Minima_txt
        '
        Me.Qnt_Minima_txt.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qnt_Minima_txt.Location = New System.Drawing.Point(219, 310)
        Me.Qnt_Minima_txt.Name = "Qnt_Minima_txt"
        Me.Qnt_Minima_txt.Size = New System.Drawing.Size(61, 29)
        Me.Qnt_Minima_txt.TabIndex = 150
        '
        'Cad_Estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(816, 475)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.Qnt_Minima_txt)
        Me.Controls.Add(Me.ButAlterar)
        Me.Controls.Add(Me.Porcentagem_txt)
        Me.Controls.Add(Me.Val_Venda_txt)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.Pic_Prod_Img)
        Me.Controls.Add(Me.Qnt_txt)
        Me.Controls.Add(Me.voltar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Cod_txt)
        Me.Controls.Add(Me.Val_Compra_txt)
        Me.Controls.Add(Me.Fabricante_txt)
        Me.Controls.Add(Me.Nome_txt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Label14)
        Me.Controls.Add(Label13)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label2)
        Me.Controls.Add(UsuárioLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Cad_Estoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fantasia Nova Diamante"
        CType(Me.Pic_Prod_Img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qnt_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qnt_Minima_txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pic_Prod_Img As System.Windows.Forms.PictureBox
    Friend WithEvents Qnt_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents voltar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Cod_txt As System.Windows.Forms.TextBox
    Friend WithEvents Val_Compra_txt As System.Windows.Forms.TextBox
    Friend WithEvents Fabricante_txt As System.Windows.Forms.TextBox
    Friend WithEvents Nome_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Val_Venda_txt As System.Windows.Forms.TextBox
    Friend WithEvents Porcentagem_txt As System.Windows.Forms.TextBox
    Friend WithEvents ButAlterar As System.Windows.Forms.Button
    Friend WithEvents Qnt_Minima_txt As System.Windows.Forms.NumericUpDown
End Class
