using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace HerosData.Entities
{
   public class SuperHeroContext:DbContext
    {
        public SuperHeroContext()
        {
            
        }
        public SuperHeroContext(DbContextOptions<SuperHeroContext> options) 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
             optionsBuilder.UseSqlServer("Server=tcp:adventureworksdbserver1.database.windows.net,1433;Initial Catalog=HerosDb;User ID=dev;Password=Password123");
            }
        }
        public DbSet<SuperHero> SuperHeros { get; set; }
        public DbSet<SuperPower> SuperPowers { get; set; }
    }
}