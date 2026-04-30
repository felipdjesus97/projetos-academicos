<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compra
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
        Dim LabelTroco As System.Windows.Forms.Label
        Dim LabelValor As System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioPendente = New System.Windows.Forms.RadioButton()
        Me.RadioDinheiro = New System.Windows.Forms.RadioButton()
        Me.RadioDebito = New System.Windows.Forms.RadioButton()
        Me.RadioCredito = New System.Windows.Forms.RadioButton()
        Me.ButFinalizar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.valorPago = New System.Windows.Forms.TextBox()
        Me.troco = New System.Windows.Forms.TextBox()
        Me.group = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        LabelTroco = New System.Windows.Forms.Label()
        LabelValor = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.group.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTroco
        '
        LabelTroco.AutoSize = True
        LabelTroco.BackColor = System.Drawing.Color.Transparent
        LabelTroco.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelTroco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        LabelTroco.Location = New System.Drawing.Point(60, 46)
        LabelTroco.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        LabelTroco.Name = "LabelTroco"
        LabelTroco.Size = New System.Drawing.Size(77, 19)
        LabelTroco.TabIndex = 165
        LabelTroco.Text = "Troco R$:"
        '
        'LabelValor
        '
        LabelValor.AutoSize = True
        LabelValor.BackColor = System.Drawing.Color.Transparent
        LabelValor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelValor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        LabelValor.Location = New System.Drawing.Point(16, 12)
        LabelValor.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        LabelValor.Name = "LabelValor"
        LabelValor.Size = New System.Drawing.Size(121, 19)
        LabelValor.TabIndex = 164
        LabelValor.Text = "Valor Pago R$:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioPendente)
        Me.GroupBox3.Controls.Add(Me.RadioDinheiro)
        Me.GroupBox3.Controls.Add(Me.RadioDebito)
        Me.GroupBox3.Controls.Add(Me.RadioCredito)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(57, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(385, 70)
        Me.GroupBox3.TabIndex = 170
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Forma de Pagamento"
        '
        'RadioPendente
        '
        Me.RadioPendente.AutoSize = True
        Me.RadioPendente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioPendente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioPendente.Location = New System.Drawing.Point(280, 27)
        Me.RadioPendente.Name = "RadioPendente"
        Me.RadioPendente.Size = New System.Drawing.Size(99, 24)
        Me.RadioPendente.TabIndex = 3
        Me.RadioPendente.TabStop = True
        Me.RadioPendente.Text = "Pendente"
        Me.RadioPendente.UseVisualStyleBackColor = True
        '
        'RadioDinheiro
        '
        Me.RadioDinheiro.AutoSize = True
        Me.RadioDinheiro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioDinheiro.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDinheiro.Location = New System.Drawing.Point(187, 26)
        Me.RadioDinheiro.Name = "RadioDinheiro"
        Me.RadioDinheiro.Size = New System.Drawing.Size(87, 24)
        Me.RadioDinheiro.TabIndex = 2
        Me.RadioDinheiro.TabStop = True
        Me.RadioDinheiro.Text = "Dinheiro"
        Me.RadioDinheiro.UseVisualStyleBackColor = True
        '
        'RadioDebito
        '
        Me.RadioDebito.AutoSize = True
        Me.RadioDebito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioDebito.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDebito.Location = New System.Drawing.Point(99, 27)
        Me.RadioDebito.Name = "RadioDebito"
        Me.RadioDebito.Size = New System.Drawing.Size(76, 24)
        Me.RadioDebito.TabIndex = 1
        Me.RadioDebito.TabStop = True
        Me.RadioDebito.Text = "Débito"
        Me.RadioDebito.UseVisualStyleBackColor = True
        '
        'RadioCredito
        '
        Me.RadioCredito.AutoSize = True
        Me.RadioCredito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioCredito.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioCredito.Location = New System.Drawing.Point(9, 27)
        Me.RadioCredito.Name = "RadioCredito"
        Me.RadioCredito.Size = New System.Drawing.Size(82, 24)
        Me.RadioCredito.TabIndex = 0
        Me.RadioCredito.TabStop = True
        Me.RadioCredito.Text = "Crédito"
        Me.RadioCredito.UseVisualStyleBackColor = True
        '
        'ButFinalizar
        '
        Me.ButFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButFinalizar.FlatAppearance.BorderSize = 2
        Me.ButFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButFinalizar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButFinalizar.Location = New System.Drawing.Point(18, 207)
        Me.ButFinalizar.Name = "ButFinalizar"
        Me.ButFinalizar.Size = New System.Drawing.Size(230, 43)
        Me.ButFinalizar.TabIndex = 169
        Me.ButFinalizar.Text = "Finalizar Compra"
        Me.ButFinalizar.UseVisualStyleBackColor = True
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
        Me.Button4.Location = New System.Drawing.Point(254, 207)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(230, 43)
        Me.Button4.TabIndex = 168
        Me.Button4.Text = "Cancelar Compra"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'valorPago
        '
        Me.valorPago.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorPago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.valorPago.Location = New System.Drawing.Point(148, 10)
        Me.valorPago.Margin = New System.Windows.Forms.Padding(5)
        Me.valorPago.MaxLength = 8
        Me.valorPago.Name = "valorPago"
        Me.valorPago.Size = New System.Drawing.Size(111, 26)
        Me.valorPago.TabIndex = 162
        Me.valorPago.Text = "0"
        '
        'troco
        '
        Me.troco.Enabled = False
        Me.troco.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.troco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.troco.Location = New System.Drawing.Point(148, 44)
        Me.troco.Margin = New System.Windows.Forms.Padding(5)
        Me.troco.MaxLength = 8
        Me.troco.Name = "troco"
        Me.troco.Size = New System.Drawing.Size(111, 26)
        Me.troco.TabIndex = 163
        '
        'group
        '
        Me.group.Controls.Add(Me.valorPago)
        Me.group.Controls.Add(Me.troco)
        Me.group.Controls.Add(LabelTroco)
        Me.group.Controls.Add(LabelValor)
        Me.group.Location = New System.Drawing.Point(118, 107)
        Me.group.Name = "group"
        Me.group.Size = New System.Drawing.Size(267, 76)
        Me.group.TabIndex = 171
        Me.group.TabStop = False
        Me.group.Visible = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(393, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 43)
        Me.Button1.TabIndex = 172
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(505, 280)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ButFinalizar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.group)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fantasia Nova Diamante"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.group.ResumeLayout(False)
        Me.group.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioPendente As System.Windows.Forms.RadioButton
    Friend WithEvents RadioDinheiro As System.Windows.Forms.RadioButton
    Friend WithEvents RadioDebito As System.Windows.Forms.RadioButton
    Friend WithEvents RadioCredito As System.Windows.Forms.RadioButton
    Friend WithEvents ButFinalizar As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents valorPago As System.Windows.Forms.TextBox
    Friend WithEvents troco As System.Windows.Forms.TextBox
    Friend WithEvents group As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
