using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using src.db.builder;
using src.db.data.model;

namespace src.db
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Comment out the following constructor when adding/updating migration
        /// </summary>
        /// <param name="configuration"></param>
        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LandlordBuilder());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connecitonString  = _configuration.GetConnectionString("dbConnectionString");

            optionsBuilder.UseSqlServer(connecitonString);
            base.OnConfiguring(optionsBuilder);
        }
        
        public DbSet<Landlord> Landlord { get; set; }
    }
}
