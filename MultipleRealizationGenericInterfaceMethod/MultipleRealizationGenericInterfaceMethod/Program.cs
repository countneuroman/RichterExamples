namespace MultipleRealizationGenericInterfaceMethod;

public static class Program
{
    public static void Main()
    {
        var number = new Number();

        int result = number.CompareTo(5);

        int strResult = number.CompareTo("2");
    }
}

public sealed class Number : IComparable<int>, IComparable<string>
{
    private int m_val = 5;
    
    public int CompareTo(int other)
    {
        return m_val.CompareTo(other);
    }

    public int CompareTo(string? other)
    {
        return m_val.CompareTo(Int32.Parse(other));
    }
}