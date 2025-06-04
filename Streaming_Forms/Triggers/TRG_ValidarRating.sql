-- Trigger para garantir que o rating está entre 1 e 5 (estrelas inteiras) e abortar update com mensagem personalizada
CREATE OR ALTER TRIGGER TRG_ValidarRating
ON Streaming_Rating
INSTEAD OF INSERT
AS
BEGIN
    -- Validação de intervalo
    IF EXISTS (
        SELECT 1 FROM inserted
        WHERE estrelas < 1 OR estrelas > 5 OR estrelas != FLOOR(estrelas)
    )
    BEGIN
        RAISERROR('O rating deve ser um número inteiro entre 1 e 5.', 16, 1)
        RETURN
    END
    -- Se já existe rating para o mesmo cliente/conteúdo, aborta e mostra mensagem personalizada
    IF EXISTS (
        SELECT 1 FROM inserted i
        JOIN Streaming_Rating r ON r.id_cliente = i.id_cliente AND r.id_conteudo = i.id_conteudo
    )
    BEGIN
        DECLARE @id_cliente INT, @id_conteudo INT, @novo DECIMAL(3,1), @antigo DECIMAL(3,1), @titulo NVARCHAR(200), @msg NVARCHAR(400)
        SELECT TOP 1 @id_cliente = i.id_cliente, @id_conteudo = i.id_conteudo, @novo = CAST(i.estrelas AS DECIMAL(3,1))
        FROM inserted i
        JOIN Streaming_Rating r ON r.id_cliente = i.id_cliente AND r.id_conteudo = i.id_conteudo
        SELECT TOP 1 @antigo = CAST(r.estrelas AS DECIMAL(3,1)) FROM Streaming_Rating r WHERE r.id_cliente = @id_cliente AND r.id_conteudo = @id_conteudo
        SELECT TOP 1 @titulo = titulo FROM Streaming_Conteudo WHERE id_conteudo = @id_conteudo
        SET @msg = N'De certeza que quer atualizar o seu rating ao conteúdo ' + ISNULL(@titulo, '') + ' de ' + FORMAT(@antigo, 'N1') + ' para ' + FORMAT(@novo, 'N1') + ' ?'
        RAISERROR(@msg, 16, 1)
        RETURN
    END
    -- Se não existe, insere normalmente
    INSERT INTO Streaming_Rating (id_cliente, id_conteudo, estrelas)
    SELECT id_cliente, id_conteudo, estrelas FROM inserted
END
GO
