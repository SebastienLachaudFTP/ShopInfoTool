using System.Collections.Generic;

namespace DataAccess
{
    public class coffeshopDataProvider
    {
        public IEnumerable<coffeshop> LoadCoffeeShops()
        {
            yield return new coffeshop
            {
                Location = "Frankfurt",
                BeansInStockInKg = 107,
                PaperCupsInStock = 350
            };
            yield return new coffeshop
            {
                Location = "Freiburg",
                BeansInStockInKg = 23,
                PaperCupsInStock = 250
            };
            yield return new coffeshop
            {
                Location = "Munich",
                BeansInStockInKg = 56,
                PaperCupsInStock = 427
            };
            yield return new coffeshop
            {
                Location = "Paris",
                BeansInStockInKg = 56,
                PaperCupsInStock = 427
            };
        }
    }
}