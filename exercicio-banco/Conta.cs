public abstract class Conta : IContaBancaria
{
  public int NumeroConta { get; set; }
  public decimal Saldo { get; set; }

  public decimal Depositar(decimal valor)
  {
    return Saldo += valor;
  }
  public decimal Sacar(decimal valor)
  {
    return Saldo -= valor;
  }

}