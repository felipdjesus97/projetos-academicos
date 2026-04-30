-- CRIAÇÃO DO BANCO DE DADOS
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'FelipeP2') --verifica se existe banco antes de criar
BEGIN
    CREATE DATABASE FelipeP2; --Cria banco se não existir
END
GO

USE FelipeP2;--Usa o banco
GO

-- 1. Soma de dois números
CREATE OR ALTER PROCEDURE sp_soma --Cria a procedure ou altera se ela já existir
    @n1 FLOAT,
    @n2 FLOAT
AS
BEGIN
    -- Realiza a soma dos dois números recebidos
    DECLARE @res FLOAT = @n1 + @n2;

    -- Exibe o resultado formatado
    PRINT 'Soma: ' + CAST(@n1 AS VARCHAR) + ' + ' + CAST(@n2 AS VARCHAR) + ' = ' + CAST(@res AS VARCHAR);
END
GO

-- 2. Subtração
CREATE OR ALTER PROCEDURE sp_subtracao --Cria a procedure ou altera se ela já existir
    @n1 FLOAT,
    @n2 FLOAT
AS
BEGIN
    -- Subtrai o segundo número do primeiro
    DECLARE @res FLOAT = @n1 - @n2;

    -- Exibe o resultado formatado
    PRINT 'Subtração: ' + CAST(@n1 AS VARCHAR) + ' - ' + CAST(@n2 AS VARCHAR) + ' = ' + CAST(@res AS VARCHAR);
END
GO

-- 3. Multiplicação
CREATE OR ALTER PROCEDURE sp_multiplicacao --Cria a procedure ou altera se ela já existir
    @n1 FLOAT,
    @n2 FLOAT
AS
BEGIN
    -- Multiplica os dois números
    DECLARE @res FLOAT = @n1 * @n2;

    -- Exibe o resultado formatado
    PRINT 'Multiplicação: ' + CAST(@n1 AS VARCHAR) + ' * ' + CAST(@n2 AS VARCHAR) + ' = ' + CAST(@res AS VARCHAR);
END
GO

-- 4. Divisão (verificar divisão por zero)
CREATE OR ALTER PROCEDURE sp_divisao --Cria a procedure ou altera se ela já existir
    @n1 FLOAT,
    @n2 FLOAT
AS
BEGIN
    -- Verifica se o divisor é zero para evitar erro
    IF @n2 = 0
        PRINT 'Erro: divisão por zero não permitida.'
    ELSE
    BEGIN
        -- Realiza a divisão
        DECLARE @res FLOAT = @n1 / @n2;

        -- Exibe o resultado
        PRINT 'Divisão: ' + CAST(@n1 AS VARCHAR) + ' / ' + CAST(@n2 AS VARCHAR) + ' = ' + CAST(@res AS VARCHAR);
    END
END
GO

-- 5. Verificar se um número é par ou ímpar
CREATE OR ALTER PROCEDURE sp_parImpar --Cria a procedure ou altera se ela já existir
    @n INT
AS
BEGIN
    -- Verifica o resto da divisão por 2
    IF @n % 2 = 0
        PRINT CAST(@n AS VARCHAR) + ' é PAR'
    ELSE
        PRINT CAST(@n AS VARCHAR) + ' é ÍMPAR'
END
GO

-- 6. Calcular o fatorial de um número
CREATE OR ALTER PROCEDURE sp_fatorial --Cria a procedure ou altera se ela já existir
    @n INT
AS
BEGIN
    -- Valida se o número é negativo
    IF @n < 0
    BEGIN
        PRINT 'Erro: fatorial não existe para números negativos.'
        RETURN
    END

    -- Inicializa variáveis para cálculo do fatorial
    DECLARE @res BIGINT = 1;
    DECLARE @i INT = 1;

    -- Laço de repetição de 1 até n
    WHILE @i <= @n
    BEGIN
        SET @res = @res * @i; -- Multiplica o acumulador pelo índice atual
        SET @i += 1; -- Incrementa o índice
    END

    -- Exibe o resultado
    PRINT 'Fatorial de ' + CAST(@n AS VARCHAR) + ' = ' + CAST(@res AS VARCHAR);
END
GO

-- 7. Exibir números primos até o número informado
CREATE OR ALTER PROCEDURE sp_primos --Cria a procedure ou altera se ela já existir
    @n INT
AS
BEGIN
   
    DECLARE @resultado VARCHAR(MAX) = '';  -- Variavél p/ armazena os números primos encontrados
    DECLARE @primeiro BIT = 1; -- Controle para evitar vírgula no início

    -- Valida se o número informado é menor que 2
    IF @n < 2
    BEGIN
        PRINT 'Não há números primos até ' + CAST(@n AS VARCHAR);
        RETURN;
    END

    DECLARE @num INT = 2; -- Começa do primeiro número primo
    DECLARE @div INT;
    DECLARE @isPrimo BIT;

    --Loop para montar a sequência até o número primo escolhido:
    WHILE @num <= @n
    BEGIN
        SET @isPrimo = 1;
        SET @div = 2;

        -- Verifica se o número atual é divisível por algum número até sua raiz quadrada
        WHILE @div <= FLOOR(SQRT(@num))
        BEGIN
            IF @num % @div = 0
            BEGIN
                SET @isPrimo = 0;
                BREAK;
            END
            SET @div += 1;
        END

        -- Se for primo, adiciona ao resultado
        IF @isPrimo = 1
        BEGIN
            IF @primeiro = 1 -- Verifica se é primeiro número primo
            BEGIN
                SET @resultado = CAST(@num AS VARCHAR); --Adiciona número a String
                SET @primeiro = 0; -- Define que primeiro número já foi adicionado
            END
            ELSE
                SET @resultado += ', ' + CAST(@num AS VARCHAR); --Adiciona número a String
        END

        SET @num += 1;
    END

    -- Exibe os primos encontrados
    PRINT 'Números primos até ' + CAST(@n AS VARCHAR) + ': '+ CAST(@resultado AS VARCHAR);
END
GO

-- 8. Exibir sequência de Fibonacci até o número informado
CREATE OR ALTER PROCEDURE sp_fibonacci --Cria a procedure ou altera se ela já existir
    @n INT
AS
BEGIN
    -- Verifica se o número é positivo
    IF @n <= 0
    BEGIN
        PRINT 'Informe um número positivo para a quantidade de termos da sequência Fibonacci.'
        RETURN
    END

    -- Inicializa os dois primeiros termos da sequência
    DECLARE @a INT = 0;
    DECLARE @b INT = 1;
    DECLARE @i INT = 1;

    -- Inicia a string com o primeiro valor
    DECLARE @seq VARCHAR(MAX) = CAST(@a AS VARCHAR);

    -- Loop para montar a sequência até o termo escolhido:
    WHILE @i < @n

    BEGIN
        SET @seq = @seq + ', ' + CAST(@b AS VARCHAR); -- Adiciona próximo termo à string de sequência

        DECLARE @temp INT = @b; --variavel temporaria recebe valor atual de "b"
        SET @b = @a + @b; -- Calcula próximo termo
        SET @a = @temp; --variavel "a" recebe o valor anterior
        SET @i += 1; -- Incrementa contador
    END

    -- Exibe a sequência completa
    PRINT 'Sequência Fibonacci com ' + CAST(@n AS VARCHAR) + ' termos: '+ CAST(@seq AS VARCHAR) ;
END
GO

-- 9. Calcular índice de aumento entre dois valores
CREATE OR ALTER PROCEDURE sp_indiceAumento --Cria a procedure ou altera se ela já existir
    @valor FLOAT,
    @percentual FLOAT
AS
BEGIN
    -- Calcula o novo valor com o percentual de aumento
    DECLARE @novoValor FLOAT = @valor * (1 + @percentual / 100.0);

    -- Exibe os valores e o resultado
    PRINT 'Valor informado: ' + CAST(@valor AS VARCHAR);
    PRINT 'Percentual de aumento: ' + CAST(@percentual AS VARCHAR) + '%';
    PRINT 'Novo valor após aumento: ' + CAST(@novoValor AS VARCHAR);
END
GO

-- 10. Calcular índice de desconto entre dois valores
CREATE OR ALTER PROCEDURE sp_indiceDesconto --Cria a procedure ou altera se ela já existir
    @valor FLOAT,
    @percentual FLOAT
AS
BEGIN
    -- Calcula o novo valor com o percentual de desconto
    DECLARE @novoValor FLOAT = @valor * (1 - @percentual / 100.0);

    -- Exibe os valores e o resultado
    PRINT 'Valor informado: ' + CAST(@valor AS VARCHAR);
    PRINT 'Percentual de desconto: ' + CAST(@percentual AS VARCHAR) + '%';
    PRINT 'Novo valor após desconto: ' + CAST(@novoValor AS VARCHAR);
END
GO

-- 11. Calcular contribuição de INSS com base no salário informado
CREATE OR ALTER PROCEDURE sp_inss --Cria a procedure ou altera se ela já existir
    @salario FLOAT
AS
BEGIN
    DECLARE @desconto FLOAT;

    -- Calcula o desconto de acordo com a faixa salarial
    IF @salario <= 1518.00
        SET @desconto = @salario * 0.075;
    ELSE IF @salario <= 2793.88
        SET @desconto = @salario * 0.09;
    ELSE IF @salario <= 4190.83
        SET @desconto = @salario * 0.12;
    ELSE
        SET @desconto = @salario * 0.14;

    -- Exibe o salário e o valor descontado
    PRINT 'Salário informado: ' + CAST(@salario AS VARCHAR);
    PRINT 'Desconto INSS: ' + CAST(@desconto AS VARCHAR);
END
GO

-- 12. Converter uma data no formato DD/MM/AAAA e exibir separadamente o dia, mês e ano
CREATE OR ALTER PROCEDURE sp_data --Cria a procedure ou altera se ela já existir
    @valor1 BIGINT
AS
BEGIN
    -- Converte o número para string de 8 dígitos, com zeros à esquerda
    DECLARE @dataStr VARCHAR(8) = RIGHT('00000000' + CAST(@valor1 AS VARCHAR(8)), 8);
    DECLARE @data DATE;

    BEGIN TRY
        -- Formata a string como DD/MM/YYYY e converte para tipo DATE
        SET @data = CONVERT(DATE,
                    SUBSTRING(@dataStr, 1, 2) + '/' +
                    SUBSTRING(@dataStr, 3, 2) + '/' +
                    SUBSTRING(@dataStr, 5, 4), 103);

        -- Exibe a data e seus componentes
        PRINT 'Data informada: ' + CONVERT(VARCHAR(10), @data, 103);
        PRINT 'Dia: ' + CAST(DAY(@data) AS VARCHAR);
        PRINT 'Mês: ' + CAST(MONTH(@data) AS VARCHAR);
        PRINT 'Ano: ' + CAST(YEAR(@data) AS VARCHAR);
    END TRY
    BEGIN CATCH
        -- Mensagem de erro se o formato for inválido
        PRINT 'Erro: número inválido para conversão de data. Use o formato DDMMAAAA (ex: 10062025).';
    END CATCH
END
GO

-- Procedure principal para escolher a operação
CREATE OR ALTER PROCEDURE sp_escolha --Cria a procedure ou altera se ela já existir
    @opcao INT,
    @valor1 FLOAT = NULL,
    @valor2 FLOAT = NULL
AS
BEGIN
    
    --Executa a opção escolhida:
        IF @opcao = 1
            EXEC sp_soma @valor1, @valor2;
        ELSE IF @opcao = 2
            EXEC sp_subtracao @valor1, @valor2;
        ELSE IF @opcao = 3
            EXEC sp_multiplicacao @valor1, @valor2;
        ELSE IF @opcao = 4
            EXEC sp_divisao @valor1, @valor2;
        ELSE IF @opcao = 5
            EXEC sp_parImpar @valor1;
        ELSE IF @opcao = 6
            EXEC sp_fatorial @valor1;
        ELSE IF @opcao = 7
            EXEC sp_primos @valor1;
        ELSE IF @opcao = 8
            EXEC sp_fibonacci @valor1;
        ELSE IF @opcao = 9
            EXEC sp_indiceAumento @valor1, @valor2;
        ELSE IF @opcao = 10
            EXEC sp_indiceDesconto @valor1, @valor2;
        ELSE IF @opcao = 11
            EXEC sp_inss @valor1;
        ELSE IF @opcao = 12
            EXEC sp_data @valor1;
        ELSE
            PRINT 'Opção inválida! Escolha um número válido.';
END
GO