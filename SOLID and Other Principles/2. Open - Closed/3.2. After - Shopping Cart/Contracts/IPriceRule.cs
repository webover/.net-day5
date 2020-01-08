namespace OpenClosedShoppingCartAfter
{
    interface IPriceRule
    {
        bool IsMatch(OrderItem item);

        decimal CalculatePrice(OrderItem item);
    }
}
