Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Public Class Cad_Estoque
    Dim sql, val As String
    Dim Nome, Val_Compra, Val_Venda, Qnt, Qnt_Min, Fab As String
    Public valor_atual_estoque, valor_atual_venda As Double
    Dim valor_ven, valor_est As Double
    'MÉTODO PARA INSERIR OS DADOS NO BANCO
    Public Sub cadastrarProduto()
        val = "'" & Nome & "','" & Qnt & "','" & Val_Compra & "','" & Fab & "','" & Qnt_Min & "','" & Val_Venda & "')"
        sql = "Insert into produto(Nome,Quantidade,Valor_Compra,Fabricante,qtd_Minima,Valor_Venda) values (" & val
        Operar(sql)
        salvaImagemProduto()
        carregarCod()
    End Sub
    Public Sub Limparcampos()
        Pic_Prod_Img.Image = My.Resources.fun
        Nome_txt.Text = ""
        Val_Compra_txt.Text = "0"
        Val_Venda_txt.Text = "0"
        Qnt_Minima_txt.Text = "0"
        Qnt_txt.Text = "0"
        Fabricante_txt.Text = ""
        Porcentagem_txt.Text = "0"
    End Sub
    Public Sub carregarCod()
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM produto"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim i As Integer = 0
                Dim y As Integer = 0
                Dim z As Integer = da.Fill(dt).ToString()
                Do While (i <= z)
                    i += 1
                Loop
                Cod_txt.Text = i
            Catch ex As Exception

            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Nome = Nome_txt.Text
            Val_Compra = Val_Compra_txt.Text
            Val_Venda = Val_Venda_txt.Text
            Qnt = Qnt_txt.Text
            Qnt_Min = Qnt_Minima_txt.Text
            Fab = Fabricante_txt.Text
            Dim i, a As Integer
            Using con As MySqlConnection = GetConnectionMySQL()
                Try
                    con.Open()
                    Dim sql As String = "SELECT * FROM produto"
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                    Dim ds As New DataSet
                    Dim dt As DataTable = New DataTable
                    ds.Clear()
                    Dim z As Integer = da.Fill(dt).ToString()
                    Do While (i <= z)
                        da.Fill(ds)
                        Dim campo As DataRow
                        campo = ds.Tables(0).Rows(i)
                        Dim nomeBanco = campo(1)
                        If nomeBanco = Nome Then
                            a = 1
                        End If
                        i += 1
                    Loop
                Catch ex As Exception

                Finally
                    con.Close()
                End Try
            End Using
            If a = 1 Then
                MsgBox("Produto Com Mesmo Nome Já Cadastrado", MsgBoxStyle.Critical, "ATENÇÂO!")
            Else
                cadastrarProduto()
                atualizarValores()
                Limparcampos()
            End If
        Catch ex As Exception
            MsgBox("Erro ao Imagem", MsgBoxStyle.Exclamation, "ATENÇÂO!")
        End Try
    End Sub
    Public Sub cadastrarValores()
        sql = "UPDATE CONTROLE SET estoque_val ='" & valor_atual_estoque & "',venda_val ='" & valor_atual_venda & "' WHERE Codigo=1"
        Try
            Conectar()
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            con.Close()
        End Try
    End Sub
    Public Sub atualizarValores()


        valor_ven = Qnt * Val_Venda
        valor_est = Qnt * Val_Compra

        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM controle WHERE Codigo=1"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim ds As New DataSet
                ds.Clear()
                cmd.CommandText = sql
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
        valor_atual_estoque += valor_est
        valor_atual_venda += valor_ven
        cadastrarValores()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limparcampos()
    End Sub
    Private Sub voltar_Click(sender As Object, e As EventArgs) Handles voltar.Click
        Home.Show()
        Me.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim dlgimage As FileDialog = New OpenFileDialog
            dlgimage.Filter = "Image File(*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"
            If (dlgimage.ShowDialog) = DialogResult.OK Then
                imgnome = dlgimage.FileName
                Dim newimg As New Bitmap(imgnome)
                Pic_Prod_Img.SizeMode = PictureBoxSizeMode.StretchImage
                Pic_Prod_Img.Image = DirectCast(newimg, Image)
            End If
            dlgimage = Nothing

        Catch ae As Exception
            imgnome = ""
            MsgBox(ae.Message.ToString)
        End Try
    End Sub
    Private Sub Cad_Estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarCod()
    End Sub
    Private Sub Nome_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nome_txt.KeyPress
        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            Nome_txt.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub
    Private Sub Val_Venda_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Val_Venda_txt.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete) Then
            Dim b As Decimal
            b = Val_Venda_txt.Text
            If b <= 9 Then
                Val_Venda_txt.Text = "0.00"
            End If
        End If
        Dim a As Integer
        Dim c As String = Val_Venda_txt.Text
        If c <> "" Then
            Dim valor As Decimal = Val_Venda_txt.Text
            a = valor / 10
            If a = valor Then
                Val_Venda_txt.Text = valor.ToString("#,###.00;(#,###.00)")
            End If
        Else
            Val_Venda_txt.Text = ",00"
        End If
    End Sub
    Private Sub Val_Compra_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Val_Compra_txt.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete) Then
            Dim b As Decimal
            b = Val_Compra_txt.Text
            If b <= 9 Then
                Val_Compra_txt.Text = "0.00"
            End If
        End If
        Dim a As Integer
        Dim c As String = Val_Compra_txt.Text
        If c <> "" Then
            Dim valor As Decimal = Val_Compra_txt.Text
            a = valor / 10
            If a = valor Then
                Val_Compra_txt.Text = valor.ToString("#,###.00;(#,###.00)")
            End If
        Else
            Val_Compra_txt.Text = ",00"
        End If
    End Sub
    Private Sub Fabricante_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Fabricante_txt.KeyPress
        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            Fabricante_txt.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub
    Private Sub Qnt_Minima_txt_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub ButAlterar_Click(sender As Object, e As EventArgs) Handles ButAlterar.Click
        Dim val1, val2, total As Double
        val1 = Val_Compra_txt.Text
        val2 = Porcentagem_txt.Text

        total = (val1 / (100 / val2))
        total += val1
        If total < 1 Then
            Val_Venda_txt.Text = "0" & total.ToString("#,###.00;(#,###.00)")
        Else
            Val_Venda_txt.Text = total.ToString("#,###.00;(#,###.00)")
        End If
    End Sub
    Private Sub Porcentagem_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Porcentagem_txt.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
            Dim c As String = Porcentagem_txt.Text
            If e.KeyChar = ControlChars.Back Then
                If c = "" Then
                    Porcentagem_txt.Text = "0"
                Else
                    Dim z As Integer = Porcentagem_txt.Text
                    If z < 10 Then
                        Porcentagem_txt.Text = "0"
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Porcentagem_txt_TextChanged(sender As Object, e As EventArgs) Handles Porcentagem_txt.TextChanged
        Dim c As String = Porcentagem_txt.Text
        If c = "" Then
            Porcentagem_txt.Text = "0"
        Else
            Dim z As Integer = Porcentagem_txt.Text
            If z >= 100 Then
                Porcentagem_txt.Text = "100"
            End If
        End If
    End Sub
    Private Sub Qnt_txt_TextChanged(sender As Object, e As EventArgs) Handles Qnt_txt.TextChanged

        Dim c As String = Qnt_txt.Text
        If c = "" Then
            Qnt_txt.Text = "0"

        End If

    End Sub
    Private Sub Qnt_Minima_txt_TextChanged(sender As Object, e As EventArgs) Handles Qnt_Minima_txt.TextChanged

        Dim c As String = Qnt_Minima_txt.Text
        If c = "" Then
            Qnt_Minima_txt.Text = "0"

        End If

    End Sub

    Private Sub Val_Compra_txt_TextChanged(sender As Object, e As EventArgs) Handles Val_Compra_txt.TextChanged
        Dim c = Val_Compra_txt.Text
        If c = "" Then
            Val_Compra_txt.Text = "0"
        End If
    End Sub

    Private Sub Val_Venda_txt_TextChanged(sender As Object, e As EventArgs) Handles Val_Venda_txt.TextChanged
        Dim c = Val_Venda_txt.Text
        If c = "" Then
            Val_Venda_txt.Text = "0"
        End If
    End Sub
End Class