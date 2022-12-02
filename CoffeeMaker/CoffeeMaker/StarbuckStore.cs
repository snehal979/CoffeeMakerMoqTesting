using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class StarbuckStore
    {
        private readonly IMakeACoffee services;

        public StarbuckStore(IMakeACoffee services)
        {
            this.services=services;
        }
        public string OrderCoffee(int suggestPerSpone, int coffePack)
        {
            if (services.CheckIngridentAvaliable())
            {
                return services.coffeeMaking(suggestPerSpone, coffePack);
            }
            else
            {
                return "Sorry! Coffee is not available.";
            }
        }

    }
}
