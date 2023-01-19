using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryDatabase.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public Owner Owner { get; set; }
    }
}
