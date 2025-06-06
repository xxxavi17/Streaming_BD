-- Stored Procedure para pesquisar filmes por texto (título, produtora, género, ano)
CREATE OR ALTER PROCEDURE SP_PesquisarFilmes
    @pesquisa NVARCHAR(100),
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
        AND (
            @pesquisa IS NULL OR @pesquisa = ''
            OR c.titulo LIKE '%' + @pesquisa + '%'
            OR p.nome LIKE '%' + @pesquisa + '%'
            OR c.genero LIKE '%' + @pesquisa + '%'
            OR CAST(c.ano AS NVARCHAR) LIKE '%' + @pesquisa + '%'
        )
    ORDER BY
        CASE WHEN c.titulo LIKE @pesquisa + '%' THEN 0 ELSE 1 END, -- Começa pelo mais parecido
        CASE WHEN c.titulo LIKE '%' + @pesquisa + '%' THEN 0 ELSE 1 END,
        c.titulo
END
GO
