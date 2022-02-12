using API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ProductFactory
{
   public interface IProductTarrifFactory
    {
        Product GenerateBasicElectricityTarriffProduct(long consumption);
        Product GeneratePackagedTarriffProduct(long consumption);
        double CalculatePackagedTarriffAnnualCost(long consumption);
        double CalculateBasicElectricityTarriffAnnualCost(long consumption);
    }
}
