<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
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
        Dim Label6 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.NomeUsu_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Senha_txt = New System.Windows.Forms.TextBox()
        Me.tipoUsuario = New System.Windows.Forms.GroupBox()
        Me.Radio_ADM = New System.Windows.Forms.RadioButton()
        Me.Radio_Normal = New System.Windows.Forms.RadioButton()
        Me.But_Limpar = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.But_Salvar = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.tipoUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label6.Location = New System.Drawing.Point(92, 93)
        Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(69, 19)
        Label6.TabIndex = 138
        Label6.Text = "Usuário:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label1.Location = New System.Drawing.Point(99, 153)
        Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(62, 19)
        Label1.TabIndex = 163
        Label1.Text = "Senha:"
        '
        'NomeUsu_txt
        '
        Me.NomeUsu_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeUsu_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NomeUsu_txt.Location = New System.Drawing.Point(170, 88)
        Me.NomeUsu_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.NomeUsu_txt.Name = "NomeUsu_txt"
        Me.NomeUsu_txt.Size = New System.Drawing.Size(158, 29)
        Me.NomeUsu_txt.TabIndex = 137
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(310, 29)
        Me.Label5.TabIndex = 161
        Me.Label5.Text = "CADASTRO DE USUÁRIO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Senha_txt
        '
        Me.Senha_txt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Senha_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Senha_txt.Location = New System.Drawing.Point(170, 148)
        Me.Senha_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.Senha_txt.Name = "Senha_txt"
        Me.Senha_txt.Size = New System.Drawing.Size(158, 29)
        Me.Senha_txt.TabIndex = 162
        '
        'tipoUsuario
        '
        Me.tipoUsuario.Controls.Add(Me.Radio_ADM)
        Me.tipoUsuario.Controls.Add(Me.Radio_Normal)
        Me.tipoUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipoUsuario.Location = New System.Drawing.Point(71, 214)
        Me.tipoUsuario.Name = "tipoUsuario"
        Me.tipoUsuario.Size = New System.Drawing.Size(257, 70)
        Me.tipoUsuario.TabIndex = 164
        Me.tipoUsuario.TabStop = False
        Me.tipoUsuario.Text = "Tipo de Usuário"
        '
        'Radio_ADM
        '
        Me.Radio_ADM.AutoSize = True
        Me.Radio_ADM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Radio_ADM.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_ADM.Location = New System.Drawing.Point(115, 27)
        Me.Radio_ADM.Name = "Radio_ADM"
        Me.Radio_ADM.Size = New System.Drawing.Size(127, 24)
        Me.Radio_ADM.TabIndex = 1
        Me.Radio_ADM.TabStop = True
        Me.Radio_ADM.Text = "Administrador"
        Me.Radio_ADM.UseVisualStyleBackColor = True
        '
        'Radio_Normal
        '
        Me.Radio_Normal.AutoSize = True
        Me.Radio_Normal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Radio_Normal.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Normal.Location = New System.Drawing.Point(16, 27)
        Me.Radio_Normal.Name = "Radio_Normal"
        Me.Radio_Normal.Size = New System.Drawing.Size(84, 24)
        Me.Radio_Normal.TabIndex = 0
        Me.Radio_Normal.TabStop = True
        Me.Radio_Normal.Text = "Comum"
        Me.Radio_Normal.UseVisualStyleBackColor = True
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
        Me.But_Limpar.Location = New System.Drawing.Point(234, 313)
        Me.But_Limpar.Name = "But_Limpar"
        Me.But_Limpar.Size = New System.Drawing.Size(50, 50)
        Me.But_Limpar.TabIndex = 169
        Me.But_Limpar.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(231, 366)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 18)
        Me.Label18.TabIndex = 170
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
        Me.But_Salvar.Location = New System.Drawing.Point(157, 316)
        Me.But_Salvar.Name = "But_Salvar"
        Me.But_Salvar.Size = New System.Drawing.Size(44, 47)
        Me.But_Salvar.TabIndex = 167
        Me.But_Salvar.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(154, 366)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 18)
        Me.Label17.TabIndex = 168
        Me.Label17.Text = "Salvar"
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
        Me.Button3.Location = New System.Drawing.Point(366, 322)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 41)
        Me.Button3.TabIndex = 165
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(363, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "Voltar"
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(423, 390)
        Me.Controls.Add(Me.But_Limpar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.But_Salvar)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tipoUsuario)
        Me.Controls.Add(Me.Senha_txt)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NomeUsu_txt)
        Me.Controls.Add(Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fantasia Nova Diamante"
        Me.tipoUsuario.ResumeLayout(False)
        Me.tipoUsuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NomeUsu_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Senha_txt As System.Windows.Forms.TextBox
    Friend WithEvents tipoUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents Radio_ADM As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_Normal As System.Windows.Forms.RadioButton
    Friend WithEvents But_Limpar As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents But_Salvar As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
