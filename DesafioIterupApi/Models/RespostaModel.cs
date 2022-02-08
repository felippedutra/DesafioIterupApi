using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioIterupApi.Models
{
    public class RespostaModel
    {
        [Key]
        public int RespostaId { get; set; }
        [Required]
        [ForeignKey("Etapa")]
        public int EtapaId { get; set; }
        [StringLength(255)]
        public string Legenda { get; set; }
        [Required]
        [ForeignKey("Etapa")]
        public int ProxEtapaId { get; set; }
        public virtual EtapaModel Etapa { get; set; }
    }
}
