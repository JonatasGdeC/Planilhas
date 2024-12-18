using Planilhas.Enums;

namespace Planilhas.Models;

public class RegisterInputs
{
  public Guid Id { get; set; }
  public int Talao { get; set; }
  public InputsType? InputType { get; set; }
  public DateTime Date { get; set; }
  public string? Name { get; set; }
  public double? Dizimo { get; set; }
  public double? Oferta { get; set; }
}
