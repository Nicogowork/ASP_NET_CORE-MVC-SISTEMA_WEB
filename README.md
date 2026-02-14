# Sistema Web - ASP.NET Core MVC

Sistema Web desenvolvido em ASP.NET Core MVC (.NET 8.0) com operações CRUD para gestão de clientes.

## Tecnologias

- **ASP.NET Core MVC** (.NET 8.0)
- **Entity Framework Core 8.0** (SQL Server)
- **Bootstrap** (frontend)
- **Razor Views**

## Estrutura do Projeto

```
Sistema_Web/
├── Controllers/
│   ├── HomeController.cs        # Páginas principais (Home, Portfólio, Serviços)
│   └── ClientesController.cs    # CRUD de Clientes
├── Models/
│   ├── Cliente.cs               # Modelo de dados do Cliente
│   └── ErrorViewModel.cs        # Modelo de erros
├── Data/
│   └── DbClienteContext.cs      # Contexto do Entity Framework (SQL Server)
├── Views/
│   ├── Home/                    # Index, Portfólio, Serviços, Erro
│   ├── Clientes/                # Index, Create, Edit, Delete, Details
│   └── Shared/                  # Layout e scripts de validação
├── wwwroot/                     # Ficheiros estáticos (CSS, JS, imagens)
├── Program.cs                   # Configuração da aplicação
└── appsettings.json             # Configurações e connection string
```

## Funcionalidades

- Página inicial, portfólio e serviços
- CRUD completo de Clientes (Criar, Listar, Editar, Eliminar, Detalhes)
- Ligação a base de dados SQL Server via Entity Framework Core

## Como Executar

1. Configurar a connection string em `appsettings.json`
2. Aplicar as migrações:
   ```bash
   dotnet ef database update
   ```
3. Executar a aplicação:
   ```bash
   dotnet run
   ```

## Autor

Desenvolvido como exercício de ASP.NET Core MVC.
