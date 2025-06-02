-- Corrige a stored procedure para garantir que o estado nunca é vazio e respeita o CHECK constraint
CREATE OR ALTER PROCEDURE SP_EditarCliente
    @id_cliente INT,
    @novo_email NVARCHAR(100),
    @novo_tipo_sub NVARCHAR(50),
    @novo_estado NVARCHAR(20),
    @nova_duracao INT = 0
AS
BEGIN
    -- Atualiza email do cliente
    UPDATE Streaming_Cliente
    SET email = @novo_email
    WHERE id_cliente = @id_cliente;

    -- Se "Sem Subscrição" for selecionado, termina TODAS as subscrições do cliente
    IF @novo_tipo_sub = 'Sem Subscrição'
    BEGIN
        UPDATE Streaming_Subscricao
        SET estado = 'inativa', tipo_sub = @novo_tipo_sub, data_inicio = NULL, data_fim = NULL
        WHERE id_cliente = @id_cliente;
    END
    ELSE
    BEGIN
        -- Garante que o estado é válido
        DECLARE @estadoValido NVARCHAR(20) = CASE WHEN @novo_estado IN ('ativa', 'inativa') THEN @novo_estado ELSE 'ativa' END;
        -- Atualiza tipo_sub e estado, e data_fim se fornecido
        UPDATE Streaming_Subscricao
        SET tipo_sub = @novo_tipo_sub,
            estado = @estadoValido,
            data_inicio = GETDATE(),
            data_fim = CASE WHEN @nova_duracao > 0 THEN DATEADD(MONTH, @nova_duracao, GETDATE()) ELSE data_fim END,
            duracao_meses = @nova_duracao
        WHERE id_cliente = @id_cliente;
    END
END
GO
