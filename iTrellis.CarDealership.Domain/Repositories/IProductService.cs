using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using iTrellis.CarDealership.Api.Models;

namespace iTrellis.CarDealership.Api.Repositories
{
    public interface IProductService
    {
        public List<Product> SearchProducts(Product product);
        public List<Product> GetAllProducts();
    }

    public class ProductService : IProductService
    {
        public ProductService()
        {}

        public List<Product> SearchProducts(Product product)
        {
            return null;
        }

        public List<Product> GetAllProducts()
        {
            return JsonConvert.DeserializeObject<List<Product>>(ReadFromFile());
        }

        private string ReadFromFile()
        {
            string path = @"c:\temp\cars.json";
            return File.ReadAllText(path);
        }
    }
}
