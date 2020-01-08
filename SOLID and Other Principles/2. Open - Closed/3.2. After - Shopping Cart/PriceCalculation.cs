

using System.Collections.Generic;
using System.Linq;

namespace OpenClosedShoppingCartAfter
{
    class PriceCalculation
    {
        private readonly List<IPriceRule> rules;

        public PriceCalculation()
        {
            this.rules = new List<IPriceRule>{
                                        new EachPriceRule(),
                                        new WeightPriceRule(),
                                        new SpecialPriceRule()
                                    };
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return this.rules.First(r => r.IsMatch(item)).CalculatePrice(item);
        }
    }
}
