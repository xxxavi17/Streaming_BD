-- Stored Procedure para pesquisar séries por título
CREATE OR ALTER PROCEDURE SP_PesquisarSeries
    @pesquisa NVARCHAR(100)
AS
BEGIN
    SELECT
        c.titulo AS serie,
        c.ano AS ano_lancamento,
        p.nome AS produtora,
        COUNT(DISTINCT t.id_temporada) AS numero_temporadas,
        COUNT(e.id_episodio) AS numero_episodios,
        s.id_conteudo AS id_serie
    FROM Streaming_Conteudo c
    INNER JOIN Streaming_Serie s ON c.id_conteudo = s.id_conteudo
    INNER JOIN Streaming_Produtora p ON c.id_produtora = p.id_produtora
    LEFT JOIN Streaming_Temporada t ON s.id_conteudo = t.id_serie
    LEFT JOIN Streaming_Episodio e ON t.id_temporada = e.id_temporada
    WHERE
        (@pesquisa IS NULL OR @pesquisa = '' OR c.titulo LIKE '%' + @pesquisa + '%')
    GROUP BY c.titulo, c.ano, p.nome, s.id_conteudo
    ORDER BY
        CASE WHEN c.titulo LIKE @pesquisa + '%' THEN 0 ELSE 1 END,
        CASE WHEN c.titulo LIKE '%' + @pesquisa + '%' THEN 0 ELSE 1 END,
        c.titulo
END
GO