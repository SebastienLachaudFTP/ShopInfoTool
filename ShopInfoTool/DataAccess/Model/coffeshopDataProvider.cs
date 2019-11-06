using System.Collections.Generic;

namespace DataAccess
{
    public class coffeshopDataProvider
    {
        public IEnumerable<coffeshop> LoadCoffeeShops()
        {
            yield return new coffeshop { Location = "Frankfurt", BeansInStockInKg = 107 };
            yield return new coffeshop { Location = "Freiburg", BeansInStockInKg = 23 };
            yield return new coffeshop { Location = "Munich", BeansInStockInKg = 56 };
        }
    }
}
