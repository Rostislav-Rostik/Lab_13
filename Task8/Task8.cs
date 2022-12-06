using System;
using System.Reflection;
using System.Runtime.Serialization.Formatters;

internal class Task8
{
    static void Main()
    {
        var text = Console.ReadLine().Split('.', ',', ':', ';', '!', '?', ' ');

        List<string> palindromes = new List<string>();

        foreach (string s in text)
        {
            int temp = 0;

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] == s[s.Length - i - 1])
                {
                    temp++;
                }
            }
            if (temp == s.Length / 2)
            {
                Console.Write(s + "\n");
            }
        }
    }
}