using Microsoft.AspNetCore.Mvc;
using ROBO.Dominio;
using ROBO.RoboAPI.DTOs;
using ROBO.Servicos;
using System.Security.Cryptography.Xml;

namespace ROBO.RoboAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoboController : Controller
    {
        private RoboServico _roboServico;
    
        public RoboController(RoboServico servico) { 
            _roboServico = servico;
        }

        [HttpGet]
        public IActionResult GetStatusAtual()
        {
            Robo robo = _roboServico.GetStatusAtual();

            RoboDTO response = new RoboDTO(robo);
            
            return Ok(response);
        }

        [HttpPost]
        [Route("Reset")]
        public IActionResult ResetRobo() {
            
            _roboServico.ResetRobo();
            
            return Ok();
        }
    }
}
