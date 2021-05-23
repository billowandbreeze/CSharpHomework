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
    }
}