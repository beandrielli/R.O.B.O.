using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBO.Dominio.ROBOEnums
{
    public enum Contracao
    {
        [Description("Em Repouso")]
        EmRepouso = 1,

        [Description("Levemente Contraído")]
        LevementeContraido = 2,

        [Description("Contraído")]
        Contraido = 3,

        [Description("Fortemente Contraído")]
        FortementeContraido = 4
    }
}
