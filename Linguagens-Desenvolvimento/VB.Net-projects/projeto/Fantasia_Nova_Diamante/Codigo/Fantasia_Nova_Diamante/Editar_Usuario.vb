Imports MySql.Data.MySqlClient

Public Class Editar_Usuario
    Dim SelecinarLista As Integer = 0
    Public Sub carregarCod()
        Try
            Dim Sql As String = "SELECT * FROM mysql.user;"
            Dim cmd As MySqlCommand = New MySqlCommand(Sql, con)
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            ds.Clear()
            cmd.CommandText = Sql
            Dim cont As Integer = da.Fill(ds).ToString()
            Dim campo As DataRow
            ListBox1.Items.Clear()
            Dim a As Integer
            Do While (a < cont)
                campo = ds.Tables(0).Rows(a)
                ListBox1.Items.Add(campo(1))
                a += 1
            Loop
        Catch ex As Exception
            MsgBox("Ação não permitida, faça o login no usuário administrador.", MsgBoxStyle.Critical, "ATENÇÂO!")
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub Editar_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarCod()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ExcluirBut.Enabled = True
        SelecinarLista = ListBox1.SelectedIndex
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.Show()
        Me.Close()
    End Sub
    Private Sub ExcluirBut_Click(sender As Object, e As EventArgs) Handles ExcluirBut.Click
        Try

            Dim Sql As String = "SELECT * FROM mysql.user;"
            Dim cmd As MySqlCommand = New MySqlCommand(Sql, con)
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            ds.Clear()
            cmd.CommandText = Sql
            Dim cont As Integer = da.Fill(ds).ToString()
            Dim campo As DataRow
            campo = ds.Tables(0).Rows(SelecinarLista)
            Dim nome As String = campo(1)
            con.ConnectionString = "server=localhost;user id=" & username & "; password=" & password
            con.Open()
            Sql = "DROP USER '" & nome & "'@'localhost';"
            cmd.CommandText = Sql
            cmd.ExecuteNonQuery()
            carregarCod()
            ExcluirBut.Enabled = False
            MsgBox("Usuário excluído com sucesso!", MsgBoxStyle.Information, "ATENÇÂO!")
        Catch ex As Exception
            MsgBox("Ação não permitida, faça o login no usuário administrador.", MsgBoxStyle.Critical, "ATENÇÂO!")
        Finally
            con.Close()
        End Try
    End Sub
End Class