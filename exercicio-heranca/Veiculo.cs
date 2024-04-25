public class Veiculo
{
  public string Marca { get; set; }
  public string Modelo { get; set; }
  public void Ligar()
  {
    Console.WriteLine("Veículo ligado...");
  }
}