namespace CallInterfaceMethod;

public static class Program
{
    public static void Main()
    {
        var simpleType = new SimpleType();
        
        simpleType.Dispose();

        IDisposable disposable = simpleType;
        
        disposable.Dispose();

        Console.ReadKey();
    }
}

internal sealed class SimpleType : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("Public Dispose");
    }

    void IDisposable.Dispose()
    {
        Console.WriteLine("IDisposable.Dispose");
    }
}

