namespace StringInterning;

public class Program
{
    public static void Main()
    {
        string s1 = "Hello";
        string s2 = "Hello";

        //Если строки итерируются, то выводит True, но без интерирования строк выводило бы false
        //т.к это 2 разных объекта.
        Console.WriteLine(ReferenceEquals(s1, s2));

        s1 = string.Intern(s1);
        s2 = string.Intern(s2);
        Console.WriteLine(ReferenceEquals(s1, s2));
    }
    
    private static int NumTimesWordAppearsEquals(string word, string[] wordList)
    {
        int count = 0;

        for (var wordNum = 0; wordNum < wordList.Length; wordNum++)
        {
            if (word.Equals(wordList[wordNum], StringComparison.Ordinal))
                count++;
        }
        
        return count;
    }
    
    private static int NumTimesWordAppearsIntern(string word, string[] wordList)
    {
        //Предполагается что все элементы wordList
        //ссылаются на итерированые строки.
        word = string.Intern(word);
        int count = 0;

        for (var wordNum = 0; wordNum < wordList.Length; wordNum++)
        {
            if (ReferenceEquals(word, wordList[wordNum]))
                count++;
        }
        
        return count;
    }
}
