using Microsoft.EntityFrameworkCore;


namespace InMemoryDatabase.Models
{
    public class RegistrationContext : DbContext
    {
        public RegistrationContext(DbContextOptions<RegistrationContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Owner> Owners { get; set; }

        public class UseInMemoryDatabase
        {
        }
    }
}
