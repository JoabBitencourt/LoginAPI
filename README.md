
# LoginAPI

Este é um **projeto de estudo** desenvolvido com ASP.NET Core, que implementa um sistema de autenticação baseado em JWT, com uso do Entity Framework Core e MySQL. O objetivo é estudar boas práticas em APIs RESTful, autenticação e organização de código em camadas.

This is a **study project** built using ASP.NET Core that implements an authentication system based on JWT, using Entity Framework Core and MySQL. The goal is to explore best practices for RESTful APIs, authentication, and layered architecture.

---

## 📁 Estrutura do Projeto | Project Structure

```
LoginAPI/
│
├── Configurations/         ← Injeção de dependências / Dependency injection setup
├── Controllers/            ← Endpoints da API / API endpoints
├── Data/                   ← Contexto EF Core / EF Core context
├── Dtos/                   ← Objetos de transferência / Transfer objects
├── Migrations/             ← Migrações do banco / EF Core migrations
├── Models/                 ← Entidades / Domain entities
├── Repositories/           ← Acesso a dados / Data access
├── Security/               ← Geração/validação de token JWT / JWT generation/validation
├── Services/               ← Lógica de negócio / Business logic
│
├── appsettings.json        ← Configurações / Configuration
├── Program.cs              ← Ponto de entrada / Entry point
├── README.md               ← Este arquivo / This file
```

---

## ⚙️ Configuração | Setup

### 🇧🇷 Em português:

1. Clone o projeto:

   ```bash
   git clone https://github.com/seu-usuario/LoginAPI.git
   cd LoginAPI
   ```

2. Configure o `appsettings.json`:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "server=localhost;database=LoginDb;user=root;password=sua_senha"
     },
     "JwtSettings": {
       "Key": "sua-chave-secreta-bem-grande",
       "Issuer": "LoginAPI",
       "Audience": "LoginAPIUsers"
     }
   }
   ```

3. Rode as migrações do banco de dados:

   ```bash
   dotnet ef database update
   ```

4. Inicie o projeto:

   ```bash
   dotnet run
   ```

---

### 🇺🇸 In English:

1. Clone the repository:

   ```bash
   git clone https://github.com/your-user/LoginAPI.git
   cd LoginAPI
   ```

2. Configure `appsettings.json`:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "server=localhost;database=LoginDb;user=root;password=your_password"
     },
     "JwtSettings": {
       "Key": "your-super-secret-key",
       "Issuer": "LoginAPI",
       "Audience": "LoginAPIUsers"
     }
   }
   ```

3. Run database migrations:

   ```bash
   dotnet ef database update
   ```

4. Start the project:

   ```bash
   dotnet run
   ```

---

## 📘 Funcionalidades | Features

- 🔐 Registro e login de usuários com senha criptografada (BCrypt)  
  User registration and login with encrypted passwords (BCrypt)
- 🔑 Autenticação via token JWT  
  JWT-based authentication
- 📚 Documentação automática com Swagger  
  Automatic documentation with Swagger
- 🧱 Arquitetura em camadas com boas práticas  
  Layered architecture with clean organization
- 📦 Injeção de dependências com extensão de serviços  
  Dependency injection via service extensions

---

## 📌 Observações | Notes

- Este projeto é experimental e voltado para fins educacionais.  
  This project is experimental and for educational purposes only.
- Você pode acessar o Swagger em `https://localhost:5001/swagger` após rodar o projeto.  
  You can access Swagger at `https://localhost:5001/swagger` after running the project.

---

## 🧪 Dependências | Dependencies

- [.NET 8](https://dotnet.microsoft.com/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [Pomelo.EntityFrameworkCore.MySql](https://www.nuget.org/packages/Pomelo.EntityFrameworkCore.MySql)
- [BCrypt.Net-Next](https://www.nuget.org/packages/BCrypt.Net-Next)
- [AutoMapper.Extensions.Microsoft.DependencyInjection](https://www.nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection)
- [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore)

---

## 🚀 Contribuição | Contributing

Pull requests são bem-vindos! Para mudanças maiores, por favor, abra uma issue primeiro para discutir o que você gostaria de modificar.

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

---

## 🧑‍💻 Autor | Author

**Joab Bitencourt**  
GitHub: [@seu-usuario](https://github.com/seu-usuario)
