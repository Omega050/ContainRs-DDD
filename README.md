# ContainRs-DDD 🚢

![.NET](https://img.shields.io/badge/.NET-8.0-blue?style=for-the-badge&logo=.net)
![C#](https://img.shields.io/badge/C%23-12.0-purple?style=for-the-badge&logo=c-sharp&logoColor=white)
![Microsoft SQL Server](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)
![DDD](https://img.shields.io/badge/DDD-Applied-orange?style=for-the-badge)
![MediatR](https://img.shields.io/badge/MediatR-CQRS-brightgreen?style=for-the-badge)

Uma evolução da API **ContainRs**, refatorada para aprofundar a aplicação dos padrões táticos e estratégicos do **Domain-Driven Design (DDD)**.

Este projeto representa o segundo estágio do estudo, onde a base de Arquitetura Limpa foi aprimorada com um modelo de domínio rico e a implementação do padrão CQRS com MediatR, buscando um código mais expressivo, robusto e fiel às regras de negócio.

> Este projeto é a continuação do [**ContainRs**](https://github.com/Omega050/ContainRs), que estabeleceu a fundação com Arquitetura Limpa.

---

## 🏛️ Arquitetura e Padrões Aplicados

O foco desta versão foi enriquecer o coração do software, a camada de `Domain`, utilizando os padrões de DDD para modelar complexidade.

- **Modelo de Domínio Rico:** As entidades foram transformadas em objetos ricos, encapsulando não apenas dados, mas também o comportamento e as regras de negócio, como validações e transições de estado.
- **Agregados (Aggregates):** Foram definidos agregados para garantir a consistência das transações. `Container` é um exemplo de Raiz de Agregado, protegendo suas entidades internas.
- **Padrão Repositório:** A camada de infraestrutura implementa os repositórios, que persistem e recuperam os agregados, abstraindo a complexidade do ORM.
- **CQRS e MediatR:** Foi aplicado o padrão **Command Query Responsibility Segregation** nos casos de uso. A biblioteca `MediatR` é utilizada para desacoplar a camada de apresentação da lógica de aplicação, separando claramente os comandos (escritas) das consultas (leituras).

## 💻 Tecnologias Utilizadas

- **C# 12** e **.NET 8**
- **ASP.NET Core:** Para a construção da API RESTful.
- **Entity Framework Core:** Como ORM para persistência de dados.
- **SQL Server:** Banco de dados relacional.
- **MediatR:** Para implementação do padrão Mediator e CQRS nos casos de uso.

## 💡 Endpoints e Fluxo de Execução

Embora os endpoints sejam similares à versão anterior, o fluxo interno é diferente:

- Uma requisição `POST /api/containers`, por exemplo, não chama um serviço diretamente. Em vez disso, o Controller cria e envia um `CreateContainerCommand`.
- O `MediatR` direciona o comando para seu respectivo `Handler` na camada de `Application`, que contém a lógica de orquestração do caso de uso.

---
## Preparando o ambiente

### Criando o banco de dados a estrutura e dados iniciais do Identity
Abra o terminal, navegue para a pasta onde baixou o projeto e execute o comando abaixo:
```
dotnet ef database update --context IdentityDbContext --project .\src\ContainRs.Api\ContainRs.Api.csproj --startup-project .\src\ContainRs.Api\ContainRs.Api.csproj
```

### Criando o banco de dados a estrutura e dados iniciais de negócio
Abra o terminal, navegue para a pasta onde baixou o projeto e execute o comando abaixo:
```
dotnet ef database update --context AppDbContext --project .\src\ContainRs.Api\ContainRs.Api.csproj --startup-project .\src\ContainRs.Api\ContainRs.Api.csproj
```

### Rodando o projeto

O comando deverá criar o banco de dados e as tabelas necessárias para o funcionamento do projeto.
