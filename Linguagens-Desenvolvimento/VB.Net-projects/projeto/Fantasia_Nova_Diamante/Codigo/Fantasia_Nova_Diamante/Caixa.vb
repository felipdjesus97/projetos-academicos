Imports MySql.Data.MySqlClient
Public Class Caixa
    Dim VecPosi(1000) As Integer
    Public qtd_minima_banco As Integer
    Public posicao As Integer = 0
    Public Itens_da_lista As String
    Dim SelecinarLista As Integer = 0
    Dim vetsub_Total(100) As Double
    Public QntEstoque_Compra(100) As Double
    Public CodQnt_Compra(100) As Integer
    Public QntCompra(100) As Double
    Dim registro As String
    Dim local As String
    Public linhaCaixa As Integer = 0
    Public preco_Unitario, QntEstoque, sub_Total, qtd_Produto, valor_Final As Double
    Private Sub Caixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PcarregaDadosProduto()
        Button6.Enabled = False
    End Sub
    Public Sub PcarregaDadosProduto()
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If codigoProduto.Text = "" Then

            MessageBox.Show("Preencha o campo código corretamente.", "Erro ao localizar o produto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resetCamposCaixa()

        Else

            Using con As MySqlConnection = GetConnectionMySQL()
                Try
                    con.Open()
                    Dim sql As String = "SELECT * FROM PRODUTO WHERE Codigo=" & codigoProduto.Text & ""

                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)

                    ds.Clear()
                    cmd.CommandText = sql
                    da.Fill(ds)
                    Dim campo As DataRow
                    campo = ds.Tables(0).Rows(0)
                    nomeProduto.Text = campo(1)
                    precoUnitario.Text = campo(6)
                    fabricante.Text = campo(4)
                    QntEstoque = campo(2)
                    If codigoProduto.Text <> 0 Then
                        preco_Unitario = precoUnitario.Text
                        qtd_Produto = qtdProduto.Text

                        sub_Total = (preco_Unitario * qtd_Produto)
                        If sub_Total = 0 Then
                            subTotal.Text = "0,00"
                        Else
                            subTotal.Text = sub_Total.ToString("#,###.00;(#,###.00)")
                        End If
                    End If


                Catch ex As Exception
                    MessageBox.Show("Digite um código válido", "Erro ao localizar o produto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resetCamposCaixa()
                Finally
                    con.Close()
                End Try
            End Using
        End If



    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM PRODUTO WHERE Codigo=" & codigoProduto.Text & ""
                Dim ds As New DataSet
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable

                ds.Clear()
                cmd.CommandText = sql
                da.Fill(ds)
                Dim campo As DataRow
                campo = ds.Tables(0).Rows(0)
                qtd_minima_banco = campo(2)



                If qtd_minima_banco < Val(qtdProduto.Text) Then

                    MessageBox.Show("Produto Indisponível em estoque.", "Erro ao adicionar produto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resetCamposCaixa()

                Else




                    If subTotal.Text = "0,00" Then
                        MessageBox.Show("Digite uma quantidade para o produto.", "Erro ao adicionar produto", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        resetCamposCaixa()
                    Else

                        ListBox1.Items.Add(qtdProduto.Text & "x " & nomeProduto.Text & " R$: " & precoUnitario.Text)
                        valor_Final = valor_Final + sub_Total
                        valorFinal.Text = valor_Final.ToString("#,###.00;(#,###.00)")
                        QntCompra(posicao) = qtd_Produto
                        CodQnt_Compra(posicao) = codigoProduto.Text
                        QntEstoque_Compra(posicao) = QntEstoque
                        vetsub_Total(posicao) = sub_Total
                        posicao = posicao + 1
                        resetCamposCaixa()
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("NENHUM PRODUTO SELECIONADO", "Erro ao adicionar produto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End Using



    End Sub
    Function resetCamposCaixa()
        codigoProduto.Clear()
        subTotal.Clear()
        fabricante.Clear()
        nomeProduto.Clear()
        precoUnitario.Clear()
        qtdProduto.Value = 0

        Button6.Enabled = False
        codigoProduto.Focus()

        Return vbNull
    End Function
    Public Sub zeraVariaveis()
        preco_Unitario = 0
        sub_Total = 0
        qtd_Produto = 0
        valor_Final = 0
        posicao = 0
    End Sub
    Private Sub voltar_Click(sender As Object, e As EventArgs) Handles voltar.Click
        Home.Show()
        Me.Close()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        resetCamposCaixa()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Realmente deseja cancelar a compra?", "CAIXA FANTASIA NOVA DIAMANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbYes Then
            ListBox1.Items.Clear()
            valorFinal.Clear()
            resetCamposCaixa()
            zeraVariaveis()
        End If
    End Sub
    Private Sub codigoProduto_TextChanged(sender As Object, e As EventArgs) Handles codigoProduto.TextChanged
        Try
            linhaCaixa = codigoProduto.Text
            carregarImagemCaixa()
        Catch ex As Exception

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
                Dim sql As String = "SELECT * FROM produto WHERE Nome LIKE '%" & pesquisar.Text & "%'"
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
                linhaCaixa = campo(0)
                carregarImagemCaixa()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim temp As Integer = Integer.Parse(e.RowIndex().ToString())
        Dim a As Integer
        While a <= temp
            linhaCaixa = VecPosi(a)
            a += 1
        End While
        carregarImagemCaixa()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        sub_Total = vetsub_Total(SelecinarLista)
        valor_Final = valor_Final - sub_Total
        Dim a As Integer = SelecinarLista
        posicao = posicao - 1
        Do While (a < posicao)
            QntCompra(a) = QntCompra((a + 1))
            QntEstoque_Compra(a) = QntEstoque_Compra((a + 1))
            CodQnt_Compra(a) = CodQnt_Compra(a + 1)
            vetsub_Total(a) = vetsub_Total(a + 1)
            a += 1
        Loop
        ListBox1.Items.Remove(ListBox1.Items(SelecinarLista))
        If valor_Final = 0 Then
            valorFinal.Text = "0,00"
        Else
            valorFinal.Text = valor_Final.ToString("#,###.00;(#,###.00)")
        End If


        Button6.Enabled = False


    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button6.Enabled = True
        SelecinarLista = ListBox1.SelectedIndex
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
          If valor_Final <> 0 Then
            Compra.Show()
            Me.Enabled = False

            Dim i As Integer


            For i = 0 To ListBox1.Items.Count - 1

                Itens_da_lista = Itens_da_lista & vbLf & ListBox1.Items.Item(i)

            Next

            ListBox1.Items.Clear()
            valorFinal.Clear()
            resetCamposCaixa()
        Else
            MessageBox.Show("Adicione algum produto ao carrinho.", "ERRO AO FINALIZAR A COMPRA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class