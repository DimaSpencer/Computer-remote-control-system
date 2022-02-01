using M1.Application.Interfaces.Db;
using M1.Domain.Entityes;
using Microsoft.EntityFrameworkCore;

namespace M1.Persistance
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public DbSet<Machine> Machines { get; set; }
        public DbSet<ChromeCredential> ChromeCredentials { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await base.SaveChangesAsync(cancellationToken);
        }
    }
}
