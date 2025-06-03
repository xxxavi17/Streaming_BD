-- Stored Procedure para filtrar filmes por género e produtora
CREATE OR ALTER PROCEDURE SP_FiltrarFilmesPorGeneroEProdutora
    @genero NVARCHAR(50) = NULL,
    @produtora NVARCHAR(100) = NULL
AS
BEGIN
    SELECT c.id_conteudo, c.titulo, p.nome AS produtora, c.genero, c.ano,
           dbo.UDF_AverageRating(c.id_conteudo) AS average_rating, f.duracao
    FROM Streaming_Conteudo c
    INNER JOIN Streaming_Filme f ON c.id_conteudo = f.id_conteudo
    INNER JOIN Streaming_Produtora p ON c.id_produtora = p.id_produtora
    WHERE
        (@genero IS NULL OR @genero = 'Todos' OR c.genero = @genero)
        AND (@produtora IS NULL OR @produtora = 'Todos' OR p.nome = @produtora)
END
GO
