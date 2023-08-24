class Autor
{
    //O autor têm varios livros, logo, criaremos uma lista
    private List<Livro> livros = new List<Livro>();

    //Vamos criar um construtor para o autor
    public Autor(string nome)
    {
        Nome = nome;
    }
    //Queremos criar uma propriedade que lê o nome do autor
    public string Nome { get; }

    //Queremos uma propriedade que^vê se o livro faz parte de uma coleção e qual coleção
    //### fica um desafio para depois

    //Queremos adicionar um livro a lista de livros
    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
        livro.Autor = this; //Estabelece a relação entre o livro e o autor
    }
    
    //Método para mostrar os livros do autor
    public void MostrarLivros()
    {
        Console.WriteLine($"Livros do autor {Nome}:");
        foreach (Livro livro in livros)
        {
            Console.WriteLine($"Livro: {livro.Titulo} (total de páginas {livro.Paginas})");
        }
    }
}