using System.Collections.Generic;

    public class HauntedHouseRepository
    {
        
        private readonly FloorsRepository _hHouseFloorRepo = new FloorsRepository();
        private readonly List<HauntedHouse> _hHouseDb = new List<HauntedHouse>( );

        public int _count;

        public bool AddHauntedHouse(HauntedHouse house) 
        { 
            if(house is null)
            {
                return false;
            }
            else
            {
                _count++;
                house.ID = _count;
                _hHouseDb.Add(house);
                return true;
            }
    }

    public List<HauntedHouse> GetHauntedHouses()
    {
        return _hHauseDb;
    }

    public HauntedHouse GetHauntedHouse()
    {
        return _hHouseDb.FirstOrDefault();
    }

    public bool HasCompletedGame(List<Floor> rooms)
    {
        if(rooms.Count ==0)
        {
            return true;

        }
        return false;
    }

    public void SeedData()
    {
        var hauntedHouse = new HauntedHouse();
        hauntedHouse.FloorsInHouse
    }