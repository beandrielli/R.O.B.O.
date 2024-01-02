using ROBO.Dominio;
using ROBO.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBO.Servicos
{
    public class CabecaServico
    {
        private IRoboRepositorio _repositorio;

        public CabecaServico(IRoboRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public bool Inclinar(int novaPosicao) {

            try
            {
                Robo robo = _repositorio.GetEstadoAtual();

                bool sucesso = robo.Cabeca.Inclinar(novaPosicao);

                if (sucesso)
                    _repositorio.AtualizarEstado(robo);

                return sucesso;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inclinar a cabeça", ex);
            }
        }

        public bool Rotacionar(int novaPosicao)
        {

            try
            {
                Robo robo = _repositorio.GetEstadoAtual();

                bool sucesso = robo.Cabeca.Rotacionar(novaPosicao);

                if (sucesso)
                    _repositorio.AtualizarEstado(robo);

                return sucesso;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao rotacionar a cabeça", ex);
            }
        }
    }
}
