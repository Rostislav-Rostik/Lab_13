using System;
internal class Task1
{
    static void Main()
    {
        Console.WriteLine("Enter a String : ");
        string originalString = Console.ReadLine();
        string reverseString = "";
        for (int i = originalString.Length - 1; i >= 0; i--)
        {
            reverseString += originalString[i];
        }
        Console.Write($"Reverse string is : {reverseString} ");
    }
}