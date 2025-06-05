CREATE OR ALTER PROCEDURE SP_ObterAtoresFiltrados
    @sexo NVARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        a.id_ator,
        a.nome,
        a.sexo,
        a.idade,
        STRING_AGG(c.titulo, ', ') AS conteudos
    FROM 
        Streaming_Ator a
    LEFT JOIN 
        Streaming_Conteudo_Ator ca ON a.id_ator = ca.id_ator
    LEFT JOIN 
        Streaming_Conteudo c ON ca.id_conteudo = c.id_conteudo
    WHERE 
        @sexo IS NULL OR a.sexo = @sexo
    GROUP BY 
        a.id_ator, a.nome, a.sexo, a.idade
END
