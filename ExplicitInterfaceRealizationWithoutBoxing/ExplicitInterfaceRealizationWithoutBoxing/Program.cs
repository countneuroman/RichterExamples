namespace ExplicitInterfaceRealizationWithoutBoxing;

public class Program
{
    public static void Main()
    {
        var v = new SomeValueType(0);
        var o = new object();
        int n = v.CompareTo(v); //Упаковки нет, т.к метод CompareTo принимает SomeValueType
        //Следующая строка выдает ошибку компиляции, т.к. мы не можем явно скастить object в SomeValueType.
        //n = v.CompareTo(o);
    }
}

internal struct SomeValueType : IComparable
{
    private int m_x;

    public SomeValueType(int mX)
    {
        m_x = mX;
    }

    //Реализована безопасность типов, т.к передаем SomeValueType.
    public int CompareTo(SomeValueType other)
    {
        return m_x - other.m_x;
    }

    //Реализуем контракт Icomparable.
    int IComparable.CompareTo(object other)
    {
        return CompareTo((SomeValueType)other);
    }
}