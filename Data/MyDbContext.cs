using Microsoft.EntityFrameworkCore;

namespace UppgifterEF
{
    public class MyDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Car> Cars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                ("Data Source=(local)\\SQLEXPRESS;Initial Catalog=Southwind;Integrated Security=SSPI")
                .UseLazyLoadingProxies();
        }
    }
}