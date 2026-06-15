public record Quantity(int Value)
{
    public static Quantity From(int Value)
    {
        if (Value < 0)
        {
            throw new ArgumentException("Quantity cannot be negative.");
        }
        return new Quantity(Value);
    }
}
