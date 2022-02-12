using API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Service
{
    public class ProductGeneratorService : IProductGeneratorService
    {
        public static readonly double Cent22Rate = 0.22;  // 22/100
        public static readonly double Cent30Rate = 0.3;   //30/100
        public static readonly string Basic_Electricity_Tarriff = "Basic_Electricity_Tarriff";  
        public static readonly string Packaged_Tarriff = "Packaged_Tarriff";  
        public List<Product> GetProducts(long cosumption)
        {
            List<Product> products = new List<Product>();
            products.Add(BasicElectricityTarriff(cosumption));
            products.Add(PackagedTarriff(cosumption));

            return products.OrderBy(x => x.AnnualCost).ToList();
        }
        //Calculation model: base costs per month 5 € + consumption costs 22 cent/kWh Examples:  
        public Product BasicElectricityTarriff(long cosumption)
        {

            Product prod = new Product();
            prod.TarriffName = Basic_Electricity_Tarriff;
            prod.AnnualCost = CalculateBasicElectricityTarriffAnnualCost(cosumption);
            return prod;
        }
        //Calculation model: 800 € for up to 4000 kWh/year and above 4000 kWh/year additionally 30 cent/kWh.  
        public Product PackagedTarriff(long consumption)
        {

            Product prod = new Product();
            prod.TarriffName = Packaged_Tarriff;
            prod.AnnualCost = CalculatePackagedTarriffAnnualCost(consumption);
            return prod;
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
        public double CalculateBasicElectricityTarriffAnnualCost(long consumption)
        {
            return 5 * 12 + consumption * Cent22Rate;
            
        }

    }
}
