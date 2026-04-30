Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Public Class Cad_Cliente
    Dim sql, val As String
    Dim Numero, Nome, Email, Sexo, RG, Telefone, Celular, Endereco, Complemento, CEP, Bairro, Cidade, Limite_Credito, Saldo As String
    'MÉTODO PARA INSERIR OS DADOS NO BANCO
    Private Sub Comp_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Comp_txt.KeyPress
        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            Comp_txt.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub
    Public Sub cadastrarCLiente()
        val = "'" & Nome & "','" & Email & "','" & Sexo & "','" & RG & "','" & Telefone & "','" & Celular & "','" & Endereco & "','" & Numero & "','" & Complemento & "','" & CEP & "','" & Bairro & "','" & Cidade & "','" & Limite_Credito & "','" & Saldo & "')"
        sql = "Insert into cliente(Nome,Email,Sexo,RG,Telefone,Celular,Endereco,Numero,Complemento,CEP,Bairro,Cidade,Limite_Credito,Saldo) values (" & val
        Operar(sql)
        salvaImagemCliente()
        carregarCod()
    End Sub
    Public Sub Limparcampos()
        Pic_Cli_Img.Image = My.Resources.fun
        Nome_txt.Text = ""
        End_txt.Text = ""
        Email_txt.Text = ""
        Rg_txt.Text = ""
        Tel_txt.Text = ""
        Cel_txt.Text = ""
        Num_txt.Text = ""
        Comp_txt.Text = ""
        Cep_txt.Text = ""
        Bairro_txt.Text = ""
        Cidade_txt.Text = ""
        Lim_txt.Text = "0"
        Sexo_Op.Text = "Selecione"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles But_Limpar.Click
        Limparcampos()
    End Sub
    Private Sub But_Salvar_Click(sender As Object, e As EventArgs) Handles But_Salvar.Click
        Dim limite_teste As Double

        If Lim_txt.Text = "" Then
            MsgBox("Digite um limite para o cliente", MsgBoxStyle.Exclamation, "ATENÇÂO!")
            Lim_txt.Focus()
        Else

            limite_teste = Lim_txt.Text

        If limite_teste >= 1000 Then

            MsgBox("Digite um limite inferior à R$ 1000,00", MsgBoxStyle.Exclamation, "ATENÇÂO!")
            Lim_txt.Clear()
            Lim_txt.Focus()

        Else

            Try
                Sexo = Sexo_Op.Text
                If Sexo = "Masculino" Or Sexo = "Feminino" Or Sexo = "Outro" Then
                    Nome = Nome_txt.Text
                    Endereco = End_txt.Text
                    Email = Email_txt.Text
                    RG = Rg_txt.Text
                    Telefone = Tel_txt.Text
                    Celular = Cel_txt.Text
                    Numero = Num_txt.Text
                    Complemento = Comp_txt.Text
                    CEP = Cep_txt.Text
                    Bairro = Bairro_txt.Text
                    Cidade = Cidade_txt.Text
                    Dim temp As Double = Lim_txt.Text
                    Limite_Credito = temp.ToString("#,###.00;(#,###.00)")
                        Saldo = temp.ToString("#,###.00;(#,###.00)")


                        Dim i, a As Integer
                        Using con As MySqlConnection = GetConnectionMySQL()
                            Try
                                con.Open()
                                Dim sql As String = "SELECT * FROM cliente"
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
                                    Dim rgBanco = campo(4)
                                    If rgBanco = RG Then
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
                            MsgBox("Cliente Com Mesmo RG Já Cadastrado", MsgBoxStyle.Critical, "ATENÇÂO!")
                        Else
                            cadastrarCLiente()
                            Limparcampos()
                        End If
                    Else
                        MsgBox("Preencha os campos corretamente!", MsgBoxStyle.Exclamation, "ATENÇÂO!")
                    End If

            Catch ex As Exception
                MsgBox("Erro na Imagem", MsgBoxStyle.Exclamation, "ATENÇÂO!")
            End Try
            End If
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles CarregarImg.Click
        Try
            Dim dlgimage As FileDialog = New OpenFileDialog
            dlgimage.Filter = "Image File(*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"
            If (dlgimage.ShowDialog) = DialogResult.OK Then
                imgnome = dlgimage.FileName
                Dim newimg As New Bitmap(imgnome)
                Pic_Cli_Img.SizeMode = PictureBoxSizeMode.StretchImage
                Pic_Cli_Img.Image = DirectCast(newimg, Image)
            End If
            dlgimage = Nothing

        Catch ae As Exception
            imgnome = ""
            MsgBox(ae.Message.ToString)
        End Try
    End Sub
    Public Sub carregarCod()
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM cliente"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim i As Integer = 0
                Dim y As Integer = 0
                Dim z As Integer = da.Fill(dt).toString()
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
    Private Sub Cad_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarCod()
    End Sub
    Private Sub Lim_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Lim_txt.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete) Then
            Dim b As Decimal
            b = Lim_txt.Text
            If b <= 9 Then
                Lim_txt.Text = "0.00"
            End If
        End If
        Dim a As Integer
        Dim c As String = Lim_txt.Text
        If c <> "" Then
            Dim valor As Decimal = Lim_txt.Text
            a = valor / 10
            If a = valor Then
                Lim_txt.Text = valor.ToString("#,###.00;(#,###.00)")
            End If
        Else
            Lim_txt.Text = ",00"
        End If
    End Sub
    Private Sub Nome_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nome_txt.KeyPress
        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            Nome_txt.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub
    Private Sub Cidade_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cidade_txt.KeyPress
        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            Cidade_txt.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub
    Private Sub Bairro_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Bairro_txt.KeyPress
        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            Bairro_txt.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub
    Private Sub End_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles End_txt.KeyPress
        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            End_txt.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub
    Private Sub Num_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Num_txt.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub Lim_txt_TextChanged(sender As Object, e As EventArgs) Handles Lim_txt.TextChanged
        Dim c = Lim_txt.Text
        If c = "" Then
            Lim_txt.Text = "0"
        End If
    End Sub
End Class