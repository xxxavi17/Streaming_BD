CREATE OR ALTER PROCEDURE SP_AdicionarTemporada
    @id_serie INT,
    @numero_temporada INT,
    @ano INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id_temporada INT;

    -- Inserir temporada
    INSERT INTO Streaming_Temporada (id_serie, numero_temporada, ano)
    VALUES (@id_serie, @numero_temporada, @ano);

    SET @id_temporada = SCOPE_IDENTITY();

    -- Atualizar a contagem de temporadas na tabela Streaming_Serie
    UPDATE Streaming_Serie
    SET numero_temporadas = (
        SELECT COUNT(*)
        FROM Streaming_Temporada
        WHERE id_serie = @id_serie
    )
    WHERE id_conteudo = @id_serie;

    -- Retornar ID da nova temporada
    SELECT @id_temporada AS id_temporada;
END
GO
