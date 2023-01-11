using System.ComponentModel.DataAnnotations;

namespace GestaoDeSoftwaresBcv.Models;

public class Software : EntidadeBase
{
    public Guid IdSoftware { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Nome { get; set; }

    [Required]
    [StringLength(20, MinimumLength = 3)]
    public string Verssao { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string LocalizacaoTeste { get; set; }
    
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string LocalizacaoProducao { get; set; }

    [DataType(DataType.Date)]
    public DateTime DataCriacao { get; set; }
        
    public string Description { get; set; }
    public TipoSoftware TipoSoftware { get; set; }
}

public enum TipoSoftware
{
    AplicacaoWeb,
    WebApi,
    webService,
    AplicacaoDesktop,
    Outros
}