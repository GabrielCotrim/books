# books
---
## Pre-requisitos

- Visual Studio 2019
- .NET Core 3.1

---
## Detalhes

 - Existe dois projetos executáveis
 - books-api: é o projeto backend onde foi construido toda logica da aplicação
 - books-web: é o projeto com a interface web (Ainda em construção)

---
## Configuração e Execução do Projeto Books-API

 - Abra a solução no visual studio
 - Set o projeto Books.Api como projeto que será executado e certifique-se que a opção de execução tenha o nome do projeto 'Books.Api'
 - Apos isso execute o projeto Api e verifique se o endereço aberto será: 'localhost:5001'
---
## Observações

- Os end-points da Api serão:
  - Ação de obter os volumes com paginação: **GET** 'https://localhost:5001/api/books/volumes?pesquisa=nome livro&pagina=1&itensPorPagina=10'
  - Ação de obter os volumes favoritos com paginação: **GET** 'https://localhost:5001/api/books/favorites?pagina=2&itensPorPagina=10'
  - Ação de deletar um volume favorito: **DELETE** 'https://localhost:5001/api/books/favorite?id=id-volume'
  - Ação de inserir volume aos favoritos: **POST** 'https://localhost:5001/api/books/favorite'
    - Body:
    {
      "id":"",
      "titulo":"",
      "resumo":"",
      "imageLink":""
    }
  
