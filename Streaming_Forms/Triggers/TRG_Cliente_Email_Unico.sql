-- Trigger para garantir unicidade do email na tabela Streaming_Cliente
CREATE TRIGGER TRG_Cliente_Email_Unico
ON Streaming_Cliente
INSTEAD OF INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM Streaming_Cliente c
        JOIN inserted i ON c.email = i.email
    )
    BEGIN
        RAISERROR ('Já existe um utilizador com esse email.', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
    ELSE
    BEGIN
        INSERT INTO Streaming_Cliente (nome, email, data_nascimento, sexo)
        SELECT nome, email, data_nascimento, sexo FROM inserted
    END
END
GO
