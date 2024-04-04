using Domain.Models;

namespace Infrastructure.Interfaces;

public interface ICustomerService
{
    Task<List<Customers>> GetCustomersAsync();
    Task AddCustomerAsync(Customers customer);
    Task UpdateCustomerAsync(Customers customer);
    Task DeleteCustomerAsync(int id);
}
