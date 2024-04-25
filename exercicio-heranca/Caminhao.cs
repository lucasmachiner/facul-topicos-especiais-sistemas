public class Caminhao : Veiculo
{
  public double CapacidadeCarga { get; set; }

  public void Ligar()
  {
    Console.WriteLine("Caminhão ligado...");
  }
}