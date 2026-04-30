Public Class Login
    Dim n As String
    Public Sub entrar()
        username = UsuarioTextBox.Text
        password = SenhaTextBox.Text
        Try
            con.ConnectionString = "server=localhost;user id=" & username & "; password=" & password & ";database=DEPOSITO"
            con.Open()
            MsgBox("Seja bem vindo!", MsgBoxStyle.Information, "Conectado!")
            Home.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Uuário ou senha incorretos. Tente novamente.", MsgBoxStyle.Critical, "ATENÇÂO!")
            UsuarioTextBox.Clear()
            SenhaTextBox.Clear()

            UsuarioTextBox.Focus()
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub sair_Click(sender As Object, e As EventArgs) Handles sair.Click
        If MessageBox.Show("Realmente deseja encerrar o sistema?", "Encerrando o sistema...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Application.Exit()
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            SenhaTextBox.PasswordChar = n
        Else
            SenhaTextBox.PasswordChar = "*"
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        entrar()
    End Sub
    Private Sub UsuarioTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsuarioTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            entrar()
        End If
    End Sub
    Private Sub SenhaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SenhaTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            entrar()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsuarioTextBox.Focus()
    End Sub
End Class
