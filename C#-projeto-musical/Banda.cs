class Banda
{
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;}
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void ExibirDiscografia()
    {
        System.Console.WriteLine($"Discografia da banda {Nome}");
            foreach(Album album in albums)
            {
                System.Console.WriteLine($"Álbum: {album.Nome}, {album.DuracaoTotal} segundos de duração.\n");
            }
    } 
}