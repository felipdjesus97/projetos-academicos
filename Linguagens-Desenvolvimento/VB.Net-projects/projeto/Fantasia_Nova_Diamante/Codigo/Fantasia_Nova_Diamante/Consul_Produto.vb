Imports MySql.Data.MySqlClient
Public Class Consul_Produto

    Dim valor_atual_estoque, valor_atual_venda As Double
    Dim valor_ven, valor_est As Double
    Dim VecPosi(1000) As Integer
    Public linhaProd As Integer = 0
    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Cad_Estoque.Show()
        Me.Close()
    End Sub
    Private Sub Consul_Produto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PcarregaDadosProduto()
    End Sub
    Private Sub pesquisar_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub PcarregaDadosProduto()
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM PRODUTO"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim ds As New DataSet
                ds.Clear()
                cmd.CommandText = sql
                Dim cont As Integer = da.Fill(ds).ToString()
                Dim campo As DataRow
                Dim a As Integer
                Do While (a < cont)
                    campo = ds.Tables(0).Rows(a)
                    VecPosi(a) = campo(0)
                    a += 1
                Loop
                da.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Public Sub cadastrarValores()
        Dim sql As String = "UPDATE CONTROLE SET estoque_val ='" & valor_atual_estoque & "',venda_val ='" & valor_atual_venda & "' WHERE Codigo=1"
        Try
            Conectar()
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MsgBox("Você tem certeza que deseja excluir este produto?", vbYesNo, "Excluir Produto") = vbYes Then
            Using con As MySqlConnection = GetConnectionMySQL()
                Try
                    con.Open()
                    Dim sql As String = "SELECT * FROM produto WHERE Codigo=" & excluir.Text & ""
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                    Dim ds As New DataSet
                    ds.Clear()
                    da.Fill(ds)
                    Dim campo As DataRow
                    campo = ds.Tables(0).Rows(0)
                    Dim Qntdd As Integer
                    Qntdd = campo(2)
                    Dim Val_Compra As Double = campo(3)
                    Dim Val_Venda As Double = campo(6)

                    valor_ven = Qntdd * Val_Venda
                    valor_est = Qntdd * Val_Compra

                    sql = "SELECT * FROM controle WHERE Codigo=1"
                    Dim cmd2 As MySqlCommand = New MySqlCommand(sql, con)
                    Dim da2 As MySqlDataAdapter = New MySqlDataAdapter(cmd2)
                    Dim ds2 As New DataSet
                    da2.Fill(ds2)
                    campo = ds2.Tables(0).Rows(0)
                    valor_atual_estoque = campo(1)
                    valor_atual_venda = campo(2)

                    valor_atual_estoque -= valor_est
                    valor_atual_venda -= valor_ven
                    cadastrarValores()

                Catch ex As Exception
                Finally
                    con.Close()
                End Try
            End Using
            Using con As MySqlConnection = GetConnectionMySQL()
                Try
                    con.Open()
                    Dim sql As String = "DELETE FROM PRODUTO WHERE Codigo=" & excluir.Text & ""
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    dgv.DataSource = dt
                    sql = "DELETE FROM foto_produto WHERE foto_cod=" & excluir.Text & ""
                    Dim cmd2 As MySqlCommand = New MySqlCommand(sql, con)
                    Dim da2 As MySqlDataAdapter = New MySqlDataAdapter(cmd2)
                    Dim dt2 As DataTable = New DataTable
                    da2.Fill(dt2)
                    dgv.DataSource = dt2
                    PcarregaDadosProduto()
                    MsgBox("PRODUTO EXCLUIDO COM SUCESSO!", MsgBoxStyle.Information, "ATENÇÂO!")
                Catch ex As Exception
                    MsgBox("SELECIONE UM CÓDIGO EXISTENTE", MsgBoxStyle.Exclamation, "ATENÇÂO!")
                Finally
                    con.Close()
                End Try
            End Using
        Else
            excluir.Clear()
        End If
    End Sub
    Private Sub excluir_TextChanged(sender As Object, e As EventArgs) Handles excluir.TextChanged
        Dim a As String = excluir.Text
        If a = "" Then
            dgv.Enabled = True
        Else
            dgv.Enabled = False
        End If
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM PRODUTO WHERE Codigo LIKE '%" & excluir.Text & "%'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgv.DataSource = dt
                linhaProd = excluir.Text
                carregarImagemProd()
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub voltar_Click(sender As Object, e As EventArgs) Handles voltar.Click
        Home.Show()
        Me.Close()
    End Sub
    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim temp As Integer = Integer.Parse(e.RowIndex().ToString())
        Dim a As Integer
        While a <= temp
            linhaProd = VecPosi(a)
            a += 1
        End While
        carregarImagemProd()
    End Sub
    Private Sub ButAlterar_Click(sender As Object, e As EventArgs) Handles ButAlterar.Click
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM produto WHERE Codigo=" & excluir.Text & ""
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Dim z As Integer = da.Fill(dt).ToString()
                If z = 0 Then
                    MsgBox("SELECIONE UM CÓDIGO EXISTENTE", MsgBoxStyle.Exclamation, "ATENÇÂO!")
                    con.Close()
                Else
                    CodAlterarProduto = excluir.Text

                    If CodAlterarProduto <> 0 Then

                        Editar_Produto.Show()
                        Me.Close()
                    End If
                End If
            Catch ex As Exception
                MsgBox("SELECIONE UM CÓDIGO EXISTENTE", MsgBoxStyle.Exclamation, "ATENÇÂO!")
                con.Close()
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub pesquisar_TextChanged_1(sender As Object, e As EventArgs) Handles pesquisar.TextChanged
        Dim a As String = pesquisar.Text
        If a = "" Then
            dgv.Enabled = True
        Else
            dgv.Enabled = False
        End If
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM PRODUTO WHERE Nome LIKE '%" & pesquisar.Text & "%'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgv.DataSource = dt
                Dim ds As New DataSet
                ds.Clear()
                Dim cont As Integer = da.Fill(ds).ToString()
                Dim campo As DataRow
                campo = ds.Tables(0).Rows(0)
                linhaProd = campo(0)
                carregarImagemProd()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException
    End Sub

End Class