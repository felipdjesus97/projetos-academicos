<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar_Produto
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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim UsuárioLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.Val_Venda_txt = New System.Windows.Forms.TextBox()
        Me.Pic_Prod_Img = New System.Windows.Forms.PictureBox()
        Me.Qnt_txt = New System.Windows.Forms.NumericUpDown()
        Me.voltar = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Cod_txt = New System.Windows.Forms.TextBox()
        Me.Val_Compra_txt = New System.Windows.Forms.TextBox()
        Me.Fabricante_txt = New System.Windows.Forms.TextBox()
        Me.Nome_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ButAlterar = New System.Windows.Forms.Button()
        Me.Porcentagem_txt = New System.Windows.Forms.TextBox()
        Me.Qnt_Minima_txt = New System.Windows.Forms.NumericUpDown()
        Label3 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        UsuárioLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.Pic_Prod_Img,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Qnt_txt,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Qnt_Minima_txt,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label3
        '
        Label3.AutoSize = true
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label3.Location = New System.Drawing.Point(27, 359)
        Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(158, 19)
        Label3.TabIndex = 191
        Label3.Text = "Valor de Venda R$:"
        '
        'Label14
        '
        Label14.AutoSize = true
        Label14.BackColor = System.Drawing.Color.Transparent
        Label14.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label14.Location = New System.Drawing.Point(114, 87)
        Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(71, 19)
        Label14.TabIndex = 180
        Label14.Text = "Código:"
        '
        'Label13
        '
        Label13.AutoSize = true
        Label13.BackColor = System.Drawing.Color.Transparent
        Label13.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label13.Location = New System.Drawing.Point(16, 321)
        Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(171, 19)
        Label13.TabIndex = 178
        Label13.Text = "Quantidade Mínima:"
        '
        'Label9
        '
        Label9.AutoSize = true
        Label9.BackColor = System.Drawing.Color.Transparent
        Label9.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label9.Location = New System.Drawing.Point(77, 163)
        Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(108, 19)
        Label9.TabIndex = 177
        Label9.Text = "Quantidade:"
        '
        'Label4
        '
        Label4.AutoSize = true
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label4.Location = New System.Drawing.Point(89, 282)
        Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(97, 19)
        Label4.TabIndex = 175
        Label4.Text = "Fabricante:"
        '
        'Label2
        '
        Label2.AutoSize = true
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label2.Location = New System.Drawing.Point(15, 205)
        Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(170, 19)
        Label2.TabIndex = 173
        Label2.Text = "Valor de Compra R$:"
        '
        'UsuárioLabel
        '
        UsuárioLabel.AutoSize = true
        UsuárioLabel.BackColor = System.Drawing.Color.Transparent
        UsuárioLabel.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        UsuárioLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        UsuárioLabel.Location = New System.Drawing.Point(36, 126)
        UsuárioLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        UsuárioLabel.Name = "UsuárioLabel"
        UsuárioLabel.Size = New System.Drawing.Size(149, 19)
        UsuárioLabel.TabIndex = 171
        UsuárioLabel.Text = "Nome do Produto:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label6.Location = New System.Drawing.Point(110, 243)
        Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(73, 19)
        Label6.TabIndex = 195
        Label6.Text = "Lucro %:"
        '
        'Val_Venda_txt
        '
        Me.Val_Venda_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Val_Venda_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Val_Venda_txt.Location = New System.Drawing.Point(195, 354)
        Me.Val_Venda_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Val_Venda_txt.MaxLength = 10
        Me.Val_Venda_txt.Name = "Val_Venda_txt"
        Me.Val_Venda_txt.Size = New System.Drawing.Size(101, 29)
        Me.Val_Venda_txt.TabIndex = 192
        Me.Val_Venda_txt.Text = "0"
        '
        'Pic_Prod_Img
        '
        Me.Pic_Prod_Img.BackColor = System.Drawing.Color.White
        Me.Pic_Prod_Img.ErrorImage = Nothing
        Me.Pic_Prod_Img.Image = Global.Fantasia_Nova_Diamante.My.Resources.Resources.fun
        Me.Pic_Prod_Img.InitialImage = Nothing
        Me.Pic_Prod_Img.Location = New System.Drawing.Point(575, 82)
        Me.Pic_Prod_Img.Name = "Pic_Prod_Img"
        Me.Pic_Prod_Img.Size = New System.Drawing.Size(159, 160)
        Me.Pic_Prod_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Prod_Img.TabIndex = 189
        Me.Pic_Prod_Img.TabStop = False
        '
        'Qnt_txt
        '
        Me.Qnt_txt.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qnt_txt.Location = New System.Drawing.Point(194, 158)
        Me.Qnt_txt.Name = "Qnt_txt"
        Me.Qnt_txt.Size = New System.Drawing.Size(61, 29)
        Me.Qnt_txt.TabIndex = 188
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
        Me.voltar.Location = New System.Drawing.Point(704, 409)
        Me.voltar.Name = "voltar"
        Me.voltar.Size = New System.Drawing.Size(42, 41)
        Me.voltar.TabIndex = 182
        Me.voltar.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(701, 453)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 18)
        Me.Label16.TabIndex = 183
        Me.Label16.Text = "Voltar"
        '
        'Cod_txt
        '
        Me.Cod_txt.Enabled = False
        Me.Cod_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cod_txt.Location = New System.Drawing.Point(194, 82)
        Me.Cod_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Cod_txt.Name = "Cod_txt"
        Me.Cod_txt.Size = New System.Drawing.Size(61, 29)
        Me.Cod_txt.TabIndex = 181
        '
        'Val_Compra_txt
        '
        Me.Val_Compra_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Val_Compra_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Val_Compra_txt.Location = New System.Drawing.Point(193, 200)
        Me.Val_Compra_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Val_Compra_txt.MaxLength = 10
        Me.Val_Compra_txt.Name = "Val_Compra_txt"
        Me.Val_Compra_txt.Size = New System.Drawing.Size(101, 29)
        Me.Val_Compra_txt.TabIndex = 176
        Me.Val_Compra_txt.Text = "0"
        '
        'Fabricante_txt
        '
        Me.Fabricante_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fabricante_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Fabricante_txt.Location = New System.Drawing.Point(194, 277)
        Me.Fabricante_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Fabricante_txt.MaxLength = 25
        Me.Fabricante_txt.Name = "Fabricante_txt"
        Me.Fabricante_txt.Size = New System.Drawing.Size(235, 29)
        Me.Fabricante_txt.TabIndex = 174
        '
        'Nome_txt
        '
        Me.Nome_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Nome_txt.Location = New System.Drawing.Point(194, 121)
        Me.Nome_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Nome_txt.MaxLength = 50
        Me.Nome_txt.Name = "Nome_txt"
        Me.Nome_txt.Size = New System.Drawing.Size(302, 29)
        Me.Nome_txt.TabIndex = 172
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 43)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "EDITAR PRODUTO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(575, 248)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(159, 33)
        Me.Button4.TabIndex = 190
        Me.Button4.Text = "Carregar Imagem..."
        Me.Button4.UseVisualStyleBackColor = True
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
        Me.Button2.Location = New System.Drawing.Point(400, 401)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 186
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(397, 453)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 18)
        Me.Label18.TabIndex = 187
        Me.Label18.Text = "Limpar"
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
        Me.Button1.Location = New System.Drawing.Point(306, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 47)
        Me.Button1.TabIndex = 184
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(275, 453)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 18)
        Me.Label17.TabIndex = 185
        Me.Label17.Text = "Salvar Edição"
        '
        'ButAlterar
        '
        Me.ButAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButAlterar.FlatAppearance.BorderSize = 2
        Me.ButAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButAlterar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButAlterar.Location = New System.Drawing.Point(247, 239)
        Me.ButAlterar.Name = "ButAlterar"
        Me.ButAlterar.Size = New System.Drawing.Size(86, 29)
        Me.ButAlterar.TabIndex = 194
        Me.ButAlterar.Text = "Calcular"
        Me.ButAlterar.UseVisualStyleBackColor = true
        '
        'Porcentagem_txt
        '
        Me.Porcentagem_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Porcentagem_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Porcentagem_txt.Location = New System.Drawing.Point(193, 238)
        Me.Porcentagem_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Porcentagem_txt.MaxLength = 3
        Me.Porcentagem_txt.Name = "Porcentagem_txt"
        Me.Porcentagem_txt.Size = New System.Drawing.Size(46, 29)
        Me.Porcentagem_txt.TabIndex = 193
        Me.Porcentagem_txt.Text = "0"
        '
        'Qnt_Minima_txt
        '
        Me.Qnt_Minima_txt.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Qnt_Minima_txt.Location = New System.Drawing.Point(195, 316)
        Me.Qnt_Minima_txt.Name = "Qnt_Minima_txt"
        Me.Qnt_Minima_txt.Size = New System.Drawing.Size(61, 29)
        Me.Qnt_Minima_txt.TabIndex = 196
        '
        'Editar_Produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(816, 475)
        Me.Controls.Add(Me.Qnt_Minima_txt)
        Me.Controls.Add(Label6)
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
        Me.Name = "Editar_Produto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fantasia Nova Diamante"
        CType(Me.Pic_Prod_Img,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Qnt_txt,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Qnt_Minima_txt,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Val_Venda_txt As System.Windows.Forms.TextBox
    Friend WithEvents Pic_Prod_Img As System.Windows.Forms.PictureBox
    Friend WithEvents Qnt_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents voltar As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Cod_txt As System.Windows.Forms.TextBox
    Friend WithEvents Val_Compra_txt As System.Windows.Forms.TextBox
    Friend WithEvents Fabricante_txt As System.Windows.Forms.TextBox
    Friend WithEvents Nome_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ButAlterar As System.Windows.Forms.Button
    Friend WithEvents Porcentagem_txt As System.Windows.Forms.TextBox
    Friend WithEvents Qnt_Minima_txt As System.Windows.Forms.NumericUpDown
End Class
