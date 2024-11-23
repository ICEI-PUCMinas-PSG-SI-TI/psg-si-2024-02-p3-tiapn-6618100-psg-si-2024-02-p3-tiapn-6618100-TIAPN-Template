create table if not exists public.dim_instrumento
(
    codigo_instrumento serial
        primary key,
    nome               varchar(100) not null,
    tipo               varchar(50)  not null,
    categoria          varchar(50),
    condicao           varchar(50)
);

alter table public.dim_instrumento
    owner to puc_aws;

create table if not exists public.dim_aluno
(
    codigo_aluno serial
        primary key,
    nome         varchar(100) not null,
    matricula    varchar(50)  not null,
    rua          varchar(255) not null,
    bairro       varchar(100) not null,
    numero       varchar(10)  not null,
    cep          varchar(15)  not null,
    telefone     varchar(15),
    email        varchar(100)
);

alter table public.dim_aluno
    owner to puc_aws;

create table if not exists public.dim_tempo
(
    codigo_tempo serial
        primary key,
    data         date        not null,
    ano          integer     not null,
    mes          integer     not null,
    dia          integer     not null,
    dia_semana   varchar(20) not null
);

alter table public.dim_tempo
    owner to puc_aws;

create table if not exists public.dim_administrador
(
    codigo_administrador serial
        primary key,
    nome                 varchar(100) not null,
    contato              varchar(100),
    tipo                 varchar(50)  not null
);

alter table public.dim_administrador
    owner to puc_aws;

create table if not exists public.dim_professor
(
    codigo_professor serial
        primary key,
    nome             varchar(100) not null,
    contato          varchar(100),
    habilidades      varchar(255)
);

alter table public.dim_professor
    owner to puc_aws;

create table if not exists public.dim_turma
(
    codigo_turma serial
        primary key,
    nome         varchar(100) not null,
    sala         integer      not null,
    nivel        varchar(50),
    duracao      time         not null,
    numero_vagas integer
);

alter table public.dim_turma
    owner to puc_aws;

create table if not exists public.dim_estoque
(
    codigo_estoque     serial
        primary key,
    localizacao        varchar(255),
    codigo_instrumento integer not null
        references public.dim_instrumento
);

alter table public.dim_estoque
    owner to puc_aws;

create table if not exists public.dim_pagamento
(
    codigo_pagamento serial
        primary key,
    tipo             varchar(50) not null,
    nome_cartao      varchar(100),
    numero_cartao    varchar(20),
    validade         varchar(7),
    codigo_seguranca varchar(5),
    status           varchar(50)
);

alter table public.dim_pagamento
    owner to puc_aws;

create table if not exists public.dim_horario
(
    codigo_horario serial
        primary key,
    dia_semana     varchar(20) not null,
    horario        time        not null
);

alter table public.dim_horario
    owner to puc_aws;

create table if not exists public.fato_matricula
(
    codigo_matricula     serial
        primary key,
    codigo_aluno         integer     not null
        references public.dim_aluno,
    codigo_turma         integer     not null
        references public.dim_turma,
    codigo_pagamento     integer     not null
        references public.dim_pagamento,
    codigo_administrador integer     not null
        references public.dim_administrador,
    data_inicio          date        not null,
    status               varchar(50) not null
);

alter table public.fato_matricula
    owner to puc_aws;

create table if not exists public.fato_emprestimo
(
    codigo_emprestimo       serial
        primary key,
    codigo_instrumento      integer not null
        references public.dim_instrumento,
    codigo_aluno            integer not null
        references public.dim_aluno,
    codigo_tempo_emprestimo integer not null
        references public.dim_tempo,
    codigo_tempo_devolucao  integer
        references public.dim_tempo,
    codigo_administrador    integer not null
        references public.dim_administrador,
    status                  varchar(50)
);

alter table public.fato_emprestimo
    owner to puc_aws;

create table if not exists public.fato_agendamentoaula
(
    codigo_agendamento   serial
        primary key,
    codigo_turma         integer not null
        references public.dim_turma,
    codigo_professor     integer not null
        references public.dim_professor,
    codigo_horario       integer not null
        references public.dim_horario,
    codigo_administrador integer not null
        references public.dim_administrador
);

alter table public.fato_agendamentoaula
    owner to puc_aws;

create table if not exists public.fato_estoquemovimentacao
(
    codigo_movimentacao  serial
        primary key,
    codigo_estoque       integer     not null
        references public.dim_estoque,
    codigo_tempo         integer     not null
        references public.dim_tempo,
    codigo_administrador integer     not null
        references public.dim_administrador,
    tipo_movimentacao    varchar(50) not null,
    quantidade           integer     not null
);

alter table public.fato_estoquemovimentacao
    owner to puc_aws;

