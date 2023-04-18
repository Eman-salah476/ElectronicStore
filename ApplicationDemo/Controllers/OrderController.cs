using ApplicationDemo.Application.Dtos.Order;
using ApplicationDemo.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationDemo.Controllers
{
    [ApiController]
    [Route("api/Order")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPut]
        public ActionResult Calculate(ItemsToOrderDto itemsToOrderDto)
        {
            try
            {
                var totalPrice = _orderService.CalculateTotalPrice(itemsToOrderDto);
                return Ok(totalPrice);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult Update(Guid id)
        {
            try
            {
                var isUpdate = _orderService.UpdateOrder(id);
                if (!isUpdate)
                    return BadRequest();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Add([FromForm]OrderToAddDto orderToAdd)
        {
            try
            {
                var isAdded = _orderService.Add(orderToAdd);
                if (!isAdded)
                    return BadRequest();
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
