Imports MySql.Data.MySqlClient
Public Class Consul_Cliente
    dim VecPosi(1000) As integer
    Public linhaCli As Integer
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
    Private Sub Consul_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PcarregaDadosCliente()
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
                linhaCli = excluir.Text
                carregarImagemCLi()
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Você tem certeza que deseja excluir este cliente?", vbYesNo, "Excluir Cliente") = vbYes Then
            Using con As MySqlConnection = GetConnectionMySQL()
                Try
                    con.Open()
                    Dim sql As String = "DELETE FROM CLIENTE WHERE Codigo=" & excluir.Text & ""
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    dgv.DataSource = dt
                    sql = "DELETE FROM foto_cliente WHERE foto_cod=" & excluir.Text & ""
                    Dim cmd2 As MySqlCommand = New MySqlCommand(sql, con)
                    Dim da2 As MySqlDataAdapter = New MySqlDataAdapter(cmd2)
                    Dim dt2 As DataTable = New DataTable
                    da2.Fill(dt2)
                    dgv.DataSource = dt2
                    PcarregaDadosCliente()
                    MsgBox("CLIENTE EXCLUIDO COM SUCESSO!", MsgBoxStyle.Information, "ATENÇÂO!")
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
    Private Sub voltar_Click(sender As Object, e As EventArgs) Handles voltar.Click
        Home.Show()
        Me.Close()
    End Sub
    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click
        Cad_Cliente.Show()
        Me.Close()
    End Sub
    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim temp As Integer = Integer.Parse(e.RowIndex().ToString())
        Dim a As Integer
        While a <= temp
            linhaCli = VecPosi(a)
            a += 1
        End While
        carregarImagemCLi()
    End Sub
    Private Sub ButAlterar_Click(sender As Object, e As EventArgs) Handles ButAlterar.Click
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM CLIENTE WHERE Codigo=" & excluir.Text & ""
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Dim z As Integer = da.Fill(dt).ToString()
                If z = 0 Then
                    MsgBox("Selecione um código existente.", MsgBoxStyle.Exclamation, "Erro ao localizar Cliente")
                    con.Close()
                Else
                    CodAlterarCliente = excluir.Text

                    If CodAlterarCliente <> 0 Then
                        Editar_Cliente.Show()
                        Me.Close()
                    End If
                End If
            Catch ex As Exception
                MsgBox("Selecione um código existente.", MsgBoxStyle.Exclamation, "Erro ao localizar Cliente")
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
                linhaCli = campo(0)
                carregarImagemCLi()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
End Class