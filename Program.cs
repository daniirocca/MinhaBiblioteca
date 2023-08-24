// Criando instâncias da classe Autor
Autor nicolasSpark = new Autor("Nicolas Spark");
Autor claytonMChristensen = new Autor("Clayton M. Christensen");
Autor donellaHMeadows = new Autor("Donella H. Meadows");

// Criando instâncias da classe Livro e associando autores
Livro livro1 = new Livro("Querido John", 384);
livro1.Lido = true;
nicolasSpark.AdicionarLivro(livro1);

Livro livro2 = new Livro("Gerenciando a si mesmo", 208);
livro2.Lido = true;
claytonMChristensen.AdicionarLivro(livro2);

Livro livro3 = new Livro("Pensando em Sistemas", 256);
livro3.Lido = false;
donellaHMeadows.AdicionarLivro(livro3);

// Exibindo informações técnicas dos livros
livro1.ExibirFichaTecnica();
livro2.ExibirFichaTecnica();
livro3.ExibirFichaTecnica();