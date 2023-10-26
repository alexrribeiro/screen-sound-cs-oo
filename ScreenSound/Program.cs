//Album letgo = new Album();
//letgo.Nome = "Let Go";

Banda paramore = new Banda("Paramore");

Album riot = new Album("Riot!");

//Musica musica1 = new Musica();
//musica1.Nome = "Complicated";
//musica1.Duracao = 244;
//musica1.Genero = new Genero { Tipo = "Pop rock" };

//Musica musica2 = new Musica();
//musica2.Nome = "My World";
//musica2.Duracao = 207;
//musica2.Genero = new Genero { Tipo = "Pop rock" };

Musica musica3 = new Musica(paramore, "That's What You Get")
{
    Duracao = 220,
    Disponivel = true
};
musica3.Genero = new Genero { Tipo = "Rock" };

Musica musica4 = new Musica(paramore, "Misery Business")
{
    Duracao = 211,
    Disponivel = false
};
musica4.Duracao = 211;
musica4.Genero = new Genero { Tipo = "Rock" };

//letgo.AdicionarMusica(musica1);
//letgo.AdicionarMusica(musica2);
riot.AdicionarMusica(musica3);
riot.AdicionarMusica(musica4);
paramore.AdicionarAlbum(riot);

musica3.ExibirFichaTecnica();
musica4.ExibirFichaTecnica();

//letgo.ExibirMusicasDoAlbum();

//musica3.ExibirFichaTecnica();

riot.ExibirMusicasDoAlbum();

paramore.ExibirDiscografia();