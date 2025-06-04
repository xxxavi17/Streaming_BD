CREATE OR ALTER PROCEDURE SP_ListarSeriesTemporadasComEpisodios
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
    GROUP BY c.titulo, c.ano, p.nome, s.id_conteudo
    ORDER BY c.titulo;
END
GO
