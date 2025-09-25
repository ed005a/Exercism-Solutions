public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    // TODO: implement equality operators
    public static bool operator==(CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency) throw new ArgumentException();
        return left.amount == right.amount;
    }
    public static bool operator!=(CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency) throw new ArgumentException();
        return left.amount != right.amount;
    }
    // TODO: implement comparison operators
    public static bool operator >(CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency) throw new ArgumentException();
        return left.amount > right.amount;
    }
    public static bool operator <(CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency) throw new ArgumentException();
        return left.currency == right.currency && left.amount < right.amount;
    }

    // TODO: implement arithmetic operators
    public static CurrencyAmount operator +(CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency) throw new ArgumentException();
        return new CurrencyAmount( left.amount + right.amount, left.currency);
    }
    public static CurrencyAmount operator -(CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency) throw new ArgumentException();
        return new CurrencyAmount( left.amount - right.amount, left.currency);
    }

    public static CurrencyAmount operator *(CurrencyAmount left, decimal right) =>
        new CurrencyAmount(left.amount * right, left.currency);
    public static CurrencyAmount operator /(CurrencyAmount left, decimal right) =>
        new CurrencyAmount(left.amount / right, left.currency);

    // TODO: implement type conversion operators
    public static explicit operator double(CurrencyAmount currencyAmount) => (double)currencyAmount.amount;
    public static implicit operator decimal(CurrencyAmount currencyAmount) => currencyAmount.amount;
    
}
