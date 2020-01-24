using NUnit.Framework;
using System.Diagnostics;
using iTrellis.CarDealership.Api.Repositories;
using iTrellis.CarDealership.Api.Models;

namespace iTrellis.CarDealership.ApiTest
{
    public class Tests
    {
        private readonly IProductService _product;
        private Product _car;
        public Tests()
        {

        }

        [SetUp]
        public void Setup()
        {
            _car = new Product() {
                Color = null,
                HasSunroof = false,
                HasHeatedSeats = false,
                HasLowMiles = false,
                HasNavigation = false,
                HasPowerWindows = false,
                IsFourWheelDrive = false
            };
        }

        [Test]
        public void should_read_all_products_from_json_file()
        {
            var productService = new ProductService();
            var product = productService.GetAllProducts();

            if(product.Count == 9) Assert.Pass();
            Assert.Fail();
        }

        [Test]
        public void should_return_cars_with_sunroof()
        {
            var productService = new ProductService();

            _car.HasSunroof = true;
            var cars = productService.SearchProducts(_car);

            Assert.AreEqual(5, cars.Count);
        }

        public void should_return_cars_with_navi_and_red()
        {
            var productService = new ProductService();

            _car.HasNavigation = true;
            _car.Color = "Red";
            var cars = productService.SearchProducts(_car);

            Assert.AreEqual(1, cars.Count);
        }
    }
}