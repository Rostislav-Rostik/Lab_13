internal class Task11
{
    static void Main()
    {
        string temp = Console.ReadLine();
        string temp1 = Console.ReadLine();

        for (int i = 0; i < temp.Length; i++)
        {
            for (int j = 0; j < temp1.Length; j++)
            {
                if (temp[i] == temp1[j])
                {
                    Console.WriteLine("yes");
                    return;
                }
            }
        }
        Console.WriteLine("no");
    }
}