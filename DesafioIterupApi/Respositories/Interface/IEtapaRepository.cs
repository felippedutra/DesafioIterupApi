using DesafioIterupApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioIterupApi.Respositories.Interface
{
    public interface IEtapaRepository
    {
        List<EtapaModel> GetEtapas();
        EtapaModel GetEtapa(int EtapaId);
        List<EtapaModel> CreateEtapa(EtapaModel Etapa);
        List<EtapaModel> EditEtapa(EtapaModel Etapa);
        List<EtapaModel> DeleteEtapa(int EtapaId);
    }
}
