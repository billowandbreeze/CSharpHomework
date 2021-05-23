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
    public class ClientsController : ControllerBase
    {
        private readonly OrderContext orderContext;

        public ClientsController(OrderContext orderContext)
        {
            this.orderContext = orderContext;
        }

        // GET api/values
        [HttpGet]
        public List<Client> Get()
        {
            return orderContext.Set<Client>().ToList();
        }

        [HttpPost]
        public List<Client> Post()
        {
            return orderContext.Set<Client>().ToList();
        }
    }
}
