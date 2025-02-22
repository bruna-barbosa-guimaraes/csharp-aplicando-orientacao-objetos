﻿class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get;  }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string TituloCompleto => $"{Nome} - {Artista}";

    public void ExibirInformacoes()
    {
     //   Console.WriteLine(TituloCompleto);
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
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

