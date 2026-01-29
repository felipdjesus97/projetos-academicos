CREATE DATABASE dbFilmes;
GO

USE dbFilmes;
GO

CREATE TABLE Diretores (
    id_diretor INT PRIMARY KEY,
    nome NVARCHAR(255)
);

CREATE TABLE Generos (
    id_genero INT PRIMARY KEY,
    nome NVARCHAR(255)
);

CREATE TABLE Filmes (
    id_filme INT PRIMARY KEY,
    titulo NVARCHAR(255),
    ano INT,
    nota FLOAT,
    id_diretor INT,
    id_genero INT,
    FOREIGN KEY (id_diretor) REFERENCES Diretores(id_diretor),
    FOREIGN KEY (id_genero) REFERENCES Generos(id_genero)
);

CREATE TABLE auditoria_filmes(
    idAuditoria INT IDENTITY(1,1) PRIMARY KEY,
    usuario VARCHAR(100) NOT NULL,
    acao VARCHAR(20) NOT NULL,
    data DATETIME NOT NULL,
    tabela VARCHAR(15) NOT NULL,
    codigo INT NOT NULL 
);
