namespace ThreadExample;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Main thread: starting a dedicated thread" +
                          "to do an asynchronous operation");
        var dedicatedThread = new Thread(ComputeBoundOp);
        dedicatedThread.Start(5);
        
        Console.WriteLine("Main thread: Doing other work here...");
        Thread.Sleep(10000);    //Имитация другой работы (10 сек)

        dedicatedThread.Join();     //Ожидание завершения потока
        Console.WriteLine("Hit <Enter> to end this program...");
        Console.ReadLine();
    }

    private static void ComputeBoundOp(object state)
    {
        Console.WriteLine("In ComputeBoundOp: state = {0}", state);
        Thread.Sleep(1000);     //Имитация другой работы (1сек)
    }
}