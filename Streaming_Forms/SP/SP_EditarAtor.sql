CREATE OR ALTER PROCEDURE SP_EditarAtor
    @id_ator INT,
    @novo_nome VARCHAR(100),
    @novo_sexo CHAR(1),
    @nova_idade INT
AS
BEGIN
    UPDATE Streaming_Ator
    SET nome = @novo_nome,
        sexo = @novo_sexo,
        idade = @nova_idade
    WHERE id_ator = @id_ator;
END
