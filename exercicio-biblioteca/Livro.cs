public class Livro
{
  public int Id { get; set; }
  public string? Titulo { get; set; }
  public string? Autor { get; set; }
  public bool Indicativo { get; set; }
  public void ExibirLivro()
  {
    Console.WriteLine("esta exibindo algo");
  }
}