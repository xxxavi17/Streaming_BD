-- Trigger para atualizar o average_rating em Streaming_Conteudo após inserção, atualização ou remoção de rating
-- Este trigger aplica-se a TODOS os conteúdos (filmes e séries), pois todos estão em Streaming_Conteudo
CREATE OR ALTER TRIGGER TRG_AtualizarAverageRating
ON Streaming_Rating
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    -- Atualiza o average_rating para todos os conteúdos afetados (filmes e séries)
    UPDATE c
    SET c.average_rating = CAST(
        (SELECT AVG(CAST(r.estrelas AS FLOAT)) FROM Streaming_Rating r WHERE r.id_conteudo = c.id_conteudo)
        AS DECIMAL(2,1))
    FROM Streaming_Conteudo c
    WHERE c.id_conteudo IN (
        SELECT id_conteudo FROM inserted
        UNION
        SELECT id_conteudo FROM deleted
    );
END
GO
