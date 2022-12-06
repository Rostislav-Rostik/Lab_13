using System;

internal class Task10
{
    static void Main()
    {
        string a = Console.ReadLine();
        for (int i = -1; i != a.Length; i++) 
        {
            int tempCount = 0;
            string temp = "";
            for (int j = 0; j < a.Length; j++)
            {
                if (j != i)
                {
                    temp += a[j];
                }
            }
            for (int j = 0; j != a.Length / 2; j++)
            {
                if (temp[j] == temp[temp.Length - 1 - j])
                {
                    tempCount++;
                }
            }
            if (tempCount == a.Length / 2 && i == -1)
            {
                Console.Write("-1");
                return;
            }
            else if (tempCount == a.Length / 2 && i != -1)
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine("It's not a palidrom");
    }
}