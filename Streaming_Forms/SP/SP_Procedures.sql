-- Stored Procedure para adicionar um cliente
CREATE PROCEDURE SP_AdicionarCliente
    @nome NVARCHAR(100),
    @email NVARCHAR(100),
    @data_nascimento DATE,
    @sexo NVARCHAR(10)
AS
BEGIN
    INSERT INTO Streaming_Cliente (nome, email, data_nascimento, sexo)
    VALUES (@nome, @email, @data_nascimento, @sexo)
END
GO

-- Stored Procedure para remover um cliente
CREATE PROCEDURE SP_RemoverCliente
    @id_cliente INT
AS
BEGIN
    DELETE FROM Streaming_Cliente WHERE id_cliente = @id_cliente
END
GO

-- Stored Procedure para adicionar conteúdo
CREATE PROCEDURE SP_AdicionarConteudo
    @titulo NVARCHAR(200),
    @genero NVARCHAR(50),
    @ano INT,
    @idade_minima INT,
    @average_rating FLOAT,
    @id_produtora INT
AS
BEGIN
    INSERT INTO Streaming_Conteudo (titulo, genero, ano, idade_minima, average_rating, id_produtora)
    VALUES (@titulo, @genero, @ano, @idade_minima, @average_rating, @id_produtora)
END
GO

-- Stored Procedure para remover conteúdo
CREATE PROCEDURE SP_RemoverConteudo
    @id_conteudo INT
AS
BEGIN
    DELETE FROM Streaming_Conteudo WHERE id_conteudo = @id_conteudo
END
GO

-- Stored Procedure para ver subscrição de um cliente
CREATE PROCEDURE SP_VerSubscricaoCliente
    @id_cliente INT
AS
BEGIN
    SELECT * FROM Streaming_Subscricao WHERE id_cliente = @id_cliente
END
GO

-- Stored Procedure para ver informações de um conteúdo
CREATE PROCEDURE SP_VerInfoConteudo
    @id_conteudo INT
AS
BEGIN
    SELECT * FROM Streaming_Conteudo WHERE id_conteudo = @id_conteudo
END
GO
