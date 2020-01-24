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
            var allProducts = GetAllProducts();

            var properties = product.GetType().GetProperties();
            foreach (var each in properties)
            {
                if (each.Name.Contains("Is") || each.Name.Contains("Has"))
                {
                    if (each.GetValue(product, null).Equals(true))
                    {
                        allProducts = allProducts.Where(p => p.GetType().GetProperty(each.Name).GetValue(p, null).Equals(true)).ToList();

                    }

                }           
            }
            if(!string.IsNullOrWhiteSpace(product.Color))
            {
                allProducts = allProducts.Where(p => p.Color == product.Color).ToList();
            }

            return allProducts;
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
