using DesafioIterupApi.Models;
using DesafioIterupApi.Respositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioIterupApi.Respositories.Repository
{
    public class RespostaRepository : IRespostaRepository
    {
        //Criando uma objeto global de Respostas
        List<RespostaModel> Respostas = new List<RespostaModel>();
        public RespostaRepository()
        {
            //Criando os dados de Respostas para manipulacao
            var Resposta1 = new RespostaModel
            {
                RespostaId = 1,
                EtapaId = 1,
                Legenda = "Sim",
                ProxEtapaId = 3
            };

            var Resposta2 = new RespostaModel
            {
                RespostaId = 2,
                EtapaId = 1,
                Legenda = "Não",
                ProxEtapaId = 2
            };

            var Resposta3 = new RespostaModel
            {
                RespostaId = 1,
                EtapaId = 2,
                Legenda = "Claro",
                ProxEtapaId = 3
            };

            var Resposta4 = new RespostaModel
            {
                RespostaId = 2,
                EtapaId = 2,
                Legenda = "Não, obrigado",
                ProxEtapaId = 3
            };

            var Resposta5 = new RespostaModel
            {
                RespostaId = 1,
                EtapaId = 3,
                Legenda = "Voltar para o início",
                ProxEtapaId = 1
            };

            Respostas.Add(Resposta1);
            Respostas.Add(Resposta2);
            Respostas.Add(Resposta3);
            Respostas.Add(Resposta4);
            Respostas.Add(Resposta5);
        }
        public List<RespostaModel> GetRespostas()
        {
            return Respostas;
        }

        public RespostaModel GetResposta(int EtapaId, int RespostaId)
        {
            return Respostas.Where(r => r.EtapaId == EtapaId && r.RespostaId == RespostaId).FirstOrDefault();
        }

        public List<RespostaModel> CreateResposta(RespostaModel Resposta)
        {
            Respostas.Add(Resposta);

            return Respostas;
        }

        public List<RespostaModel> EditResposta(RespostaModel Resposta)
        {
            foreach (var RespostaItem in Respostas)
            {
                if (RespostaItem.EtapaId == Resposta.EtapaId && RespostaItem.RespostaId == Resposta.RespostaId)
                {
                    RespostaItem.ProxEtapaId = Resposta.ProxEtapaId;
                    RespostaItem.Legenda = Resposta.Legenda;
                }
            }

            return Respostas;
        }

        public List<RespostaModel> DeleteResposta(int EtapaId, int RespostaId)
        {
            var DeleteResposta = Respostas.Where(r => r.EtapaId == EtapaId && r.RespostaId == RespostaId).FirstOrDefault();

            Respostas.Remove(DeleteResposta);

            return Respostas;
        }
    }
}
