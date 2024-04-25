public class Carro : Veiculo
{
  public int NumeroPortas { get; set; }

  public void Ligar()
  {
    Console.WriteLine("Carro ligado...");
  }
}