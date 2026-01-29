USE dbFilmes;
go
-- Buscar filmes por ano
EXEC sp_filmes_por_ano 2010;

-- Buscar filmes por gênero
EXEC sp_filmes_por_genero 'Action';

-- Buscar filmes por diretor
EXEC sp_filmes_por_diretor 'Christopher Nolan';

