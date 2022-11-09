
    public class Program_UI
    {
        public readonly HauntedHouseRepository _hHauntedHouseRepository _hHouseRepo = new HauntedHouseRepository(  );
        private HauntedHouse _house;
        private bool IsRunning = true;
        public bool _hasMiddleRoomkey;
        public bool _hasPuzzlePiecel

        public Program_UI()
        {
            SeedData();
            _house = _hHauntedHouseRepository.GetHauntedHouse();
        }
        public void Run() 
        {
            RunApplication();
        }

        public void RunApplication()
        {
            System.Console.WriteLine("Welcome to the Haunted House, Please make a selection:\n" +
            "1. Start Game"+
            "2. End Game");

            var useInput = ReadLine();
            switch (userInput)
            {
                case "1":
                StartGame();
                break;
                case "2":
                IsRunning = ClosedGame();
                default;
                    WriteLine("Invaliud Selection");
                    break;
            }
        }

        private bool ClosedGame()
        {
            System.Console.WriteLine("Thanks for Playing!");
            PressAnyKeyToContinue();
        }

        private void PressAnyKeyToContinue()
        {
            WriteLine("Press any key to continue...");
            ReadKey();
        }
        private void StartGame()
        {
             private void StartGame()
    {
        Clear();
        while (!_house.Player.IsDead && IsRunning)
        {
            GameUtilities.TellTheStory($"You are a Paranormal Investigator,\nand you have been ordered to enter a haunted house on {_house.Address}\n" +
                                                   $"You notice... Press any Key To Continue...");
            ReadKey();
            while (_hasMiddleRoomkey == false)
            {
                LoadFirstChallenge();
            }

            GameUtilities.TellTheStory("You use the key to open the Middle Room Door!");

            GameUtilities.TellTheStory("You go up the stairs, your on the Next Floor!");

            while (_hasPuzzlePiece == false)
            {
                LoadSecondChallenge();
            }

            LoadFinalChallenge();

            ReadKey();
        }

        if (_house.Player.IsDead)
        {
            IsRunning = CloseGame();
        }

    }
