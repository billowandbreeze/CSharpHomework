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

        [HttpGet("{id}")]
        public ActionResult<Good> GetTodoItem(String id)
        {
            var GoodItem = orderContext.Goods.FirstOrDefault(t => t.Id == id);

            if (GoodItem == null)
            {
                return NotFound();
            }

            return GoodItem;
        }

        [HttpGet("goodQuery")]
        public ActionResult<List<Good>> queryTodoItem(string name, string id)
        {
            IQueryable<Good> query = orderContext.Goods;

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

        [HttpPut("{id}")]
        public ActionResult<Good> PutTodoItem(String id, Good good)
        {
            if (id != good.Id)
            {
                return BadRequest("Id can not be modified!");
            }

            try
            {
                orderContext.Entry(good).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
        public ActionResult<Good> DeleteTodoItem(string id)
        {
            try
            {
                var good = orderContext.Goods.FirstOrDefault(t => t.Id == id);
                if (good != null)
                {
                    orderContext.Remove(good);
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
