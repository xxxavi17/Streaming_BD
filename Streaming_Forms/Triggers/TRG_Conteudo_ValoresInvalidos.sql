-- Trigger para impedir valores negativos em ano, idade_minima e duracao ao inserir/atualizar filmes
CREATE OR ALTER TRIGGER TRG_Conteudo_ValoresInvalidos
ON Streaming_Conteudo
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM inserted WHERE ano < 0 OR idade_minima < 0 OR idade_minima > 18
    )
    BEGIN
        RAISERROR('Ano e idade mínima não podem ser negativos e idade mínima não pode ser superior a 18.', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
END
GO

CREATE OR ALTER TRIGGER TRG_Filme_ValoresInvalidos
ON Streaming_Filme
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM inserted WHERE duracao <= 0
    )
    BEGIN
        RAISERROR('A duração do filme não pode ser negativa.', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
END
GO
