using M1.Domain.Entityes;
using Microsoft.EntityFrameworkCore;

namespace M1.Application.Interfaces.Db
{
    public interface IAppDbContext
    {
        DbSet<Machine> Machines { get; set; }
        DbSet<ChromeCredential> ChromeCredentials { get; set; }

        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
