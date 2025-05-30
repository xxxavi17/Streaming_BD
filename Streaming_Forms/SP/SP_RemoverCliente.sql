-- Stored Procedure para remover um cliente
CREATE OR ALTER PROCEDURE SP_RemoverCliente
    @id_cliente INT
AS
BEGIN
    DELETE FROM Streaming_Cliente WHERE id_cliente = @id_cliente
END
GO
