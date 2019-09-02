using Microsoft.EntityFrameworkCore;
namespace Persistance.EFCore.SQLServer.Entities
{
    public partial class NetCoreMVCSampleDBContext : DbContext
    {
        public NetCoreMVCSampleDBContext()
        {

        }

        public NetCoreMVCSampleDBContext(DbContextOptions<NetCoreMVCSampleDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Companies> Companies { get; set; }
    }
}
