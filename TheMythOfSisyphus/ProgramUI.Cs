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
            switch (userInput) {
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
        Clear();

    }





}