import pandas as pd

# Lê os arquivos .tsv
titles = pd.read_csv('title.basics.tsv', sep='\t', dtype=str)
ratings = pd.read_csv('title.ratings.tsv', sep='\t', dtype=str)
principals = pd.read_csv('title.principals.tsv', sep='\t', dtype=str)
names = pd.read_csv('name.basics.tsv', sep='\t', dtype=str)

# Filtra apenas filmes
filmes = titles[titles['titleType'] == 'movie']
filmes = filmes[['tconst', 'primaryTitle', 'startYear', 'genres']]

# Junta com notas
filmes = filmes.merge(ratings, on='tconst')

# Filtra diretores
diretores = principals[principals['category'] == 'director']
diretores = diretores[['tconst', 'nconst']]

# Junta filmes com diretores
filmes = filmes.merge(diretores, on='tconst')

# Junta com nomes dos diretores
diretor_nomes = names[['nconst', 'primaryName']]
filmes = filmes.merge(diretor_nomes, on='nconst')

# Renomeia e filtra colunas principais
filmes = filmes.rename(columns={
    'primaryTitle': 'titulo',
    'startYear': 'ano',
    'averageRating': 'nota',
    'genres': 'genero',
    'primaryName': 'diretor'
})
filmes = filmes[['titulo', 'ano', 'nota', 'genero', 'diretor']]

# Remove linhas com valores faltantes
filmes = filmes.dropna()

# Filtra apenas anos válidos (numéricos)
filmes = filmes[filmes['ano'].str.isnumeric()]
filmes['ano'] = filmes['ano'].astype(int)
filmes['nota'] = filmes['nota'].astype(float)

# Remove duplicados
filmes = filmes.drop_duplicates()

# Cria tabelas auxiliares de diretores e generos
tabela_diretores = pd.DataFrame(filmes['diretor'].unique(), columns=['nome'])
tabela_diretores['id_diretor'] = tabela_diretores.index + 1

tabela_generos = pd.DataFrame(filmes['genero'].unique(), columns=['nome'])
tabela_generos['id_genero'] = tabela_generos.index + 1

# Salva as tabelas auxiliares
tabela_diretores.to_csv('diretores.csv', index=False)
tabela_generos.to_csv('generos.csv', index=False)

# Junta os IDs nas colunas principais
filmes = filmes.merge(tabela_diretores, left_on='diretor', right_on='nome')
filmes = filmes.merge(tabela_generos, left_on='genero', right_on='nome')

# Cria tabela final de filmes
filmes_final = filmes[['titulo', 'ano', 'nota', 'id_diretor', 'id_genero']]
filmes_final['id_filme'] = filmes_final.index + 1

# Salva a tabela final
filmes_final.to_csv('filmes_final.csv', index=False)

print("✅ CSVs gerados com sucesso!")
