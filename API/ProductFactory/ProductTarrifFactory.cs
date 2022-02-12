using API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ProductFactory
{
    public class ProductTarrifFactory : IProductTarrifFactory
    {

        public static readonly double Cent22Rate = 0.22;  // 22/100
        public static readonly double Cent30Rate = 0.3;   //30/100
        public static readonly string Basic_Electricity_Tarriff = "Basic_Electricity_Tarriff";
        public static readonly string Packaged_Tarriff = "Packaged_Tarriff";
        public Product GenerateBasicElectricityTarriffProduct(long cosumption)
        {
            Product prod = new Product();
            prod.TarriffName = Basic_Electricity_Tarriff;
            prod.AnnualCost = CalculateBasicElectricityTarriffAnnualCost(cosumption);
            return prod;
        }

        public double CalculateBasicElectricityTarriffAnnualCost(long consumption)
        {
            return 5 * 12 + consumption * Cent22Rate;
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
                result = 800 + diff * Cent30Rate;
            }


            return result;
        }

        public Product GeneratePackagedTarriffProduct(long consumption)
        {
            Product prod = new Product();
            prod.TarriffName = Packaged_Tarriff;
            prod.AnnualCost = CalculatePackagedTarriffAnnualCost(consumption);
            return prod;
        }
    }
}
