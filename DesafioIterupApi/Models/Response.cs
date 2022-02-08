using System.Collections.Generic;

namespace DesafioIterupApi.Models
{
    public class Response
    {
        public Cabecalho Cabecalho { get; set; }
        public List<object> Conteudo { get; set; } = new List<object>();
    }
}
