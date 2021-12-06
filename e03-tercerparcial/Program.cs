using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Microsoft.Extensions.DependencyInjection;
using e02_segundoparcial.Data;

namespace e02_segundoparcial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build().Run();

            using (var alcance = host.Services.CreateScope())
            {
                 var servicio = alcance.ServiceProvider;
                 var contexto = servicio.GetRequiredService<DvdContexto>();
                 InicializaBD.Inicializar(contexto);
            }

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
