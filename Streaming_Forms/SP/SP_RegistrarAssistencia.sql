CREATE PROCEDURE SP_RegistrarAssistencia
    @id_cliente INT,
    @id_conteudo INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Verifica se já existe o registro
    IF EXISTS (
        SELECT 1 FROM Streaming_Assiste_Conteudo
        WHERE id_cliente = @id_cliente AND id_conteudo = @id_conteudo
    )
    BEGIN
        -- Atualiza a data para a data atual, caso já exista
        UPDATE Streaming_Assiste_Conteudo
        SET data = GETDATE()
        WHERE id_cliente = @id_cliente AND id_conteudo = @id_conteudo;
    END
    ELSE
    BEGIN
        -- Insere novo registro de assistencia
        INSERT INTO Streaming_Assiste_Conteudo (id_cliente, id_conteudo, data)
        VALUES (@id_cliente, @id_conteudo, GETDATE());
    END
END;
