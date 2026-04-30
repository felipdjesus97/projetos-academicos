Public Class Home

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles sair.Click
        If MessageBox.Show("Realmente deseja sair do sistema?", "Desconectando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cad_Cliente.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Cad_Estoque.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Consul_Cliente.Show()
        Me.Close()
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Consul_Produto.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Caixa.Show()
        Me.Close()
    End Sub

    Private Sub CadastrarNovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarNovoToolStripMenuItem.Click
        Usuario.Show()
        Me.Close()
    End Sub

    Private Sub DesenvolvedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesenvolvedoresToolStripMenuItem.Click
        Suporte.Show()
        Me.Close()
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarToolStripMenuItem.Click
        Editar_Usuario.Show()
        Me.Close()
    End Sub

    Private Sub NovoBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoBackupToolStripMenuItem.Click
        Dim caminho1 As String
        Dim saveFileDialog1 As New SaveFileDialog
        saveFileDialog1.Filter = "Ficheiros sql (*.sql)|*.sql"

        If saveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            caminho1 = saveFileDialog1.FileName

            Dim shellcomand As String
            Try
                shellcomand = "C:\Program Files (x86)\MySQL\MySQL Server 5.1\bin\mysqldump.exe --opt --password= --user=root --database deposito -r " & caminho1 & " "
                Shell(shellcomand)
                MsgBox("Backup Realizado com Sucesso.", MsgBoxStyle.Information)

            Catch ex As Exception

                MsgBox("Erro ao fazer cópia de segurança.Tente novamente.", MsgBoxStyle.Critical, "Erro")

            End Try
        Else
            MsgBox("Backup cancelado.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Consul_Falta.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Consul_pendente.show()
        Me.Close()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Historico.Show()
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Valor_atual.show()
        Me.Close()
    End Sub
End Class