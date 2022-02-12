using API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Service
{
   public interface IProductGeneratorService
    {
        List<Product> GetProducts(long consumption);
    }
}
