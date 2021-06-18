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
    public class OrderDetailsController : ControllerBase
    {
        private readonly OrderContext orderContext;

        public OrderDetailsController(OrderContext orderContext)
        {
            this.orderContext = orderContext;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<OrderDetail>> Get(String Id)
        {
            IQueryable<OrderDetail> query = orderContext.OrderDetails;
            if (Id != null)
            {
                query = query.Where(t => t.Id.Contains(Id));
            }

            return query.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<OrderDetail> GetTodoItem(String id)
        {
            var OrderDetailItem = orderContext.OrderDetails.FirstOrDefault(t => t.Id == id);

            if (OrderDetailItem == null)
            {
                return NotFound();
            }

            return OrderDetailItem;
        }

        [HttpGet("orderdetailQuery")]
        public ActionResult<List<OrderDetail>> queryTodoItem(string id)
        {
            IQueryable<OrderDetail> query = orderContext.OrderDetails;

            if (id != null)
            {
                query = query.Where(t => t.Id == id);
            }

            return query.ToList();
        }

        [HttpPost]
        public ActionResult<OrderDetail> Post(OrderDetail orderDetail)
        {
            try
            {
                orderContext.OrderDetails.Add(orderDetail);
                orderContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

            return orderDetail;
        }

        [HttpPut("{id}")]
        public ActionResult<OrderDetail> PutTodoItem(String id, OrderDetail orderDetail)
        {
            if (id != orderDetail.Id)
            {
                return BadRequest("Id can not be modified!");
            }

            try
            {
                orderContext.Entry(orderDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
        public ActionResult<OrderDetail> DeleteTodoItem(string id)
        {
            try
            {
                var orderDetail = orderContext.OrderDetails.FirstOrDefault(t => t.Id == id);
                if (orderDetail != null)
                {
                    orderContext.Remove(orderDetail);
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