using Planilhas.Enums;

namespace Planilhas.Models;

public class RegisterOutputs
{
  public Guid Id { get; set; }
  public OutputsType OutputType { get; set; }
  public double? Valor { get; set; }
}
