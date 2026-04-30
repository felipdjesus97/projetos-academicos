Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Module Module1
    Public username, password As String   ' senha do BD
    Public Function GetConnectionMySQL() As MySqlConnection
        Dim sql As String = "data source=localhost; user id=" & username & "; password=" & password & "; database=DEPOSITO"
        Return New MySqlConnection(sql)
    End Function
    Public alterarimgCli, alterarimgProd As Integer
    Public con As New MySqlConnection
    Public cmd As MySqlCommand = con.CreateCommand
    Public ds As New DataSet
    Public da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
    Public imgnome As String
    Public codigoimg, cont As Integer
    Public CodCliente, CodProduto, CodAlterarCliente, CodAlterarProduto, CodAlterarPentende, CodCaixa, pendentee As Integer
    Dim daImagem As MySqlDataAdapter
    Dim dsImagem As DataSet
    Public Sub Conectar()
        Try
            con.ConnectionString = "server=localhost;user id=" & username & "; password=" & password & ";database=DEPOSITO"
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message & "Erro ao conectar")

        End Try
    End Sub
    Public Sub Operar(ByVal sql)
        Conectar()
        Try
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information, "Cadastro")
        Catch ex As Exception
            MsgBox("Usuário Não Possuiu Permissão Para Continuar", MsgBoxStyle.Critical, "Atenção!")
        Finally
            con.Close()
        End Try
    End Sub
    'CODIOGOS DO CLIENTE
    Public Sub carregarImagemCLi()
        Try
            CodCliente += 1
            Dim cnString As String = "server=localhost;user id=" & username & "; password=" & password & ";database=deposito"
            Dim cn As New MySqlConnection(cnString)
            cn.Open()
            daImagem = New MySqlDataAdapter
            daImagem.SelectCommand = New MySqlCommand("select * from foto_cliente", cn)

            dsImagem = New DataSet("dsimagem")
            daImagem.Fill(dsImagem)

            Dim dataTable As DataTable = dsImagem.Tables(0)

            If Consul_Cliente.ImgCli.Image IsNot Nothing Then
                Consul_Cliente.ImgCli.Image.Dispose()
            End If

            Dim fsImage As New FileStream("C:\FantasiaNovaDiamante\image" & CodCliente & ".jpg", FileMode.Create)

            For Each dataRow As DataRow In dataTable.Rows
                If dataRow(0).ToString() = Consul_Cliente.linhaCli Then
                    Dim blob As Byte() = DirectCast(dataRow(1), Byte())
                    fsImage.Write(blob, 0, blob.Length)
                    fsImage.Close()
                    fsImage = Nothing
                    Consul_Cliente.ImgCli.Image = Image.FromFile("C:\FantasiaNovaDiamante\image" & CodCliente & ".jpg")
                    Consul_Cliente.ImgCli.SizeMode = PictureBoxSizeMode.StretchImage
                    Consul_Cliente.ImgCli.Refresh()
                End If
            Next
            cn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub salvaImagemCliente()
        Try
            'SEMPRE MUDAR O CAMINHO DA IMAGEM "fun.png" CONFORME A MAQUINA.
            If imgnome = "" Then
                imgnome = "C:\FantasiaNovaDiamante\fun.png"
            End If
            If imgnome <> "" Then
                Dim fs As FileStream

                fs = New FileStream(imgnome, FileMode.Open, FileAccess.Read)
                Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
                fs.Close()
                Dim cnString As String = "server=localhost;user id=" & username & "; password=" & password & ";database=DEPOSITO"
                Dim CN As New MySqlConnection(cnString)
                CN.Open()
                Dim strSQL As String
                strSQL = "INSERT INTO foto_cliente(foto_cod,image) values (" & codigoimg & ", " & " @Img)"

                Dim imgParam As New MySqlParameter()

                imgParam.MySqlDbType = MySqlDbType.Binary
                imgParam.ParameterName = "Img"
                imgParam.Value = picByte

                Dim cmd As New MySqlCommand(strSQL, CN)
                cmd.Parameters.Add(imgParam)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                imgnome = ""
                CN.Close()
                CN.Dispose()
            End If
        Catch ex As Exception

        End Try

    End Sub

    'CODIGO DO ALTERAR CLIENTE
    Public Sub carregarImagemEditarCliente()
        Try
            alterarimgCli += 1
            Dim cnString As String = "server=localhost;user id=" & username & "; password=" & password & ";database=deposito"
            Dim cn2 As New MySqlConnection(cnString)
            cn2.Open()
            daImagem = New MySqlDataAdapter
            daImagem.SelectCommand = New MySqlCommand("select * from foto_cliente", cn2)

            dsImagem = New DataSet("dsimagem")
            daImagem.Fill(dsImagem)

            Dim dataTable As DataTable = dsImagem.Tables(0)

            If Editar_Cliente.Pic_Cli_Img.Image IsNot Nothing Then
                Editar_Cliente.Pic_Cli_Img.Image.Dispose()
            End If

            Dim fsImage As New FileStream("C:\FantasiaNovaDiamante\alterarimg" & alterarimgCli & ".jpg", FileMode.Create)

            For Each dataRow As DataRow In dataTable.Rows
                If dataRow(0).ToString() = CodAlterarCliente Then
                    Dim blob As Byte() = DirectCast(dataRow(1), Byte())
                    fsImage.Write(blob, 0, blob.Length)
                    fsImage.Close()
                    fsImage = Nothing
                    Editar_Cliente.Pic_Cli_Img.Image = Image.FromFile("C:\FantasiaNovaDiamante\alterarimg" & alterarimgCli & ".jpg")
                    Editar_Cliente.Pic_Cli_Img.SizeMode = PictureBoxSizeMode.StretchImage
                    Editar_Cliente.Pic_Cli_Img.Refresh()
                End If
            Next
            cn2.Close()
        Catch ex As Exception


        End Try
    End Sub
    Public Sub salvaImagemEditarCliente()
        Try
            'SEMPRE MUDAR O CAMINHO DA IMAGEM "fun.png" CONFORME A MAQUINA.
            If imgnome = "" Then
                Editar_Cliente.verAlterarimg = 0
            End If
            If imgnome <> "" Then
                Dim fs As FileStream

                fs = New FileStream(imgnome, FileMode.Open, FileAccess.Read)
                Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
                fs.Close()
                Dim cnString As String = "server=localhost;user id=" & username & "; password=" & password & ";database=DEPOSITO"
                Dim CN As New MySqlConnection(cnString)
                CN.Open()
                Dim strSQL As String
                strSQL = "INSERT INTO foto_cliente(foto_cod,image) values (" & CodAlterarCliente & ", " & " @Img)"
                Dim imgParam As New MySqlParameter()

                imgParam.MySqlDbType = MySqlDbType.Binary
                imgParam.ParameterName = "Img"
                imgParam.Value = picByte

                Dim sql As String = "DELETE FROM foto_cliente WHERE foto_cod =" & CodAlterarCliente
                Dim cmd2 As New MySqlCommand(sql, CN)
                cmd2.ExecuteNonQuery()
                cmd2.Dispose()

                Dim cmd As New MySqlCommand(strSQL, CN)
                cmd.Parameters.Add(imgParam)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                imgnome = ""
                CN.Close()
                CN.Dispose()
            End If
        Catch ex As Exception

        End Try

    End Sub

    'CODIOGOS DO CLIENTE PENDENTE
    Public Sub carregarImagemCLiPendente()
        Try
            CodAlterarPentende += 1
            Dim cnString As String = "server=localhost;user id=" & username & "; password=" & password & ";database=deposito"
            Dim cn As New MySqlConnection(cnString)
            cn.Open()
            daImagem = New MySqlDataAdapter
            daImagem.SelectCommand = New MySqlCommand("select * from foto_cliente", cn)

            dsImagem = New DataSet("dsimagem")
            daImagem.Fill(dsImagem)

            Dim dataTable As DataTable = dsImagem.Tables(0)

            If Selec_Pendente.ImgCli.Image IsNot Nothing Then
                Selec_Pendente.ImgCli.Image.Dispose()
            End If

            Dim fsImage As New FileStream("C:\FantasiaNovaDiamante\iiigmm" & CodAlterarPentende & ".jpg", FileMode.Create)

            For Each dataRow As DataRow In dataTable.Rows
                If dataRow(0).ToString() = Selec_Pendente.linhaPen Then
                    Dim blob As Byte() = DirectCast(dataRow(1), Byte())
                    fsImage.Write(blob, 0, blob.Length)
                    fsImage.Close()
                    fsImage = Nothing
                    Selec_Pendente.ImgCli.Image = Image.FromFile("C:\FantasiaNovaDiamante\iiigmm" & CodAlterarPentende & ".jpg")
                    Selec_Pendente.ImgCli.SizeMode = PictureBoxSizeMode.StretchImage
                    Selec_Pendente.ImgCli.Refresh()
                End If
            Next
            cn.Close()
        Catch ex As Exception


        End Try
    End Sub

    'CODIGO DO PRODUTO
    Public Sub carregarImagemProd()
        Try
            CodProduto += 1
            Dim cnString As String = "server=localhost;user id=" & username & "; password=" & password & ";database=deposito"
            Dim cn As New MySqlConnection(cnString)
            cn.Open()
            daImagem = New MySqlDataAdapter
            daImagem.SelectCommand = New MySqlCommand("select * from foto_produto", cn)

            dsImagem = New DataSet("dsimagem")
            daImagem.Fill(dsImagem)

            Dim dataTable As DataTable = dsImagem.Tables(0)

            If Consul_Produto.ImgProd.Image IsNot Nothing Then
                Consul_Produto.ImgProd.Image.Dispose()
            End If

            Dim fsImage As New FileStream("C:\FantasiaNovaDiamante\iiigm" & CodProduto & ".jpg", FileMode.Create)

            For Each dataRow As DataRow In dataTable.Rows
                If dataRow(0).ToString() = Consul_Produto.linhaProd Then
                    Dim blob As Byte() = DirectCast(dataRow(1), Byte())
                    fsImage.Write(blob, 0, blob.Length)
                    fsImage.Close()
                    fsImage = Nothing
                    Consul_Produto.ImgProd.Image = Image.FromFile("C:\FantasiaNovaDiamante\iiigm" & CodProduto & ".jpg")
                    Consul_Produto.ImgProd.SizeMode = PictureBoxSizeMode.StretchImage
                    Consul_Produto.ImgProd.Refresh()
                End If
            Next
            cn.Close()
        Catch ex As Exception


        End Try
    End Sub
    Public Sub salvaImagemProduto()
        Try
            'SEMPRE MUDAR O CAMINHO DA IMAGEM "fun.png" CONFORME A MAQUINA.
            If imgnome = "" Then
                imgnome = "C:\FantasiaNovaDiamante\fun.png"
            End If
            If imgnome <> "" Then
                Dim fs As FileStream

                fs = New FileStream(imgnome, FileMode.Open, FileAccess.Read)
                Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
                fs.Close()
                Dim cnString As String = "server=localhost;user id=" & username & "; password=" & password & ";database=DEPOSITO"
                Dim CN As New MySqlConnection(cnString)
                CN.Open()
                Dim strSQL As String
                strSQL = "INSERT INTO foto_produto(foto_cod,image) values (" & codigoimg & ", " & " @Img)"

                Dim imgParam As New MySqlParameter()

                imgParam.MySqlDbType = MySqlDbType.Binary
                imgParam.ParameterName = "Img"
                imgParam.Value = picByte

                Dim cmd As New MySqlCommand(strSQL, CN)
                cmd.Parameters.Add(imgParam)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                imgnome = ""
                CN.Close()
                CN.Dispose()
            End If
        Catch ex As Exception

        End Try

    End Sub

    'CODIGO DO ALTERAR PRODUTO
    Public Sub carregarImagemEditarProduto()
        Try
            alterarimgProd += 1
            Dim cnString As String = "server=localhost;user id=" & username & "; password=" & password & ";database=deposito"
            Dim cn2 As New MySqlConnection(cnString)
            cn2.Open()
            daImagem = New MySqlDataAdapter
            daImagem.SelectCommand = New MySqlCommand("select * from foto_produto", cn2)

            dsImagem = New DataSet("dsimagem")
            daImagem.Fill(dsImagem)

            Dim dataTable As DataTable = dsImagem.Tables(0)

            If Editar_Produto.Pic_Prod_Img.Image IsNot Nothing Then
                Editar_Produto.Pic_Prod_Img.Image.Dispose()
            End If

            Dim fsImage As New FileStream("C:\FantasiaNovaDiamante\alterarimgProduto" & alterarimgProd & ".jpg", FileMode.Create)

            For Each dataRow As DataRow In dataTable.Rows
                If dataRow(0).ToString() = CodAlterarProduto Then
                    Dim blob As Byte() = DirectCast(dataRow(1), Byte())
                    fsImage.Write(blob, 0, blob.Length)
                    fsImage.Close()
                    fsImage = Nothing
                    Editar_Produto.Pic_Prod_Img.Image = Image.FromFile("C:\FantasiaNovaDiamante\alterarimgProduto" & alterarimgProd & ".jpg")
                    Editar_Produto.Pic_Prod_Img.SizeMode = PictureBoxSizeMode.StretchImage
                    Editar_Produto.Pic_Prod_Img.Refresh()
                End If
            Next
            cn2.Close()
        Catch ex As Exception


        End Try
    End Sub
    Public Sub salvaImagemEditarProduto()
        Try
            'SEMPRE MUDAR O CAMINHO DA IMAGEM "fun.png" CONFORME A MAQUINA.
            If imgnome = "" Then
                Editar_Produto.verAlterarimg = 0
            End If
            If imgnome <> "" Then
                Dim fs As FileStream

                fs = New FileStream(imgnome, FileMode.Open, FileAccess.Read)
                Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
                fs.Close()
                Dim cnString As String = "server=localhost;user id=" & username & "; password=" & password & ";database=DEPOSITO"
                Dim CN As New MySqlConnection(cnString)
                CN.Open()
                Dim strSQL As String
                strSQL = "INSERT INTO foto_produto(foto_cod,image) values (" & CodAlterarProduto & ", " & " @Img)"
                Dim imgParam As New MySqlParameter()

                imgParam.MySqlDbType = MySqlDbType.Binary
                imgParam.ParameterName = "Img"
                imgParam.Value = picByte

                Dim sql As String = "DELETE FROM foto_produto WHERE foto_cod =" & CodAlterarProduto
                Dim cmd2 As New MySqlCommand(sql, CN)
                cmd2.ExecuteNonQuery()
                cmd2.Dispose()

                Dim cmd As New MySqlCommand(strSQL, CN)
                cmd.Parameters.Add(imgParam)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                imgnome = ""
                CN.Close()
                CN.Dispose()
            End If
        Catch ex As Exception

        End Try

    End Sub

    'CODIGO DO CAIXA
    Public Sub carregarImagemCaixa()
        Try
            CodCaixa += 1
            Dim cnString As String = "server=localhost;user id=" & username & "; password=" & password & ";database=deposito"
            Dim cn As New MySqlConnection(cnString)
            cn.Open()
            daImagem = New MySqlDataAdapter
            daImagem.SelectCommand = New MySqlCommand("select * from foto_produto", cn)

            dsImagem = New DataSet("dsimagem")
            daImagem.Fill(dsImagem)

            Dim dataTable As DataTable = dsImagem.Tables(0)

            If Caixa.Pic_Img_Caixa.Image IsNot Nothing Then
                Caixa.Pic_Img_Caixa.Image.Dispose()
            End If

            Dim fsImage As New FileStream("C:\FantasiaNovaDiamante\caixa" & CodCaixa & ".jpg", FileMode.Create)

            For Each dataRow As DataRow In dataTable.Rows
                If dataRow(0).ToString() = Caixa.linhaCaixa Then
                    Dim blob As Byte() = DirectCast(dataRow(1), Byte())
                    fsImage.Write(blob, 0, blob.Length)
                    fsImage.Close()
                    fsImage = Nothing
                    Caixa.Pic_Img_Caixa.Image = Image.FromFile("C:\FantasiaNovaDiamante\caixa" & CodCaixa & ".jpg")
                    Caixa.Pic_Img_Caixa.SizeMode = PictureBoxSizeMode.StretchImage
                    Caixa.Pic_Img_Caixa.Refresh()
                End If
            Next
            cn.Close()
        Catch ex As Exception


        End Try
    End Sub

End Module
