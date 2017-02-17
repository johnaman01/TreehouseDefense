using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        //A static member (field)
        private static readonly Random _random = new Random();

        private readonly MapLocation _location;
        public Tower (MapLocation location)
        {
            MapLocation _location = location; 
        }

        //method to fire at invaders
        public void FireAtInvaders (Invader[] invaders)
        {
            for (int i = 0; i < invaders.Length; i++)
            {
                Invader invader = invaders[i];
            }

            foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, 1))
                {
                    invader.DecreaseHealth(1);
                    break;
                }
            }        
        }
    }
}
