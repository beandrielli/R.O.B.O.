using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBO.Dominio.ROBOEnums
{
    public enum Inclinacao
    {
        [Description("Para Cima")]
        Cima = 1,

        [Description("Em Repouso")]
        Repouso = 2,

        [Description("Para Baixo")]
        Baixo = 3
    }
}
