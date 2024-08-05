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

////////////////////////////////////////////////

//Banda arcticMonkeys = new Banda("Arctic Monkeys");

//Album albumArcticMonkeys = new Album("Whatever People Say I Am, That's What I'm Not ");

//Musica musica1 = new Musica(arcticMonkeys, "The View from the Afternoon")
//{
//    Duracao = 213,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(arcticMonkeys, "I Bet You Look Good on the Dancefloor")
//{
//    Duracao = 354,
//    Disponivel = true,
//};

//albumArcticMonkeys.AdicionarMusica(musica1);
//albumArcticMonkeys.AdicionarMusica(musica2);
//arcticMonkeys.AdicionarAlbum(albumArcticMonkeys);

//musica1.ExibirInformacoes();
//musica2.ExibirInformacoes();
//albumArcticMonkeys.exibirAlbum();
//arcticMonkeys.ExibirDiscografia();

////////////////////////////////////////////////

Episodio ep1 = new (450, 1, "Episódio teste");
ep1.AdicionarConvidados("Vinicius");
ep1.AdicionarConvidados("Bruna");

Episodio ep2 = new(560, 2, "Episódio novo");
ep2.AdicionarConvidados("Gabi");
ep2.AdicionarConvidados("João");

Podcast podcast1 = new("Flow Podcast", "Igor");
podcast1.AdicionarEpsodio(ep1);
podcast1.AdicionarEpsodio(ep2);
podcast1.ExibirDetalhes();