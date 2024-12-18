namespace Planilhas.Models;

public class Register
{
  public Guid Id { get; set; }
  public int Talao { get; set; }
  public DateTime Date { get; set; }
  public required string Name { get; set; }
  public double? Dizimo { get; set; }
  public double? Oferta { get; set; }
}
