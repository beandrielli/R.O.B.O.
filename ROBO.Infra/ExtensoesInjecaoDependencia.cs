using Microsoft.Extensions.DependencyInjection;
using ROBO.Infra.Interfaces;
using ROBO.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBO.Infra
{
    public static class ExtensoesInjecaoDependencia
    {
        public static void RegistrarDependenciasInfra(this IServiceCollection services)
        {

            services.AddSingleton<IRoboRepositorio, ROBORepository>();

        }

    }
}
