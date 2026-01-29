USE dbFilmes;
go
-- Inserir filme
EXEC sp_inserir_filme 400000, 'A Origem', 2010, 8.8, 3, 5;

-- Atualizar filme
EXEC sp_atualizar_filme 400000, 'A Origem (Inception)', 2010, 9.0, 3, 5;

-- Excluir filme
EXEC sp_excluir_filme 400000;

SELECT * FROM auditoria_filmes;