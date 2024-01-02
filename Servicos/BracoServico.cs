using ROBO.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ROBO.Dominio.ROBOEnums;
using ROBO.Dominio;

namespace ROBO.Servicos
{
    public  class BracoServico
    {

        private IRoboRepositorio _repositorio;

        public BracoServico(IRoboRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public bool MoverPulso(int novaPosicao, TipoBraco tipo) {

            try
            {
                bool sucesso = false;
                Robo robo = _repositorio.GetEstadoAtual();

                if (tipo == TipoBraco.Esquerdo)
                    sucesso = robo.BracoEsquerdo.MoverPulso(novaPosicao);
                else
                    sucesso = robo.BracoDireito.MoverPulso(novaPosicao);

                if (sucesso)
                    _repositorio.AtualizarEstado(robo);

                return sucesso;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao mover o pulso {tipo.GetDescription()}", ex);
            }

        }

        public bool MoverCotovelo(int novaPosicao, TipoBraco tipo) {

            try
            {
                bool sucesso = false;
                Robo robo = _repositorio.GetEstadoAtual();

                if (tipo == TipoBraco.Esquerdo)
                    sucesso = robo.BracoEsquerdo.MoverCotovelo(novaPosicao);
                else
                    sucesso = robo.BracoDireito.MoverCotovelo(novaPosicao);

                if (sucesso)
                    _repositorio.AtualizarEstado(robo);
                
                return sucesso;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao mover o cotovelo {tipo.GetDescription()}", ex);
            }
        }

    }
}
