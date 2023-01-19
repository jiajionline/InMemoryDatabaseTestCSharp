using InMemoryDatabase.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace InMemoryDatabaseTest
{
    public class RegistrationUnitTest
    {
        private RegistrationController _controller;
        private IRegistrationRepository _registrationRepository;
        private IRegistrationRepository IMemoryRepository()
        {
            var options = new DbContextOptionsBuilder<RegistrationContext>()
                             .UseInMemoryDatabase(databaseName: "MockDB")
                             .Options;

            var context = new RegistrationContext(options);

            var repository = new DbRepository(context);

            return repository;
        }

        [Fact]
        public void Test1()
        {
            _registrationRepository = IMemoryRepository();
            _controller = new RegistrationController(_registrationRepository);

            _controller.Create();

            Assert.Equal("John", _registrationRepository.Cars.First().Owner.Name);
            Assert.Equal(1, _registrationRepository.Cars.Count());
            Assert.Equal(1, _registrationRepository.Owners.Count());
            Assert.Equal("vintest", _registrationRepository.Owners.First().Cars.First().VIN);
        }
    }
}