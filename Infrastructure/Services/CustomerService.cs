using Dapper;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class CustomerService(DapperContext dapperContext) : ICustomerService
{
    public async Task AddCustomerAsync(Customers customer)
    {
        string query = "insert into Customers(name,surname,email,phonenumber)values(@name,@surname,@email,@phonenumber)";
        await dapperContext.Connection().ExecuteAsync(query,customer);
    }

    public async Task DeleteCustomerAsync(int id)
    {
        string query = "delete from Customers where Id = @id";
        await dapperContext.Connection().ExecuteAsync(query,new {Id = id});
    }

    public async Task<List<Customers>> GetCustomersAsync()
    {
        string query = "select * from Customers";
        var list = await dapperContext.Connection().QueryAsync<Customers>(query);
        return list.ToList();
    }

    public async Task UpdateCustomerAsync(Customers customer)
    {
        string query = "update Customers set name = @name, surname = @surname, email = @email, phoneNumber = @phoneNumber where Id = @id";
        await dapperContext.Connection().ExecuteAsync(query,customer);
    }
}
