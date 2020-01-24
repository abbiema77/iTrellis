using System;
using System.Collections.Generic;
using System.Linq;
using StructureMap;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using iTrellis.CarDealership.Api.Models;
using iTrellis.CarDealership.Api.Repositories;
using iTrellis.CarDealership.Api.Controllers.Base;
using Newtonsoft.Json;

namespace iTrellis.CarDealership.Api.Controllers
{
    [Route("product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _product;

        public ProductController(IProductService product)
        {
            _product = product;
        }

        [Route("postsearch")]
        [HttpPost]
        public dynamic PostSearch(Product dto)
        {
            return _product.SearchProducts(dto);
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