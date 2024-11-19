using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Model;
using System.Diagnostics;

namespace Server.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Client_OrderController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Client_OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Client_Order>> GetOrders()
        {
            var orders = _context.Client_Order.ToList();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Client_Order>> GetOrderById(int id)
        {
            var order = await _context.Client_Order.FindAsync(id);

            if (order == null)
            {
                return NotFound("Заказ с указанным ID не найден.");
            }

            return Ok(order);
        }
    }
}