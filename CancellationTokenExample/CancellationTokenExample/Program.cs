namespace CancellationTokenExample;

public static class Program
{
    public static void Main()
    {
        var cts = new CancellationTokenSource();
        ThreadPool.QueueUserWorkItem(_=> Count(cts.Token, 1000));
        
        Console.WriteLine("Press Enter to cancel the operatuin.");
        Console.ReadLine();
        //Если метод Count уже вернул управление, то не оказывает никакого эффекта.
        cts.Cancel();

        //Cancel немедленно возвращает управление, метод продолжает работу.
        Console.ReadLine();
    }

    private static void Count(CancellationToken token, int countTo)
    {
        for (var count = 0; count < countTo; count++)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Count is cancelled.");
                break;
            }
            Console.WriteLine(count);
            Thread.Sleep(200);
        }
        
        Console.WriteLine($"{nameof(Count)} is done");
    }
}