# 📋 Changelog - Projeto CleanCode

Todas as mudanças significativas neste projeto serão documentadas neste arquivo.

---

### 🔨 Refatorações (branch: dev)

- Refatoração completa da estrutura de pastas do projeto, separando o backend e frontend em diretórios distintos.
- Organização da camada `Core` com divisão clara entre:
  - `Entities`: entidades de domínio (Receita, Usuario, Ingrediente, etc.)
  - `Enums`: enumerações como `DificuldadeReceita`
  - `Interfaces` e `Rules`: estruturas de contrato e validação.
- Ajuste de nomenclaturas de arquivos e classes para refletir responsabilidade (ex: `IngredienteReceita`, `Preparo`).
- Separação de responsabilidades entre entidades e DTOs, com planejamento para mover `GerarReceita` para camada `Application`.

### 🧹 Boas práticas aplicadas

- Aplicação de princípios de **Clean Code**:
  - Responsabilidade única (SRP)
  - Eliminação de comentários obsoletos
  - Melhoria na legibilidade e nomeação semântica
- Remoção de `usings` não utilizados e de trechos comentados irrelevantes.

### 🛠️ Infraestrutura

- Inclusão de `Dockerfile` e `docker-compose.yml` para facilitar execução local da aplicação.
- Criação do arquivo `.gitignore` para excluir artefatos de build, cache e secrets locais.

### 🧪 Preparação para Testes

- Estrutura inicial para uso de **xUnit** nos testes de unidade.
- Planejamento para uso de **FluentAssertions** e análise estática com **SonarLint**.

---

## [Initial Commit] – 12/05/2025

- Criação do repositório com estrutura base.
- Adição do `README.md`.

