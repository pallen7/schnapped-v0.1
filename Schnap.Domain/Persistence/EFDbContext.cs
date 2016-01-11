using Schnap.Domain.Persistence.Entities;
using System.Data.Entity;

namespace Schnap.Domain.Persistence.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Picture> pictures { get; set; }
    }
}
