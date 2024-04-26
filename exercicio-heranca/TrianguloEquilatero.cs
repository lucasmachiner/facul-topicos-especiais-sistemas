public class TrianguloEquilatero : FiguraGeometrica
{
  public double Altura { get; set; }
  public double Base { get; set; }

  public override double CalcularArea()
  {
    return (Altura * Base) / 2;
  }

  public override double CalcularPerimetro()
  {
    return Base * 3;
  }
}