using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryDatabase.Models
{
    public interface IRegistrationRepository
    {
        public IQueryable<Car> Cars { get; }
        public IQueryable<Owner> Owners { get; }

        void Add<EntityType>(EntityType entity);
        void SaveChanges();

    }
}
