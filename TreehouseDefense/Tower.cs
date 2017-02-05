using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Tower
    {
        private readonly MapLocation _location;
        public Tower (MapLocation location)
        {
            MapLocation _location = location; 
        }

        //method to fire at invaders
        public void FireAtInvaders (Invader[] invaders)
        {
            for (int index = 0; index < invaders.Length; index++)
            {
                Invader invader = invaders[index];
            }
        }
    }
}
