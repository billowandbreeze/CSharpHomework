using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly CoreDbContext _coreDbContext;

        public ValuesController(CoreDbContext coreDbContext)
        {
            _coreDbContext = coreDbContext;
        }

        // GET api/values
        [HttpGet]
        public List<Person> Get()
        {
            return _coreDbContext.Set<Person>().ToList();
        }

        [HttpPost]
        public List<Person> Post()
        {
            return _coreDbContext.Set<Person>().ToList();
        }
    }
}
