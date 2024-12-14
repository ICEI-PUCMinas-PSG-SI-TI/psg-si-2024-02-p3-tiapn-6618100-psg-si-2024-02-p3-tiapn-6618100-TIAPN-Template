# Especificações do Projeto


## Personas

Carlos, o administrador geral de 45 anos, gerencia alunos, planos e profissionais, garantindo que tudo no sistema funcione corretamente e acompanhando relatórios administrativos.

Ana, nutricionista de 32 anos, utiliza o sistema para calcular a bioimpedância dos alunos, registrando dados e gerando relatórios detalhados sobre a evolução física.

Rafael, instrutor de 29 anos, cria fichas de treino personalizadas, monitora o desempenho dos alunos e ajusta planos para otimizar os resultados.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`  | QUERO/PRECISO ... `FUNCIONALIDADE`            |PARA ... `MOTIVO/VALOR`                                |
|----------------------|-----------------------------------------------|-------------------------------------------------------|
|Administrador         | Quero cadastrar professores                   | Permitir que possam administrar fichas de alunos      |
|Administrador         | Quero alterar dados dos alunos com facilidade | Manter a base de dados atualizada                     |
|Profissional da saúde | Atualizar a bioimpedância do aluno            | Melhorar suas fichas ao longo do tempo                |
|Professor físico      | Ver a bioimpedância do aluno                  | Ter base base para criar suas fichas de forma prática |

## Requisitos

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre, edite e exclua os dados dos alunos | ALTA |
|RF-002| Permitir que o usuário cadastre, edite e exclua dados dos profissionais | BAIXA | 
|RF-003| Permitir que o usuário cadastre, edite e exclua dados dos planos | BAIXA |
|RF-004| Permitir que o usuário atribua um plano a um aluno | BAIXA | 
|RF-004| Permitir que o usuário crie a bioimpedância personalizada para cada aluno | BAIXA | 
|RF-005| Permitir que o usuário pesquise os dados de qualquer aluno   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ter conexão initerrupta com o banco de dados | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 
|RNF-003| Deve avisar quando um dado está sendo inserido de forma incorreta | ALTA | 


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| O projeto deverá seguir exatamente a modelagem de dados criada        |

