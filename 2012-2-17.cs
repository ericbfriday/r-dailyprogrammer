using System;
					
public class Program
{
    public static void Main(string[] args)
    {
        string sentence = "Daily Programmer";
        string filter = "aeiou ";
        foreach (char c in filter)
        {
            sentence = sentence.Replace(c.ToString(), "");
        }
        Console.WriteLine(sentence);
    }
}
