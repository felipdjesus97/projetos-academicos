Imports MySql.Data.MySqlClient

Public Class Editar_Cliente
    Dim sql As String
    Public verAlterarimg As Integer = 0
    Dim Numero, Nome, Email, Sexo, RG, Telefone, Celular, Endereco, Complemento, CEP, Bairro, Cidade, Limite_Credito, rgAntigo As String
    Dim limiteAtual, saldo As Double
    Public Sub preenchercampos()
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM cliente WHERE Codigo=" & CodAlterarCliente & ""

                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim ds As New DataSet
                ds.Clear()
                cmd.CommandText = sql
                da.Fill(ds)
                Dim campo As DataRow
                campo = ds.Tables(0).Rows(0)
                Cod_txt.Text = campo(0)
                Nome_txt.Text = campo(1)
                Email_txt.Text = campo(2)
                Sexo_Op.Text = campo(3)
                Rg_txt.Text = campo(4)
                rgAntigo = campo(4)
                Tel_txt.Text = campo(5)
                Cel_txt.Text = campo(6)
                End_txt.Text = campo(7)
                Num_txt.Text = campo(8)
                Comp_txt.Text = campo(9)
                Cep_txt.Text = campo(10)
                Bairro_txt.Text = campo(11)
                Cidade_txt.Text = campo(12)
                Lim_txt.Text = campo(13)
                saldo = campo(14)

                limiteAtual = Lim_txt.Text
                carregarImagemEditarCliente()
            Catch ex As Exception

            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Public Sub cadastrarCLiente()
        sql = "UPDATE cliente SET Nome ='" & Nome & "',Email='" & Email & "',Sexo='" & Sexo & "',RG='" & RG & "',Telefone='" & Telefone & "',"
        sql += "Celular ='" & Celular & "',Endereco='" & Endereco & "',Numero='" & Numero & "',Complemento='" & Complemento & "',CEP='" & CEP & "',"
        sql += "Bairro='" & Bairro & "',Cidade='" & Cidade & "',Limite_Credito='" & Limite_Credito & "' WHERE Codigo=" & CodAlterarCliente

        Try
            Conectar()
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            limiteAtual = Limite_Credito - limiteAtual
            saldo = saldo + limiteAtual
            Dim temp As String = saldo.ToString("#,###.00;(#,###.00)")
            sql = "UPDATE cliente SET Saldo ='" & temp & "' WHERE Codigo=" & CodAlterarCliente
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            If verAlterarimg = 1 Then
                salvaImagemEditarCliente()
            End If
            MsgBox("ALTERAÇÃO REALIZADA COM SUCESSO!", MsgBoxStyle.Information, "OK!")
            Consul_Cliente.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Ação não permitida, faça o login no usuário administrador.", MsgBoxStyle.Critical, "ATENÇÂO!")
        Finally
            con.Close()
        End Try
        
    End Sub
    Private Sub Editar_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        preenchercampos()
    End Sub
    Private Sub But_Limpar_Click(sender As Object, e As EventArgs) Handles But_Limpar.Click
        preenchercampos()
    End Sub
    Private Sub CarregarImg_Click(sender As Object, e As EventArgs) Handles CarregarImg.Click
        Try
            VerAlterarImg = 1
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
        Dim valor As Decimal

        valor = Lim_txt.Text

        a = valor / 10
        If a = valor Then
            Lim_txt.Text = valor.ToString("#,###.00;(#,###.00)")
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
                                        If RG <> rgAntigo Then
                                            a = 1
                                        End If
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
                        End If
                    Else
                        MsgBox("Selecione o sexo do cliente.", MsgBoxStyle.Exclamation, "Erro ao Editar!")
                    End If

                Catch ex As Exception
                    MsgBox("Erro na Imagem", MsgBoxStyle.Exclamation, "ATENÇÂO!")
                End Try
            End If
        End If

    End Sub
    Private Sub Comp_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Comp_txt.KeyPress
        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            Comp_txt.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.Show()
        Me.Close()
    End Sub
End Class