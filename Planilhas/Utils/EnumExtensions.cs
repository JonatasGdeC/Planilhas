using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Planilhas.Utils;

public static class EnumExtensions
{
  public static string GetDisplayName(this Enum value)
  {
    var fieldInfo = value.GetType().GetField(value.ToString());
    var displayAttribute = fieldInfo?
      .GetCustomAttributes<DisplayAttribute>(false)
      .FirstOrDefault();
    return displayAttribute?.Name ?? value.ToString();
  }
}
