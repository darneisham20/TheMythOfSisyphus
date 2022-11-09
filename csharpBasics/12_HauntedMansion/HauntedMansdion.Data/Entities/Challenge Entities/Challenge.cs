
    public abstract class Challenge
    {
        public int ID {get; set;}
        public string ChallengeDescription { get; set; }

        public list<string> ChallengeTasks { get; set; }    = new List<string>();

        public bool isComplete
        { 
            get
            {
                return(ChallengeTasks.Count() <=0) ? true : false;
            }; 
        }
    }