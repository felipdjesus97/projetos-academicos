Imports MySql.Data.MySqlClient
Public Class Valor_atual
    Dim valor_atual_estoque, valor_atual_venda, total As Double
    Private Sub voltar_Click(sender As Object, e As EventArgs) Handles voltar.Click
        Home.Show()
        Me.Close()
    End Sub
    Private Sub Valor_atual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM controle WHERE Codigo=1"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim ds As New DataSet
                ds.Clear()
                da.Fill(ds)
                Dim campo As DataRow
                campo = ds.Tables(0).Rows(0)
                valor_atual_estoque = campo(1)
                valor_atual_venda = campo(2)

            Catch ex As Exception

            Finally
                con.Close()
            End Try
        End Using
        total = valor_atual_venda - valor_atual_estoque
        Estoque.Text = valor_atual_estoque.ToString("#,###.00;(#,###.00)")
        Venda.Text = valor_atual_venda.ToString("#,###.00;(#,###.00)")
        total_txt.Text = total.ToString("#,###.00;(#,###.00)")

    End Sub
End Class