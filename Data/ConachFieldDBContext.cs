using exampleapp.Models;
using Microsoft.EntityFrameworkCore;


using Microsoft.Extensions.Configuration;

namespace exampleapp.Data
{
    public class ConachFieldDBContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ConachFieldDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DBConnectionString"));
            }
        }

        public DbSet<CoachField> CoachField { get; set; }
    }
}