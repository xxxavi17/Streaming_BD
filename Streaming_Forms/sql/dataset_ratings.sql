-- Dataset de ratings aleatórios para clientes e filmes
-- Clientes:
-- 33 Xavier
-- 37 Bruna
-- 38 Marta
-- 39 Cristiano Ronaldo
-- 40 ALEO
-- Filmes:
-- 1 Toy Story 1
-- 2 Top Gun: Maverick
-- 3 Cars 1

-- Ratings aleatórios (estrelas entre 1 e 5)
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 33, 1);
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 33, 2);
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 33, 3);
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 37, 1);
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 37, 2);
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 37, 3);
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 38, 1);
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 38, 2);
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 38, 3);
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 39, 1);
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 39, 2);
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 39, 3);
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 40, 1);
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 40, 2);
INSERT INTO Streaming_Rating (estrelas, id_cliente, id_conteudo) VALUES (ROUND(RAND(CHECKSUM(NEWID()))*4+1,0), 40, 3);

-- Atualizar o average_rating de cada filme
UPDATE Streaming_Conteudo
SET average_rating = (
    SELECT CAST(AVG(CAST(estrelas AS FLOAT)) AS DECIMAL(2,1))
    FROM Streaming_Rating r
    WHERE r.id_conteudo = Streaming_Conteudo.id_conteudo
)
WHERE id_conteudo IN (1,2,3);
