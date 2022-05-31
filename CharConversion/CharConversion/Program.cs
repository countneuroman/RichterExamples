char c;
int n;

c = (char) 65;
Console.WriteLine(c); // 'A'

n = (int) c;
Console.WriteLine(n); //65

c = unchecked((char) (65536 + 65));
Console.WriteLine(c); // 'A'

c = Convert.ToChar(65);
Console.WriteLine(c); // 'A'

n = Convert.ToInt32(c);
Console.WriteLine(n); //65

try
{
    c = Convert.ToChar(70000);
    Console.WriteLine(c);
}
catch (OverflowException)
{
    Console.WriteLine("Can`t convert 70000 to a char");
}

c = ((IConvertible)65).ToChar(null);
Console.WriteLine(c); // 'A'

n = ((IConvertible)c).ToInt32(null);
Console.WriteLine(n); //65