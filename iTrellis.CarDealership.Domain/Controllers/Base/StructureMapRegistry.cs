using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructureMap;

namespace iTrellis.CarDealership.Api.Controllers.Base
{
    public class StructureMapRegistry : Registry
    {
        public StructureMapRegistry()
        {
            Scan(s =>
            {
                s.AssembliesFromApplicationBaseDirectory();
                s.WithDefaultConventions();
                s.LookForRegistries();
            });
        }
    }
}
