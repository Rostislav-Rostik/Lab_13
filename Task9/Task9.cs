internal class Task9
{
    static void Main()
    {
        var text = Console.ReadLine().Split('.', ',', ':', ';', '!', '?', ' ');

        for (int i = 0; i < text.Length; i++) 
        {
            string temp = text[i];
            if (temp.Length > 0)
            {
                char first = char.ToUpper(temp[0]);

                string temporary = "";

                temporary += first;

                for (int j = 1; j < temp.Length; j++)
                {
                    temporary += temp[j];
                }

                text[i] = temporary;
            }
        }
        foreach (string temp in text)
        {
            Console.Write(temp + " ");
        }
    }
}
