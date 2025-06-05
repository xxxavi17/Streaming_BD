CREATE PROCEDURE SP_RemoverAtor
    @id_ator INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Remove todas as associações com conteúdos
    DELETE FROM Streaming_Conteudo_Ator
    WHERE id_ator = @id_ator;

    -- Em seguida, remove o ator
    DELETE FROM Streaming_Ator
    WHERE id_ator = @id_ator;
END;
