Imports MySql.Data.MySqlClient
Public Class Historico
    Dim DateAntiga As DateTime = DateTime.Today.AddDays(-7)
    Dim VecPosiApagar(1000) As String
    Private Sub Historico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PcarregaDadosHistorico()
    End Sub
    Private Sub PcarregaDadosHistorico()
        exclirDatas()
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM VENDA"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim ds As New DataSet
                ds.Clear()
                cmd.CommandText = sql
                Dim cont As Integer = da.Fill(ds).ToString()
                Dim campo As DataRow
                Dim a As Integer
                Dim vendas As Double
                Do While (a < cont)
                    campo = ds.Tables(0).Rows(a)
                    vendas += campo(2)
                    Dim b As String
                    Dim c As String = campo(3)
                    If b <> c Then
                        ComboBoxData.Items.Add(c)
                    End If
                    a += 1
                    If a > 0 Then
                        b = campo(3)
                    End If
                Loop
                totVendas_txt.Text = vendas.ToString("#,###.00;(#,###.00)")
                da.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Public Sub exclirDatas()
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM VENDA"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim ds As New DataSet
                ds.Clear()
                cmd.CommandText = sql
                Dim cont As Integer = da.Fill(ds).ToString()
                Dim campo As DataRow
                Dim a As Integer
                Do While (a < cont)
                    campo = ds.Tables(0).Rows(a)
                    VecPosiApagar(a) = campo(3)
                    Dim cod As Integer = campo(0)
                    If VecPosiApagar(a) < DateAntiga Then
                        Dim sql2 As String = "DELETE FROM venda WHERE Codigo =" & cod
                        Try
                            cmd.CommandText = sql2
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                    a += 1
                Loop
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
    Private Sub ComboBoxData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxData.SelectedIndexChanged
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM venda WHERE Data LIKE '%" & ComboBoxData.Text & "%'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgv.DataSource = dt


                Dim ds As New DataSet
                ds.Clear()
                cmd.CommandText = sql
                Dim cont As Integer = da.Fill(ds).ToString()
                Dim campo As DataRow
                Dim a As Integer
                Dim vendas As Double
                Do While (a < cont)
                    campo = ds.Tables(0).Rows(a)
                    vendas += campo(2)
                    a += 1
                Loop
                totVendas_txt.Text = vendas.ToString("#,###.00;(#,###.00)")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
End Class