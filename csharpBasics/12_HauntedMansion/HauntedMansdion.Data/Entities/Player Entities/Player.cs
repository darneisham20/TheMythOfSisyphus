using System.Reflection.Metadata.Ecma335;
using System.Dynamic;

    public class Player
    {
        //properties
        //unique Identifies
        public int 10 (get;set;)

        public int HealthPoints (get; set;) = 100
        public bool IsDead
        (
            get
            (
                return (HealthPoints <= 0) ? true : false;
            
            )
        )
        public List <InGameItem>

    }

    private InGameItem PlasmePistol;
    private InGameItem FlashLight;
    private InGameItem Map;
    private InGameItem Knife;
    public void ShootPlasmaPistol(Enemy enemy, int attackpower = 15)
    {
        if(ShootPlasmaPistol.IsUsable)
        {
            ShootPlasmaPistol.TimesCanBeUsed --;
            System.Console.WriteLine($"You shot the Plasma Pistol at {enemy.Name}!\n" +
            $"YOu ghave {PlasmaPistol.TimesCanBeUsed} bullets left!");
            if (enemy.HealthPoints >= 0)
            {
                enemy.DecreaseHealth(attackPower);
            }
            else
            {
                System.Console.WriteLine("Shoot! I better find some bullets!");
            }
        }

        public void LoadPlasmaPistol(int roundValue){
            PlasmePistol.TimesCanBeUsed += roundValue;
        }
    }

