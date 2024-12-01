Podcast podcast1 = new("Humberto Lucio", "Pod C#");

Episodio episodio1 = new(2, "C# na teoria", 100)
{
    Resumo = "Como aprender C#"
};

Episodio episodio2 = new(1, "C# na prática", 100)
{
    Resumo = "Como aplicar C#"
};

episodio1.AdicionarConvidados("Maria");
episodio2.AdicionarConvidados("Jósé");
episodio2.AdicionarConvidados("João");

podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);
Console.WriteLine($"PODCAST - {podcast1.Nome}");
podcast1.ExibirDetalhes();