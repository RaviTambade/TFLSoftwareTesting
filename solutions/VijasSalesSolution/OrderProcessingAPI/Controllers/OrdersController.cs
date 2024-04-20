using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Entities;
using OrderProcessing.Repositories;

namespace OrderProcessingAPI.Controllers
{
    [Authorize("admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;

        
        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Order> GetAll()
        {
            List<Order> orders = OrderManager.GetAll();
            return orders;
        }


        [HttpGet("{id}")]
        public Order GetById(int id)
        {
            Order theOrder = OrderManager.GetById(id);
            return theOrder;
        }
    }
}
