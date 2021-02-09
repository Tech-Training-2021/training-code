using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace HerosData.Entities
{
    class SuperPeopleContext:DbContext
    {
        public SuperPeopleContext()
        {
            
        }
        public SuperPeopleContext(DbContextOptions<SuperPeopleContext> options) 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
             optionsBuilder.UseSqlServer("Server=tcp:adventureworksdbserver1.database.windows.net,1433;Initial Catalog=HerosDb;User ID=dev;Password=Password123");
            }
        }
        public DbSet<SuperPeople> SuperPeople { get; set; }
    }
}