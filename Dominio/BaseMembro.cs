using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBO.Dominio
{
    public static class BaseMembro
    {
        public static  bool IsValidMove(int estadoAtual, int novoEstado)
        {

            if (estadoAtual + 1 == novoEstado || estadoAtual - 1 == novoEstado)
                return true;

            return false;
        }
    }
}
