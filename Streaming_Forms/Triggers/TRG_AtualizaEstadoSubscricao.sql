-- Trigger para atualizar o estado da subscrição automaticamente
CREATE OR ALTER TRIGGER TRG_AtualizaEstadoSubscricao
ON Streaming_Subscricao
AFTER INSERT, UPDATE
AS
BEGIN
    -- Atualiza para 'ativa' se data_fim >= hoje, senão 'inativa'
    UPDATE s
    SET estado = CASE WHEN s.data_fim >= CAST(GETDATE() AS DATE) THEN 'ativa' ELSE 'inativa' END
    FROM Streaming_Subscricao s
    INNER JOIN inserted i ON s.id_sub = i.id_sub
END
GO
