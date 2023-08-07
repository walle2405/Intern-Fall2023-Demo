using Microsoft.EntityFrameworkCore;

namespace Demo1.Entity
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        }

        DbSet<UserEntity> Users { get; set; }
        DbSet<CafeEntity> Cafes { get; set; }
        DbSet<OrderEntity> Orders { get; set; }
        DbSet<OrderItemEntity> OrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var strConn = config["ConnectionStrings:DefaultConnectionStrings"];
            return strConn;
        }
    }

}
