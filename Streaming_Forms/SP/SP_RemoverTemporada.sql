CREATE OR ALTER PROCEDURE SP_RemoverTemporada
    @id_temporada INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id_serie INT;

    -- Obter id da série
    SELECT @id_serie = id_serie
    FROM Streaming_Temporada
    WHERE id_temporada = @id_temporada;

    -- Remover episódios da temporada
    DELETE FROM Streaming_Episodio
    WHERE id_temporada = @id_temporada;

    -- Remover a temporada
    DELETE FROM Streaming_Temporada
    WHERE id_temporada = @id_temporada;

    -- Verificar se ainda restam temporadas na série
    IF NOT EXISTS (
        SELECT 1 FROM Streaming_Temporada WHERE id_serie = @id_serie
    )
    BEGIN
        -- Remover a série e o conteúdo associado
        DELETE FROM Streaming_Serie WHERE id_conteudo = @id_serie;
        DELETE FROM Streaming_Conteudo WHERE id_conteudo = @id_serie;
        RETURN;
    END

    -- Caso contrário, atualizar número de temporadas
    UPDATE Streaming_Serie
    SET numero_temporadas = (
        SELECT COUNT(*) FROM Streaming_Temporada WHERE id_serie = @id_serie
    )
    WHERE id_conteudo = @id_serie;
END
GO
