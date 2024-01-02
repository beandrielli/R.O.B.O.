using ROBO.Dominio;
using ROBO.Dominio.ROBOEnums;
using System.ComponentModel;
using System.ComponentModel.Design;
using Xunit.Sdk;

namespace ROBO.Test
{

    public class RoboTesting
    {

        [Fact]
        public void Robo_Comeca_Em_Reposo()
        {

            Robo robo = new Robo();

            bool emRepouso = false;

            if (robo.Cabeca.EstadoRotacao == Dominio.ROBOEnums.Rotacao.EmRepouso
                && robo.Cabeca.EstadoInclinacao == Dominio.ROBOEnums.Inclinacao.Repouso
                && robo.BracoEsquerdo.Pulso.EstadoAtual == (int)Rotacao.EmRepouso
                && robo.BracoEsquerdo.Cotovelo.EstadoAtual == (int)Contracao.EmRepouso
                && robo.BracoDireito.Pulso.EstadoAtual == (int)Rotacao.EmRepouso
                && robo.BracoDireito.Cotovelo.EstadoAtual == (int)Contracao.EmRepouso)
                emRepouso = true;

            Assert.True(emRepouso, "Robo deve sempre iniciar em repouso");

        }

        [Fact]
        public void Cabeca_Nao_Inclina_Quando_Inclinacao_Baixo() { 
            
            Robo robo = new Robo();

            Assert.True(robo.Cabeca.Inclinar((int)Inclinacao.Baixo), "Cabeça deveria ter se movido com sucesso");

            Assert.False(robo.Cabeca.Rotacionar((int)Rotacao.Rotacao45), "Cabeça não pode rotacionar quando inclinada para baixo");

            Assert.True(robo.Cabeca.Inclinar((int)Inclinacao.Repouso), "Cabeça deveria ter se movido com sucesso");

            Assert.True(robo.Cabeca.Rotacionar((int)Rotacao.Rotacao45), "Cabeça deve se mover se a inclinação não é para baixo");
        }

        [Fact]
        public void Pulso_Move_Apenas_Cotovelo_Fortemente_Contraido()
        {

            Robo robo = new Robo();

            Assert.True(robo.BracoEsquerdo.MoverCotovelo((int)Contracao.LevementeContraido), "Cotovelo deve se mover");

            Assert.False(robo.BracoEsquerdo.MoverPulso((int)Rotacao.Rotacao45), "Pulso não pode se mover");

            Assert.True(robo.BracoEsquerdo.MoverCotovelo((int)Contracao.Contraido), "Cotovelo deve se mover");
            Assert.True(robo.BracoEsquerdo.MoverCotovelo((int)Contracao.FortementeContraido), "Cotovelo deve se mover");

            Assert.True(robo.BracoEsquerdo.MoverPulso((int)Rotacao.Rotacao45), "pulso deve se mover");

        }

        [Theory]
        [InlineData((int)Contracao.LevementeContraido)]
        [InlineData((int)Contracao.Contraido)]
        [InlineData((int)Contracao.FortementeContraido)]
        [InlineData(0)]
        public void Cotovelo_Move_Apenas_Em_Valores_Validos(int movimento) {

            Robo robo = new Robo();

            bool sucessoMovimento = robo.BracoEsquerdo.MoverCotovelo(movimento);

            if (!Enum.IsDefined(typeof(Contracao), movimento))
                Assert.False(sucessoMovimento, "Valor de movimento é inválido, então cotovelo não deve se mover");
            else if(movimento != (int)Contracao.LevementeContraido)
                Assert.False(sucessoMovimento, "Valor de movimento é inválido (maior que uma distância), então cotovelo não deve se mover");
            else
                Assert.True(sucessoMovimento, "Valor de movimento é válido, então cotovelo deve se mover");
        }
    }
}