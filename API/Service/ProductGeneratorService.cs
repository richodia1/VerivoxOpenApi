using API.Model;
using API.ProductFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Service
{
    public class ProductGeneratorService : IProductGeneratorService
    {
      
        private readonly IProductTarrifFactory productTarrifFactory;
        public ProductGeneratorService(IProductTarrifFactory _productTarrifFactory)
        {
            productTarrifFactory = _productTarrifFactory;
        }
        public List<Product> GetProducts(long cosumption)
        {
            List<Product> products = new List<Product>();
            products.Add(productTarrifFactory.GenerateBasicElectricityTarriffProduct(cosumption));
            products.Add(productTarrifFactory.GeneratePackagedTarriffProduct(cosumption));

            return products.OrderBy(x => x.AnnualCost).ToList();
        }
        

    }
}
