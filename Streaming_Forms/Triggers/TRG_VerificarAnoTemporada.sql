CREATE OR ALTER TRIGGER TRG_VerificarAnoTemporada
ON Streaming_Temporada
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @erro NVARCHAR(MAX) = '';

    DECLARE cur CURSOR FOR
        SELECT id_serie, numero_temporada, ano
        FROM inserted;

    DECLARE @id_serie INT, @numero_temporada INT, @ano INT;

    OPEN cur;
    FETCH NEXT FROM cur INTO @id_serie, @numero_temporada, @ano;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        DECLARE @ano_serie INT;
        SELECT @ano_serie = ano
        FROM Streaming_Conteudo
        WHERE id_conteudo = @id_serie;

        -- Validação de existência da série
        IF @ano_serie IS NULL
        BEGIN
            SET @erro += FORMATMESSAGE('Conteúdo com id %d não encontrado para a série.%s', @id_serie, CHAR(13));
        END
        ELSE
        BEGIN
            -- Validação do ano da temporada vs ano da série
            IF @ano < @ano_serie
            BEGIN
                SET @erro += FORMATMESSAGE('Ano da temporada (%d) não pode ser menor que o ano da série (%d).%s', @ano, @ano_serie, CHAR(13));
            END

            -- Verificação da ordem cronológica entre temporadas
            DECLARE @ano_max_temporada_anterior INT;
            SELECT @ano_max_temporada_anterior = MAX(ano)
            FROM Streaming_Temporada
            WHERE id_serie = @id_serie AND numero_temporada < @numero_temporada;

            IF @ano_max_temporada_anterior IS NOT NULL AND @ano < @ano_max_temporada_anterior
            BEGIN
                SET @erro += FORMATMESSAGE('Ano da temporada %d (%d) não pode ser menor que o da anterior (%d).%s', 
                    @numero_temporada, @ano, @ano_max_temporada_anterior, CHAR(13));
            END
        END

        FETCH NEXT FROM cur INTO @id_serie, @numero_temporada, @ano;
    END

    CLOSE cur;
    DEALLOCATE cur;

    -- Se houve erro, cancelar
    IF @erro <> ''
    BEGIN
        RAISERROR(@erro, 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    -- Inserir se tudo estiver válido
    INSERT INTO Streaming_Temporada (id_serie, numero_temporada, ano)
    SELECT id_serie, numero_temporada, ano
    FROM inserted;
END
GO
