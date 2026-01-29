use dbFilmes;
go
CREATE OR ALTER TRIGGER tr_auditaInsereFilme
ON Filmes
FOR INSERT
AS
BEGIN
    INSERT INTO auditoria_filmes (usuario, acao, data, tabela, codigo)
    SELECT 
        SUSER_SNAME(), 
        'Inseriu', 
        GETDATE(), 
        'dbo.Filmes', 
        id_filme
    FROM inserted;
END;
GO

CREATE OR ALTER TRIGGER tr_auditaAlteraFilme
ON Filmes
FOR UPDATE
AS
BEGIN
    INSERT INTO auditoria_filmes (usuario, acao, data, tabela, codigo)
    SELECT 
        SUSER_SNAME(), 
        'Atualizou', 
        GETDATE(), 
        'dbo.Filmes', 
        id_filme
    FROM inserted;
END;
GO

CREATE OR ALTER TRIGGER tr_auditaDeletaFilme
ON Filmes
FOR DELETE
AS
BEGIN
    INSERT INTO auditoria_filmes (usuario, acao, data, tabela, codigo)
    SELECT 
        SUSER_SNAME(), 
        'Deletou', 
        GETDATE(), 
        'dbo.Filmes', 
        id_filme
    FROM deleted;
END;
GO
