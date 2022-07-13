using System.ComponentModel.DataAnnotations;

namespace CSRegler.Data;

internal sealed class Datenpunkt
{
    [Key]
    public int DatenpunktId { get; set; }

    [Required]
    public int DPNummer { get; set; } 

    [Required]
    public string DPWert { get; set; } = string.Empty;

    [MaxLength(200)]
    public string DPBeschreibung { get; set; } = string.Empty;

    [MaxLength(200)]
    public string DPBeschreibungEN { get; set; } = string.Empty;

    [MaxLength(200)]
    public string DPRange { get; set; } = string.Empty;

}