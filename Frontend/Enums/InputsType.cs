using System.ComponentModel.DataAnnotations;

namespace Frontend.Enums;

public enum InputsType
{
  [Display(Name = "Assistência")]
  Assistencia,

  [Display(Name = "Umadesa")]
  Umadesa,

  [Display(Name = "CEAC")]
  Ceac,

  [Display(Name = "Caped Sand")]
  CapedSand
}
