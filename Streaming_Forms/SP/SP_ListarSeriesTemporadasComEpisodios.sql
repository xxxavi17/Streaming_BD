CREATE OR ALTER PROCEDURE SP_ListarSeriesTemporadasComEpisodios
AS
BEGIN
    SELECT
        t.id_temporada,
        s.id_conteudo AS id_serie,
        c.titulo AS serie,
        t.numero_temporada,
        t.ano,
        COUNT(e.id_episodio) AS numero_episodios
    FROM Streaming_Conteudo c
    INNER JOIN Streaming_Serie s ON c.id_conteudo = s.id_conteudo
    INNER JOIN Streaming_Temporada t ON s.id_conteudo = t.id_serie
    LEFT JOIN Streaming_Episodio e ON t.id_temporada = e.id_temporada
    GROUP BY t.id_temporada, s.id_conteudo, c.titulo, t.numero_temporada, t.ano
    ORDER BY c.titulo, t.numero_temporada;
END
GO
