CREATE OR ALTER PROCEDURE SP_EditarTemporada
    @id_temporada INT,
    @numero_temporada INT,
    @ano INT
AS
BEGIN
    UPDATE Streaming_Temporada
    SET
        numero_temporada = @numero_temporada,
        ano = @ano
    WHERE id_temporada = @id_temporada;
END
GO
