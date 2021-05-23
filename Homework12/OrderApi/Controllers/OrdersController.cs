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
    public class OrdersController : ControllerBase
    {
        private readonly OrderContext orderContext;

        public OrdersController(OrderContext orderContext)
        {
            this.orderContext = orderContext;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Order>> Get(String Id)
        {
            IQueryable<Order> query = orderContext.Orders;
            if (Id != null)
            {
                query = query.Where(t => t.Id.Contains(Id));
            }

            return query.ToList();
        }

        [HttpPost]
        public ActionResult<Order> Post(Order order)
        {
            try
            {
                orderContext.Orders.Add(order);
                orderContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

            return order;
        }
    }
}