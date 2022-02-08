using DesafioIterupApi.Models;
using DesafioIterupApi.Respositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DesafioIterupApi.Controllers
{
    [ApiController]
    public class EtapaController : Controller
    {
        IEtapaRepository _etapaRepository;
        IRespostaRepository _respostaRepository;
        ITipoEtapaRepository _tipoEtapaRepository;

        public EtapaController(IEtapaRepository EtapaRepository = null, IRespostaRepository RespostaRepository = null, ITipoEtapaRepository TipoEtapaRepository = null)
        {
            _etapaRepository = EtapaRepository;
            _respostaRepository = RespostaRepository;
            _tipoEtapaRepository = TipoEtapaRepository;
        }

        /// <summary>
        /// Retorna uma lista de Etapas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/[controller]/GetEtapas")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public Response GetEtapas()
        {
            //Iniciando o obj Response
            Response response = new Response();

            var cabecalho = new Cabecalho
            {
                Erro = false,
                CodErro = 0,
                MsgErro = ""
            };

            try
            {
                var Etapas = _etapaRepository.GetEtapas();

                response.Conteudo.Add(Etapas);
            }
            catch (System.Exception)
            {
                cabecalho.Erro = true;
                cabecalho.CodErro = 500;
                cabecalho.MsgErro = "Nao foi possivel concluir a solicitacao.";
            }

            //Criando o conteudo do obj Response
            response.Cabecalho = cabecalho;

            return response;
        }


        /// <summary>
        /// Retorna uma Etapa
        /// </summary>
        /// <param name="EtapaId">Id da Etapa</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/[controller]/GetEtapa/{EtapaId}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public Response GetEtapa(int EtapaId = 0)
        {
            //Iniciando o obj Response
            Response response = new Response();

            var cabecalho = new Cabecalho
            {
                Erro = false,
                CodErro = 0,
                MsgErro = ""
            };

            try
            {
                var Etapa = _etapaRepository.GetEtapa(EtapaId);

                response.Conteudo.Add(Etapa);
            }
            catch (System.Exception)
            {
                cabecalho.Erro = true;
                cabecalho.CodErro = 500;
                cabecalho.MsgErro = "Nao foi possivel concluir a solicitacao.";
            }

            //Criando o conteudo do obj Response
            response.Cabecalho = cabecalho;

            return response;
        }

        /// <summary>
        /// Cadastro de Etapa
        /// </summary>
        /// <param name="Resposta">Modelo de dados da classe Etapa</param>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/[controller]/CreateEtapa")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public Response CreateEtapa(EtapaModel Etapa = null)
        {
            //Iniciando o obj Response
            Response response = new Response();

            var cabecalho = new Cabecalho
            {
                Erro = false,
                CodErro = 0,
                MsgErro = ""
            };

            if (Etapa != null)
            {
                try
                {
                    var result = _etapaRepository.CreateEtapa(Etapa);

                    response.Conteudo.Add(result);
                }
                catch (System.Exception)
                {
                    cabecalho.Erro = true;
                    cabecalho.CodErro = 500;
                    cabecalho.MsgErro = "Nao foi possivel concluir a solicitacao.";
                }
            }
            else{
                cabecalho.Erro = true;
                cabecalho.CodErro = 422;
                cabecalho.MsgErro = "Dados da Etapa nao informados.";
            }

            //Atribuindo o cabecalho ao Response
            response.Cabecalho = cabecalho;

            return response;
        }

        /// <summary>
        /// Edição de Etapa
        /// </summary>
        /// <param name="Resposta">Modelo de dados da classe Etapa</param>
        /// <returns></returns>
        [HttpPut]
        [Route("/api/[controller]/EditEtapa")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public Response EditEtapa(EtapaModel Etapa = null)
        {
            //Iniciando o obj Response
            Response response = new Response();

            var cabecalho = new Cabecalho
            {
                Erro = false,
                CodErro = 0,
                MsgErro = ""
            };

            if (Etapa != null)
            {
                try
                {
                    var result = _etapaRepository.EditEtapa(Etapa);

                    response.Conteudo.Add(result);
                }
                catch (System.Exception)
                {
                    cabecalho.Erro = true;
                    cabecalho.CodErro = 500;
                    cabecalho.MsgErro = "Nao foi possivel concluir a solicitacao.";
                }
            }
            else
            {
                cabecalho.Erro = true;
                cabecalho.CodErro = 422;
                cabecalho.MsgErro = "Dados da Etapa nao informados.";
            }

            //Atribuindo o cabecalho ao Response
            response.Cabecalho = cabecalho;

            return response;
        }

        /// <summary>
        /// Exclusão de Etapa
        /// </summary>
        /// <param name="EtapaId">Id da Etapa</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/api/[controller]/DeleteEtapa/{EtapaId}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public Response DeleteEtapa(int EtapaId = 0)
        {
            //Iniciando o obj Response
            Response response = new Response();

            var cabecalho = new Cabecalho
            {
                Erro = false,
                CodErro = 0,
                MsgErro = ""
            };

            try
            {
                var result = _etapaRepository.DeleteEtapa(EtapaId);

                response.Conteudo.Add(result);
            }
            catch (System.Exception)
            {
                cabecalho.Erro = true;
                cabecalho.CodErro = 500;
                cabecalho.MsgErro = "Nao foi possivel concluir a solicitacao.";
            }

            //Atribuindo o cabecalho ao Response
            response.Cabecalho = cabecalho;

            return response;
        }

        /// <summary>
        /// Retorna uma lista de Etapas e suas respectivas Respostas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/[controller]/EtapasRespostas")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public Response GetEtapasRespostas()
        {
            //Iniciando o obj Response
            Response response = new Response();

            var cabecalho = new Cabecalho
            {
                Erro = false,
                CodErro = 0,
                MsgErro = ""
            };

            try
            {
                var Etapas = _etapaRepository.GetEtapas();

                foreach (var Etapa in Etapas)
                {
                    var Respostas = _respostaRepository.GetRespostas().Where(r => r.EtapaId == Etapa.EtapaId);
                    Etapa.Respostas = Respostas;

                    //if (Etapa.TipoEtapaId != null)
                    //{
                    //    var TipoEtapa = _tipoEtapaRepository.TiposEtapas().Where(te => te.TipoEtapaId == Etapa.TipoEtapaId).FirstOrDefault();
                    //    Etapa.TipoEtapa = TipoEtapa;
                    //}

                    //if(Etapa.ProxEtapaId != null)
                    //{
                    //    var ProxEtapa = _etapaRepository.Etapas().Where(e => e.EtapaId == Etapa.ProxEtapaId).FirstOrDefault();
                    //    Etapa.ProxEtapa = ProxEtapa;
                    //}   
                }

                response.Conteudo.Add(Etapas);
            }
            catch (System.Exception)
            {
                cabecalho.Erro = true;
                cabecalho.CodErro = 500;
                cabecalho.MsgErro = "Nao foi possivel concluir a solicitacao.";
            }

            //Atribuindo o cabecalho ao Response
            response.Cabecalho = cabecalho;

            return response;
        }
    }
}
