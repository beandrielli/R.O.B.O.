using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBO.Servicos
{
    public static class ExtensoesInjecaoDependencia
    {
        public static void RegistrarDependenciasServicos(this IServiceCollection services)
        {
            services.AddScoped(typeof(RoboServico));
            services.AddScoped(typeof(BracoServico));
            services.AddScoped(typeof(CabecaServico));
            services.AddScoped(typeof(ValidacaoServico));

        }

    }
}
