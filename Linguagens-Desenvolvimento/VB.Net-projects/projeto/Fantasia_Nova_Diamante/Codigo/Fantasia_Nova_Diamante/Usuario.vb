Imports MySql.Data.MySqlClient
Public Class Usuario
    Dim usu, pass, permi As String
    Public Sub limpar()
        usu = ""
        pass = ""
        permi = ""
        NomeUsu_txt.Text = ""
        Senha_txt.Text = ""
        If Radio_Normal.Checked Then
            Radio_Normal.Checked = False
        ElseIf Radio_ADM.Checked Then
            Radio_ADM.Checked = False
        End If
    End Sub
    Private Sub But_Salvar_Click(sender As Object, e As EventArgs) Handles But_Salvar.Click
        If NomeUsu_txt.Text = "" Or Senha_txt.Text = "" Then

            MsgBox("Preencha os campos corretamente", MsgBoxStyle.Exclamation, "ATENÇÂO!")

            NomeUsu_txt.Clear()
            Senha_txt.Clear()

            NomeUsu_txt.Focus()

        Else
            usu = NomeUsu_txt.Text
            pass = Senha_txt.Text
            Try
                If Radio_ADM.Checked Then
                    permi = "GRANT ALL PRIVILEGES ON * . * TO  '" & usu & "'@'localhost' WITH GRANT OPTION MAX_QUERIES_PER_HOUR 0 MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0;"
                ElseIf Radio_Normal.Checked Then
                    permi = "GRANT SELECT ON * . * TO '" & usu & "'@'localhost';  GRANT UPDATE (`Quantidade`) ON `deposito`.`produto` TO '" & usu & "'@'localhost';GRANT UPDATE (`Saldo`) ON `deposito`.`cliente` TO '" & usu & "'@'localhost'; GRANT DELETE,INSERT ON `deposito`.`venda` TO '" & usu & "'@'localhost';"
                End If
                If permi = "" Then
                    MsgBox("SELECIONE O TIPO DE USUÁRIO", MsgBoxStyle.Exclamation, "ATENÇÂO!")
                Else
                    con.ConnectionString = "server=localhost;user id=" & username & "; password=" & password
                    con.Open()
                    Dim sql As String = "CREATE USER '" & usu & "'@'localhost' IDENTIFIED BY '" & pass & "'"
                    cmd.CommandText = sql
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = permi
                    cmd.ExecuteNonQuery()
                    MsgBox("CADASTRO REALIZADO COM SUCESSO!", MsgBoxStyle.Information)
                    limpar()
                End If
            Catch ex As Exception
                MsgBox("AÇÃO NÃO PERMETIDA, FAÇA LOGIN NO USUÁRIO ADMINISTRADOR", MsgBoxStyle.Critical, "ATENÇÂO!")
                limpar()
            Finally
                con.Close()
            End Try

        End If

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.Show()
        Me.Close()
    End Sub
    Private Sub But_Limpar_Click(sender As Object, e As EventArgs) Handles But_Limpar.Click
        limpar()
    End Sub

End Class