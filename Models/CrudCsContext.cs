using Microsoft.EntityFrameworkCore;

namespace CrudCsApi.Models
{
    public class CrudCsContext : DbContext
    {
        public CrudCsContext(DbContextOptions<CrudCsContext> options)
            : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}