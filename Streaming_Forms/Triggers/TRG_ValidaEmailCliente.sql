-- Trigger para validar email ao inserir ou atualizar cliente
CREATE OR ALTER TRIGGER TRG_ValidaEmailCliente
ON Streaming_Cliente
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM inserted
        WHERE CHARINDEX('@', email) = 0 OR CHARINDEX('.', email) = 0
    )
    BEGIN
        RAISERROR('O email do cliente deve cumprir o formato "nome@email.com"', 16, 1);
        ROLLBACK TRANSACTION;
    END
END
GO
