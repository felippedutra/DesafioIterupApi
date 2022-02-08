using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioIterupApi.Models
{
    public class TipoEtapaModel
    {
        [Key]
        public int TipoEtapaId { get; set; }
        [StringLength(255)]
        public string Nome { get; set; }
    }
}
