CREATE TABLE TIPO_EVENTO 
(
    ID SERIAL PRIMARY KEY,
    DESCRICAO VARCHAR (500)
);

CREATE TABLE EVENTO
(
    ID SERIAL PRIMARY KEY, 
    NOME VARCHAR(200),
    DESCRICAO VARCHAR(500),
    TIPOEVENTO_ID INT REFERENCES TIPO_EVENTO(ID)
);

CREATE TABLE PAIS
(
    ID SERIAL PRIMARY KEY,
    DESCRICAO VARCHAR (200),
    CODIGO_IBGE INT
);

CREATE TABLE UF
(
    ID SERIAL PRIMARY KEY,
    DESCRICAO VARCHAR(200),
    CODIGO_IBGE INT,
    PAIS_ID INT REFERENCES PAIS(ID)
);

CREATE TABLE CIDADE 
(
    ID SERIAL PRIMARY KEY,
    DESCRICAO VARCHAR(200),
    CODIGO_IBGE INT,
    UF_ID INT REFERENCES UF(ID)
);

CREATE TABLE LOCAL
(
    ID SERIAL PRIMARY KEY, 
    NOME VARCHAR(200),
    CAPACIDADE INT,
    ENDERECO VARCHAR(200),
    OBSERVACOES VARCHAR(200),
    CIDADE_ID INT REFERENCES CIDADE(ID)
);


CREATE TABLE SESSAO
(
    ID SERIAL PRIMARY KEY, 
    DATA_INICIO DATE,
    DATA_FIM DATE,
    EVENTO_ID INT REFERENCES EVENTO(ID),
    LOCAL_ID INT REFERENCES LOCAL(ID)
);

CREATE TABLE PAPEL 
(
    ID SERIAL PRIMARY KEY, 
    DESCRICAO VARCHAR(100)
);

CREATE TABLE PESSOA 
(
    ID SERIAL PRIMARY KEY,
    NOME VARCHAR(200),
    CPF VARCHAR(10),
    TIPOPESSOA INT
);

CREATE TABLE USUARIO
(
    ID SERIAL PRIMARY KEY,
    NOME VARCHAR(200),
    EMAIL VARCHAR(100),
    SENHA VARCHAR (100),
    PESSOA_ID INT REFERENCES PESSOA(ID)
);

CREATE TABLE USUARIO_PAPEL
(
	USUARIO_ID INT REFERENCES USUARIO(ID),
	PAPEL_ID INT REFERENCES PAPEL(ID),
	PRIMARY KEY (USUARIO_ID, PAPEL_ID)
);

CREATE TABLE EVENTO_ORGANIZADORES
(
    EVENTO_ID INT REFERENCES EVENTO(ID),
    PESSOA_ID INT REFERENCES PESSOA(ID),
	PRIMARY KEY(EVENTO_ID, PESSOA_ID)
);

CREATE TABLE SESSAO_INTEGRANTES
(
    SESSAO_ID INT REFERENCES SESSAO(ID),
    PESSOA_ID INT REFERENCES PESSOA(ID),
	PRIMARY KEY(SESSAO_ID, PESSOA_ID)
);

CREATE TABLE AVALIACAO 
(
    ID SERIAL PRIMARY KEY, 
    COMENTARIO VARCHAR(500),
    NOTA INT,
    PESSOA_ID INT REFERENCES PESSOA(ID),
    SESSAO_ID INT REFERENCES SESSAO(ID)
);

-- Inserção na tabela PAIS e captura dos IDs
WITH pais_ids AS (
    INSERT INTO PAIS (DESCRICAO, CODIGO_IBGE) 
    VALUES 
        ('Brasil', 1058),
        ('Argentina', 1059),
        ('Estados Unidos', 1060)
    RETURNING ID, DESCRICAO
),

-- Inserção na tabela UF usando os IDs de PAIS
uf_ids AS (
    INSERT INTO UF (DESCRICAO, CODIGO_IBGE, PAIS_ID) 
    VALUES 
        ('São Paulo', 3550308, (SELECT ID FROM pais_ids WHERE DESCRICAO = 'Brasil')),
        ('Rio de Janeiro', 3304557, (SELECT ID FROM pais_ids WHERE DESCRICAO = 'Brasil')),
        ('Buenos Aires', 1007, (SELECT ID FROM pais_ids WHERE DESCRICAO = 'Argentina')),
        ('California', 1008, (SELECT ID FROM pais_ids WHERE DESCRICAO = 'Estados Unidos'))
    RETURNING ID, DESCRICAO
),

-- Inserção na tabela CIDADE usando os IDs de UF
cidade_ids AS (
    INSERT INTO CIDADE (DESCRICAO, CODIGO_IBGE, UF_ID) 
    VALUES 
        ('São Paulo', 3550308, (SELECT ID FROM uf_ids WHERE DESCRICAO = 'São Paulo')),
        ('Rio de Janeiro', 3304557, (SELECT ID FROM uf_ids WHERE DESCRICAO = 'Rio de Janeiro')),
        ('Buenos Aires', 1007, (SELECT ID FROM uf_ids WHERE DESCRICAO = 'Buenos Aires')),
        ('Los Angeles', 1009, (SELECT ID FROM uf_ids WHERE DESCRICAO = 'California'))
    RETURNING ID, DESCRICAO
),

-- Inserção na tabela TIPO_EVENTO
tipo_evento_ids AS (
    INSERT INTO TIPO_EVENTO (DESCRICAO) 
    VALUES 
        ('Conferência'),
        ('Seminário'),
        ('Workshop')
    RETURNING ID, DESCRICAO
),

-- Inserção na tabela EVENTO usando os IDs de TIPO_EVENTO
evento_ids AS (
    INSERT INTO EVENTO (NOME, DESCRICAO, TIPOEVENTO_ID) 
    VALUES 
        ('Tech Conference 2024', 'Conferência sobre tecnologia', (SELECT ID FROM tipo_evento_ids WHERE DESCRICAO = 'Conferência')),
        ('Business Seminar 2024', 'Seminário sobre negócios', (SELECT ID FROM tipo_evento_ids WHERE DESCRICAO = 'Seminário')),
        ('Creative Workshop 2024', 'Workshop sobre criatividade', (SELECT ID FROM tipo_evento_ids WHERE DESCRICAO = 'Workshop'))
    RETURNING ID, NOME
),

-- Inserção na tabela LOCAL usando os IDs de CIDADE
local_ids AS (
    INSERT INTO LOCAL (NOME, CAPACIDADE, ENDERECO, OBSERVACOES, CIDADE_ID) 
    VALUES 
        ('Centro de Convenções SP', 1000, 'Avenida Paulista, 1000', 'Perto do metrô', (SELECT ID FROM cidade_ids WHERE DESCRICAO = 'São Paulo')),
        ('Auditório RJ', 500, 'Rua das Laranjeiras, 200', 'Estacionamento disponível', (SELECT ID FROM cidade_ids WHERE DESCRICAO = 'Rio de Janeiro')),
        ('Centro Cultural BA', 700, 'Calle Corrientes, 500', 'Próximo ao teatro', (SELECT ID FROM cidade_ids WHERE DESCRICAO = 'Buenos Aires')),
        ('Hollywood Hall', 1500, 'Sunset Blvd, 800', 'Área VIP disponível', (SELECT ID FROM cidade_ids WHERE DESCRICAO = 'Los Angeles'))
    RETURNING ID, NOME
),

-- Inserção na tabela SESSAO usando os IDs de EVENTO e LOCAL
sessao_ids AS (
    INSERT INTO SESSAO (DATA_INICIO, DATA_FIM, EVENTO_ID, LOCAL_ID) 
    VALUES 
        ('2024-06-01', '2024-06-03', (SELECT ID FROM evento_ids WHERE NOME = 'Tech Conference 2024'), (SELECT ID FROM local_ids WHERE NOME = 'Centro de Convenções SP')),
        ('2024-07-15', '2024-07-17', (SELECT ID FROM evento_ids WHERE NOME = 'Business Seminar 2024'), (SELECT ID FROM local_ids WHERE NOME = 'Auditório RJ')),
        ('2024-08-20', '2024-08-21', (SELECT ID FROM evento_ids WHERE NOME = 'Creative Workshop 2024'), (SELECT ID FROM local_ids WHERE NOME = 'Centro Cultural BA'))
    RETURNING ID
),

-- Inserção na tabela PESSOA
pessoa_ids AS (
    INSERT INTO PESSOA (NOME, CPF, TIPOPESSOA) 
    VALUES 
        ('João Silva', '123456789', 0),
        ('Maria Souza', '234567891', 2),
        ('Carlos Pereira', '34567891', 1),
        ('Ana Oliveira', '456789101', 2)
    RETURNING ID, NOME
),

-- Inserção na tabela EVENTO_ORGANIZADORES usando os IDs de EVENTO e PESSOA
evento_organizadores_ids AS (
    INSERT INTO EVENTO_ORGANIZADORES (EVENTO_ID, PESSOA_ID) 
    VALUES 
        ((SELECT ID FROM evento_ids WHERE NOME = 'Tech Conference 2024'), (SELECT ID FROM pessoa_ids WHERE NOME = 'João Silva')),
        ((SELECT ID FROM evento_ids WHERE NOME = 'Business Seminar 2024'), (SELECT ID FROM pessoa_ids WHERE NOME = 'Maria Souza')),
        ((SELECT ID FROM evento_ids WHERE NOME = 'Creative Workshop 2024'), (SELECT ID FROM pessoa_ids WHERE NOME = 'Carlos Pereira'))
),

-- Inserção na tabela SESSAO_INTEGRANTES usando os IDs de SESSAO e PESSOA
sessao_integrantes_ids AS (
    INSERT INTO SESSAO_INTEGRANTES (SESSAO_ID, PESSOA_ID) 
    VALUES 
        ((SELECT ID FROM sessao_ids LIMIT 1 OFFSET 0), (SELECT ID FROM pessoa_ids WHERE NOME = 'João Silva')),
        ((SELECT ID FROM sessao_ids LIMIT 1 OFFSET 0), (SELECT ID FROM pessoa_ids WHERE NOME = 'Maria Souza')),
        ((SELECT ID FROM sessao_ids LIMIT 1 OFFSET 1), (SELECT ID FROM pessoa_ids WHERE NOME = 'Carlos Pereira')),
        ((SELECT ID FROM sessao_ids LIMIT 1 OFFSET 2), (SELECT ID FROM pessoa_ids WHERE NOME = 'Ana Oliveira'))
),

-- Inserção na tabela AVALIACAO usando os IDs de PESSOA e SESSAO
avaliacao_ids AS (
    INSERT INTO AVALIACAO (COMENTARIO, NOTA, PESSOA_ID, SESSAO_ID) 
    VALUES 
        ('Ótima conferência', 5, (SELECT ID FROM pessoa_ids WHERE NOME = 'João Silva'), (SELECT ID FROM sessao_ids LIMIT 1 OFFSET 0)),
        ('Muito bom', 4, (SELECT ID FROM pessoa_ids WHERE NOME = 'Maria Souza'), (SELECT ID FROM sessao_ids LIMIT 1 OFFSET 0)),
        ('Informativo e útil', 4, (SELECT ID FROM pessoa_ids WHERE NOME = 'Carlos Pereira'), (SELECT ID FROM sessao_ids LIMIT 1 OFFSET 1)),
        ('Excelente workshop', 5, (SELECT ID FROM pessoa_ids WHERE NOME = 'Ana Oliveira'), (SELECT ID FROM sessao_ids LIMIT 1 OFFSET 2))
),

-- Inserção na tabela PAPEL
papel_ids AS (
    INSERT INTO PAPEL (DESCRICAO) 
    VALUES 
        ('Administrador'),
        ('Usuario')
    RETURNING ID, DESCRICAO
),

-- Inserção na tabela USUARIO
usuario_ids AS (
    INSERT INTO USUARIO (NOME, EMAIL, SENHA, PESSOA_ID) 
    VALUES 
        ('João Silva', 'admin@example.com', '$2a$11$tbQBZSCq5AVHHkV7RsG2xevqXcPd2LaNtvF5HK3JfXMBA/GhWd.we', (SELECT ID FROM pessoa_ids WHERE NOME = 'João Silva')),
        ('Maria Souza', 'usuario@example.com', '$2a$11$tbQBZSCq5AVHHkV7RsG2xevqXcPd2LaNtvF5HK3JfXMBA/GhWd.we', (SELECT ID FROM pessoa_ids WHERE NOME = 'Maria Souza')),
        ('Carlos Pereira', 'carlos@example.com', '$2a$11$tbQBZSCq5AVHHkV7RsG2xevqXcPd2LaNtvF5HK3JfXMBA/GhWd.we', (SELECT ID FROM pessoa_ids WHERE NOME = 'Carlos Pereira')),
        ('Ana Oliveira', 'ana@example.com', '$2a$11$tbQBZSCq5AVHHkV7RsG2xevqXcPd2LaNtvF5HK3JfXMBA/GhWd.we', (SELECT ID FROM pessoa_ids WHERE NOME = 'Ana Oliveira'))
    RETURNING ID, NOME
)

-- Inserção na tabela USUARIO_PAPEL usando os IDs de USUARIO e PAPEL
INSERT INTO USUARIO_PAPEL (USUARIO_ID, PAPEL_ID) 
VALUES 
    ((SELECT ID FROM usuario_ids WHERE NOME = 'João Silva'), (SELECT ID FROM papel_ids WHERE DESCRICAO = 'Administrador')), 
    ((SELECT ID FROM usuario_ids WHERE NOME = 'Maria Souza'), (SELECT ID FROM papel_ids WHERE DESCRICAO = 'Usuario'));
