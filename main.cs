using System;

class Program 
{
    static void Main(string[] args) 
    {
        bool exit = false;

        do 
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Denomination");
            Console.WriteLine("2. Message");
            Console.WriteLine("3. Star Triangle");
            Console.WriteLine("4. Sum and Append");
            Console.WriteLine("5. FooBar");
            Console.WriteLine("6. Exit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice)) 
            {
                switch (choice) 
                {
                    case 1:
                        Denomination();
                        break;
                    case 2:
                        Message(args);
                        break;
                    case 3:
                        Console.Write("Enter a positive number for the Star Triangle: ");
                        int number = int.Parse(Console.ReadLine());
                        StarTriangle(number);
                        break;
                    case 4:
                        SumAppend(args);
                        break;
                    case 5:
                        Foobar();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } 
            else 
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
            }

        } while (!exit);
    }

    static void Denomination() 
    {
        decimal cent = 0.01m;
        decimal nickel = 0.05m;
        decimal quarter = 0.25m;
        decimal peso = 1;
        decimal lima = 5;
        decimal sampu = 10;
        decimal bente = 20;
        decimal fifty = 50;
        decimal onehund = 100;
        decimal twohund = 200;
        decimal fivehund = 500;
        decimal onethou = 1000;

        Console.WriteLine("Enter the denomination:");
        decimal money = Decimal.Parse(Console.ReadLine());

        if (money == cent)
        {
            Console.WriteLine($"No person is found in PHP {cent}");
        }
        else if (money == nickel)
        {
            Console.WriteLine($"No person is found in PHP {nickel}");
        }
        else if (money == quarter)
        {
            Console.WriteLine($"No person if found in PHP {quarter}");
        }
        else if (money == peso)
        {
            Console.WriteLine($"Jose Rizal is found in PHP {peso}");
        }
        else if (money == lima)
        {
            Console.WriteLine($"Emilio Aguinaldo is found in PHP {lima}");
        }
        else if (money == sampu)
        {
            Console.WriteLine($"Andres Bonifacio & Apolinario Mabini is found in PHP {sampu}");
        }
        else if (money == bente)
        {
            Console.WriteLine($"Manuel Quezon is found in PHP {bente}");
        }
        else if (money == fifty)
        {
            Console.WriteLine($"Sergio Osmena is found in PHP {fifty}");
        }
        else if (money == onehund)
        {
            Console.WriteLine($"Manuel Roxas is found in PHP {onehund}");
        }
        else if (money == twohund)
        {
            Console.WriteLine($"Diosdado Macapagal is found in PHP {twohund}");
        }
        else if (money == fivehund)
        {
            Console.WriteLine($"Benigno Aquino & Corazon Aquino is found in PHP {fivehund}");
        }
        else if (money == onethou)
        {
            Console.WriteLine($"Jose Abad Santos, Josefa Escoda, & Vicente Lim is found in PHP {onethou}");
        }
        else
        {
            Console.WriteLine($"Invalid Denomination: {money}");
        }
    }

    static void Message(string[] args) 
    {
        string text = " ";
        string text2 = " ";

        Console.Write("Enter Something: ");
        while ((text = Console.ReadLine()) != "exit") 
        {
            text2 += text + " ";
            Console.WriteLine(text2.Trim());
            Console.WriteLine("Enter Something: ");
        }

        Console.WriteLine("\nClosing Program...");
    }

    static void StarTriangle(int n) 
    {
        for (int i = 1; i <= n; i++) 
        {
            for (int k = 1; k <= n - i; k++) 
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= 2 * i - 1; j++) 
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void SumAppend(string[] args) 
    {
        int PrevNum = 0;
        string NowMess = "";

        while (true) 
        {
            Console.Write("Enter Something: ");
            var UserInput = Console.ReadLine();

            if (UserInput.ToLower() == "exit") 
            {
                Console.WriteLine("Closing Program. Goodbye.");
                break;
            }

            if (int.TryParse(UserInput, out int number)) 
            {
                PrevNum += number;
                Console.WriteLine($"Adding {UserInput} to {PrevNum - number} = {PrevNum}");
            } 
            else 
            {
                NowMess += UserInput;
                Console.WriteLine($"Current Message is: {NowMess}");
            }
        }
    }

    static void Foobar() 
    {
        Console.WriteLine("Enter FooBar Limit: ");
        var UserInput = int.Parse(Console.ReadLine());
        for (int i = 1; i <= UserInput; i++) 
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine(i + "- FooBar");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine(i + "- Foo");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine(i + "- Bar");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}