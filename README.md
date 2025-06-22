# 💼 ConciligApp – Sistema de Gerenciamento de Contratos

Este projeto foi desenvolvido como parte de um desafio técnico da empresa **Concilig**, com foco em construir uma aplicação desktop funcional usando **C# com Windows Forms** e **Entity Framework 6**.

A proposta era criar uma interface simples, intuitiva e funcional para importar, visualizar e analisar contratos em atraso, utilizando banco de dados SQL Server e arquivos CSV.

---

## 📌 Funcionalidades

- 🔐 **Login com verificação de credenciais**
- 📂 **Importação de arquivos CSV com contratos**
- 📊 **Consulta de contratos agrupados por cliente (nome e CPF)**
- 🏦 **Cálculo automático de valores e atrasos**
- 🔄 **Atualização dinâmica da interface**
- 📤 **Botões para sair e voltar com tratamento**
- 🧑‍💼 **Interface personalizada para o usuário logado**

---

## 🛠️ Tecnologias utilizadas

- C# (.NET Framework 4.8)
- Windows Forms
- Entity Framework 6
- SQL Server 2022 (instância local)
- CsvHelper
- Visual Studio 2022

---

## ⚙️ Como executar

### Pré-requisitos:
- SQL Server instalado e em execução (ex: `localhost\MSSQLSERVER01`)
- Visual Studio 2022 com suporte a WinForms e NuGet

### Passo a passo:

1. Clone o repositório ou abra a solução no Visual Studio.
2. Abra o arquivo `App.config` e ajuste sua string de conexão se necessário:
   ```xml
   <connectionStrings>
     <add name="ConexaoSql"
          connectionString="Data Source=localhost\\MSSQLSERVER01;Initial Catalog=ConciligDB;Integrated Security=True;TrustServerCertificate=True;"
          providerName="System.Data.SqlClient" />
   </connectionStrings>

No Gerenciador de Pacotes NuGet, rode:
Update-Database
Isso irá criar o banco e as tabelas automaticamente via Entity Framework.

Rode o projeto (F5) e utilize:

Email: admin@gmail.com
Senha: admin

🧠 Organização do código
Forms1/ → telas principais (LoginForm, MainForm, ConsultaForm)
Models1/ → entidades de banco (Usuario, Contrato, ArquivoImportado)
Data1/ → AppDbContext com conexão ao banco
Migrations/ → migrations e seed de dados
Program.cs → ponto de entrada do app

📈 Sobre os dados
Os contratos são importados de um arquivo CSV que deve seguir o modelo padrão com colunas como:

NomeCliente
CPF
Valor
DataVencimento

O sistema agrupa os dados por cliente e calcula o maior atraso em dias.

🚀 Objetivo do projeto

O foco deste projeto foi demonstrar capacidade técnica em:

Manipular banco de dados com EF6
Criar telas funcionais e organizadas com WinForms
Realizar importações e agrupamentos de dados
Garantir boa lógica de navegação e usabilidade

🙋‍♂️ Autor
João Pedro
Estudante de Ciência da Computação | Dev C# | Apaixonado por resolver problemas
🔗 (https://www.linkedin.com/in/jo%C3%A3o-pedro-ferreira-50b389302/)
💻 (https://github.com/OJAOFERREIRA7)

📄 Observações
Este projeto foi desenvolvido com fins acadêmicos e de avaliação.
Todos os dados e nomes usados no sistema são fictícios ou genéricos


