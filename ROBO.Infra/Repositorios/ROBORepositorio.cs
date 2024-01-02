using ROBO.Dominio;
using ROBO.Infra.Interfaces;

namespace ROBO.Infra.Repositorios
{
    public class ROBORepository : IRoboRepositorio
    {
        private Robo _robo;

        public ROBORepository()
        {
            _robo = new Robo();
        }

        public Robo GetEstadoAtual() { 
            return _robo;
        }

        public void AtualizarEstado(Robo robo)
        {
            try
            {
                _robo = robo;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o robô.", ex);
            }
        }

        public void IniciarRobo()
        {
            try
            {
                _robo = new Robo();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inicializar o robô.", ex);
            }
        }
    }
}