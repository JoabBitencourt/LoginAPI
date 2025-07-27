# LoginAPI


# 📚 Projeto de Estudo - API de Login com JWT

Este é um projeto de estudo desenvolvido em **ASP.NET Core** com objetivo de praticar autenticação utilizando **JWT (Bearer Token)**.  


---

## Estrutura do projeto
- Controllers/ → Endpoints públicos e protegidos
- Services/ → Lógica de negócio, geração do token JWT
- Security/ → Hasher de senha com BCrypt
- Models/ → Modelos de dados (User, LoginRequest etc.)
- Extensions/ → Configurações desacopladas do Program.cs



## 🚀 Tecnologias e Dependências

Este projeto foi desenvolvido com:

- [.NET 8](https://dotnet.microsoft.com/en-us/download) 
- `Microsoft.AspNetCore.Authentication.JwtBearer`
- `System.IdentityModel.Tokens.Jwt`
- `BCrypt.Net-Next` *(para hash de senhas)*
- `Swashbuckle.AspNetCore` *(para Swagger UI - documentação da API)*

---

## 📦 Pré-requisitos

Antes de rodar o projeto, certifique-se de ter instalado:

- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- Editor como [Visual Studio](https://visualstudio.microsoft.com/)
- Banco de dados relacional MySQL

## ⚙️ Configuração

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/sua-api-login-jwt.git
   cd sua-api-login-jwt
 1. Execute o comando:
   ```bash
    dotnet -run
