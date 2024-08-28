class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;}
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    
    public void ExibirMusicasDoAlbum()
    {
        System.Console.WriteLine($"Lista de músicas do album {Nome}: \n");
        foreach(var musica in musicas)
        {
            System.Console.WriteLine($"Música: {musica.Nome}");
        }
        System.Console.WriteLine($"Para ouvir este álbum inteiro você precisa de {DuracaoTotal} segundos.\n");
    }
}