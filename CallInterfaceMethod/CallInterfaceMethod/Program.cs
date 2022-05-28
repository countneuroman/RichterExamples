namespace CallInterfaceMethod;

public static class Program
{
    public static void Main()
    {
        var simpleType = new SimpleType();
        
        simpleType.Dispose();

        IDisposable disposable = simpleType;
        
        //Если создана явная реализация интерфейсного метода, то вызывается она.
        //Иначе вызывается метод, который был реализован в том типе, на который ссылается созданный IDisposable объект.
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

    //Создаем явную реализацию интерфейсного метода
    void IDisposable.Dispose()
    {
        Console.WriteLine("IDisposable.Dispose");
    }
}

