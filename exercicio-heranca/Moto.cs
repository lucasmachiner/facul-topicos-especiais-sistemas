public class Moto : Veiculo
{
  public int Cilindradas { get; set; }

  public void Ligar()
  {
    Console.WriteLine("Moto ligada...");
  }
}