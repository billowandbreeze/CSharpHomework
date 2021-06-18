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
        public ActionResult<List<Client>> Get(String Id)
        {
            IQueryable<Client> query = orderContext.Clients;
            if (Id != null)
            {
                query = query.Where(t => t.Id.Contains(Id));
            }

            return query.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Client> GetTodoItem(String id)
        {
            var clientItem = orderContext.Clients.FirstOrDefault(t => t.Id == id);

            if (clientItem == null)
            {
                return NotFound();
            }

            return clientItem;
        }

        [HttpGet("clientQuery")]
        public ActionResult<List<Client>> queryTodoItem(string name, string id)
        {
            IQueryable<Client> query = orderContext.Clients;

            if (name != null)
            {
                query = query.Where(t => t.Name.Contains(name));
            }

            if (id != null)
            {
                query = query.Where(t => t.Id == id);
            }

            return query.ToList();
        }

        [HttpPost]
        public ActionResult<Client> Post(Client client)
        {
            try
            {
                orderContext.Clients.Add(client);
                orderContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

            return client;
        }

        [HttpPut("{id}")]
        public ActionResult<Client> PutTodoItem(String id, Client client)
        {
            if (id != client.Id)
            {
                return BadRequest("Id can not be modified!");
            }

            try
            {
                orderContext.Entry(client).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                orderContext.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null)
                {
                    error = e.InnerException.Message;
                }
                return BadRequest(error);
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Client> DeleteTodoItem(string id)
        {
            try
            {
                var client = orderContext.Clients.FirstOrDefault(t => t.Id == id);
                if (client != null)
                {
                    orderContext.Remove(client);
                    orderContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

            return NoContent();
        }
    }
}
