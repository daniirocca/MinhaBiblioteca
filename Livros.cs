class Livro
{
    //Construtor de classe que armazena titulo do livro e quantidade de páginas
    public Livro(string titulo, int paginas)
    {
        Titulo = titulo;
        Paginas = paginas;
    }
    //Queremos uma propriedade para ler o nome do livro
    public string Titulo { get; }

    //Queremos uma propriedade para ler e definir a quantidade de páginas do livro
    public int Paginas { get; set; }

    //Propriedade para definir se o livro já foi lido, ou não
    public bool Lido { get; set; }

    public Autor Autor { get; set; } // Adiciona uma referência ao autor do livro


    //Método para obter a ficha técnica do livro
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nTítulo: {Titulo}");
        Console.WriteLine($"Páginas: {Paginas}");
        //Console.WriteLine($"Genero: {Genero}");
        if (Lido)
        {
            Console.WriteLine("Esse livro já foi lido");
        }
        else 
        {
            Console.WriteLine("Não Lido. Coloque na sua lista de leitura.");
        }
    }


}