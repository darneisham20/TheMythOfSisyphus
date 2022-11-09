

    public static class GameUtilities
    {
      public static List<InGameItem> InitializePlayersStartupItems()
      {
        //we need to read the InGameItems.txt file
      }

      public static void FoundPistolCartridge(int roundValue, Player player)
      {
        player.LoadPlasmaPistol(roundValue);
      }

      public static void TellTheStory(string storySection)
      {
        System.Console.WriteLine(storySection);
      }

      public static void DisplayFloorChallengeInfo(HauntedHouse _house)
      {
        foreach (var challenge in _house.FloorsInHouse)
        {
           foreach(var floor in _house.FloorsInHouse)
           {}
        }
      }
    }