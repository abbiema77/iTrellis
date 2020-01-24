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

namespace iTrellis.CarDealership.Api.Controllers
{
    [Route("product")]
    [ApiController]
    public class ProductController : ApiController
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _product;

        public ProductController(IContainer container) : base(container)
        {
            _logger = container.GetInstance<ILogger<ProductController>>();
            _product = container.GetInstance<IProductService>();
        }

        [HttpGet]
        [Route("Search")]
        public dynamic Search(Product dto)
        {
            return null;
        }

    }
}