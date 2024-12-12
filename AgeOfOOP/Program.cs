namespace AgeOfOOP;

class Program
{
    static void Main(string[] args)
    {
        
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        bool run = false;
        Display.TitleScreen();
        switch (Console.ReadKey().KeyChar)
        {
            case '1':
                run = true;
                break;
            case '0':
                run = false;
                break;
        }

        if (run)
        {
            while (run)
            {
                if (Console.ReadKey().KeyChar == '0')
                {
                    run = false;
                }
            }
        }
        Console.ReadKey();
    }
}