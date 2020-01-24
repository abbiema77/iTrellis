using iTrellis.CarDealership.Api.Models;
using iTrellis.CarDealership.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iTrellis.CarDealership.Api.Controllers
{

    public class ProductController : ApiController
    {

        private readonly IProductService _product;

        public ProductController(IProductService product)
        {
   
            _product = product;
        }

        [Route("search")]
        [HttpPost]
        public dynamic Search(Product dto)
        {
            //return _product.SearchProducts(dto);

            return null;
        }

        [Route("PostTest")]
        [HttpPost]
        public void PostTest(int id)
        {
            var test = id;
        }

        [HttpGet]
        [Route("GetAll")]
        public List<Product> GetAllProducts()
        {
            return _product.GetAllProducts();
        }
    }
}
