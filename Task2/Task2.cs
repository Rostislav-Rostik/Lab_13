internal class Task2
{
    static void Main()
    {
        string temp = Console.ReadLine();

        if (temp.Length < 20)
        {
            Console.WriteLine(temp.PadRight(20, '*'));

        }
        else if (temp.Length > 20)
        {
            Console.WriteLine(temp.Substring(0, 20));
        }
        
    }
}