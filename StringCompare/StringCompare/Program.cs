using System.Globalization;

namespace StringCompare;

public class Program
{
    public static void Main()
    {
        var s = "Hello";
        var s1 = "Hello";

        //Ordinal быстрее сравнивает строки, т.к не проверяет региональные стандарты.
        //Полезно использовать для сравнения значений, которые используются внутри приложения и не видны пользователям.
        int result = string.Compare(s, s1, StringComparison.OrdinalIgnoreCase);

        bool startsWith = s.StartsWith(s1, StringComparison.CurrentCultureIgnoreCase);

        bool equals = s.Equals(s1, StringComparison.CurrentCultureIgnoreCase);

        var ci = new CultureInfo("en-US");

        int compareInfo = ci.CompareInfo.Compare(s, s1);

        var comparer = StringComparer.CurrentCultureIgnoreCase;

        int compare = comparer.Compare(s, s1);
    }
}