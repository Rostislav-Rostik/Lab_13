using System.Text.RegularExpressions;

internal class Task5
{
    static void Main()
    {
        string url = Console.ReadLine();

        string server = "";
        string protocol = "";
        string resource = "";


        if (Regex.IsMatch(url, @"(\w|\W)+://(\w|\W)"))
        {
            for (int i = 0; i < url.Length; i++)
            {
                if (url[i] == ':' && url[i+1] == '/' && url[i + 2] == '/')
                {
                    break;
                }
                else
                {
                    protocol += url[i];
                    
                }
            }
        }
        if (Regex.IsMatch(url,@"[a-z]+.+(\w|\W)"))
        {
            for (int i = protocol.Length + 3; i < url.Length; i++)
            {
                if (url[i] == '/')
                {
                    break;
                }
                else
                {
                    server += url[i];
                }
            }
        }
        
        if (Regex.IsMatch(url, @"[a-z]+(\w|\W)"))
        {
            for (int i = protocol.Length + 3 + server.Length + 1; i < url.Length; i++)
            {
                if (url[i] == null)
                {
                    break;
                }
                else
                {
                    resource += url[i];
                }
            }
        }


        Console.WriteLine($"[protocol] = {protocol}");
        Console.WriteLine($"[server] = {server}");
        Console.WriteLine($"[resource] = {resource}");
    }
}