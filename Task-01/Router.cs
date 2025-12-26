namespace MyLib;

public class Router
{
    private int optionNumber;

    // public Router(UsersManager manager)
    // {
    //     wallet = new();
    //     usersManager = manager; // از همان instance مشترک استفاده می‌کند
    // }

    // this method for show option list and run a options - send to switch case for run
    public void showAndSelectOptions()
    {
        while (optionNumber != 5)
        {
            Console.WriteLine("Please select an option: \n");
            Console.WriteLine("[1] - add book");
            Console.WriteLine("[2] - show book");
            Console.WriteLine("[3] - deletd book");
            Console.WriteLine("[4] - create library");
            Console.WriteLine("[5] - Exit");
            optionNumber = int.Parse(Console.ReadLine());
            Console.Clear();

            // run method options
            WalletManageSwitch();
        }
    }

    // run all options - methods manager wallet
    public void WalletManageSwitch()
    {
        switch (optionNumber)
        {
            case 1:
                // show cash
                WriteLine("case 1");
                break;
            case 2:
                // deposit
                WriteLine("case 2");
                break;
            case 5:
                WriteLine("exit");
                break;
            default:
                // invalid option
                Console.WriteLine("Invalid Options, Try again!");
                break;
        }
    }


    static void Options(string[] args)
    {
        string? name = null;
        int age = 0;

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "--helps")
            {
                WriteLine("Usage:");
                WriteLine("  --add <value1, ..>    User name");
                WriteLine("  --find <value1>     User age\n");
                WriteLine("  --delete <value1>     User age\n");
                WriteLine("Example:");
                WriteLine("dotnet run --add Ali , hadi , sam");
                return;
            }

            if (args[i] == "--name" && i + 1 < args.Length)
            {
                name = args[i + 1];
                i++;
            }
            else if (args[i] == "--age" && i + 1 < args.Length)
            {
                age = int.Parse(args[i + 1]);
                i++;
            }
        }

        if (name == null || age == 0)
        {
            WriteLine("Error: name and age are required.");
            return;
        }

        WriteLine($"Hello {name}, you are {age} years old.");
    }


}

