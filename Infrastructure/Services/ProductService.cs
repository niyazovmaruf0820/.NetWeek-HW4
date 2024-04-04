using Dapper;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ProductService(DapperContext dapperContext) : IProductService
{
    public async Task AddProductAsync(Products product)
    {
        string query = "insert into Products(name,desription,price,stockQuantity)values(@name,@desription,@price,@stockQuantity)";
        await dapperContext.Connection().ExecuteAsync(query,product);
    }

    public async Task DeleteProductAsync(int id)
    {
        string query = "delete from Products where Id = @id";
        await dapperContext.Connection().ExecuteAsync(query,new {Id = id});
    }

    public async Task<List<Products>> GetProductsAsync()
    {
        string query = "select * from Products";
        var list = await dapperContext.Connection().QueryAsync<Products>(query);
        return list.ToList();
    }

    public async Task UpdateProductAsync(Products product)
    {
        string query = "update Products set name = @name, desription = @desription, price = @price, stockQuantity = @stockQuantity where Id = @id";
        await dapperContext.Connection().ExecuteAsync(query,product);
    }
}
