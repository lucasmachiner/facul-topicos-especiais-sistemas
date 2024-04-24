public class Estante
{
  public int Id { get; set; }
  public List<Livro> Livros = new List<Livro>();
  public void AdicionarLivro(Livro livro)
  {
    Livros.Add(livro);
  }
  public void ExibirEstante()
  {
    Console.WriteLine("esta exibindo algo");
  }
}