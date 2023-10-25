Musica musica1 =  new Musica();
musica1.Nome = "Blinding Lights";
musica1.Artista = "The Weeknd";
musica1.Duracao = 199;
musica1.Disponivel = true;
//Console.WriteLine(musica1.Disponivel);
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "Higher Power";
musica2.Artista = "Coldplay";
musica2.Duracao = 209;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

//musica1.ExibirNomeEArtista();
//musica2.ExibirNomeEArtista();