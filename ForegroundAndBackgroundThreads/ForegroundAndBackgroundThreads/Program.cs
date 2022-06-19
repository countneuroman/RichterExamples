namespace ForegroundAndBackgroundThreads;

public static class Program
{
    public static void Main()
    {
        var thread = new Thread(Worker)
        {
            IsBackground = true
        };
        
        thread.Start();
        //В случае активного потока приложение будет работать около 10 секунд.
        //В случае фонового потока приложение немедленно прекратит работу.
        Console.WriteLine("Returning to Main");
    }

    private static void Worker()
    {
        Thread.Sleep(10000);    //Имитация другой работы (10сек)
        
        //Выводится только для кода, исполняемого активным потоком
        Console.WriteLine("Returning from Worker");
    }
}