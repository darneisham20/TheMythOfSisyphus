    public class Boss : Enemy
    {
        public void AteRandomGhoul()
        {
            IncreaseHealth(20);
            System.Console.WriteLine("${Name} just ate a random ghoul!\n" + $"Its Health is now {HealthPoints}\n");
        }
    }
    