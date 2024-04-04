using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Infrastructure.Interfaces;
namespace WEBAPI.Cotrollers;
[ApiController]
[Route("[controller]")]
public class OrderController(IOrderService orderService)
{
    [HttpGet("get-orders")]
    public async Task<List<Orders>> GetOrdersAsync()
    {
        return await orderService.GetOrdersAsync();
    }
    [HttpPost("add-order")]
    public async Task AddOrderAsync(Orders Order)
    {
        await orderService.AddOrderAsync(Order);
    }
    [HttpPut("update-order")]
    public async Task UpdateOrderAsync(Orders Order)
    {
        await orderService.UpdateOrderAsync(Order);
    }
    [HttpDelete("delete-order")]
    public async Task DeleteOrderAsync(int id)
    {
        await orderService.DeleteOrderAsync(id);
    }   
}
