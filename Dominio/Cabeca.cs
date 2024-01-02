using ROBO.Dominio.ROBOEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBO.Dominio
{
    public class Cabeca
    {

        public Cabeca() {

            EstadoRotacao = Rotacao.EmRepouso;
            EstadoInclinacao = Inclinacao.Repouso;

        }

        public Rotacao EstadoRotacao { get; set; }

        public Inclinacao EstadoInclinacao { get; set; }

        public bool Rotacionar(int novoEstado) {

            if (!Enum.IsDefined(typeof(Rotacao), novoEstado))
                    return false;

            if(novoEstado > (int)Rotacao.Rotacao90)
                return false;

            if (EstadoInclinacao == Inclinacao.Baixo)
                return false;

            if (BaseMembro.IsValidMove((int)EstadoRotacao, novoEstado)) {
                EstadoRotacao = (Rotacao)novoEstado;
                return true;
            }

            return false;
        }

        public bool Inclinar(int novoEstado)
        {

            if (!Enum.IsDefined(typeof(Inclinacao), novoEstado))
                return false;

            if (BaseMembro.IsValidMove((int)EstadoInclinacao, novoEstado))
            {
                EstadoInclinacao = (Inclinacao)novoEstado;
                return true;
            }

            return false;
        }
    }
}
