using ROBO.Dominio;
using ROBO.Dominio.ROBOEnums;

namespace ROBO.RoboAPI.DTOs
{
    public class RoboDTO
    {
        public RoboDTO(Robo robo) { 
            Cabeca = new CabecaDTO() { 
                InclinacaoCabeca = robo.Cabeca.EstadoInclinacao.GetDescription(),
                RotacaoCabeca = robo.Cabeca.EstadoRotacao.GetDescription(),
            };
            
            BracoDireito = new BracoDTO() { 
               PosicaoCotovelo = ((Contracao)robo.BracoDireito.Cotovelo.EstadoAtual).GetDescription(),
               PosicaoPulso = ((Rotacao)robo.BracoDireito.Pulso.EstadoAtual).GetDescription()
            };

            BracoEsquerdo = new BracoDTO()
            {
                PosicaoCotovelo = ((Contracao)robo.BracoEsquerdo.Cotovelo.EstadoAtual).GetDescription(),
                PosicaoPulso = ((Rotacao)robo.BracoEsquerdo.Pulso.EstadoAtual).GetDescription()
            };
        }

        public CabecaDTO Cabeca { get; set; }

        public BracoDTO BracoEsquerdo { get; set; }

        public BracoDTO BracoDireito { get; set; }
    }
}
