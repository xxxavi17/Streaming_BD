-- SP_AdicionarRating
CREATE OR ALTER PROCEDURE SP_AdicionarRating
    @id_cliente INT,
    @id_conteudo INT,
    @estrelas INT
AS
BEGIN
    -- Verifica se o cliente existe e tem subscrição ativa
    IF NOT EXISTS (
        SELECT 1 FROM Streaming_Cliente c
        LEFT JOIN (
            SELECT id_cliente, data_fim, ROW_NUMBER() OVER (PARTITION BY id_cliente ORDER BY data_fim DESC) AS rn
            FROM Streaming_Subscricao
        ) s ON c.id_cliente = s.id_cliente AND s.rn = 1
        WHERE c.id_cliente = @id_cliente AND s.data_fim >= CAST(GETDATE() AS DATE)
    )
    BEGIN
        RAISERROR('Cliente não existe ou não tem subscrição ativa.', 16, 1)
        RETURN
    END
    -- Verifica se o conteúdo existe
    IF NOT EXISTS (SELECT 1 FROM Streaming_Conteudo WHERE id_conteudo = @id_conteudo)
    BEGIN
        RAISERROR('Conteúdo não existe.', 16, 1)
        RETURN
    END
    -- Verifica se estrelas está no intervalo correto
    IF @estrelas < 1 OR @estrelas > 5
    BEGIN
        RAISERROR('O rating deve ser um número inteiro entre 1 e 5.', 16, 1)
        RETURN
    END
    -- Tenta inserir (o trigger irá abortar e mostrar mensagem personalizada se já existir rating)
    INSERT INTO Streaming_Rating (id_cliente, id_conteudo, estrelas)
    VALUES (@id_cliente, @id_conteudo, @estrelas)
END
GO
