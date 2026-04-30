<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim SenhaLabel As System.Windows.Forms.Label
        Dim UsuárioLabel As System.Windows.Forms.Label
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.sair = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        SenhaLabel = New System.Windows.Forms.Label()
        UsuárioLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SenhaLabel
        '
        SenhaLabel.AutoSize = True
        SenhaLabel.BackColor = System.Drawing.Color.Transparent
        SenhaLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SenhaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        SenhaLabel.Location = New System.Drawing.Point(36, 115)
        SenhaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        SenhaLabel.Name = "SenhaLabel"
        SenhaLabel.Size = New System.Drawing.Size(69, 22)
        SenhaLabel.TabIndex = 13
        SenhaLabel.Text = "Senha:"
        '
        'UsuárioLabel
        '
        UsuárioLabel.AutoSize = True
        UsuárioLabel.BackColor = System.Drawing.Color.Transparent
        UsuárioLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuárioLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        UsuárioLabel.Location = New System.Drawing.Point(26, 66)
        UsuárioLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        UsuárioLabel.Name = "UsuárioLabel"
        UsuárioLabel.Size = New System.Drawing.Size(79, 22)
        UsuárioLabel.TabIndex = 11
        UsuárioLabel.Text = "Usuário:"
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsuarioTextBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UsuarioTextBox.Location = New System.Drawing.Point(112, 66)
        Me.UsuarioTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(164, 22)
        Me.UsuarioTextBox.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.UsuarioTextBox, "Digite Nome de Usuário")
        '
        'SenhaTextBox
        '
        Me.SenhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SenhaTextBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SenhaTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SenhaTextBox.Location = New System.Drawing.Point(112, 115)
        Me.SenhaTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.SenhaTextBox.Name = "SenhaTextBox"
        Me.SenhaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaTextBox.Size = New System.Drawing.Size(164, 22)
        Me.SenhaTextBox.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.SenhaTextBox, "Digite a Senha")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CheckBox1.Location = New System.Drawing.Point(177, 145)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(99, 18)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Mostrar senha "
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UsuarioTextBox)
        Me.GroupBox1.Controls.Add(Me.SenhaTextBox)
        Me.GroupBox1.Controls.Add(SenhaLabel)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(UsuárioLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 184)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login do Usuário"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(433, 38)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "FANTASIA NOVA DIAMANTE"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Fantasia_Nova_Diamante.My.Resources.Resources.confirme
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(104, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 56)
        Me.Button1.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.Button1, "Confirmar")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'sair
        '
        Me.sair.BackColor = System.Drawing.Color.Transparent
        Me.sair.BackgroundImage = Global.Fantasia_Nova_Diamante.My.Resources.Resources.desliga
        Me.sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sair.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.sair.FlatAppearance.BorderSize = 0
        Me.sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sair.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sair.Location = New System.Drawing.Point(254, 258)
        Me.sair.Name = "sair"
        Me.sair.Size = New System.Drawing.Size(70, 56)
        Me.sair.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.sair, "Sair")
        Me.sair.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(275, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Sair"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Entrar"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(439, 340)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sair)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fantasia Nova Diamante"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SenhaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents sair As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
