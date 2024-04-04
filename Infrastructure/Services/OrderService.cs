using Dapper;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class OrderService(DapperContext dapperContext) : IOrderService
{
    public async Task AddOrderAsync(Orders order)
    {
        string q0 = "select Price from Products where Id = ProductId";
        decimal price = dapperContext.Connection().QueryFirst<int>(q0);
        decimal totalAmount = price * order.ProductQuantity;
        string query = "insert into Orders(customerId,orderDate,productId,productQuantity,totalAmount)values(@name,@surname,@email,@phomenumber,@totalAmount)";
        await dapperContext.Connection().ExecuteAsync(query, new {order,TotalAmount = totalAmount});
    }

    public async Task DeleteOrderAsync(int id)
    {
        string query = "delete from Orders where Id = @id";
        await dapperContext.Connection().ExecuteAsync(query,new {Id = id});
    }

    public async Task<List<Orders>> GetOrdersAsync()
    {
        string query = "select * from Orders";
        var list = await dapperContext.Connection().QueryAsync<Orders>(query);
        return list.ToList();
    }

    public async Task UpdateOrderAsync(Orders order)
    {
        string q0 = "select Price from Products where Id = ProductId";
        decimal price = dapperContext.Connection().QueryFirst<int>(q0);
        decimal totalAmount = price * order.ProductQuantity;
        string query = "update Orders set customerId = @customerId, orderDate = @orderDate, productId = @productId, productQuantity = @productQuantity, totalAmount = @totalAmount  where Id = @id";
        await dapperContext.Connection().ExecuteAsync(query,new {order,TotalAmount = totalAmount});
    }
}
