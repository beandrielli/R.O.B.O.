using ROBO.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBO.Infra.Interfaces
{
    public interface IRoboRepositorio
    {
        public Robo GetEstadoAtual();

        public void IniciarRobo();

        public void AtualizarEstado(Robo robo);

    }
}
