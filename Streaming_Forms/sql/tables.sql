-- DROP TABLES EM ORDEM CORRETA (considerando dependências)
DROP TABLE IF EXISTS Streaming_Rating;
DROP TABLE IF EXISTS Streaming_Assiste_Conteudo;
DROP TABLE IF EXISTS Streaming_Conteudo_Ator;
DROP TABLE IF EXISTS Streaming_Episodio;
DROP TABLE IF EXISTS Streaming_Temporada;
DROP TABLE IF EXISTS Streaming_Serie;
DROP TABLE IF EXISTS Streaming_Filme;
DROP TABLE IF EXISTS Streaming_Conteudo;
DROP TABLE IF EXISTS Streaming_Ator;
DROP TABLE IF EXISTS Streaming_Subscricao;
DROP TABLE IF EXISTS Streaming_Cliente;
DROP TABLE IF EXISTS Streaming_Produtora;

-- 1. PRODUTORA
CREATE TABLE Streaming_Produtora (
    id_produtora INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL
);

-- 2. CLIENTE
CREATE TABLE Streaming_Cliente (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    data_nascimento DATE,
    sexo CHAR(1) CHECK (sexo IN ('M', 'F'))
);

-- 3. SUBSCRICAO
CREATE TABLE Streaming_Subscricao (
    id_sub INT IDENTITY(1,1) PRIMARY KEY,
    tipo_sub VARCHAR(50) NOT NULL,
    estado VARCHAR(20) CHECK (estado IN ('ativa', 'inativa')) NOT NULL,
    duracao_meses INT CHECK (duracao_meses >= 0) NOT NULL,
    data_inicio DATE NULL,
    data_fim DATE NULL,
    id_cliente INT NOT NULL,
    FOREIGN KEY (id_cliente) REFERENCES Streaming_Cliente(id_cliente)
);


-- 4. ATOR
CREATE TABLE Streaming_Ator (
    id_ator INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    sexo CHAR(1) CHECK (sexo IN ('M', 'F')),
    idade INT
);

-- 5. CONTEUDO
CREATE TABLE Streaming_Conteudo (
    id_conteudo INT IDENTITY(1,1) PRIMARY KEY,
    titulo VARCHAR(200) NOT NULL,
    genero VARCHAR(50),
    ano INT,
    idade_minima INT,
    average_rating DECIMAL(2,1) CHECK (average_rating BETWEEN 0.0 AND 5.0),
    id_produtora INT NOT NULL,
    FOREIGN KEY (id_produtora) REFERENCES Streaming_Produtora(id_produtora)
);

-- 6. FILME
CREATE TABLE Streaming_Filme (
    id_conteudo INT PRIMARY KEY,
    duracao INT,
    FOREIGN KEY (id_conteudo) REFERENCES Streaming_Conteudo(id_conteudo)
);

-- 7. SERIE
CREATE TABLE Streaming_Serie (
    id_conteudo INT PRIMARY KEY,
    numero_temporadas INT CHECK (numero_temporadas >= 1),
    FOREIGN KEY (id_conteudo) REFERENCES Streaming_Conteudo(id_conteudo)
);

-- 8. TEMPORADA
CREATE TABLE Streaming_Temporada (
    id_temporada INT IDENTITY(1,1) PRIMARY KEY,
    numero_temporada INT NOT NULL,
    ano INT,
    id_serie INT NOT NULL,
    FOREIGN KEY (id_serie) REFERENCES Streaming_Serie(id_conteudo)
);

-- 9. EPISODIO
CREATE TABLE Streaming_Episodio (
    id_episodio INT IDENTITY(1,1) PRIMARY KEY,
    titulo VARCHAR(200) NOT NULL,
    numero_episodio INT,
    duracao INT,
    id_temporada INT NOT NULL,
    FOREIGN KEY (id_temporada) REFERENCES Streaming_Temporada(id_temporada)
);

-- 10. RELAÇÃO CONTEUDO - ATOR (N:N)
CREATE TABLE Streaming_Conteudo_Ator (
    id_conteudo INT,
    id_ator INT,
    PRIMARY KEY (id_conteudo, id_ator),
    FOREIGN KEY (id_conteudo) REFERENCES Streaming_Conteudo(id_conteudo),
    FOREIGN KEY (id_ator) REFERENCES Streaming_Ator(id_ator)
);

-- 11. ASSISTE CONTEUDO
CREATE TABLE Streaming_Assiste_Conteudo (
    id_cliente INT,
    id_conteudo INT,
    data DATE DEFAULT GETDATE(),
    PRIMARY KEY (id_cliente, id_conteudo),
    FOREIGN KEY (id_cliente) REFERENCES Streaming_Cliente(id_cliente),
    FOREIGN KEY (id_conteudo) REFERENCES Streaming_Conteudo(id_conteudo)
);

-- 12. RATING
CREATE TABLE Streaming_Rating (
    id_rating INT IDENTITY(1,1) PRIMARY KEY,
    estrelas INT CHECK (estrelas BETWEEN 1 AND 5),
    data DATE DEFAULT GETDATE(),
    id_cliente INT NOT NULL,
    id_conteudo INT NOT NULL,
    FOREIGN KEY (id_cliente) REFERENCES Streaming_Cliente(id_cliente),
    FOREIGN KEY (id_conteudo) REFERENCES Streaming_Conteudo(id_conteudo)
);

-- 13. AUTENTICAÇÃO DO CLIENTE
CREATE TABLE Streaming_Cliente_Auth (
    id_cliente INT PRIMARY KEY,
    password_hash VARCHAR(256) NOT NULL,
    FOREIGN KEY (id_cliente) REFERENCES Streaming_Cliente(id_cliente)
);
