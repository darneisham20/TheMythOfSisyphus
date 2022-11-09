// To do list: Go through the game and check semantics on wording

using static System.Console;

public class Program_UI
{
    private bool IsRunning = true;
    bool MissionComplete = false;

    public void Run()
    {
        RunApplication();
    }
//*Edited Start Game in-game text
    private void RunApplication()
    {
        while (IsRunning)
        {
            System.Console.WriteLine("Another day, another boulder: Welcome to The Myth of Sisyphus, please make a selection:\n" +
                "1. Enter the Cycle \n" +
                "2. Give Up Now");

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

    // Number 2 Route //* Edited in-game text, added "invalid selection" default to user input.
    private void CopEventStart()
    {
        Console.Clear();
        System.Console.WriteLine("Secure in the notion that you'll enjoy your day off, you begin to imagine all the possibilities, \n" +
                                "Hittin' the links with the boys...  Crackin' open a cold one with the boys... \n" +
                                "Finally figuring out why the boys stopped returning your calls... \n" +
                                "- your eyes glaze over as the world passes around you. You stand in front of your trunk as the sky turns \n" +
                                "from blue to amber, from amber to navy, and back to blue again. all of a sudden, it's tomorrow 9:00am");

        PressAnyKeyToContinue();

        System.Console.WriteLine("It's a beautiful day, you can't wait to go outside and enjoy your day off! Oh sh*t... you're already outside.\n" +
            "1. Be Productive\n");

        var userInput = ReadLine();
        switch (userInput)
        {
            case "1":
                CopEventMiddle();
                break;
            default:
                WriteLine("Invalid Selection");
                    break;
        }
    }
//* Edited in-game text //* added "invalid selection" default
    private void CopEventMiddle()
    {
        System.Console.WriteLine("You get in your car...start the engine and start heading over to the DMV. \n" +
                                "\n" +
                                "WEEWOO WEEWOO! \n" +
                                "\n" +
                                "Your laziness has cost you, and now an interceptor with the state troopers has come to show you the error of your ways. \n" +
                                "You hear the crunch of the heels of his boots on the gravel of the shoulder of the highway as he approaches your driver side window...\n" +
            "1. Quick!!! Equip and use item: Disarming Phrase!\n" +
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
            default:
                WriteLine("Invalid Selection");
                break;
        }
    }

    private void CopEventEndGame()
    {
        System.Console.WriteLine("ARE YOU ATTEMPTING TO BRIBE AN OFFICER OF THE LAW?!?!?!? \n" +
                                "Guess you don't need to renew your plates. The state trooper cuffs you and sends you to jail forever!");

        PressAnyKeyToContinue();
        YouLostTheGame();
    }

    private void RestartOfGame()
    {
        Console.Clear();
        System.Console.WriteLine("The cop writes you a ticket and sends you straight to bed with no dinner.... It's tomorrow at 9:00am.");

        PressAnyKeyToContinue();

        System.Console.WriteLine("It's a beautiful day, you can't wait to go outside and enjoy your day off! Oh sh*t...your tags are expired...\n" +
            "1. Be Productive\n");

        var userInput = ReadLine(); //* Added Invalid Selection default
        switch (userInput)
        {
            case "1":
                HeadToTheDMV();
                break;
            default:
                    WriteLine("Invalid Selection");
                    break;
        }
    }

    // Number 1 Route //* Included story text for the other patrons (four horsemen) - requires player to click through
    private void HeadToTheDMV()
    {
        Console.Clear();

        System.Console.WriteLine("You arrive at the BMV and see four seats already occupied by patrons. \n" + 
                                "You're surprised to see the first guy dressed in all red, and carrying a side arm. Weird - you didn't think they let the public carry swords at the BMV. \n" +
                                "Better walk around him....");

        PressAnyKeyToContinue();
        Console.Clear();

        System.Console.WriteLine("You almost miss the second patron, then you hear their stomach growl un-naturally loud as you pass them. \n" + 
                                "Teenagers man. The whole all-black outfit, malnourished emo look never seems to go away. Not worth skipping breakfast. \n" +
                                "Better keep moving - kid's lookin' at your fingers like you look at hot wings. \n ");

        PressAnyKeyToContinue();
        Console.Clear();

        System.Console.WriteLine( "As you walk past the third patron, you consider complimenting their green ... frock? \n" +
                                "On second thought, you decide to keep walking when you notice the cough and the various oozing orifices. gross. \n" +
                                "Whatever happened to 6 feet....");

        System.Console.WriteLine("6 Feet under? I KNOW RIGHT?!?!  \n" +
                                "Oh you gotta be kidding me - the voice you hear agreeing with you appears to be coming from a cloaked figure carrying a scythe. \n" +
                                "You feel like you recognize these guys from somewhere... better not think too hard about it. You're here for a reason.");

        PressAnyKeyToContinue();
        Console.Clear();
//todo: Finish copy editing and adding invalid defaults to lines 185 - End
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
        Console.Clear();
        ApproachingTheCounter();
    }

    private void ApproachingTheCounter()
    {
        int count = 1;
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
                case "Driver's License":
                    DriversL();
                    if (!isDriverLSelected)
                    {
                        isDriverLSelected = true;
                        count++;
                    }
                    else
                    {
                        System.Console.WriteLine("...but this has already been selected");
                        PressAnyKeyToContinue();
                    }
                    break;
                case "2":
                case "Social Security Card":
                    SocialS();
                    if (!isSocialSSelected)
                    {
                        isSocialSSelected = true;
                        count++;
                    }
                    else
                    {
                        System.Console.WriteLine("...but this has already been selected");
                        PressAnyKeyToContinue();
                    }
                    break;
                case "3":
                case "Birth Certificate":
                    BirthC();
                    if (!isBirthCSelected)
                    {
                        isBirthCSelected = true;
                        count++;
                    }
                    else
                    {
                        System.Console.WriteLine("...but this has already been selected");
                        PressAnyKeyToContinue();
                    }
                    break;
                case "4":
                case "Arm":
                    Arm();
                    break;
                case "5":
                case "Leg":
                    Leg();
                    break;
                case "6":
                case "Credit Card":
                    CreditC();
                    break;
            }
        }
        
        LastScenario();
    }
    private void DriversL()
    {
        System.Console.WriteLine("Thank you for your Driver's License...");
    }

    private void SocialS()
    {
        System.Console.WriteLine("Thank you for your Social Security Card");
    }

    private void BirthC()
    {
        System.Console.WriteLine("Thank you for your Birth Certificate");
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

    private void LastScenario()
    {
        PressAnyKeyToContinue();
        Console.Clear();

        System.Console.WriteLine("As you hand the third item over to the DMV worker, they are joined by a cast of hooded figures who lay the artifacts at three equidistant points...the lights suddenly go dark. Choose a method of sacrifice to seal the oath and cast the incantation:\n" +
            "1. Arm\n" +
            "2. Leg\n" +
            "3. Credit card\n");

        var userInput = ReadLine();
        switch (userInput)
        {
            case "1":
                LastScenarioPart2a();
                break;
            case "2":
                LastScenarioPart2b();
                break;
            case "3":
                LastScenarioPart2c();
                break;
        }
    }

    // Arm
    private void LastScenarioPart2a()
    {
        System.Console.WriteLine("Scoffing, the DMV worker spits at you 'Sir...this is a public property I'm afraid that means I'm going to disarm you'. Before you know what's happening the DMV worker sinks her elongated fangs into you arm, panicking you think to yourself 'I should have stayed home and kept coding...', all of sudden a voice filters through the speaker...\n" +

        "The DMV is now closed... please come back to complete your transaction tomorrow.");

        PressAnyKeyToContinue();
        LastScenarioPart3();
    }

    // Leg
    private void LastScenarioPart2b()
    {
        System.Console.WriteLine("Scoffing, the DMV worker spits at you 'You may think it's a cruel joke the prices we charge to renew your registration, but unfortunately the only kind of leg pulling we're doing is literal'. Before you know what's happening the DMV worker sinks her elongated fangs into you leg, panicking you think to yourself 'I should have stayed home and kept coding...', all of sudden a voice filters through the speaker...\n" +

        "The DMV is now closed... please come back to complete your transaction tomorrow.");

        PressAnyKeyToContinue();
        LastScenarioPart3();
    }

    // Credit Card
    private void LastScenarioPart2c()
    {
        System.Console.WriteLine("As the sacrifice is laid in the center of three equidistant points. Directly before you the eyes of the DMV worker roll to the back of their sockets, the wind starts to scatter papers, and you hear the whispers that soon grow into murmurs that become a hellish chorus. Suddenly, a flickering buzz in your head is broken by a single voice:\n" +

        "The DMV is now closed... please come back to complete your transaction tomorrow.");

        PressAnyKeyToContinue();
        LastScenarioPart3();
    }

    private void LastScenarioPart3()
    {
        Console.Clear();
        System.Console.WriteLine("It's tomorrow at 9:00am...");
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