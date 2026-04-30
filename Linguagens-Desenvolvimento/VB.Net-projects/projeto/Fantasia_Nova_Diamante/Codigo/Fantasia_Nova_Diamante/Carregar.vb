Public Class Carregar
    Dim a As Integer
    Private Sub Carregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        Login.Show()
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.PerformStep()
        If a < 100 Then
            a += 10
        End If
        texto.Text = "Carregando Dados do Sistema " & a & "%"
    End Sub

End Class