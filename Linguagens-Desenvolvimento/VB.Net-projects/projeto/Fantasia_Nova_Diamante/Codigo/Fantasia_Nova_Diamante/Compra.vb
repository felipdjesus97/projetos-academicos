Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO

Public Class Compra
    Dim sql, val As String
    Dim Produtos_Vendidos, Itens_da_lista As String
    Dim Valor_Venda As String
    Dim data As String = Today
    Public Debitar_valor_ven(100) As Double
    Public Debitar_valor_est(100) As Double


    'MÉTODO PARA INSERIR OS DADOS NO BANCO
    Public Sub cadastrarVenda()
        val = "'" & Produtos_Vendidos & "','" & Valor_Venda & "','" & data & "')"
        sql = "Insert into venda(Produtos_Vendidos,Valor_Venda,Data) values (" & val

        Try
            Conectar()
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            con.Close()
        End Try

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButFinalizar.Click
        If ButFinalizar.Text = "Selecionar Cliente" Then
            Selec_Pendente.Show()
            Me.Hide()
        Else

            If RadioCredito.Checked Or RadioDebito.Checked Or RadioDinheiro.Checked Or RadioPendente.Checked Then
                Dim a As Integer = 0
                Dim sql As String
                Dim temp As Integer
                Dim temp2 As Double
                Dim temp3 As Double



                Try

                    Itens_da_lista = Caixa.Itens_da_lista
                    Produtos_Vendidos = Itens_da_lista
                    Valor_Venda = Caixa.valor_Final.ToString("#,###.00;(#,###.00)")

                    cadastrarVenda()

                Catch ex As Exception

                End Try

                Using con As MySqlConnection = GetConnectionMySQL()
                    Try
                        con.Open()

                        sql = "SELECT * FROM controle WHERE Codigo=1"
                        Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                        Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                        Dim ds As New DataSet
                        ds.Clear()
                        cmd.CommandText = sql
                        da.Fill(ds)
                        Dim campo As DataRow
                        campo = ds.Tables(0).Rows(0)
                        Cad_Estoque.valor_atual_estoque = campo(1)
                        Cad_Estoque.valor_atual_venda = campo(2)

                    Catch ex As Exception

                    Finally
                        con.Close()
                    End Try
                End Using

                        Try
                            Conectar()
                            Do While (a < Caixa.posicao)


                                sql = "SELECT * FROM produto WHERE Codigo=" & Caixa.CodQnt_Compra(a) & ""

                                Dim cmd2 As MySqlCommand = New MySqlCommand(sql, con)
                                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd2)
                                Dim ds As New DataSet
                                ds.Clear()
                                cmd2.CommandText = sql
                                da.Fill(ds)

                                Dim campo As DataRow
                                campo = ds.Tables(0).Rows(0)
                                Caixa.QntEstoque_Compra(a) = campo(2)
                                Debitar_valor_est(a) = campo(3)
                                Debitar_valor_ven(a) = campo(6)


                                temp = Caixa.QntEstoque_Compra(a) - Caixa.QntCompra(a)

                                Debitar_valor_est(a) = Debitar_valor_est(a) * Caixa.QntCompra(a)
                                temp2 = Cad_Estoque.valor_atual_estoque - Debitar_valor_est(a)

                                Debitar_valor_ven(a) = Debitar_valor_ven(a) * Caixa.QntCompra(a)
                                temp3 = Cad_Estoque.valor_atual_venda - Debitar_valor_ven(a)

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
                            Caixa.Show()
                            Me.Close()
                        Catch ex As Exception
                        Finally
                            con.Close()
                        End Try
            Else
                        MsgBox("Selecione Uma Opção de Pagamento!", MsgBoxStyle.Exclamation, "ATENÇÂO!")
            End If
        End If

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Realmente deseja cancelar a compra?", "CAIXA FANTASIA NOVA DIAMANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbYes Then
            Caixa.zeraVariaveis()
            Caixa.PcarregaDadosProduto()
            Caixa.Close()
            Caixa.Show()
            Me.Close()
        End If
    End Sub
    Private Sub RadioDinheiro_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDinheiro.CheckedChanged
        ButFinalizar.Text = "Finalizar Compra"
        ButFinalizar.Enabled = False
        Button1.Visible = True
        group.Visible = True
        valorPago.Focus()
    End Sub
    Private Sub RadioDebito_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDebito.CheckedChanged
        ButFinalizar.Text = "Finalizar Compra"
        ButFinalizar.Enabled = True
        Button1.Visible = False
        group.Visible = False
    End Sub
    Private Sub RadioCredito_CheckedChanged(sender As Object, e As EventArgs) Handles RadioCredito.CheckedChanged
        Button1.Visible = False
        ButFinalizar.Enabled = True
        ButFinalizar.Text = "Finalizar Compra"
        group.Visible = False
    End Sub
    Private Sub valorPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valorPago.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete) Then
            Dim b As Decimal
            b = valorPago.Text
            If b <= 9 Then
                valorPago.Text = "0.00"
            End If
        End If
        Dim a As Integer
        Dim c As String = valorPago.Text
        If c <> "" Then
            Dim valor As Decimal = valorPago.Text
            a = valor / 10
            If a = valor Then
                valorPago.Text = valor.ToString("#,###.00;(#,###.00)")
            End If
        Else
            valorPago.Text = ",00"
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim valor_Pago, valor_Troco As Double
        valor_Pago = (valorPago.Text)

        valor_Troco = valor_Pago - Caixa.valor_Final

        If valor_Troco < 0 Then

            MsgBox("Digite um valor válido.", MsgBoxStyle.Critical)
        Else
            If valor_Troco = 0 Then
                troco.Text = "0,00"

            Else
                troco.Text = valor_Troco.ToString("#,###.00;(#,###.00)")
                ButFinalizar.Enabled = True

            End If
        End If
    End Sub
    Private Sub RadioPendente_CheckedChanged(sender As Object, e As EventArgs) Handles RadioPendente.CheckedChanged
        ButFinalizar.Text = "Selecionar Cliente"
        ButFinalizar.Enabled = True
        Button1.Visible = False
        group.Visible = False
    End Sub

    Private Sub Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RadioCredito.Checked Then
            RadioCredito.Checked = False
        ElseIf RadioDebito.Checked Then
            RadioDebito.Checked = False
        ElseIf RadioDinheiro.Checked Then
            RadioDinheiro.Checked = False
        ElseIf RadioPendente.Checked Then
            RadioPendente.Checked = False
        End If
    End Sub
End Class