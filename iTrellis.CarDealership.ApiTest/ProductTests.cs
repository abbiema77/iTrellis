using NUnit.Framework;
using System.Diagnostics;
using iTrellis.CarDealership.Api.Repositories;


namespace iTrellis.CarDealership.ApiTest
{
    public class Tests
    {
        private readonly IProductService _product;

        public Tests()
        {

        }

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void should_read_all_products_from_json_file()
        {
            var productService = new ProductService();
            var product = productService.GetAllProducts();

            if(product.Count == 9) Assert.Pass();
            Assert.Fail();
        }
    }
}