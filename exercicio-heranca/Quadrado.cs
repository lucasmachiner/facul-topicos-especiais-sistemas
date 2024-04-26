public class Quadrado : FiguraGeometrica
{
  public double Altura { get; set; }
  public double Largura { get; set; }

  public override double CalcularArea()
  {
    return Altura * Largura;
  }

  public override double CalcularPerimetro()
  {
    return 4 * Altura;
  }

}