using static System.Console;

public class Program_UI
{

    private bool IsRunning = true;
    bool MissionComplete = false;
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


    // DOES NOT WORK
    private void ApproachingTheCounter()
    {
        bool driversLTurnedIn = false;
        bool socialSTurnedIn = false;
        bool birthCTurnedIn = false;
        int count = 0;
        bool isDriverLSelected = false;
        bool isSocialSSelected = false;
        bool isBirthCSelected = false;


        while (count <= 3)
        {
            System.Console.WriteLine("You approach the counter. Choose an item: \n" +
            "1. Driver's License \n" +
            "2. Social Security Card \n" +
            "3. Birth Certificate \n" +
            "4. Arm \n" +
            "5. Leg \n" +
            "6. Credit Card");

            var userInput = ReadLine();
            switch (userInput)
            {
                case "1":
                    DriversL();
                    if (!isDriverLSelected)
                    {
                        isDriverLSelected = true;
                        count++;
                    }
                    else
                    {
                        System.Console.WriteLine("Sorry this is already selected");
                    }
                    break;
                case "2":
                    SocialS();
                    if (!isSocialSSelected)
                    {
                        isSocialSSelected = true;
                        count++;
                    }
                    else
                    {
                        System.Console.WriteLine("Sorry this is already selected");
                    }
                    break;
                case "3":
                    BirthC();
                    if (!isBirthCSelected)
                    {
                        isBirthCSelected = true;
                        count++;
                    }
                    else
                    {
                        System.Console.WriteLine("Sorry this is already selected");
                    }
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

        LastScenario();
    }
    private void DriversL()
    {
        System.Console.WriteLine("Thank you for your Driver's License...");
        bool driversLTurnedIn = true;
    }

    private void SocialS()
    {
        System.Console.WriteLine("Thank you for your Social Security Card");
        bool socialSTurnedIn = true;
    }

    private void BirthC()
    {
        System.Console.WriteLine("Thank you for your Birth Certificate");
        bool birthCTurnedIn = true;
    }


    private void Arm()
    {
        System.Console.WriteLine("The BMV attendant snorts at you and kicks its hoof into the soil beneath its chair ... you think it's about to charge so you go back to your seat to try and wait for your number to be called again before approaching the counter once more...");

        PressAnyKeyToContinue();

        ApproachingTheCounter();
    }

    private void Leg()
    {
        System.Console.WriteLine("The BMV attendant snorts at you and kicks its hoof into the soil beneath its chair ... you think it's about to charge so you go back to your seat to try and wait for your number to be called again before approaching the counter once more...");

        PressAnyKeyToContinue();

        ApproachingTheCounter();
    }


    private void CreditC()
    {
        System.Console.WriteLine("The BMV attendant snorts at you and kicks its hoof into the soil beneath its chair ... you think it's about to charge so you go back to your seat to try and wait for your number to be called again before approaching the counter once more...");

        PressAnyKeyToContinue();

        ApproachingTheCounter();
    }

    // Start of not being broken
    private void LastScenario()
    {
        Console.Clear();
        System.Console.WriteLine("As you hand the third item over to the DMV worker, they are joined by a cast of hooded figures who lay the artifacts at three equidistant points...the lights suddenly go dark. Choose a method of sacrifice to seal the oath and cast the incantation:\n" +
            "1. Arm\n" +
            "2. Leg\n" +
            "3. Credit card\n");

        var userInput = ReadLine();
        switch (userInput)
        {
            case "1":
                LastScenarioPart2();
                break;
            case "2":
                LastScenarioPart2();
                break;
            case "3":
                LastScenarioPart2();
                break;
        }
    }

    private void LastScenarioPart2()
    {
        System.Console.WriteLine("As the sacrifice is laid in the center of three equidistant points. Directly before you the eyes of the DMV worker roll to the back of their sockets, the wind starts to scatter papers, and you hear the whispers that soon grow into murmurs that become a hellish chorus. Suddenly, a flickering buzz in your head is broken by a single voice:\n" +
        "The DMV is now closed, all nevers higher than ... please come back to complete your transaction tomorrow.");

        PressAnyKeyToContinue();

        LastScenarioPart3();
    }

    private void LastScenarioPart3()
    {
        Console.Clear();
        System.Console.WriteLine("It's tomorrow at 9:00am...");

        PressAnyKeyToContinue();

        YouWonTheGame();
    }

    private void YouWonTheGame()
    {
        System.Console.WriteLine("Where we came forth, and once saw the stars - Dante's Inferno");

        CloseGame();
    }


    private void YouLostTheGame()
    {
        System.Console.WriteLine("You lost the game!");
        CloseGame();
    }
}

