using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioIterupApi.Models
{
    public class Cabecalho
    {
        public bool Erro { get; set; }
        public int CodErro { get; set; }
        [StringLength(255)]
        public string MsgErro { get; set; }
    }
}
