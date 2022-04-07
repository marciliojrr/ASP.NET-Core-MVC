# ASP.NET-Core-MVC
Desenvolvimento Web do ASP.NET Core MVC com controladores e exibições.

---
Projeto baseado no artigo da Microsoft, disponível em:
[Introdução ao ASP.NET Core MVC](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/start-mvc?WT.mc_id=dotnet-35129-website&view=aspnetcore-6.0&tabs=visual-studio)

O projeto tem como dependência os seguintes pacotes, que podem ser adicionados através do Package Manager Console:

- `Install-Package Microsoft.EntityFrameworkCore.Design`
- `Install-Package Microsoft.EntityFrameworkCore.SqlServer`

---

# O padrão de arquitetura MVC (Model-View-Controller)

É um aplicativo em três componentes principais: Model, View e Controller. O padrão MVC ajuda a criar aplicativos que são mais testáveis e fáceis de atualizar comparado aos aplicativos monolíticos tradicionais.

## Os aplicativos baseados no MVC contêm:

### Models

Classes que representam os dados do aplicativo. As classes de modelo usam a lógica de validação para impor regras de negócio aos dados. Normalmente, os objetos de modelo recuperam e armazenam o estado do modelo em um banco de dados. Neste tutorial, um modelo Movie recupera dados de filmes de um banco de dados, fornece-os para a exibição ou atualiza-os. O dados atualizados são gravados em um banco de dados.

### Views

Exibições são os componentes que exibem a interface do usuário do aplicativo. Em geral, essa interface do usuário exibe os dados de modelo.


### Controllers

Classes que:

 - Manipulam solicitações do navegador.
 - Recuperam dados do modelo.
 - Modelos de exibição de chamada que retornam uma resposta.


## Criação do CRUD
* Clique com o botão direito do mouse na pasta _Controllers_ e selecione **Add > New Scaffolded Item...**
* selecione **MVC Controller with views, using Entity Framework > Add**
* Na caixa de diálogo **Add MVC Controller with views, Entity Framework:**
* **Model classe**: Movie (MvcMovie.Models)
* **Data context class**: selecione o sinal de **+**, em seguida o nome de classe _MvcMovie. Data. MvcMovieContext_ é gerado. Após isso, clique em **Add**. Manhenha as demais opções como estão e em **Controller name** digite _MoviesController_. Por fim clique em **Add**.

### O scaffolding cria o seguinte:
-   Um controlador de filmes:  `Controllers/MoviesController.cs`
-   Arquivos _Views Razor_ para as páginas  **criar**,  **excluir**,  **detalhes**,  **Editar** e  **indexar**:  `Views/Movies/*.cshtml`
-   Uma classe de contexto de banco de dados:  `Data/MvcMovieContext.cs`

A criação automática desses arquivos e atualizações de arquivo é conhecida como  _scaffolding_.

### Scaffolding atualiza o seguinte:
-   Insere as referências de pacote necessárias no arquivo de projeto `MvcMovie.csproj`.
-   Registra o contexto do banco de dados no  arquivo `Program.cs`.
-   Adiciona uma cadeia de conexão de banco de dados ao arquivo  `appsettings.json`.