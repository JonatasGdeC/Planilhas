namespace Planilhas.Models;

public class RegisterDeposit
{
  public Guid Id { get; set; }
  public DateTime Date { get; set; }
  public int Receipt { get; set; }
  public double Valor { get; set; }
}
