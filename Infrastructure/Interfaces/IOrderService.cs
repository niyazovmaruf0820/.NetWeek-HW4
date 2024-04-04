using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IOrderService
{

    Task<List<Orders>> GetOrdersAsync();
    Task AddOrderAsync(Orders order);
    Task UpdateOrderAsync(Orders order);
    Task DeleteOrderAsync(int id);


}
