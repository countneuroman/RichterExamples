double d;
d = char.GetNumericValue('\u0033'); //number 3
Console.WriteLine(d.ToString());

d = char.GetNumericValue('\u00bc'); // (1/4)
Console.WriteLine(d.ToString());

d = char.GetNumericValue('A');
Console.WriteLine(d.ToString());