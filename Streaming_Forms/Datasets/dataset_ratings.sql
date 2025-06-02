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