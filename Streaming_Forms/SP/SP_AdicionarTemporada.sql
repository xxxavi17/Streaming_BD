CREATE OR ALTER PROCEDURE SP_AdicionarTemporada
    @id_serie INT,
    @numero_temporada INT,
    @ano INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Inserir temporada (o trigger fará a validação e inserção real)
    INSERT INTO Streaming_Temporada (id_serie, numero_temporada, ano)
    VALUES (@id_serie, @numero_temporada, @ano);

    DECLARE @id_temporada INT;

    -- Buscar o ID da temporada recém-criada
    SELECT TOP 1 @id_temporada = id_temporada
    FROM Streaming_Temporada
    WHERE id_serie = @id_serie AND numero_temporada = @numero_temporada
    ORDER BY id_temporada DESC;

    -- Atualizar o número de temporadas na série
    UPDATE Streaming_Serie
    SET numero_temporadas = (
        SELECT COUNT(*) FROM Streaming_Temporada WHERE id_serie = @id_serie
    )
    WHERE id_conteudo = @id_serie;

    -- Retornar o ID da nova temporada
    SELECT @id_temporada AS id_temporada;
END
GO