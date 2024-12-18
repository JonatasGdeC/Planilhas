using Planilhas.Enums;

namespace Planilhas.Models;

public class RegisterOutpus
{
  public Guid Id { get; set; }
  public OutputsType OutputType { get; set; }
  public double? Valor { get; set; }
}
