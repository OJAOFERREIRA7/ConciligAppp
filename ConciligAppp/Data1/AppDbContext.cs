using System.Data.Entity; // CORRETO para EF6
using ConciligAppp.Models1; // se seu namespace realmente é esse, então ok!

namespace ConciligAppp.Data1
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ArquivoImportado> ArquivosImportados { get; set; }
        public DbSet<Contrato> Contratos { get; set; }

        public AppDbContext()
            : base("name=ConexaoSql") // nome da string no App.config
        {
        }
    }
}
