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

Ingles ingles = new Ingles();

Aluno aluno = new Aluno();
aluno.Nome = "Lucas Machiner";
aluno.Matricula = "123456";
aluno.Nota1 = 8;
aluno.Nota2 = 5;
aluno.Nota3 = 9;

ingles.NivelCurso = "Avançado";
ingles.AdicionarAluno(aluno);
ingles.CalcMedia("123456");
ingles.GerarCertificado("123456");