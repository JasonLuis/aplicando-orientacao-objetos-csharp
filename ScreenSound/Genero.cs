class Genero {

    public string Nome { get; set; }
    private List<Musica> musicas  = new List<Musica>();

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoGenero() {
        Console.WriteLine($"Lista de músicas do genero {Nome}: \n");
        foreach (Musica musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
    }
 
}