/* Banda RaizCoral = new Banda("Raiz Coral");

Album albumDoRaizCoral = new Album("Vencedor");

Musica musica1 = new Musica(RaizCoral, "Perfume")
{
    Duracao = 279,
    Disponivel = true,
};

Musica musica2 = new Musica(RaizCoral, "Lugar secreto")
{
    Duracao = 405,
    Disponivel = false,
};

albumDoRaizCoral.AdicionarMusica(musica1);
albumDoRaizCoral.AdicionarMusica(musica2);
RaizCoral.AdicionarAlbum(albumDoRaizCoral);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoRaizCoral.ExibirMusicasDoAlbum();
RaizCoral.ExibirDiscografia();

// Desafio
Genero generoMusicaGospel = new Genero();
generoMusicaGospel.Nome = "Gospel";

generoMusicaGospel.AdicionarMusica(musica1);
generoMusicaGospel.AdicionarMusica(musica2);
Console.WriteLine("******************\n");
generoMusicaGospel.ExibirMusicasDoGenero();


// Desafio

Playlist minhaPlaylist = new Playlist("Só música boa");
minhaPlaylist.AdicionarMusicaNaPlaylist(musica1);
minhaPlaylist.AdicionarMusicaNaPlaylist(musica2);

minhaPlaylist.ExibirPlaylist(); */

Episodio ep1 = new(1, "A Multiplicação", 45);
ep1.AdicionarConvidados("Pedro");
ep1.AdicionarConvidados("Tiago");
ep1.AdicionarConvidados("João");

Episodio ep2 = new(2, "A transfiguração de Jesus", 50);
ep2.AdicionarConvidados("Pedro");
ep2.AdicionarConvidados("Tiago");
ep2.AdicionarConvidados("João");

Episodio ep3 = new(3, "Pentecoste", 50);
ep3.AdicionarConvidados("Pedro");
ep3.AdicionarConvidados("Tiago");
ep3.AdicionarConvidados("João");
ep3.AdicionarConvidados("Apostolos");

Podcast podcast = new("Podcast Bíblicos", "Jesus");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.ExibirDetalhes();