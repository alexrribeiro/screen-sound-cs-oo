Album letgo = new Album();
letgo.Nome = "Let Go";

Musica musica1 = new Musica();
musica1.Nome = "Complicated";
musica1.Duracao = 244;
musica1.Genero = new Genero();
musica1.Genero.Tipo = "Pop rock";

Musica musica2 = new Musica();
musica2.Nome = "My World";
musica2.Duracao = 207;
musica2.Genero = new Genero();
musica1.Genero.Tipo = "Pop rock";

letgo.AdicionarMusica(musica1);
letgo.AdicionarMusica(musica2);

letgo.ExibirMusicasDoAlbum();

musica2.ExibirFichaTecnica();