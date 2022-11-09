
    public class BossRepository
    {
        //Fake Database
        public List<Boss> _hHouseBassDb { get; set;} = new List<Boss>();
        //This helps with auto-incrementing the ID for the Boss obj
        public int _Count { get; set; }=0;
        public BossRepository()
        {
            SeedBoss();
        }

        //C.U.R.D.
        public bool AddBoss(Boss boss)
        {
            return (boss is null)? false : SaveToDatabass(boss);
        }

        public bool SaveToDatabase(Boss boss)
        {
            return (boss is null) ? false : SaveToDatabaser(boss);
        }
        private bool SaveToDatabase(Boss boss)
        {
            AssignId(boss);
            _hHouseBossDb.Add(boss);
            return true;
        }

        private void AssignId(Boss boss)
        {
            _count++;
            boss.ID = _count;
        }

        public Boss GetBoss()
        {
            return _hHouseBassDb.FirstOrDefault();
        }
        public Boss GetBoss()
        {
            ingleOrDefault(x=> x.Id)
        }
        public void SeedBoss()
        {
            var boss = new Boss
            {
                ID=1,
                Name = "Demon with Pins in his head"
            };

            _hHouseBassDb.Add(boss);
        }
    }
