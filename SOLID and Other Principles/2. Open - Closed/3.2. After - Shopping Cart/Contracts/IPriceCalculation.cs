namespace OpenClosedShoppingCartAfter
{
    interface IPriceCalculation
    {
        decimal CalculatePrice(OrderItem item);
    }
}
