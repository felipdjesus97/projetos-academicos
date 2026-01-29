USE dbFilmes;
go
CREATE OR ALTER PROCEDURE sp_excluir_filme
    @id_filme INT
AS
BEGIN
    DELETE FROM Filmes
    WHERE id_filme = @id_filme;
END;
GO

CREATE OR ALTER PROCEDURE sp_atualizar_filme
    @id_filme INT,
    @titulo NVARCHAR(255),
    @ano INT,
    @nota FLOAT,
    @id_diretor INT,
    @id_genero INT
AS
BEGIN
    UPDATE Filmes
    SET titulo = @titulo,
        ano = @ano,
        nota = @nota,
        id_diretor = @id_diretor,
        id_genero = @id_genero
    WHERE id_filme = @id_filme;
END;
GO

CREATE OR ALTER PROCEDURE sp_inserir_filme
    @id_filme INT,
    @titulo NVARCHAR(255),
    @ano INT,
    @nota FLOAT,
    @id_diretor INT,
    @id_genero INT
AS
BEGIN
    INSERT INTO Filmes (id_filme, titulo, ano, nota, id_diretor, id_genero)
    VALUES (@id_filme, @titulo, @ano, @nota, @id_diretor, @id_genero);
END;
GO