class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string TituloCompleto => $"{Nome} - {Artista}";

    public void ExibirInformacoes()
    {
     //   Console.WriteLine(TituloCompleto);
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");

        }
        else
        {
            Console.WriteLine("Adquira o plano Plus");
        }
    }
}

