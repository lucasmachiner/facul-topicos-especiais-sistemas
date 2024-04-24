public class Transacao
{
  public void ExibirDetalhes(Conta conta)
  {
    Console.WriteLine(conta.TipoConta);
    Console.WriteLine(conta.NumeroConta);
    Console.WriteLine(conta.Saldo);
    Console.WriteLine(conta.TipoTransaca);
    Console.WriteLine(conta.SaldoFinal);
  }
}