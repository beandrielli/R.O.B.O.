using ROBO.Dominio.ROBOEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBO.Dominio
{
    public class Braco
    {
        public Braco(TipoBraco tipo) { 
            Pulso = new Membro();
            Cotovelo = new Membro();

            Pulso.EstadoAtual = (int)Rotacao.EmRepouso;
            Cotovelo.EstadoAtual = (int)Contracao.EmRepouso;

            TipoBraco = tipo;
        }

        public TipoBraco TipoBraco { get; set; }

        public Membro Pulso { get; set; }

        public Membro Cotovelo { get; set; }

        public bool MoverCotovelo(int novoEstado) {

            if (!Enum.IsDefined(typeof(Contracao), novoEstado))
                return false;

            if (BaseMembro.IsValidMove(Cotovelo.EstadoAtual, novoEstado))
            {
                Cotovelo.EstadoAtual = novoEstado;
                return true;
            }

            return false;

        }

        public bool MoverPulso(int novoEstado) {

            if (!Enum.IsDefined(typeof(Rotacao), novoEstado))
                return false;

            if(Cotovelo.EstadoAtual != (int)Contracao.FortementeContraido) 
                return false;

            if (BaseMembro.IsValidMove(Pulso.EstadoAtual, novoEstado))
            {
                Pulso.EstadoAtual = novoEstado;
                return true;
            }

            return false;
        }       

    }
}
