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
        
    }

    private void RestartOfGame()
    {

    }

    private void HeadToTheDMV()
    {

    }

}