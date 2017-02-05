using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace = where it was learned
namespace TreehouseDefense
{
    class CheetSheet
    {
        //Accessor Method
        private MapLocation _location;
        public MapLocation GetLocation()
        {
            return _location;
        }
        public void SetLocation(MapLocation value)
        {
            _location = value
        }
        //cf. AutoProperty
        public MapLocation Location { get; set; }

        //Computed Property
        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }
        //cf. Sugar
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        //Method
        public void Move()
        {
            _pathStep += 1;
        }
        //cf. Sugar
        public void Move() => _pathStep += 1;

        //While Loop
        //A method needs to iterate through the array invaders
        public void FireAtInvaders(Invader[] invaders)
        {
            int index = 0;
            while (index < invaders.Length)
            {
                Invader invader = invaders[index];
                //do stuff with each invader...invaderOne = invaders[0], invaderTwo = invaders[1], etc.
                index++;
            }
            //cf. For Loop
            for (index = 0; index < invaders.Length; index++)
            {
                Invader invader = invaders[index];
            }
        }
    }
}
