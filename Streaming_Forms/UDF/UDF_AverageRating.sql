-- UDF para calcular a média de ratings de um conteúdo
CREATE OR ALTER FUNCTION dbo.UDF_AverageRating (@id_conteudo INT)
RETURNS DECIMAL(3,1)
AS
BEGIN
    DECLARE @media DECIMAL(3,1)
    SELECT @media = CAST(AVG(CAST(estrelas AS FLOAT)) AS DECIMAL(3,1))
    FROM Streaming_Rating
    WHERE id_conteudo = @id_conteudo
    RETURN @media
END
GO
