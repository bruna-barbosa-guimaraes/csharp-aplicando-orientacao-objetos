class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string host, string nome)
    {
        Nome = nome;
        Host = host;
    }
    public string Nome { get;  }
    public string Host { get; }
    public int TotalEpsodios => episodios.Count;

    public void AdicionarEpsodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Total de episódios: {TotalEpsodios}");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
    }
}