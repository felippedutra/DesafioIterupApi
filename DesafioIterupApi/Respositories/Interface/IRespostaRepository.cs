using DesafioIterupApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioIterupApi.Respositories.Interface
{
    public interface IRespostaRepository
    {
        List<RespostaModel> GetRespostas();
        RespostaModel GetResposta(int EtapaId, int RespostaId);
        List<RespostaModel> CreateResposta(RespostaModel Resposta);
        List<RespostaModel> EditResposta(RespostaModel Resposta);
        List<RespostaModel> DeleteResposta(int EtapaId, int RespostaId);
    }
}
