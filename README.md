# Agenda de Implantações e Tarefas

Sistema pessoal para organizar implantações com clientes (treinamentos e alinhamentos) e tarefas de backlog, com visualização em lista semanal e em calendário. Construído em C#/.NET com Clean Architecture e DDD leve, com foco em regras de negócio protegidas no domínio.

## Status

🚧 Em desenvolvimento. Atualmente em construção: camada de domínio.

## Funcionalidades planejadas

- Tarefas com status (Pendente, Em andamento, Concluída)
- Agendamento de tarefas com data, hora, tipo (Treinamento ou Alinhamento) e cliente
- Lista de tarefas agrupada por semana
- Calendário com os agendamentos
- API REST

## Arquitetura

O projeto segue Clean Architecture, com dependências apontando sempre para o domínio:

- **Domain:** entidades, value objects e regras de negócio, sem dependência de banco ou HTTP
- **Application:** casos de uso (planejado)
- **Infrastructure:** persistência com EF Core e PostgreSQL (planejado)
- **Api:** endpoints REST com ASP.NET Core (planejado)

## Tecnologias

- C# / .NET
- PostgreSQL (planejado)
- Docker (planejado)

## Como executar

Instruções serão adicionadas quando a API estiver disponível.
