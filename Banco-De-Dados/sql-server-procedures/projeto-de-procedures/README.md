# Projeto de Procedures em SQL Server

## 1. Organização Geral

O projeto foi desenvolvido com foco em práticas de programação em SQL Server utilizando procedures armazenadas.

A estrutura foi organizada em três blocos principais:

- Criação e uso do banco de dados  
- Implementação de procedures funcionais  
- Procedure principal responsável pela centralização das operações  

O banco de dados utilizado contém procedures independentes, cada uma responsável por uma operação específica, além de uma procedure central que atua como menu de execução.

---

## 2. Procedures Desenvolvidas

### Operações Matemáticas

- Soma – realiza a soma de dois valores  
- Subtração – realiza a subtração entre dois valores  
- Multiplicação – realiza a multiplicação e exibe o cálculo  
- Divisão – realiza divisão com validação para evitar divisão por zero  

---

### Estruturas Condicionais

- Par ou Ímpar – verifica se um número é par ou ímpar  
- Índice de Aumento – aplica aumento percentual em um valor  
- Índice de Desconto – aplica desconto percentual em um valor  
- Cálculo do INSS – calcula desconto baseado em faixas salariais  

---

### Estruturas de Repetição

- Fatorial – cálculo de fatorial com validação de entrada  
- Números Primos – identifica números primos dentro de um intervalo  
- Sequência de Fibonacci – geração de sequência numérica  

---

### Manipulação de Dados

- Conversão de Data – converte valor numérico no formato DDMMAAAA para data válida  

---

## 3. Procedure Principal

Foi implementada uma procedure central responsável por gerenciar todas as demais.

Essa procedure recebe uma opção numérica e executa a operação correspondente, funcionando como um menu de execução dentro do banco de dados.

Caso seja informado um valor inválido, o sistema retorna uma mensagem de erro.

---

## 4. Justificativa da Organização

O projeto foi estruturado com base nos seguintes princípios:

- Modularidade: cada procedure possui responsabilidade única  
- Reutilização: procedimentos independentes podem ser chamados separadamente  
- Legibilidade: código organizado e de fácil compreensão  
- Centralização: procedure principal unifica a execução das operações  
- Tratamento de erros: validações para evitar falhas como divisão por zero e entradas inválidas  

---

## 5. Objetivo do Projeto

O objetivo é demonstrar a utilização de procedures no SQL Server para construção de lógica programável dentro do banco de dados, simulando um sistema estruturado com entrada de comandos e execução de operações distintas.