use dbFilmes;
go

CREATE OR ALTER PROCEDURE sp_filmes_por_ano
    @ano INT
AS
BEGIN
    SELECT 
        f.id_filme,
        f.titulo,
        f.ano,
        f.nota,
        d.nome AS diretor,
        g.nome AS genero
    FROM Filmes f
    INNER JOIN Diretores d ON f.id_diretor = d.id_diretor
    INNER JOIN Generos g ON f.id_genero = g.id_genero
    WHERE f.ano = @ano
    ORDER BY f.titulo;
END;
GO

CREATE OR ALTER PROCEDURE sp_filmes_por_genero
    @nome_genero VARCHAR(100)
AS
BEGIN
    SELECT 
        f.id_filme,
        f.titulo,
        f.ano,
        f.nota,
        d.nome AS diretor,
        g.nome AS genero
    FROM Filmes f
    INNER JOIN Diretores d ON f.id_diretor = d.id_diretor
    INNER JOIN Generos g ON f.id_genero = g.id_genero
    WHERE g.nome = @nome_genero
    ORDER BY f.titulo;
END;
GO

CREATE OR ALTER PROCEDURE sp_filmes_por_diretor
    @nome_diretor VARCHAR(100)
AS
BEGIN
    SELECT 
        f.id_filme,
        f.titulo,
        f.ano,
        f.nota,
        d.nome AS diretor,
        g.nome AS genero
    FROM Filmes f
    INNER JOIN Diretores d ON f.id_diretor = d.id_diretor
    INNER JOIN Generos g ON f.id_genero = g.id_genero
    WHERE d.nome = @nome_diretor
    ORDER BY f.titulo;
END;
GO