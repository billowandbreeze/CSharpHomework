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
    public class GoodsController : ControllerBase
    {
        private readonly OrderContext orderContext;

        public GoodsController(OrderContext orderContext)
        {
            this.orderContext = orderContext;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Good>> Get(String Id)
        {
            IQueryable<Good> query = orderContext.Goods;
            if (Id != null)
            {
                query = query.Where(t => t.Id.Contains(Id));
            }

            return query.ToList();
        }

        [HttpPost]
        public ActionResult<Good> Post(Good good)
        {
            try
            {
                orderContext.Goods.Add(good);
                orderContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

            return good;
        }
    }
}
