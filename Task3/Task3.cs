using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

internal class Task3
{
    static void Main()
    {
        string email = Console.ReadLine();
        string text = Console.ReadLine();

        string censorEmail = "";

        for (int i = 0; i < email.Length; i++)
        {
            if (email[i] == '@')
            {
                for (int j = i; j < email.Length; j++)
                {
                    censorEmail += email[j];
                }
            }
            censorEmail += '*';
        }
        text = text.Replace(email, censorEmail);
        Console.WriteLine(text);
    }
}