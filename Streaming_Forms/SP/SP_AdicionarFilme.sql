-- Stored Procedure para adicionar um filme
CREATE OR ALTER PROCEDURE SP_AdicionarFilme
    @titulo NVARCHAR(200),
    @genero NVARCHAR(50),
    @ano INT,
    @duracao INT,
    @idade_minima INT,
    @nome_produtora NVARCHAR(100)
AS
BEGIN
    DECLARE @id_produtora INT;
    -- Buscar id da produtora pelo nome
    SELECT @id_produtora = id_produtora FROM Streaming_Produtora WHERE nome = @nome_produtora;
    IF @id_produtora IS NULL
    BEGIN
        -- Se não existir, inserir nova produtora
        INSERT INTO Streaming_Produtora (nome) VALUES (@nome_produtora);
        SET @id_produtora = SCOPE_IDENTITY();
    END
    -- Inserir conteúdo
    INSERT INTO Streaming_Conteudo (titulo, genero, ano, idade_minima, average_rating, id_produtora)
    VALUES (@titulo, @genero, @ano, @idade_minima, 0, @id_produtora);
    DECLARE @id_conteudo INT = SCOPE_IDENTITY();
    -- Inserir filme
    INSERT INTO Streaming_Filme (id_conteudo, duracao)
    VALUES (@id_conteudo, @duracao);
END
GO
