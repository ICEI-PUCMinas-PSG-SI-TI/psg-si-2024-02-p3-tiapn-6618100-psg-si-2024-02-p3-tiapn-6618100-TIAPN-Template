
-- Dim_Instrumento
CREATE TABLE Dim_Instrumento
(
    Codigo_Instrumento SERIAL PRIMARY KEY,
    Nome               VARCHAR(100) NOT NULL,
    Tipo               VARCHAR(50)  NOT NULL
);

-- Dim_Aluno
CREATE TABLE Dim_Aluno
(
    Codigo_Aluno SERIAL PRIMARY KEY,
    Nome         VARCHAR(100) NOT NULL,
    Matricula    VARCHAR(50)  NOT NULL,
    Endereco     VARCHAR(255)
);

-- Dim_Tempo
CREATE TABLE Dim_Tempo
(
    Codigo_Tempo SERIAL PRIMARY KEY,
    Data         DATE        NOT NULL,
    Ano          INT         NOT NULL,
    Mes          INT         NOT NULL,
    Dia          INT         NOT NULL,
    Dia_Semana   VARCHAR(20) NOT NULL
);

-- Dim_Administrador
CREATE TABLE Dim_Administrador
(
    Codigo_Administrador SERIAL PRIMARY KEY,
    Nome                 VARCHAR(100) NOT NULL,
    Contato              VARCHAR(100),
    Tipo                 VARCHAR(50)  NOT NULL
);

-- Dim_Professor
CREATE TABLE Dim_Professor
(
    Codigo_Professor SERIAL PRIMARY KEY,
    Nome             VARCHAR(100) NOT NULL,
    Contato          VARCHAR(100),
    Habilidades      VARCHAR(255)
);

-- Dim_Turma
CREATE TABLE Dim_Turma
(
    Codigo_Turma SERIAL PRIMARY KEY,
    Nome         VARCHAR(100) NOT NULL,
    Sala         INT          NOT NULL,
    Horario      TIME         NOT NULL
);

-- Dim_Estoque
CREATE TABLE Dim_Estoque
(
    Codigo_Estoque SERIAL PRIMARY KEY,
    Localizacao    VARCHAR(255),
    Quantidade     INT
);

-- Fatos

-- Fato_Emprestimo
CREATE TABLE Fato_Emprestimo
(
    Codigo_Emprestimo       SERIAL PRIMARY KEY,
    Codigo_Instrumento      INT         NOT NULL,
    Codigo_Aluno            INT         NOT NULL,
    Codigo_Tempo_Emprestimo INT         NOT NULL,
    Codigo_Tempo_Devolucao  INT,
    Codigo_Administrador    INT         NOT NULL,
    Tipo_Administrador      VARCHAR(50) NOT NULL,
    Status                  VARCHAR(50),
    Descricao               VARCHAR(255)
);
-- Fato_AgendamentoAula
CREATE TABLE Fato_AgendamentoAula
(
    Codigo_Agendamento   SERIAL PRIMARY KEY,
    Codigo_Turma         INT         NOT NULL,
    Codigo_Professor     INT         NOT NULL,
    Codigo_Tempo         INT         NOT NULL,
    Codigo_Administrador INT         NOT NULL,
    Tipo_Administrador   VARCHAR(50) NOT NULL,
    Descricao            VARCHAR(255)
);

-- Fato_Matricula
CREATE TABLE Fato_Matricula
(
    Codigo_Matricula     SERIAL PRIMARY KEY,
    Codigo_Aluno         INT         NOT NULL,
    Codigo_Turma         INT         NOT NULL,
    Codigo_Administrador INT         NOT NULL,
    Tipo_Administrador   VARCHAR(50) NOT NULL,
    Data_Inicio          DATE        NOT NULL,
    Status               VARCHAR(50) NOT NULL
);

-- Fato_EstoqueMovimentacao
CREATE TABLE Fato_EstoqueMovimentacao
(
    Codigo_Movimentacao  SERIAL PRIMARY KEY,
    Codigo_Estoque       INT         NOT NULL,
    Codigo_Tempo         INT         NOT NULL,
    Codigo_Administrador INT         NOT NULL,
    Tipo_Administrador   VARCHAR(50) NOT NULL,
    Tipo_Movimentacao    VARCHAR(50) NOT NULL,
    Quantidade           INT         NOT NULL
);

-- Alterações para adicionar chaves estrangeiras

-- Fato_Emprestimo
ALTER TABLE Fato_Emprestimo
    ADD CONSTRAINT FK_Emprestimo_Instrumento FOREIGN KEY (Codigo_Instrumento) REFERENCES Dim_Instrumento (Codigo_Instrumento),
    ADD CONSTRAINT FK_Emprestimo_Aluno FOREIGN KEY (Codigo_Aluno) REFERENCES Dim_Aluno (Codigo_Aluno),
    ADD CONSTRAINT FK_Emprestimo_Tempo_Emprestimo FOREIGN KEY (Codigo_Tempo_Emprestimo) REFERENCES Dim_Tempo (Codigo_Tempo),
    ADD CONSTRAINT FK_Emprestimo_Tempo_Devolucao FOREIGN KEY (Codigo_Tempo_Devolucao) REFERENCES Dim_Tempo (Codigo_Tempo),
    ADD CONSTRAINT FK_Emprestimo_Administrador FOREIGN KEY (Codigo_Administrador) REFERENCES Dim_Administrador (Codigo_Administrador);

-- Fato_AgendamentoAula
ALTER TABLE Fato_AgendamentoAula
    ADD CONSTRAINT FK_Agendamento_Turma FOREIGN KEY (Codigo_Turma) REFERENCES Dim_Turma (Codigo_Turma),
    ADD CONSTRAINT FK_Agendamento_Professor FOREIGN KEY (Codigo_Professor) REFERENCES Dim_Professor (Codigo_Professor),
    ADD CONSTRAINT FK_Agendamento_Tempo FOREIGN KEY (Codigo_Tempo) REFERENCES Dim_Tempo (Codigo_Tempo),
    ADD CONSTRAINT FK_Agendamento_Administrador FOREIGN KEY (Codigo_Administrador) REFERENCES Dim_Administrador (Codigo_Administrador);

-- Fato_Matricula
ALTER TABLE Fato_Matricula
    ADD CONSTRAINT FK_Matricula_Aluno FOREIGN KEY (Codigo_Aluno) REFERENCES Dim_Aluno (Codigo_Aluno),
    ADD CONSTRAINT FK_Matricula_Turma FOREIGN KEY (Codigo_Turma) REFERENCES Dim_Turma (Codigo_Turma),
    ADD CONSTRAINT FK_Matricula_Administrador FOREIGN KEY (Codigo_Administrador) REFERENCES Dim_Administrador (Codigo_Administrador);

-- Fato_EstoqueMovimentacao
ALTER TABLE Fato_EstoqueMovimentacao
    ADD CONSTRAINT FK_Movimentacao_Estoque FOREIGN KEY (Codigo_Estoque) REFERENCES Dim_Estoque (Codigo_Estoque),
    ADD CONSTRAINT FK_Movimentacao_Tempo FOREIGN KEY (Codigo_Tempo) REFERENCES Dim_Tempo (Codigo_Tempo),
    ADD CONSTRAINT FK_Movimentacao_Administrador FOREIGN KEY (Codigo_Administrador) REFERENCES Dim_Administrador (Codigo_Administrador);



INSERT INTO Dim_Instrumento (Nome, Tipo)
VALUES
    ('Violão Yamaha', 'Cordas'),
    ('Piano Kawai', 'Teclas'),
    ('Flauta Yamaha', 'Sopro'),
    ('Guitarra Fender', 'Cordas'),
    ('Bateria Pearl', 'Percussão');

INSERT INTO Dim_Aluno (Nome, Matricula, Endereco)
VALUES
    ('Maria Oliveira', '20230001', 'Rua das Flores, 123'),
    ('João Silva', '20230002', 'Rua das Palmeiras, 456'),
    ('Ana Costa', '20230003', 'Av. Brasil, 789'),
    ('Pedro Santos', '20230004', 'Rua das Laranjeiras, 101'),
    ('Clara Ferreira', '20230005', 'Rua dos Jacarandás, 202');

INSERT INTO Dim_Tempo (Data, Ano, Mes, Dia, Dia_Semana)
VALUES
    ('2024-01-10', 2024, 1, 10, 'Quarta-feira'),
    ('2024-01-15', 2024, 1, 15, 'Segunda-feira'),
    ('2024-01-20', 2024, 1, 20, 'Sábado'),
    ('2024-01-25', 2024, 1, 25, 'Quinta-feira'),
    ('2024-01-30', 2024, 1, 30, 'Terça-feira');
INSERT INTO Dim_Administrador (Nome, Contato, Tipo)
VALUES
    ('Carlos Mendes', 'carlos.mendes@escola.com', 'Supervisor Geral'),
    ('Mariana Souza', 'mariana.souza@escola.com', 'Administrador de Recursos'),
    ('Fernando Lima', 'fernando.lima@escola.com', 'Supervisor de Estoque'),
    ('Clara Almeida', 'clara.almeida@escola.com', 'Coordenadora Geral');
INSERT INTO Dim_Professor (Nome, Contato, Habilidades)
VALUES
    ('Carlos Silva', 'carlos.silva@escola.com', 'Violão, Piano'),
    ('Ana Pereira', 'ana.pereira@escola.com', 'Flauta, Saxofone'),
    ('João Souza', 'joao.souza@escola.com', 'Guitarra, Bateria'),
    ('Mariana Costa', 'mariana.costa@escola.com', 'Teclado, Violino');
INSERT INTO Dim_Turma (Nome, Sala, Horario)
VALUES
    ('Turma A', 101, '08:00:00'),
    ('Turma B', 102, '10:00:00'),
    ('Turma C', 103, '14:00:00'),
    ('Turma D', 104, '16:00:00');
INSERT INTO Dim_Estoque (Localizacao, Quantidade)
VALUES
    ('Sala de Instrumentos', 20),
    ('Depósito Central', 50),
    ('Sala 101', 10),
    ('Sala 102', 15);
INSERT INTO Fato_Emprestimo (Codigo_Instrumento, Codigo_Aluno, Codigo_Tempo_Emprestimo, Codigo_Tempo_Devolucao, Codigo_Administrador, Tipo_Administrador, Status, Descricao)
VALUES
    (1, 1, 1, 2, 1, 'Supervisor Geral', 'Devolvido', 'Sem danos.'),
    (2, 2, 3, NULL, 2, 'Administrador de Recursos', 'Em andamento', 'Prazo de devolução: 7 dias.'),
    (3, 3, 4, 5, 3, 'Supervisor de Estoque', 'Devolvido', 'Devolução no prazo.');
INSERT INTO Fato_AgendamentoAula (Codigo_Turma, Codigo_Professor, Codigo_Tempo, Codigo_Administrador, Tipo_Administrador, Descricao)
VALUES
    (1, 1, 1, 1, 'Supervisor Geral', 'Aula de violão.'),
    (2, 2, 2, 2, 'Administrador de Recursos', 'Aula de flauta.'),
    (3, 3, 3, 3, 'Supervisor de Estoque', 'Aula de guitarra.');
INSERT INTO Fato_Matricula (Codigo_Aluno, Codigo_Turma, Codigo_Administrador, Tipo_Administrador, Data_Inicio, Status)
VALUES
    (1, 1, 1, 'Supervisor Geral', '2024-01-01', 'Ativo'),
    (2, 2, 2, 'Administrador de Recursos', '2024-01-05', 'Ativo'),
    (3, 3, 3, 'Supervisor de Estoque', '2024-01-10', 'Inativo');
INSERT INTO Fato_EstoqueMovimentacao (Codigo_Estoque, Codigo_Tempo, Codigo_Administrador, Tipo_Administrador, Tipo_Movimentacao, Quantidade)
VALUES
    (1, 1, 1, 'Supervisor Geral', 'Entrada', 10),
    (2, 2, 2, 'Administrador de Recursos', 'Saída', 5),
    (3, 3, 3, 'Supervisor de Estoque', 'Entrada', 20);
