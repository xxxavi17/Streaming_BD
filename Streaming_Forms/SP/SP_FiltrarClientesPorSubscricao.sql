-- Stored Procedure para filtrar clientes por tipo de subscrição
CREATE OR ALTER PROCEDURE SP_FiltrarClientesPorSubscricao
    @tipo_sub NVARCHAR(50) = NULL
AS
BEGIN
    SELECT c.id_cliente, c.nome, c.email, c.data_nascimento, c.sexo,
           ISNULL(s.tipo_sub, 'Sem Subscrição') AS [Tipo Subscrição],
           CASE 
               WHEN s.data_fim IS NULL THEN 'Inativo'
               WHEN s.data_fim >= CAST(GETDATE() AS DATE) THEN 'Ativo'
               ELSE 'Inativo'
           END AS [Estado]
    FROM Streaming_Cliente c
    LEFT JOIN (
        SELECT *, ROW_NUMBER() OVER (PARTITION BY id_cliente ORDER BY data_fim DESC) AS rn
        FROM Streaming_Subscricao
    ) s ON c.id_cliente = s.id_cliente AND s.rn = 1
    WHERE (@tipo_sub IS NULL OR @tipo_sub = 'Todos' OR ISNULL(s.tipo_sub, 'Sem Subscrição') = @tipo_sub)
END
GO
