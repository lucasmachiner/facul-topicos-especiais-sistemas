public class Circulo : FiguraGeometrica
{
  public double Raio { get; set; }
  public override double CalcularArea()
  {
    return Math.PI() * Raio;
  }
  public override double CalcularPerimetro()
  {
    return Math.PI() * Raio * 2;
  }
}