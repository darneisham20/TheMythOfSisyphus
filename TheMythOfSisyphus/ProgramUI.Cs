using static System.Console;

public class Program_UI
{

    private bool IsRunning = true;

    // REPOSITORY
    // public Program_UI()
    // {
    //     SeedData();
    // }

    public void Run()
    {
        RunApplication();
    }

    private void RunApplication()
    {
        while (IsRunning)
        {
            System.Console.WriteLine("Welcome to The Myth of Sisyphus, please make a selection:\n" +
                "1. Start Game\n" +
                "2. End Game");

            var userInput = ReadLine();
            switch (userInput)
            {
                case "1":
                    StartGame();
                    break;
                case "2":
                    IsRunning = CloseGame();
                    break;
                default:
                    WriteLine("Invalid Selection");
                    break;
            }
        }
    }

    private bool CloseGame()
    {
        System.Console.WriteLine("Thank you for playing The Myth of Sisyphus!");
        PressAnyKeyToContinue();
        return false;
    }

    private void PressAnyKeyToContinue()
    {
        System.Console.WriteLine("Press any key to continue...");
        ReadKey();
    }

    private void StartGame()
    {
        Console.Clear();
        System.Console.WriteLine("It's a beautiful day, you can't wait to go outside and enjoy your day off! Oh sh*t...your tags are expired...\n" +
            "1. Be Productive\n" +
            "2. Naaaah~ I'm going to enjoy my day off!");

        var userInput = ReadLine();
        switch (userInput)
        {
            case "1":
                HeadToTheDMV();
                break;
            case "2":
                CopEventStart();
                break;
        }
    }
    private void CopEventStart()
    {
        Console.Clear();
        System.Console.WriteLine("Securing the notion that you'll enjoy your day off - your eyes glaze over...all of a sudden, it's tomorrow 9:00am");

        PressAnyKeyToContinue();

        System.Console.WriteLine("It's a beautiful day, you can't wait to go outside and enjoy your day off! Oh sh*t...your tags are expired...\n" +
            "1. Be Productive\n");

        var userInput = ReadLine();
        switch (userInput)
        {
            case "1":
                CopEventMiddle();
                break;
        }
    }

    private void CopEventMiddle()
    {
        System.Console.WriteLine("You get in your car...start the engine and start heading over to the DMV. WEEWOO WEEWOO! Your laziness has cost you, and now an interceptor with the state trooper has come to show you the error of your ways. You hear the crunch of the heels of his boots on the gravel of the shoulder of the highway as he approaches your driver side window...\n" +
            "1. Equip and use item: Disarming Phrase!\n" +
            "2. Hand over your license and registration");

        var userInput = ReadLine();
        switch (userInput)
        {
            case "1":
                CopEventEndGame();
                break;
            case "2":
                RestartOfGame();
                break;
        }
    }

    private void CopEventEndGame()
    {
        System.Console.WriteLine("Are you attempting to bribe an officer of the law?! Guess you don't need to renew your plates. The state trooper cuffs you and sends you to jail forever!");

        PressAnyKeyToContinue();

        YouLostTheGame();
    }

    private void RestartOfGame()
    {
        Console.Clear();
        System.Console.WriteLine("The cop writes you a ticket and sends you straight home with no dinner. It's tomorrow 9:00am.");

        PressAnyKeyToContinue();

        System.Console.WriteLine("It's a beautiful day, you can't wait to go outside and enjoy your day off! Oh sh*t...your tags are expired...\n" +
            "1. Be Productive\n");

        var userInput = ReadLine();
        switch (userInput)
        {
            case "1":
                HeadToTheDMV();
                break;
        }
    }

    private void HeadToTheDMV()
    {
        Console.Clear();

        System.Console.WriteLine("You arrive at the BMV and see four seats taken by the following characters...(C1, C2, C3, C4)");
        System.Console.WriteLine("You pull a number from the MICROFRAME B80 TURN-O-MATIC TAKE A NUMBER TICKET DISPENSER available at Microframe Corp (https://microframecorp.com/6000-0090-kit-b80-turn-o-matic-take-a-number-ticket-dispenser-floor-kit)");
        System.Console.WriteLine("Please enter a number from 5-8");

        string ticketNumber = Console.ReadLine();
        int number = int.Parse(ticketNumber);
        int almostNumber = (number - 1);

        for (int i = 1; i <= 8; i++)
        {
            System.Console.WriteLine($"Ticket number {i} has been called");

            if (i == almostNumber)
            {
                System.Console.WriteLine("Uh oh! You're stuck in an infinite loop!");
                break;
            }
        }

        PressAnyKeyToContinue();

        for (int a = 1; a <= 8; a++)
        {
            System.Console.WriteLine($"Ticket number {a} has been called");

            if (a == almostNumber)
            {
                System.Console.WriteLine("Uh oh! You're stuck in an infinite loop!");
                break;
            }
        }

        PressAnyKeyToContinue();

        for (int b = 1; b <= number; b++)
        {
            System.Console.WriteLine($"Ticket number {b} has been called");
            if (b == number)
            {
                System.Console.WriteLine("Finally your ticket number has been called!");
            }
        }

        PressAnyKeyToContinue();
        ApproachingTheCounter();
    }

    private void ApproachingTheCounter()
    {
        Console.Clear();

        System.Console.WriteLine("You approach the counter. Choose an item: \n" +
            "1. Driver's License \n" +
            "2. Social Security Card \n" +
            "3. Birth Certificate \n" +
            "4. Arm \n" +
            "5. Leg \n" +
            "6. Credit Card \n");

        var userInput = ReadLine();
        switch (userInput)
        {
            case "1":
                DriversL();
                break;
            case "2":
                SocialS();
                break;
            case "3":
                BirthC();
                break;
            case "4":
                Arm();
                break;
            case "5":
                Leg();
                break;
            case "6":
                CreditC();
                break;
        }
    }

    private void DriversL()
    {

    }

    private void SocialS()
    {

    }

    private void BirthC()
    {

    }

    private void Arm()
    {
        System.Console.WriteLine("The BMV attendant snorts at you and kicks its hoof into the soil beneath its chair…you think it's about to charge and go back to your seat to try again");

        SeatCounter();
    }

    private void Leg()
    {
        System.Console.WriteLine("The BMV attendant snorts at you and kicks its hoof into the soil beneath its chair…you think it's about to charge and go back to your seat to try again");
        
        SeatCounter();
    }

    private void CreditC()
    {
        System.Console.WriteLine("The BMV attendant snorts at you and kicks its hoof into the soil beneath its chair…you think it's about to charge and go back to your seat to try again");

        SeatCounter();
    }


    private void SeatCounter()
    {
        string ticketNumber2 = Console.ReadLine();
        int number2 = int.Parse(ticketNumber2);
        int almostNumber2 = (number2 - 1);

        for (int c = 1; c <= number2; c++)
        {
            System.Console.WriteLine($"Ticket number {c} has been called");
            if (c == number2)
            {
                System.Console.WriteLine("Finally your ticket number has been called!");
            }
        }

        ApproachingTheCounter();
    }

    private void YouLostTheGame()
    {
        System.Console.WriteLine("You lost the game!");
        CloseGame();
    }
}

