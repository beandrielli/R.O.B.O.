using Microsoft.AspNetCore.Mvc;
using ROBO.Dominio;
using ROBO.Dominio.ROBOEnums;
using ROBO.Infra.Interfaces;
using ROBO.RoboAPI.DTOs;
using ROBO.Servicos;

namespace ROBO.RoboAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BracoController : Controller
    {
        private BracoServico _servico;

        public BracoController(BracoServico servico)
        {
            _servico = servico;
        }


        [HttpPost]
        [Route("Cotovelo")]
        public IActionResult MoverCotovelo(int tipoBraco, int novaPosicao) {

            try
            {

                if (!Enum.IsDefined(typeof(TipoBraco), tipoBraco))
                    return BadRequest("Braço inválido");


                if (!Enum.IsDefined(typeof(Contracao), novaPosicao))
                    return BadRequest("Novo movimento inválido");

                if (_servico.MoverCotovelo(novaPosicao, (TipoBraco)tipoBraco))
                    return Ok();
                else
                    return Conflict("Movimento impossível");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao mover o braço (cotovelo) {((TipoBraco)tipoBraco).GetDescription()}");
            }

        }

        [HttpPost]
        [Route("Pulso")]
        public IActionResult MoverPulso(int tipoBraco, int novaPosicao)
        {

            try
            {

                if (!Enum.IsDefined(typeof(TipoBraco), tipoBraco))
                    return BadRequest("Braço inválido");


                if (!Enum.IsDefined(typeof(Rotacao), novaPosicao))
                    return BadRequest("Novo movimento inválido");

                if (_servico.MoverPulso(novaPosicao, (TipoBraco)tipoBraco))
                    return Ok();
                else
                    return Conflict("Movimento impossível");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao mover o braço (pulso) {((TipoBraco)tipoBraco).GetDescription()}");
            }

        }
    }
}
