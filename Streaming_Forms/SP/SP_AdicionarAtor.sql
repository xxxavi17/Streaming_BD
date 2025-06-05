CREATE PROCEDURE SP_AdicionarAtor
    @nome NVARCHAR(100),
    @sexo NVARCHAR(20),
    @idade INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Streaming_Ator (nome, sexo, idade)
    VALUES (@nome, @sexo, @idade);

    SELECT SCOPE_IDENTITY(); -- retorna o ID gerado
END;
