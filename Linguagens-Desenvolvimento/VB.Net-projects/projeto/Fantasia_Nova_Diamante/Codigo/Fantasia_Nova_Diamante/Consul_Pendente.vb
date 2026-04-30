Imports MySql.Data.MySqlClient
Public Class Consul_Pendente
    Dim saldo As Double
    Private Sub Consul_Pendente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PcarregaDadosClientePendente()
    End Sub
    Public Sub recarregarQuitar()
        Using con As MySqlConnection = GetConnectionMySQL()
            If consultar.Text = "" Then
                TextBox1.Text = "0,00"
                PcarregaDadosClientePendente()
            Else

                Try
                    con.Open()
                    Dim sql As String = "SELECT * FROM CLIENTE WHERE Codigo LIKE '%" & consultar.Text & "%'"

                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                    Dim ds As New DataSet
                    Dim dt As DataTable = New DataTable
                    ds.Clear()
                    da.Fill(ds)
                    cmd.CommandText = sql
                    da.Fill(dt)
                    dgv.DataSource = dt
                    Dim campo As DataRow
                    campo = ds.Tables(0).Rows(0)
                    Dim saldoo As Double = campo(14)
                    Dim limite As Double = campo(13)

                    Dim total As Double = limite - saldoo
                    If total <= 0 Then
                        TextBox1.Text = "0,00"
                        PcarregaDadosClientePendente()
                    Else
                        TextBox1.Text = total.ToString("#,###.00;(#,###.00)")
                    End If
                Catch ex As Exception
                    TextBox1.Text = "0,00"
                Finally
                    con.Close()
                End Try
            End If
        End Using
    End Sub
    Private Sub PcarregaDadosClientePendente()
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM CLIENTE WHERE Limite_Credito <> Saldo "
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If MsgBox("Você tem certeza que deseja quitar a divida?", vbYesNo, "Quitar Pendente") = vbYes Then

                Dim quitar As Double
                quitar = QuitarTxt.Text
                If quitar = 0 Then
                    MsgBox("Digite Valor Da Divida A Ser Pago", MsgBoxStyle.Exclamation, "ATENÇÂO!")
                ElseIf quitar > TextBox1.Text Then
                    MsgBox("Valor A Ser Pago Superior A Divida", MsgBoxStyle.Exclamation, "ATENÇÂO!")
                Else
                    Using con As MySqlConnection = GetConnectionMySQL()
                        Try
                            con.Open()
                            Dim sql As String = "SELECT * FROM cliente WHERE Codigo=" & consultar.Text & ""

                            Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                            Dim ds As New DataSet
                            ds.Clear()
                            cmd.CommandText = sql
                            da.Fill(ds)
                            Dim campo As DataRow
                            campo = ds.Tables(0).Rows(0)
                            saldo = campo(14)
                            saldo += quitar
                            Dim t As String = saldo.ToString("#,###.00;(#,###.00)")
                            sql = "UPDATE cliente SET Saldo ='" & t & "' WHERE Codigo=" & consultar.Text & ""
                            cmd.CommandText = sql
                            cmd.ExecuteNonQuery()
                            recarregarQuitar()
                            PcarregaDadosClientePendente()
                            MsgBox("Divida Quitada com Sucesso", MsgBoxStyle.Information, "Pendente!")

                            QuitarTxt.Clear()

                        Catch ex As Exception
                            MsgBox("Digite o Código do Cliente.", MsgBoxStyle.Critical, "ATENÇÂO!")
                        Finally
                            con.Close()
                        End Try
                    End Using
                End If
            End If
        Catch ex As Exception
            MsgBox("AÇÃO NÃO PERMETIDA, FAÇA LOGIN NO USUÁRIO ADMINISTRADOR", MsgBoxStyle.Critical, "ATENÇÂO!")
        End Try

    End Sub
    Private Sub QuitarTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuitarTxt.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete) Then
            Dim b As Decimal
            b = QuitarTxt.Text
            If b <= 9 Then
                QuitarTxt.Text = "0.00"
            End If
        End If
        Dim a As Integer
        Dim c As String = QuitarTxt.Text
        If c <> "" Then
            Dim valor As Decimal = QuitarTxt.Text
            a = valor / 10
            If a = valor Then
                QuitarTxt.Text = valor.ToString("#,###.00;(#,###.00)")
            End If
        Else
            QuitarTxt.Text = ",00"
        End If
    End Sub
    Private Sub consultar_TextChanged(sender As Object, e As EventArgs) Handles consultar.TextChanged
        recarregarQuitar()
    End Sub
End Class