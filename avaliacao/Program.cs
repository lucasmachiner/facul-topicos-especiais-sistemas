// See https://aka.ms/new-console-template for more information
Locadora locadora = new Locadora();
Filme filme = new Filme();

filme.Titulo = "Borat";
filme.Genero = "Comedia";
filme.Duracao = 1.60;
filme.Disponivel = true;

locadora.AdicionarFilme(filme);

Filme filme1 = new Filme();

filme1.Titulo = "Teste";
filme1.Genero = "Ação";
filme1.Duracao = 1.80;
filme1.Disponivel = false;

locadora.AdicionarFilme(filme1);

Console.WriteLine("----------------- Locar filmes -----------------");
locadora.LocarFilme("Borat");
locadora.LocarFilme("Teste");


Console.WriteLine("----------------- Devolver filmes -----------------");
locadora.DevolverFilme("Borat");