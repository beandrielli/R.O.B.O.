using ROBO.Dominio;
using ROBO.Infra.Interfaces;
using ROBO.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBO.Servicos
{
    public class RoboServico
    {
        private IRoboRepositorio _repositorio;

        public RoboServico(IRoboRepositorio repositorio) { 
            _repositorio = repositorio;
        }

        public Robo GetStatusAtual() {
            return _repositorio.GetEstadoAtual();
        }

        public void ResetRobo() { 
            _repositorio.IniciarRobo();
        }


    }
}
