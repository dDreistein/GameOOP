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
            Civilization civilization = new CGreeks();
            bool a = true;
            while (a)
            {
                Display.ChooseCivilization();
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        civilization = new CGreeks();
                        a = false;
                        break;
                    case '2':
                        civilization = new CMinoans();
                        a = false;
                        break;
                    case '3':
                        civilization = new CPhoenicians();
                        a = false;
                        break;
                    case '4':
                        civilization = new CAssyrians();
                        a = false;
                        break;
                    case '5':
                        civilization = new CEgyptians();
                        a = false;
                        break;
                    case '6':
                        civilization = new CSumerians();
                        a = false;
                        break;
                    case '7':
                        civilization = new CBabylonians();
                        a = false;
                        break;
                    case '8':
                        civilization = new CHittites();
                        a = false;
                        break;
                    case '9':
                        civilization = new CPersians();
                        a = false;
                        break;
                    case 'q':
                        civilization = new CChoson();
                        a = false;
                        break;
                    case 'w':
                        civilization = new CShang();
                        a = false;
                        break;
                    case 'e':
                        civilization = new CYamato();
                        a = false;
                        break;
                    default:
                        continue;
                }
            }

            do
            {
                bool b = true;
                while (b)
                {
                    Display.Civilization(civilization);
                    switch (Console.ReadKey().KeyChar)
                    {
                        case '1':
                            Display.Attack();
                            b = false;
                            break;
                        case '0':
                            b = false;
                            run = false;
                            break;
                        default:
                            b = true;
                            break;
                    }
                }
            } while (civilization.Cycle());
            Display.Extinct();
            Console.ReadKey();
        }
    }
}