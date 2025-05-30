-- Stored Procedure para adicionar um cliente
CREATE OR ALTER PROCEDURE SP_AdicionarCliente
    @nome NVARCHAR(100),
    @email NVARCHAR(100),
    @data_nascimento DATE,
    @sexo CHAR(1)
AS
BEGIN
    INSERT INTO Streaming_Cliente (nome, email, data_nascimento, sexo)
    VALUES (@nome, @email, @data_nascimento, @sexo)
    
    -- Retorna o id_cliente inserido
    SELECT SCOPE_IDENTITY() AS id_cliente;
END
GO
