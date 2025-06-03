-- Stored Procedure para filtrar filmes por género
CREATE OR ALTER PROCEDURE SP_FiltrarFilmesPorGenero
    @genero NVARCHAR(50) = NULL
AS
BEGIN
    SELECT c.id_conteudo, c.titulo, p.nome AS produtora, c.genero, c.ano,
           dbo.UDF_AverageRating(c.id_conteudo) AS average_rating, f.duracao
    FROM Streaming_Conteudo c
    INNER JOIN Streaming_Filme f ON c.id_conteudo = f.id_conteudo
    INNER JOIN Streaming_Produtora p ON c.id_produtora = p.id_produtora
    WHERE (@genero IS NULL OR c.genero = @genero)
END
GO
