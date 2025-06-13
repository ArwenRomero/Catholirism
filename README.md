# Catholirism

Catholirism é um sistema de gerenciamento de pacotes turísticos focado em turismo religioso, permitindo a administração de clientes, destinos, pacotes turísticos, reservas e anotações relacionadas a peregrinações e locais sagrados.

## Funcionalidades

- **Autenticação de Usuários**: Acesso seguro com login e senha.
- **Gerenciamento de Pacotes Turísticos**: Criação, visualização, edição e exclusão de pacotes.
- **Gestão de Reservas**: Operações CRUD para reservas de pacotes.
- **Cadastro de Clientes e Destinos**: Manutenção de registros de clientes e locais de interesse.
- **Anotações Espirituais**: Espaço para registrar reflexões e notas relacionadas à fé e peregrinações.

## Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- SQLite
- Razor Pages
- Bootstrap para estilização

## Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) (versão 8.0 ou superior)
- [SQLite](https://www.sqlite.org/download.html) (embutido, não é necessário instalar separadamente)

## Instalação

1. **Clonar o Repositório**
   ```bash
   git clone [url-do-repositorio]
   cd Catholirism
   ```

2. **Restaurar Pacotes NuGet**
   ```bash
   dotnet restore
   ```

3. **Aplicar Migrações do Banco de Dados**
   ```bash
   dotnet ef database update
   ```

4. **Executar a Aplicação**
   ```bash
   dotnet run
   ```

   A aplicação estará disponível em `http://localhost:5140` ou `https://localhost:7187`.

## Uso

- **Login**: Acesse a página de login em `/Account/Login` com as credenciais:
  - **Usuário**: `adm`
  - **Senha**: `senha123`
- **Navegação**: Utilize o menu superior para acessar as diferentes seções:
  - **Página Inicial**: Visão geral dos pacotes disponíveis.
  - **Igrejas Turísticas**: Gerenciamento de pacotes turísticos.
  - **Reservas**: Administração de reservas.
  - **Igrejas de Destino**: Cadastro e edição de destinos.
  - **Clientes**: Gerenciamento de clientes.
  - **Anotações**: Registro e visualização de anotações espirituais.

## Estrutura do Projeto

- **`Catholirism.csproj`**: Arquivo de projeto .NET.
- **`Program.cs`**: Ponto de entrada da aplicação, configura serviços e middleware.
- **`appsettings.json`**: Configurações da aplicação, incluindo a string de conexão com o banco de dados.
- **`Data/Catholirism.cs`**: Contexto do Entity Framework para interação com o banco de dados.
- **`Migrations/`**: Contém as migrações para criar e atualizar o esquema do banco de dados.
- **`Pages/`**: Razor Pages que compõem a interface do usuário.
- **`Model/`**: Classes de modelo representando as entidades do sistema.

## Banco de Dados

- **SQLite**: O banco de dados é armazenado localmente no arquivo `Catholirism.db`.
- **Migrações**: Use `dotnet ef migrations add [nome]` para criar novas migrações e `dotnet ef database update` para aplicá-las.

## Logging

- Configurado para registrar informações no nível `Information` por padrão. Ajuste em `appsettings.json` se necessário.

## Segurança

- **Autenticação**: Implementada com cookies. Certifique-se de alterar a senha padrão em ambientes de produção.