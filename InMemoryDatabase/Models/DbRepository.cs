namespace InMemoryDatabase.Models
{
    public class DbRepository : IRegistrationRepository
    {
        private readonly RegistrationContext _db;
        public DbRepository(RegistrationContext db)
        {
            _db = db;
        }

        public IQueryable<Car> Cars => _db.Cars;

        public IQueryable<Owner> Owners => _db.Owners;

        public void Add<EntityType>(EntityType entity)
        {
            _db.Add(entity);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
