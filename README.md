# Sistema de Gerenciamento de Autores e Livros

Este é um projeto simples em C# que modela autores e livros e permite associar livros a autores e exibir informações técnicas sobre eles. O projeto demonstra conceitos de programação orientada a objetos e encapsulamento.

## Estrutura do Projeto

O projeto é composto por duas classes principais:

1. `Autor`: Representa um autor de livros e permite adicionar livros à lista de livros do autor e mostrar os livros de um autor.

2. `Livro`: Representa um livro com título, número de páginas, status de leitura e uma referência ao autor. Também permite exibir a ficha técnica do livro.

## Como Usar

1. Crie instâncias da classe `Autor` para representar autores.

2. Crie instâncias da classe `Livro` associando-os a autores.

3. Utilize os métodos disponíveis para mostrar informações sobre os autores e livros.

### Exemplo de Uso

```csharp
// Criando instâncias da classe Autor
Autor nicolasSpark = new Autor("Nicolas Spark");
Autor claytonMChristensen = new Autor("Clayton M. Christensen");

// Criando instâncias da classe Livro e associando autores
Livro livro1 = new Livro("Querido John", 384, nicolasSpark);
Livro livro2 = new Livro("Gerenciando a si mesmo", 208, claytonMChristensen);

// Exibindo informações técnicas dos livros
livro1.ExibirFichaTecnica();
livro2.ExibirFichaTecnica();

Contribuições
Contribuições são bem-vindas! Se você quiser melhorar este projeto ou adicionar novos recursos, siga estas etapas:

Faça um fork deste repositório.

Crie um branch para suas alterações: git checkout -b minha-alteracao.

Faça suas alterações e commit: git commit -m 'Minha alteração'.

Envie suas alterações para o seu fork: git push origin minha-alteracao.

Abra um Pull Request neste repositório.

Licença
Este projeto é licenciado sob a Licença MIT - veja o arquivo LICENSE para detalhes.

Divirta-se explorando e melhorando este projeto! Se tiver alguma dúvida ou sugestão, sinta-se à vontade para abrir uma issue.


Lembre-se de substituir `seu-usuario` e `seu-repositorio` pelas informações corretas do seu repositório no GitHub.
