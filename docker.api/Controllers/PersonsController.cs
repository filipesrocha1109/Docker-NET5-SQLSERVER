using docker.api.Context;
using docker.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace docker.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly DockerContext _context;
        public PersonsController(DockerContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetPersons")]
        public async Task<List<Person>> Get()
        {
            return await _context.Persons.ToListAsync();
        }
    }
}