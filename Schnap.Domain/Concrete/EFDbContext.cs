using Schnap.Domain.Entities;
using System.Data.Entity;

namespace Schnap.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Picture> pictures { get; set; }
    }
}
