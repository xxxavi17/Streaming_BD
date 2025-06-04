CREATE OR ALTER PROCEDURE SP_EditarEpisodio
    @id_episodio INT,
    @titulo NVARCHAR(200),
    @numero_episodio INT,
    @duracao INT
AS
BEGIN
    UPDATE Streaming_Episodio
    SET
        titulo = @titulo,
        numero_episodio = @numero_episodio,
        duracao = @duracao
    WHERE id_episodio = @id_episodio;
END
GO
