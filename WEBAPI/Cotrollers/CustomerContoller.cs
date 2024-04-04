using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Infrastructure.Interfaces;
namespace WEBAPI.Cotrollers;
[ApiController]
[Route("[controller]")]
public class CustomerContoller(ICustomerService customerService)
{
    [HttpGet("get-customers")]
    public async Task<List<Customers>> GetcustomersAsync()
    {
        return await customerService.GetCustomersAsync();
    }
    [HttpPost("add-customers")]
    public async Task AddcustomerAsync(Customers customer)
    {
        await customerService.AddCustomerAsync(customer);
    }
    [HttpPut("update-customers")]
    public async Task UpdatecustomerAsync(Customers customer)
    {
        await customerService.UpdateCustomerAsync(customer);
    }
    [HttpDelete("delete-customers")]
    public async Task DeletecustomerAsync(int id)
    {
        await customerService.DeleteCustomerAsync(id);
    }
}
