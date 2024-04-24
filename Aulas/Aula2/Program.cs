// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Intanciar uma universidade 
Universidade UP = new Universidade();

UP.Nome = "Universidade Positivo";
UP.Localizacao = "Praça Osório";
UP.AnoFundacao = 2016;

Console.WriteLine("UP >> " + UP.Nome);

Curso ADS = new Curso();
ADS.Nome = "Analise e Desenvolvimento de Sistemas";
ADS.Area = "Computação";
ADS.Duracao = 2;
//Passo 2 Adicionar o curso na Uniersidade 
UP.adicionarCurso(ADS);

Curso BSI = new Curso();
BSI.Nome = "BSI";
BSI.Area = "Computação";
BSI.Duracao = 4;

UP.adicionarCurso(BSI);

foreach (var curso in UP.Cursos)
{
    Console.WriteLine("Cursos " + curso.Nome);
}
