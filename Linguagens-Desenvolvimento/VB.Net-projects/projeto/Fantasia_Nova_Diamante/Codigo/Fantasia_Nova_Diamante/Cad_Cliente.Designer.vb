<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cad_Cliente
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
        Dim Label15 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim UsuárioLabel As System.Windows.Forms.Label
        Me.CarregarImg = New System.Windows.Forms.Button()
        Me.Pic_Cli_Img = New System.Windows.Forms.PictureBox()
        Me.But_Limpar = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.But_Salvar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lim_txt = New System.Windows.Forms.TextBox()
        Me.Cidade_txt = New System.Windows.Forms.TextBox()
        Me.Bairro_txt = New System.Windows.Forms.TextBox()
        Me.Comp_txt = New System.Windows.Forms.TextBox()
        Me.Num_txt = New System.Windows.Forms.TextBox()
        Me.End_txt = New System.Windows.Forms.TextBox()
        Me.Cod_txt = New System.Windows.Forms.TextBox()
        Me.Email_txt = New System.Windows.Forms.TextBox()
        Me.Nome_txt = New System.Windows.Forms.TextBox()
        Me.Sexo_Op = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cel_txt = New System.Windows.Forms.MaskedTextBox()
        Me.Tel_txt = New System.Windows.Forms.MaskedTextBox()
        Me.Rg_txt = New System.Windows.Forms.MaskedTextBox()
        Me.Cep_txt = New System.Windows.Forms.MaskedTextBox()
        Label15 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        UsuárioLabel = New System.Windows.Forms.Label()
        CType(Me.Pic_Cli_Img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.BackColor = System.Drawing.Color.Transparent
        Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label15.Location = New System.Drawing.Point(431, 328)
        Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(165, 19)
        Label15.TabIndex = 137
        Label15.Text = "Limite de Crédito R$:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.BackColor = System.Drawing.Color.Transparent
        Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label14.Location = New System.Drawing.Point(97, 89)
        Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(71, 19)
        Label14.TabIndex = 136
        Label14.Text = "Código:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.BackColor = System.Drawing.Color.Transparent
        Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label13.Location = New System.Drawing.Point(549, 211)
        Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(42, 19)
        Label13.TabIndex = 135
        Label13.Text = "CEP:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.BackColor = System.Drawing.Color.Transparent
        Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label12.Location = New System.Drawing.Point(116, 211)
        Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(50, 19)
        Label12.TabIndex = 133
        Label12.Text = "Sexo:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.BackColor = System.Drawing.Color.Transparent
        Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label11.Location = New System.Drawing.Point(110, 172)
        Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(56, 19)
        Label11.TabIndex = 132
        Label11.Text = "Email:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.BackColor = System.Drawing.Color.Transparent
        Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label10.Location = New System.Drawing.Point(97, 328)
        Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(69, 19)
        Label10.TabIndex = 131
        Label10.Text = "Celular:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.BackColor = System.Drawing.Color.Transparent
        Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label9.Location = New System.Drawing.Point(53, 289)
        Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(113, 19)
        Label9.TabIndex = 130
        Label9.Text = "Telefone Fixo:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.BackColor = System.Drawing.Color.Transparent
        Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label8.Location = New System.Drawing.Point(534, 250)
        Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(57, 19)
        Label8.TabIndex = 129
        Label8.Text = "Bairro:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.Transparent
        Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label7.Location = New System.Drawing.Point(519, 289)
        Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(72, 19)
        Label7.TabIndex = 128
        Label7.Text = "Cidade:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label6.Location = New System.Drawing.Point(515, 128)
        Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(76, 19)
        Label6.TabIndex = 127
        Label6.Text = "Número:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label5.Location = New System.Drawing.Point(465, 172)
        Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(126, 19)
        Label5.TabIndex = 126
        Label5.Text = "Complemento:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label4.Location = New System.Drawing.Point(504, 89)
        Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(87, 19)
        Label4.TabIndex = 125
        Label4.Text = "Endereço:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label3.Location = New System.Drawing.Point(131, 250)
        Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(35, 19)
        Label3.TabIndex = 124
        Label3.Text = "RG:"
        '
        'UsuárioLabel
        '
        UsuárioLabel.AutoSize = True
        UsuárioLabel.BackColor = System.Drawing.Color.Transparent
        UsuárioLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuárioLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        UsuárioLabel.Location = New System.Drawing.Point(26, 128)
        UsuárioLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        UsuárioLabel.Name = "UsuárioLabel"
        UsuárioLabel.Size = New System.Drawing.Size(142, 19)
        UsuárioLabel.TabIndex = 123
        UsuárioLabel.Text = "Nome Completo:"
        '
        'CarregarImg
        '
        Me.CarregarImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CarregarImg.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CarregarImg.FlatAppearance.BorderSize = 2
        Me.CarregarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CarregarImg.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarregarImg.Location = New System.Drawing.Point(917, 250)
        Me.CarregarImg.Name = "CarregarImg"
        Me.CarregarImg.Size = New System.Drawing.Size(159, 33)
        Me.CarregarImg.TabIndex = 158
        Me.CarregarImg.Text = "Carregar Imagem..."
        Me.CarregarImg.UseVisualStyleBackColor = True
        '
        'Pic_Cli_Img
        '
        Me.Pic_Cli_Img.BackColor = System.Drawing.Color.White
        Me.Pic_Cli_Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Cli_Img.ErrorImage = Nothing
        Me.Pic_Cli_Img.Image = Global.Fantasia_Nova_Diamante.My.Resources.Resources.fun
        Me.Pic_Cli_Img.InitialImage = Nothing
        Me.Pic_Cli_Img.Location = New System.Drawing.Point(917, 84)
        Me.Pic_Cli_Img.Name = "Pic_Cli_Img"
        Me.Pic_Cli_Img.Size = New System.Drawing.Size(159, 160)
        Me.Pic_Cli_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Cli_Img.TabIndex = 157
        Me.Pic_Cli_Img.TabStop = False
        '
        'But_Limpar
        '
        Me.But_Limpar.BackColor = System.Drawing.Color.Transparent
        Me.But_Limpar.BackgroundImage = Global.Fantasia_Nova_Diamante.My.Resources.Resources.limpar
        Me.But_Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.But_Limpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.But_Limpar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.But_Limpar.FlatAppearance.BorderSize = 0
        Me.But_Limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.But_Limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.But_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.But_Limpar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Limpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.But_Limpar.Location = New System.Drawing.Point(546, 416)
        Me.But_Limpar.Name = "But_Limpar"
        Me.But_Limpar.Size = New System.Drawing.Size(50, 50)
        Me.But_Limpar.TabIndex = 155
        Me.ToolTip1.SetToolTip(Me.But_Limpar, "Limpar")
        Me.But_Limpar.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(543, 469)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 18)
        Me.Label18.TabIndex = 156
        Me.Label18.Text = "Limpar"
        '
        'But_Salvar
        '
        Me.But_Salvar.BackColor = System.Drawing.Color.Transparent
        Me.But_Salvar.BackgroundImage = Global.Fantasia_Nova_Diamante.My.Resources.Resources.salvar
        Me.But_Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.But_Salvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.But_Salvar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.But_Salvar.FlatAppearance.BorderSize = 0
        Me.But_Salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.But_Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.But_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.But_Salvar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Salvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.But_Salvar.Location = New System.Drawing.Point(457, 418)
        Me.But_Salvar.Name = "But_Salvar"
        Me.But_Salvar.Size = New System.Drawing.Size(44, 47)
        Me.But_Salvar.TabIndex = 153
        Me.ToolTip1.SetToolTip(Me.But_Salvar, "Salvar")
        Me.But_Salvar.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.Fantasia_Nova_Diamante.My.Resources.Resources.sair_318_100261
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(1048, 424)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 41)
        Me.Button3.TabIndex = 151
        Me.ToolTip1.SetToolTip(Me.Button3, "Menu Principal")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(454, 468)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 18)
        Me.Label17.TabIndex = 154
        Me.Label17.Text = "Salvar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1045, 468)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Voltar"
        '
        'Lim_txt
        '
        Me.Lim_txt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lim_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lim_txt.Location = New System.Drawing.Point(601, 323)
        Me.Lim_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Lim_txt.MaxLength = 8
        Me.Lim_txt.Name = "Lim_txt"
        Me.Lim_txt.Size = New System.Drawing.Size(90, 26)
        Me.Lim_txt.TabIndex = 149
        Me.Lim_txt.Text = "0"
        '
        'Cidade_txt
        '
        Me.Cidade_txt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cidade_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cidade_txt.Location = New System.Drawing.Point(601, 284)
        Me.Cidade_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Cidade_txt.MaxLength = 30
        Me.Cidade_txt.Name = "Cidade_txt"
        Me.Cidade_txt.Size = New System.Drawing.Size(235, 26)
        Me.Cidade_txt.TabIndex = 148
        '
        'Bairro_txt
        '
        Me.Bairro_txt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bairro_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bairro_txt.Location = New System.Drawing.Point(601, 245)
        Me.Bairro_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Bairro_txt.MaxLength = 30
        Me.Bairro_txt.Name = "Bairro_txt"
        Me.Bairro_txt.Size = New System.Drawing.Size(235, 26)
        Me.Bairro_txt.TabIndex = 147
        '
        'Comp_txt
        '
        Me.Comp_txt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comp_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Comp_txt.Location = New System.Drawing.Point(601, 167)
        Me.Comp_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Comp_txt.MaxLength = 20
        Me.Comp_txt.Name = "Comp_txt"
        Me.Comp_txt.Size = New System.Drawing.Size(235, 26)
        Me.Comp_txt.TabIndex = 145
        '
        'Num_txt
        '
        Me.Num_txt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Num_txt.Location = New System.Drawing.Point(602, 123)
        Me.Num_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Num_txt.MaxLength = 8
        Me.Num_txt.Name = "Num_txt"
        Me.Num_txt.Size = New System.Drawing.Size(89, 26)
        Me.Num_txt.TabIndex = 144
        '
        'End_txt
        '
        Me.End_txt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.End_txt.Location = New System.Drawing.Point(601, 84)
        Me.End_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.End_txt.MaxLength = 50
        Me.End_txt.Name = "End_txt"
        Me.End_txt.Size = New System.Drawing.Size(235, 26)
        Me.End_txt.TabIndex = 142
        '
        'Cod_txt
        '
        Me.Cod_txt.Enabled = False
        Me.Cod_txt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cod_txt.Location = New System.Drawing.Point(178, 84)
        Me.Cod_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Cod_txt.Name = "Cod_txt"
        Me.Cod_txt.Size = New System.Drawing.Size(61, 26)
        Me.Cod_txt.TabIndex = 141
        '
        'Email_txt
        '
        Me.Email_txt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Email_txt.Location = New System.Drawing.Point(178, 167)
        Me.Email_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Email_txt.MaxLength = 50
        Me.Email_txt.Name = "Email_txt"
        Me.Email_txt.Size = New System.Drawing.Size(277, 26)
        Me.Email_txt.TabIndex = 139
        '
        'Nome_txt
        '
        Me.Nome_txt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Nome_txt.Location = New System.Drawing.Point(178, 123)
        Me.Nome_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Nome_txt.MaxLength = 50
        Me.Nome_txt.Name = "Nome_txt"
        Me.Nome_txt.Size = New System.Drawing.Size(279, 26)
        Me.Nome_txt.TabIndex = 138
        '
        'Sexo_Op
        '
        Me.Sexo_Op.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sexo_Op.FormattingEnabled = True
        Me.Sexo_Op.Items.AddRange(New Object() {"Feminino", "Masculino", "Outro"})
        Me.Sexo_Op.Location = New System.Drawing.Point(178, 204)
        Me.Sexo_Op.Name = "Sexo_Op"
        Me.Sexo_Op.Size = New System.Drawing.Size(124, 26)
        Me.Sexo_Op.TabIndex = 134
        Me.Sexo_Op.Text = "Selecione"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(345, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 43)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "CADASTRAR CLIENTE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cel_txt
        '
        Me.Cel_txt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cel_txt.Location = New System.Drawing.Point(178, 323)
        Me.Cel_txt.Mask = "(99) 00000-0000"
        Me.Cel_txt.Name = "Cel_txt"
        Me.Cel_txt.Size = New System.Drawing.Size(124, 26)
        Me.Cel_txt.TabIndex = 159
        '
        'Tel_txt
        '
        Me.Tel_txt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tel_txt.Location = New System.Drawing.Point(178, 284)
        Me.Tel_txt.Mask = "(99) 0000-0000"
        Me.Tel_txt.Name = "Tel_txt"
        Me.Tel_txt.Size = New System.Drawing.Size(124, 26)
        Me.Tel_txt.TabIndex = 160
        '
        'Rg_txt
        '
        Me.Rg_txt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rg_txt.Location = New System.Drawing.Point(178, 245)
        Me.Rg_txt.Mask = "00,000,999-9"
        Me.Rg_txt.Name = "Rg_txt"
        Me.Rg_txt.Size = New System.Drawing.Size(124, 26)
        Me.Rg_txt.TabIndex = 161
        '
        'Cep_txt
        '
        Me.Cep_txt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cep_txt.Location = New System.Drawing.Point(602, 204)
        Me.Cep_txt.Mask = "#####-###"
        Me.Cep_txt.Name = "Cep_txt"
        Me.Cep_txt.Size = New System.Drawing.Size(89, 26)
        Me.Cep_txt.TabIndex = 162
        '
        'Cad_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1122, 497)
        Me.Controls.Add(Me.Cep_txt)
        Me.Controls.Add(Me.Rg_txt)
        Me.Controls.Add(Me.Tel_txt)
        Me.Controls.Add(Me.Cel_txt)
        Me.Controls.Add(Me.CarregarImg)
        Me.Controls.Add(Me.Pic_Cli_Img)
        Me.Controls.Add(Me.But_Limpar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.But_Salvar)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lim_txt)
        Me.Controls.Add(Me.Cidade_txt)
        Me.Controls.Add(Me.Bairro_txt)
        Me.Controls.Add(Me.Comp_txt)
        Me.Controls.Add(Me.Num_txt)
        Me.Controls.Add(Me.End_txt)
        Me.Controls.Add(Me.Cod_txt)
        Me.Controls.Add(Me.Email_txt)
        Me.Controls.Add(Me.Nome_txt)
        Me.Controls.Add(Label15)
        Me.Controls.Add(Label14)
        Me.Controls.Add(Label13)
        Me.Controls.Add(Me.Sexo_Op)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(UsuárioLabel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Cad_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fantasia Nova Diamante"
        CType(Me.Pic_Cli_Img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CarregarImg As System.Windows.Forms.Button
    Friend WithEvents Pic_Cli_Img As System.Windows.Forms.PictureBox
    Friend WithEvents But_Limpar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents But_Salvar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lim_txt As System.Windows.Forms.TextBox
    Friend WithEvents Cidade_txt As System.Windows.Forms.TextBox
    Friend WithEvents Bairro_txt As System.Windows.Forms.TextBox
    Friend WithEvents Comp_txt As System.Windows.Forms.TextBox
    Friend WithEvents Num_txt As System.Windows.Forms.TextBox
    Friend WithEvents End_txt As System.Windows.Forms.TextBox
    Friend WithEvents Cod_txt As System.Windows.Forms.TextBox
    Friend WithEvents Email_txt As System.Windows.Forms.TextBox
    Friend WithEvents Nome_txt As System.Windows.Forms.TextBox
    Friend WithEvents Sexo_Op As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cel_txt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Tel_txt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Rg_txt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Cep_txt As System.Windows.Forms.MaskedTextBox

End Class
