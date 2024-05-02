public class ReservaRegular : IReserva
{
  public string Passageiro { get; set; }
  public bool Reservado { get; set; }
  public void ReservarVoo() { }
  public void CancelarReserva();
  public void VerificarReserva();
}