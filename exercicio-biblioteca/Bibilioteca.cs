public class Biblioteca
{
  public string? NomeBiblioteca { get; set; }
  public string? Endereco { get; set; }
  public List<Estante> Estantes = new List<Estante>();
  public void ExibirBiblioteca()
  {
    Console.WriteLine("esta exibindo algo");
  }
  public void AdicionarEstante(Estante estante)
  {
    Estantes.Add(estante);
  }
}