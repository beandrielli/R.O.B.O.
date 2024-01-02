using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBO.Dominio.ROBOEnums
{
    public enum Rotacao
    {
        [Description("Rotação -90")]
        RotacaoMenos90 = 1,

        [Description("Rotação -45")]
        RotacaoMenos45 = 2,

        [Description("Em Repouso")]
        EmRepouso = 3,

        [Description("Rotação 45")]
        Rotacao45 = 4,

        [Description("Rotação 90")]
        Rotacao90 = 5,

        [Description("Rotação 135")]
        Rotacao135 = 6,

        [Description("Rotação 180")]
        Rotacao180 = 7

    }
}
