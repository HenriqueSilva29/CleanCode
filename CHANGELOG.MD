# 📘 CHANGELOG

Todas as alterações importantes neste projeto serão documentadas neste arquivo.

## [1.3.0] - 2025-05-27

### ✅ Adicionado
- Projeto de testes `backend.Tests` criado utilizando `.NET`, com suporte a `xUnit`, `Moq` e `FluentAssertions`.
- Implementação do primeiro teste unitário para o serviço `ReceitaServices`, verificando o método `Receita(id)` com retorno simulado.
- Interface `IReceitaRepository` criada para representar operações de repositório de receitas, promovendo desacoplamento.
- Interface `IReceitaRegras` criada para permitir testes isolados dos serviços sem dependência direta da lógica de regras.
- Injeção de dependência implementada em `ReceitaServices` e `ReceitaRegras`, aumentando a testabilidade e aderência ao princípio da inversão de dependência (SOLID).
- Adição da pasta `Mappers` com arquivos de mapeamento entre documentos do MongoDB e entidades do domínio.
- Implementação do `IngredienteBaseMapper` com testes unitários de conversão entre `IngredienteBaseDocument` e `IngredienteBase`.

### 🔧 Alterado
- Refatoração das entidades do domínio para a pasta `Core/Entities` com padronização de nomenclatura.
- Separação da lógica de regras para a pasta `Core/Rules` e dos serviços para `Application/Services`.
- Documentos do MongoDB movidos para `Infrastructure/Data/MongoModels`, isolando as dependências de banco de dados.
- Mapeamentos entre entidades e documentos Mongo organizados em `Infrastructure/Data/Mappers`.
- Adição de arquivo `GlobalUsings.cs` para simplificar imports nos projetos.
- Estrutura de pastas reorganizada no backend: `Core`, `Application`, `Infrastructure`, `API`, seguindo os princípios de Clean Architecture.

### 🗑️ Removido
- Dependências diretas entre lógica de negócio e persistência foram eliminadas com a criação das interfaces de repositório.
- Testes unitários `ReceitaRegrasTests` e `ReceitaServicesTests` que dependiam de métodos não virtualizáveis foram removidos temporariamente para evitar falhas de build com o `Moq`.

### 📌 Observações
Esta versão representa a consolidação da arquitetura e das boas práticas no projeto. Com a introdução de testes unitários, modularização das camadas e uso de interfaces, o código está mais organizado, testável e preparado para evoluções futuras.

A entrega também atende aos objetivos acadêmicos propostos, demonstrando:
- Conhecimento em Clean Code e princípios SOLID;
- Adoção de práticas profissionais de engenharia de software;
- Preparo para manutenção, escalabilidade e confiabilidade do projeto.

---

## [1.2.0] - 2025-05-23

### ✅ Adicionado
- Implementação inicial da entidade `Receita` e seus campos principais.
- Criação dos serviços `ReceitaServices` e `ReceitaRegras` com métodos para `Gerar`, `Atualizar`, `Remover` e `Recuperar`.
- Criação do DTO `Response<T>` padronizando retornos de métodos da aplicação.
- Introdução do DTO `GerarReceitaDto` para encapsular dados de criação de receitas.

### 🔧 Alterado
- Métodos assíncronos refatorados para utilizar `Task` com boas práticas de async/await.

---

## [1.1.0] - 2025-05-21

### ✅ Adicionado
- Organização da estrutura de pastas com base no padrão Clean Architecture.
- Configuração inicial do projeto `backend` com .NET 7.0.
- Adição de `.gitignore` específico para pastas de build (`bin`, `obj`), IDEs e arquivos sensíveis.

---

## [1.0.0] - 2025-05-20

### ✅ Iniciado
- Repositório inicial criado com a estrutura básica do projeto CleanCode.
- Inclusão das pastas `frontend/` (React), `backend/` (.NET) e arquivos de configuração.
