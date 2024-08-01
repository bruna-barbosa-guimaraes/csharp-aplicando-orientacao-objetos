class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void exibirAlbum()
    {
        Console.WriteLine($"Álbum: {Nome}");
        Console.WriteLine($"Duração total: {DuracaoTotal}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine(musica.Nome);
        }
    }
}