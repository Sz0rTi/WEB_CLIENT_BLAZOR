using BlazorApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public ProductService(HttpClient client)
        {
            _client = client;
        }

        public async Task<Product[]> GetProducts()
        {
            Product[] temp = await _client.GetJsonAsync<Product[]>("https://localhost:5001/api/Products");
            return temp;
        }
    }

    public interface IProductService
    {
        Task<Product[]> GetProducts();
    }
}
