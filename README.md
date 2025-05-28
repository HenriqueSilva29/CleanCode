# 🧼 CleanCode Project

Este projeto tem como objetivo a aplicação prática dos princípios de **Clean Code**, utilizando a linguagem **C# (.NET 7)** no backend e **React (TypeScript)** no frontend.

A iniciativa visa demonstrar, por meio de um sistema funcional, a importância de um código limpo, modular, testável e de fácil manutenção. O foco está na adoção das boas práticas de engenharia de software, especialmente aquelas defendidas por autores como **Robert C. Martin** (Uncle Bob) e reforçadas pelo uso de padrões de projeto, SOLID e testes automatizados.

## 🔍 Objetivos principais

- Aplicar os princípios de **Clean Code** em todas as camadas da aplicação;
- Organizar a arquitetura do projeto de forma clara e escalável;
- Utilizar testes unitários com **xUnit**, **Moq** e **FluentAssertions**;
- Separar responsabilidades com base na **Clean Architecture**;
- Melhorar a legibilidade, coesão e manutenibilidade do código;
- Produzir um exemplo prático que possa ser utilizado como referência acadêmica e profissional.

## 📂 Estrutura do projeto

CleanCode/
│
├── backend/ # Projeto .NET (API + serviços)
│ ├── Core/ # Entidades de domínio e regras de negócio
│ ├── Application/ # Serviços e DTOs
│ ├── Infrastructure/ # Modelos de dados e integração com banco
│ ├── API/ # Controllers e configurações da API
│
├── backend.Tests/ # Projeto de testes unitários (xUnit)
│
├── frontend/ # Projeto React + TypeScript
│
└── README.md # Documentação do projeto
