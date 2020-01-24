using iTrellis.CarDealership.Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace iTrellis.CarDealership.Api.Repositories
{
    public interface IProductService
    {
        List<Product> SearchProducts(Product product);
        List<Product> GetAllProducts();
    }

    public class ProductService : IProductService
    {
        public ProductService()
        { }

        public List<Product> SearchProducts(Product product)
        {
            var allProducts = GetAllProducts();

            var properties = product.GetType().GetProperties();
            foreach (var each in properties)
            {
                if (each.Name.Contains("Is") || each.Name.Contains("Has") || each.Name.Equals("Color"))
                {
                    if (each.GetValue(product, null).Equals(true))
                    {
                        allProducts = allProducts.Where(p => p.GetType().GetProperty(each.Name).GetValue(p, null).Equals(true)).ToList();

                    }

                }
            }
            return allProducts;
            //allProducts.Where(p =>
            //p.HasHeatedSeats == product.HasHeatedSeats 
            //&& p.HasLowMiles == product.HasLowMiles
            //&& p.HasNavigation == product.HasNavigation
            //&& p.HasPowerWindows == product.HasPowerWindows
            //&& p.HasSunroof == product.HasSunroof
            //&& p.IsFourWheelDrive == p.IsFourWheelDrive
            //&& p.colo
            //)
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