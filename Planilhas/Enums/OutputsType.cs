using System.ComponentModel.DataAnnotations;

namespace Planilhas.Enums;

public enum OutputsType
{
  [Display(Name = "Água e Esgoto")]
  AguaEEsgoto,

  [Display(Name = "Água Mineral e Copos")]
  AguaMineralECopos,

  [Display(Name = "Ajuda a Necessitado")]
  AjudaANecessitado,

  [Display(Name = "Ajuda a Obreiro Itinerante")]
  AjudaAObreiroItinerante,

  [Display(Name = "Ajuda Transporte Obreiro")]
  AjudaTransporteObreiro,

  [Display(Name = "Aluguel de Imóveis")]
  AluguelDeImoveis,

  [Display(Name = "Aluguel de Ônibus")]
  AluguelDeOnibus,

  [Display(Name = "Contas de Internet")]
  ContasDeInternet,

  [Display(Name = "Despesas Festividades/Eventos")]
  DespesasFestividadesEventos,

  [Display(Name = "Diárias de Limpeza")]
  DiariasDeLimpeza,

  [Display(Name = "Energia Elétrica")]
  EnergiaEletrica,

  [Display(Name = "Gêneros Alimentícios")]
  GenerosAlimenticios,

  [Display(Name = "I.P.T.U.")]
  IPTU,

  [Display(Name = "Instrumentos Musicais")]
  InstrumentosMusicais,

  [Display(Name = "Literaturas")]
  Literaturas,

  [Display(Name = "Manutenção e Conservação")]
  ManutencaoEConservacao,

  [Display(Name = "Mão de Obras Terceiros")]
  MaoDeObrasTerceiros,

  [Display(Name = "Material de Escritório")]
  MaterialDeEscritorio,

  [Display(Name = "Material de Limpeza")]
  MaterialDeLimpeza,

  [Display(Name = "Material de Santa Ceia")]
  MaterialDeSantaCeia,

  [Display(Name = "Móveis e Utensílios")]
  MoveisEUtensilios,

  [Display(Name = "Segurança e Vigilância")]
  SegurancaEVigilancia,

  [Display(Name = "Som e Acessórios")]
  SomEAcessorios,

  [Display(Name = "Combustível Pastor")]
  CombustivelPastor
}
