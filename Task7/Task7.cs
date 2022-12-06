using System;
using System.Reflection;
using System.Runtime.Serialization.Formatters;

internal class Program
{
    static void Main()
    {
        var text = Console.ReadLine().Split(' ', '>', '/');
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == "<upcase")
            {
                text[i] = "";
                while (true)
                {
                    i++;
                    if (text[i] == "upcase" || i == text.Length - 1)
                    {
                        text[i] = "";
                        break;
                    }
                    text[i] = text[i].ToUpper();
                    i++;
                    if (text[i] == "upcase" || i == text.Length - 1)
                    {
                        text[i - 1] = text[i - 1].Remove(text[i - 1].Length - 2, 2);
                    }
                    i--;
                }
            }
        }
        foreach (var f in text)
        {
            Console.Write(f + " ");
        }
    }
}