using API.Model;
using API.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ProductFactory
{
    public class ProductTarrifFactory : IProductTarrifFactory
    {


        public Product GenerateBasicElectricityTarriffProduct(long consumption)
        {
            Product prod = new Product();
            prod.TarriffName = ConstantValues.Get_Basic_Electricity_Tarriff_Name;
            prod.AnnualCost = CalculateBasicElectricityTarriffAnnualCost(consumption);
            return prod;
        }

        public double CalculateBasicElectricityTarriffAnnualCost(long consumption)
        {
            return 5 * 12 + consumption * ConstantValues.Get22CentRate;
        }

        public double CalculatePackagedTarriffAnnualCost(long consumption)
        {
            double result = 0.0d;
            if (consumption <= 4000)
            {
                result = 800;
            }
            else
            {
                var diff = consumption - 4000;
                result = 800 + diff * ConstantValues.Get30CentRate;
            }


            return result;
        }

        public Product GeneratePackagedTarriffProduct(long consumption)
        {
            Product prod = new Product();
            prod.TarriffName = ConstantValues.Get_Packaged_Tarriff_Name;
            prod.AnnualCost = CalculatePackagedTarriffAnnualCost(consumption);
            return prod;
        }
    }
}
