CREATE OR ALTER PROCEDURE SP_RemoverSerie
    @id_serie INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Remover ratings ligados ao conteúdo (série)
    DELETE FROM Streaming_Rating WHERE id_conteudo = @id_serie;

    -- Remover visualizações (caso existam)
    DELETE FROM Streaming_Assiste_Conteudo WHERE id_conteudo = @id_serie;

    -- Remover vínculos com atores
    DELETE FROM Streaming_Conteudo_Ator WHERE id_conteudo = @id_serie;

    -- Remover episódios
    DELETE e
    FROM Streaming_Episodio e
    INNER JOIN Streaming_Temporada t ON e.id_temporada = t.id_temporada
    WHERE t.id_serie = @id_serie;

    -- Remover temporadas
    DELETE FROM Streaming_Temporada WHERE id_serie = @id_serie;

    -- Remover série
    DELETE FROM Streaming_Serie WHERE id_conteudo = @id_serie;

    -- Remover conteúdo
    DELETE FROM Streaming_Conteudo WHERE id_conteudo = @id_serie;
END
GO
