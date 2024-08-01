//Musica musica1 =  new Musica();
//musica1.Nome = "Wonderwall";
//musica1.Artista = "Oasis";
//musica1.Duracao = 273;
//musica1.Disponivel = true;

//Musica musica2 = new Musica();
//musica2.Nome = "Like a stone";
//musica2.Artista = "Audioslave";
//musica2.Duracao = 346;
//musica2.Disponivel = false;

//musica1.ExibirInformacoes();
//musica2.ExibirInformacoes();


Album albumArcticMonkeys = new Album();
albumArcticMonkeys.Nome = "Whatever People Say I Am, That's What I'm Not ";

Musica musica1 = new Musica();
musica1.Nome = "The View from the Afternoon";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "I Bet You Look Good on the Dancefloor";
musica2.Duracao = 354;

albumArcticMonkeys.AdicionarMusica(musica1);
albumArcticMonkeys.AdicionarMusica(musica2);

// albumArcticMonkeys.exibirAlbum();

Banda arcticMonkeys = new Banda();
arcticMonkeys.Nome = "Arctic Monkeys";
arcticMonkeys.AdicionarAlbum(albumArcticMonkeys);
arcticMonkeys.ExibirDiscografia();