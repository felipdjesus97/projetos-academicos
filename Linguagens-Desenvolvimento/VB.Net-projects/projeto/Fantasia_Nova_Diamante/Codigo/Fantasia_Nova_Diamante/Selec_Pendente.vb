Imports MySql.Data.MySqlClient
Public Class Selec_Pendente
    Dim VecPosi(1000) As Integer
    Public linhaPen As Integer
    Dim SaldoPendente As Double
    Dim data As String = Today
    Dim sql, val As String
    Dim Produtos_Vendidos, Itens_da_lista As String
    Dim Valor_Venda As String

    'MÉTODO PARA INSERIR OS DADOS NO BANCO
    Public Sub cadastrarVenda()
        val = "'" & Produtos_Vendidos & "','" & Valor_Venda & "','" & data & "')"
        sql = "Insert into venda(Produtos_Vendidos,Valor_Venda,Data) values (" & val

        Try
            Conectar()
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

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
                Dim sql As String = "SELECT * FROM CLIENTE WHERE Nome LIKE '%" & pesquisar.Text & "%'"
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
                linhaPen = campo(0)
                carregarImagemCLiPendente()
            Catch ex As Exception

            Finally
                con.Close()
            End Try
        End Using
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
                Dim sql As String = "SELECT * FROM CLIENTE WHERE Codigo LIKE '%" & excluir.Text & "%'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgv.DataSource = dt
                linhaPen = excluir.Text
                carregarImagemCLiPendente()
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub voltar_Click(sender As Object, e As EventArgs) Handles voltar.Click
        Compra.Show()
        Me.Close()
    End Sub
    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim temp As Integer = Integer.Parse(e.RowIndex().ToString())
        Dim a As Integer
        While a <= temp
            linhaPen = VecPosi(a)
            a += 1
        End While
        carregarImagemCLiPendente()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM cliente WHERE Codigo=" & excluir.Text & ""

                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim ds As New DataSet
                ds.Clear()
                cmd.CommandText = sql
                da.Fill(ds)
                Dim campo As DataRow
                campo = ds.Tables(0).Rows(0)
                SaldoPendente = campo(14)


                If Caixa.valor_Final > SaldoPendente Then

                    MsgBox("Saldo Insuficiente", MsgBoxStyle.Critical, "ATENÇÂO!")

                Else

                    If MessageBox.Show("Deseja confirmar esta compra pendente?", "Finalizando compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                        Itens_da_lista = Caixa.Itens_da_lista
                        Produtos_Vendidos = Itens_da_lista
                        Valor_Venda = Caixa.valor_Final.ToString("#,###.00;(#,###.00)")

                        cadastrarVenda()


                        SaldoPendente -= Caixa.valor_Final
                        Dim t As String = SaldoPendente.ToString("#,###.00;(#,###.00)")
                        sql = "UPDATE cliente SET Saldo ='" & t & "' WHERE Codigo=" & excluir.Text

                        cmd.CommandText = sql
                        cmd.ExecuteNonQuery()


                

                            sql = "SELECT * FROM controle WHERE Codigo=1"
                            Dim cmd4 As MySqlCommand = New MySqlCommand(sql, con)
                            Dim da4 As MySqlDataAdapter = New MySqlDataAdapter(cmd4)
                            Dim ds4 As New DataSet
                            ds4.Clear()
                            cmd4.CommandText = sql
                        da4.Fill(ds4)
                            Dim campo4 As DataRow
                            campo4 = ds4.Tables(0).Rows(0)
                            Cad_Estoque.valor_atual_estoque = campo4(1)
                            Cad_Estoque.valor_atual_venda = campo4(2)

                        

                        Dim a As Integer = 0
                        Dim temp As Integer
                        Dim temp2 As Double
                        Dim temp3 As Double


                        Do While (a < Caixa.posicao)

                            sql = "SELECT * FROM produto WHERE Codigo=" & Caixa.CodQnt_Compra(a) & ""

                            Dim cmd2 As MySqlCommand = New MySqlCommand(sql, con)
                            Dim da2 = New MySqlDataAdapter(cmd2)
                            Dim ds2 = New DataSet
                            ds2.Clear()
                            cmd2.CommandText = sql
                            da2.Fill(ds2)


                            campo = ds2.Tables(0).Rows(0)
                            Caixa.QntEstoque_Compra(a) = campo(2)
                            Compra.Debitar_valor_est(a) = campo(3)
                            Compra.Debitar_valor_ven(a) = campo(6)



                            temp = Caixa.QntEstoque_Compra(a) - Caixa.QntCompra(a)

                            Compra.Debitar_valor_est(a) = Compra.Debitar_valor_est(a) * Caixa.QntCompra(a)
                            temp2 = Cad_Estoque.valor_atual_estoque - Compra.Debitar_valor_est(a)

                            Compra.Debitar_valor_ven(a) = Compra.Debitar_valor_ven(a) * Caixa.QntCompra(a)
                            temp3 = Cad_Estoque.valor_atual_venda - Compra.Debitar_valor_ven(a)

                            sql = "UPDATE produto SET Quantidade ='" & temp & "' WHERE Codigo=" & Caixa.CodQnt_Compra(a) & ""

                            cmd.CommandText = sql
                            cmd.ExecuteNonQuery()

                            sql = "UPDATE CONTROLE SET estoque_val ='" & temp2 & "',venda_val ='" & temp3 & "' WHERE Codigo=1"

                            cmd.CommandText = sql
                            cmd.ExecuteNonQuery()

                            Cad_Estoque.valor_atual_estoque = temp2
                            Cad_Estoque.valor_atual_venda = temp3
                            a += 1

                        Loop

                        MessageBox.Show("Compra realizada com sucesso.", "Compra Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Caixa.PcarregaDadosProduto()
                        Caixa.Close()
                        Caixa.zeraVariaveis()
                        Caixa.Show()
                        Me.Close()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using

    End Sub
    Private Sub Selec_Pendente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PcarregaDadosCliente()
    End Sub
    Private Sub PcarregaDadosCliente()
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM CLIENTE"
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
End Class