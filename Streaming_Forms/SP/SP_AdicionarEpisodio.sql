CREATE OR ALTER PROCEDURE SP_AdicionarEpisodio
    @titulo NVARCHAR(200),
    @numero_episodio INT,
    @duracao INT,
    @id_temporada INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Inserir episódio
    INSERT INTO Streaming_Episodio (titulo, numero_episodio, duracao, id_temporada)
    VALUES (@titulo, @numero_episodio, @duracao, @id_temporada);
END
GO
