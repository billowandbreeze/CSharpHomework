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


        [HttpGet("{id}")]
        public ActionResult<Order> GetTodoItem(String id)
        {
            var OrderItem = orderContext.Orders.FirstOrDefault(t => t.Id == id);

            if (OrderItem == null)
            {
                return NotFound();
            }

            return OrderItem;
        }

        [HttpGet("orderQuery")]
        public ActionResult<List<Order>> queryTodoItem(string id)
        {
            IQueryable<Order> query = orderContext.Orders;

            if (id != null)
            {
                query = query.Where(t => t.Id == id);
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

        [HttpPut("{id}")]
        public ActionResult<Order> PutTodoItem(String id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest("Id can not be modified!");
            }

            try
            {
                orderContext.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
        public ActionResult<Order> DeleteTodoItem(string id)
        {
            try
            {
                var order = orderContext.Orders.FirstOrDefault(t => t.Id == id);
                if (order != null)
                {
                    orderContext.Remove(order);
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