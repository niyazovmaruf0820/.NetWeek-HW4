using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IProductService
{
    Task<List<Products>> GetProductsAsync();
    Task AddProductAsync(Products product);
    Task UpdateProductAsync(Products product);
    Task DeleteProductAsync(int id);
}
