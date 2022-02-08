using DesafioIterupApi.Models;
using DesafioIterupApi.Respositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioIterupApi.Respositories.Repository
{
    public class TipoEtapaRepository : ITipoEtapaRepository
    {
        public List<TipoEtapaModel> TiposEtapas()
        {
            //Criando os dados de Etapas
            List<TipoEtapaModel> TiposEtapas = new List<TipoEtapaModel>();

            var TipoEtapa1 = new TipoEtapaModel
            {
                TipoEtapaId = 0,
                Nome = "pergunta"
            };
            var TipoEtapa2 = new TipoEtapaModel
            {
                TipoEtapaId = 1,
                Nome = "mensagem"
            };

            TiposEtapas.Add(TipoEtapa1);
            TiposEtapas.Add(TipoEtapa2);

            return TiposEtapas;
        }
    }
}
