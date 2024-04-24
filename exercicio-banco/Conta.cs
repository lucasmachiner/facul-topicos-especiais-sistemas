public class Conta : IContaBancaria
{
  public int NumeroConta { get; set; }
  public decimal Saldo { get; set; }
  public decimal SaldoFinal { get; set; }
  public string? TipoConta { get; set; }
  public string? TipoTransaca { get; set; }
  public decimal Trasacao(string tipoTransacao, decimal valor)
  {
    TipoTransaca = tipoTransacao;
    if (tipoTransacao == "saque")
    {
      return SaldoFinal = Saldo + valor;
    }
    else
    {
      return SaldoFinal = Saldo - valor;
    }

  }
}