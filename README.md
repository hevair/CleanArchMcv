# CleanArchMvc - Projeto de Catálogo de Produtos 🛒

## Escopo Geral 🌐

### Objetivo 🎯

O projeto CleanArchMvc tem como objetivo criar uma aplicação web utilizando ASP.NET Core MVC para o gerenciamento de produtos e categorias, proporcionando a criação de um catálogo de produtos para vendas.

### Ferramentas Utilizadas 🛠️

-   Visual Studio Community (ou VS Code)
-   ASP.NET Core MVC
-   Entity Framework Core
-   SQL Server

## Estrutura do Projeto 🏗️

O projeto CleanArchMvc segue a abordagem da Clean Architecture, com os seguintes componentes distribuídos por camadas:

1.  **CleanArchMvc.Domain:**
    
    -   `Entities`: Contém as classes que representam o modelo de domínio (Product e Category).
    -   `Interfaces`: Contém as interfaces (ICategoryRepository, IProductRepository).
    -   `Validation`: Contém a classe `DomainExceptionValidation` para validar o modelo de domínio.
2.  **CleanArchMvc.Application:**
    
    -   `Services`: Contém os serviços (ProductService, CategoryService).
    -   `Interfaces`: Contém as interfaces (IProductService, ICategoryService).
    -   `DTOs`: Contém os Data Transfer Objects (ProductDTO, CategoryDTO).
    -   `Mappings`: Contém mapeamentos entre domínio e visão (DomainViewModel, ViewModelDomain).
    -   `CQRS`: Implementação do padrão Command-Query Responsibility Segregation.
    -   `Exceptions`: Tratamento de exceções específicas.
3.  **CleanArchMvc.Infra.Data:**
    
    -   `Repositories`: Implementação concreta dos repositórios (ProductRepository, CategoryRepository).
    -   `Context`: Implementação do DbContext (ApplicationDbContext).
    -   `Migrations`: Migrations para versionamento do banco de dados.
    -   `Identity`: Configuração para autenticação e autorização com Identity.
4.  **CleanArchMvc.Infra.IoC:**
    
    -   `DependencyInjection`: Configuração da injeção de dependência e registro de serviços.
    -   `Lifetime`: Utilização dos padrões de tempo de vida (Transient, Scoped, Singleton).
5.  **CleanArchMvc.WebUI:**
    
    -   `Controllers`: Controladores da aplicação (AccountController, CategoriesController, ProductsController).
    -   `Views`: Arquivos de visualização da aplicação.
    -   `Filters`: Filtros utilizados na aplicação.
    -   `MapConfig`: Configurações de mapeamento entre domínio e visão.
    -   `ViewModels`: Modelos de visão utilizados pela camada de apresentação.


## Persistência dos Dados 💾

-   Banco de dados relacional: SQL Server.
-   ORM: Entity Framework Core.
-   Abordagem Code-First.
-   Provedor do banco de dados: Microsoft.EntityFrameworkCore.SqlServer.
-   Ferramenta para aplicar Migrations: Microsoft.EntityFrameworkCore.Tools.
-   Desacoplamento da camada de acesso a dados do ORM usando o padrão Repository.

## Nomenclatura 📏

-   CamelCase: `valorDoDesconto`, `nomeCompleto`.
-   PascalCase: `CalculaImpostoDeRenda`, `ValorDoDesconto`.
-   Classes: PascalCase.
-   Interfaces: `I` + PascalCase.
-   Métodos, Propriedades: PascalCase.
-   Variáveis, Parâmetros: camelCase.
-   Constantes: Maiúsculo + sublinhado.

## Estrutura do Projeto CleanArchMvc 🏠

-   CleanArchMvc.Domain: Sem dependências.
-   CleanArchMvc.Application: Dependência com CleanArchMvc.Domain.
-   CleanArchMvc.Infra.Data: Dependência com CleanArchMvc.Domain.
-   CleanArchMvc.Infra.IoC: Dependência com CleanArchMvc.Domain, CleanArchMvc.Application, CleanArchMvc.Infra.Data.
-   CleanArchMvc.WebUI: Dependência com CleanArchMvc.Infra.IoC.

## Testes de Unidade 🧪

-   Idioma: Inglês.
-   Nome do teste: `<Método ou Classe>_<Cenário de Teste>_<Resultado Esperado>`.

Exemplo:


```C#
[Fact(DisplayName="Create Category Object With Valid State")]
public void CreateProduct_WithValidParameters_ResultObjectValidState()
{
    Action action = () => new Category(1, "Category Name");
    action.Should()
        .NotThrow<DomainExceptionValidation>();
} 

