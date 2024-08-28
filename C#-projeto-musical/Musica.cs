class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome {get;}
    public Banda Artista {get;}
    public int Duracao {get;set;}
    public bool Disponivel {get; set;}
    public string DescricaoResumida  => $"A música {Nome} pertence à banda {Artista}";
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        System.Console.WriteLine($"Duração: {Duracao}");
        if(Disponivel)
        {
            System.Console.WriteLine("Disponível no plano\n");
        }else
        {
            System.Console.WriteLine("Adquira no Plano Plus+\n");
        }
    }
}