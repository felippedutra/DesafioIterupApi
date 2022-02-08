using DesafioIterupApi.Models;
using DesafioIterupApi.Respositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioIterupApi.Respositories.Repository
{
    public class EtapaRepository : IEtapaRepository
    {
        //Criando uma objeto global de Etapas
        List<EtapaModel> Etapas = new List<EtapaModel>();
        public EtapaRepository()
        {
            //Criando os dados de Etapas para manipulação
            var Etapa1 = new EtapaModel
            {
                EtapaId = 1,
                TipoEtapaId = 1,
                Texto = "Me diga, você já utilizou os nossos produtos",
                ProxEtapaId = 2
            };
            var Etapa2 = new EtapaModel
            {
                EtapaId = 2,
                TipoEtapaId = 1,
                Texto = "Não? Então deixa eu te apresentar?",
                ProxEtapaId = 3
            };
            var Etapa3 = new EtapaModel
            {
                EtapaId = 3,
                TipoEtapaId = 1,
                Texto = "Nossos produtos são os mais TOPs das Galáxias, vamos começar de novo!"
            };

            Etapas.Add(Etapa1);
            Etapas.Add(Etapa2);
            Etapas.Add(Etapa3);
        }
        public List<EtapaModel> GetEtapas()
        {
            return Etapas;
        }

        public EtapaModel GetEtapa(int EtapaId)
        {
            return Etapas.Where(e => e.EtapaId == EtapaId).FirstOrDefault();
        }

        public List<EtapaModel> CreateEtapa(EtapaModel Etapa)
        {
            Etapas.Add(Etapa);

            return Etapas;
        }

        public List<EtapaModel> EditEtapa(EtapaModel Etapa)
        {
            foreach (var EtapaItem in Etapas)
            {
                if(EtapaItem.EtapaId == Etapa.EtapaId)
                {
                    EtapaItem.ProxEtapaId = Etapa.ProxEtapaId;
                    EtapaItem.Texto = Etapa.Texto;
                    EtapaItem.TipoEtapaId = Etapa.TipoEtapaId;
                }
            }

            return Etapas;
        }

        public List<EtapaModel> DeleteEtapa(int EtapaId)
        {
            var DeleteEtapa = Etapas.Where(e => e.EtapaId == EtapaId).FirstOrDefault();

            Etapas.Remove(DeleteEtapa);

            return Etapas;
        }
    }
}
