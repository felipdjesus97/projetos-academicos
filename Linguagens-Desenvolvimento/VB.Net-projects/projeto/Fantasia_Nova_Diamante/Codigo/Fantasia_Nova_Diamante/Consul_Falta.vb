Imports MySql.Data.MySqlClient
Public Class Consul_Falta

    Private Sub Consul_Falta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PcarregaDadosProdutoFalta()
    End Sub

    Private Sub PcarregaDadosProdutoFalta()
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM PRODUTO WHERE QUANTIDADE < QTD_MINIMA;"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub voltar_Click(sender As Object, e As EventArgs) Handles voltar.Click
        Home.Show()
        Me.Close()
    End Sub
End Class