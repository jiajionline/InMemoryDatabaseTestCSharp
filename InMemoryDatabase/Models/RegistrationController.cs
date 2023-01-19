namespace InMemoryDatabase.Models
{
    public class RegistrationController
    {
        private readonly IRegistrationRepository _repository;

        public RegistrationController(IRegistrationRepository repository) 
        {
            _repository = repository;
        }

        public void Create()
        {
            var owner = new Owner { Name = "John"  };
            var car = new Car { Brand = "Mazda CX9", VIN = "vintest", Year = 2016, Owner = owner };


            _repository.Add(car);

            _repository.SaveChanges();
        }
    }
}
