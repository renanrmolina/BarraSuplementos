using Microsoft.EntityFrameworkCore;

namespace SeuNamespace // Substitua com o namespace correto do seu projeto
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Defina suas entidades e configurações do DbContext aqui
    }
}
