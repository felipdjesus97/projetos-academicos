import pyodbc
import pandas as pd

# Conexão com o SQL Server (ajuste se necessário)
conn = pyodbc.connect(
    "DRIVER={SQL Server};"
    "SERVER=FELIPE-PC;" #NOME DO MEU SERVIDOR
    "DATABASE=dbFilmes;" #NOME DO MEU BANCO
    "Trusted_Connection=yes;"
)
cursor = conn.cursor()

# Inserir Diretores
df_diretores = pd.read_csv('diretores.csv')
for _, row in df_diretores.iterrows():
    cursor.execute("""
        INSERT INTO Diretores (id_diretor, nome)
        VALUES (?, ?)
    """, int(row['id_diretor']), row['nome'])

# Inserir Gêneros
df_generos = pd.read_csv('generos.csv')
for _, row in df_generos.iterrows():
    cursor.execute("""
        INSERT INTO Generos (id_genero, nome)
        VALUES (?, ?)
    """, int(row['id_genero']), row['nome'])

# Inserir Filmes
df_filmes = pd.read_csv('filmes_final.csv')
for _, row in df_filmes.iterrows():
    cursor.execute("""
        INSERT INTO Filmes (id_filme, titulo, ano, nota, id_diretor, id_genero)
        VALUES (?, ?, ?, ?, ?, ?)
    """, int(row['id_filme']), row['titulo'], int(row['ano']), float(row['nota']),
         int(row['id_diretor']), int(row['id_genero']))

conn.commit()
cursor.close()
conn.close()

print("✅ Dados inseridos com sucesso no SQL Server!")
