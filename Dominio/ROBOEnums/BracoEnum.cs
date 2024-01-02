using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBO.Dominio.ROBOEnums
{
    //Possibilidade do robo ter futuramente mais braços
    public enum TipoBraco
    {
        [Description("Direito")]
        Direito = 0,

        [Description("Esquerdo")]
        Esquerdo = 1
    }
}
