using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class Starbucks : IMakeACoffee
    {
        public bool CheckIngridentAvaliable()
        {
            return true;
        }
        string IMakeACoffee.coffeeMaking(int suggerPerSpone,int coffePack)
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// StubStarbuck
    /// </summary>
    public class StubStarbucks : IMakeACoffee
    {
        public bool CheckIngridentAvaliable()
        {
            return true;
        }
        string IMakeACoffee.coffeeMaking(int suggestPerSpone, int coffePack)
        {
            return "your order is received.";
        }
    }
    /// <summary>
    /// fakeStarBuck
    /// </summary>
    public class FakeStarbucks : IMakeACoffee
    {
        public bool CheckIngridentAvaliable()
        {
            return true;
        }
        string IMakeACoffee.coffeeMaking(int suggestPerSpone, int coffePack)
        {
            return "your order is received.";
        }
    }
}
