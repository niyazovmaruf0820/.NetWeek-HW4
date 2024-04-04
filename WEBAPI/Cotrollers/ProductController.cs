using Domain.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Cotrollers;
[ApiController]
[Route("[controller]")]
public class ProductController(IProductService productService)
{
    [HttpGet("get-products")]
    public async Task<List<Products>> GetProductsAsync()
    {
        return await productService.GetProductsAsync();
    }
    [HttpPost("add-products")]
    public async Task AddProductAsync(Products product)
    {
        await productService.AddProductAsync(product);
    }
    [HttpPut("update-products")]
    public async Task UpdateProductAsync(Products product)
    {
        await productService.UpdateProductAsync(product);
    }
    [HttpDelete("delete-products")]
    public async Task DeleteProductAsync(int id)
    {
        await productService.DeleteProductAsync(id);
    }
}
