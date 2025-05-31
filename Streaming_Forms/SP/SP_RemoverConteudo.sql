CREATE OR ALTER PROCEDURE SP_RemoverConteudo
    @id_conteudo INT
AS
BEGIN
    -- Remove primeiro de Streaming_Filme (ou outras tabelas filhas)
    DELETE FROM Streaming_Filme WHERE id_conteudo = @id_conteudo;
    -- Depois remove de Streaming_Conteudo
    DELETE FROM Streaming_Conteudo WHERE id_conteudo = @id_conteudo;
END
GO