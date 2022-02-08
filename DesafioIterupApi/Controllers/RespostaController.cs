using DesafioIterupApi.Models;
using DesafioIterupApi.Respositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DesafioIterupApi.Controllers
{
    [ApiController]
    public class RespostaController : Controller
    {
        IRespostaRepository _respostaRepository;
        public RespostaController(IRespostaRepository RespostaRepository = null)
        {
            _respostaRepository = RespostaRepository;
        }

        /// <summary>
        /// Retorna uma lista de Respostas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/[controller]/GetRespostas")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public Response GetRespostas()
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
                var Respostas = _respostaRepository.GetRespostas();

                response.Conteudo.Add(Respostas);
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
        /// Retorna uma Resposta
        /// </summary>
        /// <param name="EtapaId">Id da Etapa</param>
        /// <param name="RespostaId">Id da Resposta</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/[controller]/GetResposta/{EtapaId}/{RespostaId}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public Response GetResposta(int EtapaId = 0, int RespostaId = 0)
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
                var Resposta = _respostaRepository.GetResposta(EtapaId, RespostaId);

                response.Conteudo.Add(Resposta);
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
        /// Cadastro de Resposta
        /// </summary>
        /// <param name="Resposta">Modelo de dados da classe Resposta</param>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/[controller]/CreateResposta")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public Response CreateResposta(RespostaModel Resposta = null)
        {
            //Iniciando o obj Response
            Response response = new Response();

            var cabecalho = new Cabecalho
            {
                Erro = false,
                CodErro = 0,
                MsgErro = ""
            };

            if (Resposta != null)
            {
                try
                {
                    var result = _respostaRepository.CreateResposta(Resposta);

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
                cabecalho.MsgErro = "Dados da Resposta nao informados.";
            }

            //Atribuindo o cabecalho ao Response
            response.Cabecalho = cabecalho;

            return response;
        }

        /// <summary>
        /// Edição de Resposta
        /// </summary>
        /// <param name="Resposta">Modelo de dados da classe Resposta</param>
        /// <returns></returns>
        [HttpPut]
        [Route("/api/[controller]/EditResposta")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public Response EditResposta(RespostaModel Resposta = null)
        {
            //Iniciando o obj Response
            Response response = new Response();

            var cabecalho = new Cabecalho
            {
                Erro = false,
                CodErro = 0,
                MsgErro = ""
            };

            if (Resposta != null)
            {
                try
                {
                    var result = _respostaRepository.EditResposta(Resposta);

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
                cabecalho.MsgErro = "Dados da Resposta nao informados.";
            }

            //Atribuindo o cabecalho ao Response
            response.Cabecalho = cabecalho;

            return response;
        }

        /// <summary>
        /// Exclusão de Resposta
        /// </summary>
        /// <param name="EtapaId">Id da Etapa</param>
        /// <param name="RespostaId">Id da Resposta</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/api/[controller]/DeleteResposta/{EtapaId}/{RespostaId}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public Response DeleteResposta(int EtapaId = 0, int RespostaId = 0)
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
                var result = _respostaRepository.DeleteResposta(EtapaId, RespostaId);

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
        /// Retorna uma lista de Respostas de acordo com o parametro EtapaId
        /// </summary>
        /// <param name="EtapaId">Id da Etapa</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/[controller]/RespostasByEtapaId/{EtapaId?}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public Response RespostasByEtapaId(int EtapaId = 0)
        {
            //Iniciando o obj Response
            Response response = new Response();

            var cabecalho = new Cabecalho
            {
                Erro = false,
                CodErro = 0,
                MsgErro = ""
            };

            if (EtapaId != 0)
            {
                try
                {
                    var Respostas = _respostaRepository.GetRespostas();
                    //Criando o conteudo do obj Response
                    response.Conteudo.Add(Respostas.Where(x => x.EtapaId == EtapaId).ToList());
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
                cabecalho.MsgErro = "Parametro obrigatorio nao informado.";
            }

            //Atribuindo o cabecalho ao Response
            response.Cabecalho = cabecalho;

            return response;
        }
    }
}
