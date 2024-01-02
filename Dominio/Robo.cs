using ROBO.Dominio.ROBOEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBO.Dominio
{
    public class Robo
    {
        public Robo() { 
            Cabeca = new Cabeca();
            BracoEsquerdo = new Braco(TipoBraco.Direito);
            BracoDireito = new Braco(TipoBraco.Esquerdo);
        }

        public Cabeca Cabeca { get; set; }

        //Poderia ser uma lista de braços, mas para simplicidade manterei assim
        public Braco BracoEsquerdo { get; set; }

        public Braco BracoDireito { get; set;}


    }
}
