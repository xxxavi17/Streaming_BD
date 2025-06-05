CREATE OR ALTER PROCEDURE SP_AdicionarSerie
    @titulo NVARCHAR(200),
    @genero NVARCHAR(50),
    @ano INT,
    @idade_minima INT,
    @nome_produtora NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id_produtora INT;
    DECLARE @id_conteudo INT;

    -- ❌ Verificar se já existe uma série com esse título (ignora maiúsculas/minúsculas)
    IF EXISTS (
        SELECT 1
        FROM Streaming_Conteudo c
        INNER JOIN Streaming_Serie s ON c.id_conteudo = s.id_conteudo
        WHERE LOWER(c.titulo) = LOWER(@titulo)
    )
    BEGIN
        RAISERROR('Já existe uma série com esse título.', 16, 1);
        RETURN;
    END

    -- 🔍 Buscar ou inserir produtora
    SELECT @id_produtora = id_produtora
    FROM Streaming_Produtora
    WHERE nome = @nome_produtora;

    IF @id_produtora IS NULL
    BEGIN
        INSERT INTO Streaming_Produtora (nome)
        VALUES (@nome_produtora);

        SET @id_produtora = SCOPE_IDENTITY();
    END

    -- ✅ Inserir conteúdo
    INSERT INTO Streaming_Conteudo (titulo, genero, ano, idade_minima, average_rating, id_produtora)
    VALUES (@titulo, @genero, @ano, @idade_minima, 0.0, @id_produtora);

    SET @id_conteudo = SCOPE_IDENTITY();

    -- ✅ Inserir série com 1 temporada
    INSERT INTO Streaming_Serie (id_conteudo, numero_temporadas)
    VALUES (@id_conteudo, 1);

    -- ✅ Inserir Temporada 1 automaticamente
    -- INSERT INTO Streaming_Temporada (id_serie, numero_temporada, ano)
    -- VALUES (@id_conteudo, 1, @ano);

    -- 📤 Retornar o ID da série
    SELECT @id_conteudo AS id_serie;
END
GO
