using Microsoft.AspNetCore.Mvc;
using ROBO.Dominio.ROBOEnums;
using ROBO.Servicos;

namespace ROBO.RoboAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CabecaController : Controller
    {
        private CabecaServico _servico;

        public CabecaController(CabecaServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        [Route("Rotacao")]
        public IActionResult Rotacionar(int novaPosicao)
        {
            try
            {
                if (!Enum.IsDefined(typeof(Rotacao), novaPosicao))
                    return BadRequest("Novo movimento inválido");

                if (_servico.Rotacionar(novaPosicao))
                    return Ok();
                else
                    return Conflict("Movimento impossível");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao rotacionar a cabeça", ex);
            }
        }

        [HttpPost]
        [Route("Inclinacao")]
        public IActionResult Inclinar(int novaPosicao) {

            try
            {
                if (!Enum.IsDefined(typeof(Inclinacao), novaPosicao))
                    return BadRequest("Novo movimento inválido");

                if (_servico.Inclinar(novaPosicao))
                    return Ok();
                else
                    return Conflict("Movimento impossível");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inclinar a cabeça", ex);
            }
        }
    }
}
