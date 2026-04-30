<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caixa
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
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.qtdProduto = New System.Windows.Forms.NumericUpDown()
        Me.codigoProduto = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pesquisar = New System.Windows.Forms.TextBox()
        Me.fabricante = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.subTotal = New System.Windows.Forms.TextBox()
        Me.valorFinal = New System.Windows.Forms.TextBox()
        Me.precoUnitario = New System.Windows.Forms.TextBox()
        Me.nomeProduto = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.voltar = New System.Windows.Forms.Button()
        Me.Pic_Img_Caixa = New System.Windows.Forms.PictureBox()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        CType(Me.qtdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Img_Caixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.Transparent
        Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label7.Location = New System.Drawing.Point(320, 129)
        Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(97, 19)
        Label7.TabIndex = 151
        Label7.Text = "Fabricante:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label6.Location = New System.Drawing.Point(1, 32)
        Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(159, 19)
        Label6.TabIndex = 136
        Label6.Text = "Código do Produto:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.BackColor = System.Drawing.Color.Transparent
        Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label9.Location = New System.Drawing.Point(52, 69)
        Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(108, 19)
        Label9.TabIndex = 138
        Label9.Text = "Quantidade:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label3.Location = New System.Drawing.Point(643, 274)
        Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(112, 23)
        Label3.TabIndex = 145
        Label3.Text = "Valor Final:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label2.Location = New System.Drawing.Point(278, 168)
        Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(141, 19)
        Label2.TabIndex = 144
        Label2.Text = "Preço Unitário R$:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label4.Location = New System.Drawing.Point(314, 207)
        Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(104, 19)
        Label4.TabIndex = 146
        Label4.Text = "Sub Total R$:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label1.Location = New System.Drawing.Point(665, 22)
        Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(176, 19)
        Label1.TabIndex = 137
        Label1.Text = "Carrinho de Compras"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.BackColor = System.Drawing.Color.Transparent
        Label11.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label11.Location = New System.Drawing.Point(233, 246)
        Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(114, 25)
        Label11.TabIndex = 159
        Label11.Text = "Pesquisar:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.BackColor = System.Drawing.Color.Transparent
        Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label8.Location = New System.Drawing.Point(304, 47)
        Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(149, 19)
        Label8.TabIndex = 164
        Label8.Text = "Nome do Produto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(331, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(271, 29)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "LISTA DE PRODUTOS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(218, 609)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(230, 43)
        Me.Button5.TabIndex = 158
        Me.Button5.Text = "Confirmar Compra"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(454, 609)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(230, 43)
        Me.Button4.TabIndex = 157
        Me.Button4.Text = "Cancelar Compra"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(838, 649)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 16)
        Me.Label16.TabIndex = 156
        Me.Label16.Text = "Fechar Caixa"
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(230, 41)
        Me.Button2.TabIndex = 147
        Me.Button2.Text = "Limpar Campos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'qtdProduto
        '
        Me.qtdProduto.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtdProduto.Location = New System.Drawing.Point(165, 64)
        Me.qtdProduto.Name = "qtdProduto"
        Me.qtdProduto.Size = New System.Drawing.Size(71, 29)
        Me.qtdProduto.TabIndex = 139
        '
        'codigoProduto
        '
        Me.codigoProduto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigoProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.codigoProduto.Location = New System.Drawing.Point(165, 27)
        Me.codigoProduto.Margin = New System.Windows.Forms.Padding(5)
        Me.codigoProduto.Name = "codigoProduto"
        Me.codigoProduto.Size = New System.Drawing.Size(71, 29)
        Me.codigoProduto.TabIndex = 135
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(6, 165)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(230, 41)
        Me.Button3.TabIndex = 148
        Me.Button3.Text = "Adicionar ao Carrinho"
        Me.Button3.UseVisualStyleBackColor = True
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
        Me.Button1.Location = New System.Drawing.Point(6, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 43)
        Me.Button1.TabIndex = 134
        Me.Button1.Text = "Ver Produto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pesquisar
        '
        Me.pesquisar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pesquisar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pesquisar.Location = New System.Drawing.Point(351, 245)
        Me.pesquisar.Margin = New System.Windows.Forms.Padding(5)
        Me.pesquisar.Name = "pesquisar"
        Me.pesquisar.Size = New System.Drawing.Size(261, 29)
        Me.pesquisar.TabIndex = 161
        '
        'fabricante
        '
        Me.fabricante.Enabled = False
        Me.fabricante.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fabricante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.fabricante.Location = New System.Drawing.Point(428, 124)
        Me.fabricante.Margin = New System.Windows.Forms.Padding(5)
        Me.fabricante.Name = "fabricante"
        Me.fabricante.Size = New System.Drawing.Size(161, 29)
        Me.fabricante.TabIndex = 150
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.codigoProduto)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Label6)
        Me.GroupBox2.Controls.Add(Label9)
        Me.GroupBox2.Controls.Add(Me.qtdProduto)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 270)
        Me.GroupBox2.TabIndex = 149
        Me.GroupBox2.TabStop = False
        '
        'subTotal
        '
        Me.subTotal.Enabled = False
        Me.subTotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.subTotal.Location = New System.Drawing.Point(429, 202)
        Me.subTotal.Margin = New System.Windows.Forms.Padding(5)
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Size = New System.Drawing.Size(161, 29)
        Me.subTotal.TabIndex = 143
        '
        'valorFinal
        '
        Me.valorFinal.Enabled = False
        Me.valorFinal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorFinal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.valorFinal.Location = New System.Drawing.Point(762, 272)
        Me.valorFinal.Margin = New System.Windows.Forms.Padding(5)
        Me.valorFinal.Name = "valorFinal"
        Me.valorFinal.Size = New System.Drawing.Size(138, 29)
        Me.valorFinal.TabIndex = 142
        '
        'precoUnitario
        '
        Me.precoUnitario.Enabled = False
        Me.precoUnitario.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precoUnitario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.precoUnitario.Location = New System.Drawing.Point(429, 163)
        Me.precoUnitario.Margin = New System.Windows.Forms.Padding(5)
        Me.precoUnitario.Name = "precoUnitario"
        Me.precoUnitario.Size = New System.Drawing.Size(161, 29)
        Me.precoUnitario.TabIndex = 141
        '
        'nomeProduto
        '
        Me.nomeProduto.Enabled = False
        Me.nomeProduto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nomeProduto.Location = New System.Drawing.Point(308, 71)
        Me.nomeProduto.Margin = New System.Windows.Forms.Padding(5)
        Me.nomeProduto.Name = "nomeProduto"
        Me.nomeProduto.Size = New System.Drawing.Size(281, 29)
        Me.nomeProduto.TabIndex = 140
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(627, 51)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(274, 166)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(Me.fabricante)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.subTotal)
        Me.GroupBox1.Controls.Add(Me.valorFinal)
        Me.GroupBox1.Controls.Add(Me.precoUnitario)
        Me.GroupBox1.Controls.Add(Me.nomeProduto)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 269)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(908, 321)
        Me.GroupBox1.TabIndex = 154
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caixa"
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button6.FlatAppearance.BorderSize = 2
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(657, 223)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(232, 41)
        Me.Button6.TabIndex = 163
        Me.Button6.Text = "Remover Item"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(15, 36)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(749, 191)
        Me.dgv.TabIndex = 153
        '
        'voltar
        '
        Me.voltar.BackColor = System.Drawing.Color.Transparent
        Me.voltar.BackgroundImage = Global.Fantasia_Nova_Diamante.My.Resources.Resources.sair
        Me.voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.voltar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.voltar.FlatAppearance.BorderSize = 0
        Me.voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.voltar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.voltar.Location = New System.Drawing.Point(865, 607)
        Me.voltar.Name = "voltar"
        Me.voltar.Size = New System.Drawing.Size(42, 41)
        Me.voltar.TabIndex = 155
        Me.ToolTip1.SetToolTip(Me.voltar, "Menu Principal")
        Me.voltar.UseVisualStyleBackColor = False
        '
        'Pic_Img_Caixa
        '
        Me.Pic_Img_Caixa.BackColor = System.Drawing.Color.White
        Me.Pic_Img_Caixa.ErrorImage = Nothing
        Me.Pic_Img_Caixa.Image = Global.Fantasia_Nova_Diamante.My.Resources.Resources.fun
        Me.Pic_Img_Caixa.InitialImage = Nothing
        Me.Pic_Img_Caixa.Location = New System.Drawing.Point(770, 58)
        Me.Pic_Img_Caixa.Name = "Pic_Img_Caixa"
        Me.Pic_Img_Caixa.Size = New System.Drawing.Size(159, 160)
        Me.Pic_Img_Caixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Img_Caixa.TabIndex = 162
        Me.Pic_Img_Caixa.TabStop = False
        '
        'Caixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(934, 671)
        Me.Controls.Add(Me.Pic_Img_Caixa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.voltar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.pesquisar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Caixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fantasia Nova Diamante"
        CType(Me.qtdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Img_Caixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents voltar As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents qtdProduto As System.Windows.Forms.NumericUpDown
    Friend WithEvents codigoProduto As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pesquisar As System.Windows.Forms.TextBox
    Friend WithEvents fabricante As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents subTotal As System.Windows.Forms.TextBox
    Friend WithEvents valorFinal As System.Windows.Forms.TextBox
    Friend WithEvents precoUnitario As System.Windows.Forms.TextBox
    Friend WithEvents nomeProduto As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Pic_Img_Caixa As System.Windows.Forms.PictureBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
