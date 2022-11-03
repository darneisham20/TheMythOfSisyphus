public class Player
{

    public Player()
    {
        SetupPlayerInitialization();
    }

    // If we want the user to have a name!
    // public Player(string name)
    // {
    //     Name = name;
    //     SetupPlayerInitialization();
    // }

    public int ID { get; set; }
    public string Name { get; set; }
    public List<InGameItem> Items;

    private InGameItem DriversLicense;
    private InGameItem SocialSecurityCard;
    private InGameItem BirthCertificate;
    private InGameItem Arm;
    private InGameItem Leg;
    private InGameItem CreditCard;
    private InGameItem DisarmingPhrase;

    private void SetupPlayerInitialization()
    {
        Items = GameUtilities.InitializePlayerStartupItems();
        DriversLicense = Items[0];
        SocialSecurityCard = Items[1];
        BirthCertificate = Items[2];
        Arm = Items[3];
        Leg = Items[4];
        CreditCard = Items[5];
        DisarmingPhrase = Items[6];
    }
}
