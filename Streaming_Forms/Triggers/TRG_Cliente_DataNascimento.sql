-- Trigger para impedir inserção de clientes com data de nascimento no futuro
CREATE OR ALTER TRIGGER TRG_Cliente_DataNascimento
ON Streaming_Cliente
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM inserted WHERE data_nascimento > CAST(GETDATE() AS DATE)
    )
    BEGIN
        RAISERROR('A data de nascimento não pode ser no futuro.', 16, 1)
        ROLLBACK TRANSACTION
    END
END
GO
