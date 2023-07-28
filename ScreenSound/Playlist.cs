class Playlist
{

    
    public string Nome { get; }
    private List<Musica> playlist = new List<Musica>();

    public Playlist(string nome)
    {
        Nome = nome;
    }

    public void AdicionarMusicaNaPlaylist(Musica musica) {
        playlist.Add(musica);
    }

    public void ExibirPlaylist() {
        Console.WriteLine($"\nMinha Playlist {Nome}");
        foreach (Musica musica in playlist)
        {
            Console.WriteLine($"{musica.Nome} - {musica.Artista.Nome}");
        }
    }

}