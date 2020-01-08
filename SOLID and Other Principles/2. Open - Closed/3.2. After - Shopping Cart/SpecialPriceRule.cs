namespace OpenClosedShoppingCartAfter
{
    class SpecialPriceRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            return (item.Quantity * .4m) - (item.Quantity / 3 * .2m);
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("SPECIAL");
        }
    }
}
