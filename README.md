# Guia de Execução da Aplicação EventManager
## Introdução
O EventManager é uma aplicação de gerenciamento de eventos. Siga este guia para configurar e rodar o sistema utilizando uma das duas opções disponíveis: instalando o executável ou rodando o código-fonte diretamente.

#

### 🛠️ Pré-requisitos
Antes de começar, certifique-se de ter:

* PostgreSQL instalado e configurado.
* Uma conta de administrador no banco de dados PostgreSQL.
* Visual Studio (opcional, para executar o código-fonte).

## 🚀 Primeira Opção: Instalar a Aplicação via Setup
1. Instale a aplicação
- Localize e execute o arquivo setup.exe.
- Siga as instruções do instalador para concluir a instalação.
2. Configure o banco de dados
- Abra o PostgreSQL e conecte-se ao banco.
- Crie um novo banco de dados chamado eventmanager.
- Execute o script create.sql (disponível na pasta do projeto ou fornecido junto ao instalador) para configurar as tabelas necessárias.
  
### Credenciais padrão do banco de dados
* Usuário: postgres
* Senha: 12345

3. Faça login na aplicação com as credenciais padrão
* Usuário: admin@example.com
* Senha: senha

## 💻 Segunda Opção: Rodar o Código-Fonte no Visual Studio
1. Obtenha o código-fonte
- Opção 1: Clone o repositório com:
git clone git@github.com:surviveed/EventManager.git
- Opção 2: Baixe o código-fonte compactado (.zip) e extraia os arquivos.
  
2. Abra o projeto no Visual Studio
- Localize e abra o arquivo EventManager.sln.
  
3. Configure a conexão com o banco de dados
- Abra o arquivo App.config.
- Localize a seção <connectionStrings> e configure as credenciais do PostgreSQL de acordo com o seu ambiente:

connectionStrings>
   add name="EventManagerDbContext" connectionString="server=localhost;Port=5432;user id=postgres;password=12345;database=eventmanager" providerName="Npgsql" />
 /connectionStrings>

- Certifique-se de que o banco eventmanager já foi criado e que o script create.sql foi executado.
  
4. Execute a aplicação
- Compile e execute a aplicação no Visual Studio.
- Use as credenciais padrão para fazer login:
Usuário: admin@example.com
Senha: senha

## 📝 Observações
* Configuração personalizada: Se o PostgreSQL estiver rodando em outra porta ou com diferentes credenciais, ajuste o arquivo App.config ou as configurações do banco antes de executar o sistema.
* Credenciais padrão: Alterar a senha do administrador após o primeiro login é recomendado para maior segurança.
