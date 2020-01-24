using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StructureMap;

namespace iTrellis.CarDealership.Api.Controllers.Base
{
    public class ApiController : ControllerBase
    {
        private readonly IContainer _container;
        public ApiController(IContainer container)
        {
            _container = container;
        }
    }
}