using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioIterupApi.Models
{
    public class EtapaModel
    {
        [Key]
        public int EtapaId { get; set; }
        [Required]
        [StringLength(255)]
        public string Texto { get; set; }
        [ForeignKey("ProxEtapa")]
        public int ProxEtapaId { get; set; }
        [ForeignKey("TipoEtapa")]
        public int TipoEtapaId { get; set; }
        public virtual EtapaModel ProxEtapa { get; set; }
        public virtual TipoEtapaModel TipoEtapa { get; set; }
        public virtual IEnumerable<RespostaModel> Respostas { get; set; }
    }
}
