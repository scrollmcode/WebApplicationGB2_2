using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationGB2_2.Models;
using WebApplicationGB2_2.Services;

namespace WebApplicationGB2_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        // /api/persons/1
        [Route("{id}")]
        [HttpGet()]
        public Person Get(int id)
        {
            return _personService.GetById(id);
        }

        // /api/persons/search?searchTerm=Demetria

        [Route("search")]
        [HttpGet()]
        public Person Search([FromQuery]string searchTerm)
        {
            return _personService.GetByName(searchTerm);
        }


        // /api/persons/?skip=2&take=5

        //[Route("api/persons")]
        [HttpGet()]
        public IEnumerable<Person> Get([FromQuery]int skip, [FromQuery]int take)
        {
            IEnumerable<Person> persons = 
                _personService.GetAll().OrderBy(o => o.Id).
                    Where(p => skip <= p.Id && p.Id <= take);

            return persons;
        }

        //[Route("api/persons")]
        [HttpPost()]
        public void AddPerson([FromBody]Person person)
        {
            _personService.Add(person);
        }

        //[Route("api/persons")]
        [HttpPut()]
        public void EditPerson([FromBody]Person person)
        {
            _personService.Update(person);
        }

        [Route("{personID}")]
        [HttpDelete()]
        public void DeletePerson(int personID)
        {
            _personService.Delete(personID);
        }

    }
}
