using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationGB2_2.Models;

namespace WebApplicationGB2_2.Services
{
    public interface IPersonService
    {
        public IEnumerable<Person> GetAll();
        public Person GetById(int id);
        public Person GetByName(string name);
        public void Add(Person person);
        public void Update(Person person);
        public void Delete(int id);
    }
}
