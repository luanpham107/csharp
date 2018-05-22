using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ExploreTheHouse
{
    class Opponent
    {
        private Location myLocation;
        private Random random;

        public Opponent(Location startLocation, Random random)
        {
            myLocation = startLocation;
            this.random = random;
        }

        public void Move()
        {
            if(myLocation is IHasExteriorDoor)
            {
                int i = random.Next(2);
                if(myLocation.Exits.Length == 1)
                {
                    myLocation = myLocation.Exits[0];
                }
                else if(myLocation.Exits.Length > 1)
                {
                    myLocation = myLocation.Exits[i];
                }

            }

        }

        public bool check(Location GuessLocation)
        {
            if (GuessLocation.Name == myLocation.Name)
                return true;
            else
                return false;
        }


    }
}
