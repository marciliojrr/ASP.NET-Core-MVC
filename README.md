# ASP.NET-Core-MVC
Desenvolvimento Web do ASP.NET Core MVC com controladores e exibições.

---
Projeto baseado no artigo da Microsoft, disponível em:
[Introdução ao ASP.NET Core MVC](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/start-mvc?WT.mc_id=dotnet-35129-website&view=aspnetcore-6.0&tabs=visual-studio)

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