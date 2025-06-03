CREATE OR ALTER PROCEDURE SP_RemoverFilme
    @id_conteudo INT
AS
BEGIN
    -- Só remove se for filme
    IF EXISTS (SELECT 1 FROM Streaming_Filme WHERE id_conteudo = @id_conteudo)
    BEGIN
        DELETE FROM Streaming_Filme WHERE id_conteudo = @id_conteudo;
        DELETE FROM Streaming_Conteudo WHERE id_conteudo = @id_conteudo;
    END
    ELSE
    BEGIN
        RAISERROR('Só é possível remover filmes.', 16, 1);
    END
END
GO