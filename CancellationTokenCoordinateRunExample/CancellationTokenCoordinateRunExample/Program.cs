var cts = new CancellationTokenSource();

cts.Token.Register(() => Console.WriteLine("Canceled 1"));
cts.Token.Register(() => Console.WriteLine("Canceled 2"));

cts.Cancel();

//Создем первый токен.
var cts1 = new CancellationTokenSource();
cts1.Token.Register(() => Console.WriteLine("cts1 canceled"));

//Создем второй токен.
var cts2 = new CancellationTokenSource();
cts2.Token.Register(() => Console.WriteLine("cts2 canceled"));

//Создем токен, который отменится если мы отменим cts1 или cts2
var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(cts1.Token, cts2.Token);
linkedCts.Token.Register(() => Console.WriteLine("linkedCts canceled"));

//Отменяем один из токенов.
cts2.Cancel();

//Смотрим статус токенов.
Console.WriteLine($"cts1 canceled = {cts1.IsCancellationRequested}, cts2 canceled = {cts2.IsCancellationRequested}," +
                  $" linkedCts canceled = {linkedCts.IsCancellationRequested}");