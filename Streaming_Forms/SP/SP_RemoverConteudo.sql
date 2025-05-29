-- Stored Procedure para remover conteúdo
CREATE PROCEDURE SP_RemoverConteudo
    @id_conteudo INT
AS
BEGIN
    DELETE FROM Streaming_Conteudo WHERE id_conteudo = @id_conteudo
END
GO
