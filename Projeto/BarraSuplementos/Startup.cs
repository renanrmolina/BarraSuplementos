using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BarraSuplementos;

namespace BarraSuplementos // Substitua com o namespace correto do seu projeto
{
    public class Startup
    {
        string conn = builder.Configuration.GetConnectionString("GalloFlix");
        string version = ServerVersion.AutoDetect(conn);

        private readonly IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {


            // Outras configurações de serviços

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"));
            });
            
            //         services.AddDbContext<AppDbContext>(options =>
            // options.UseMySql(conn, version)



            // Outros serviços e configurações
        }

        // Outros métodos de configuração, como Configure, podem estar aqui
    }
}
