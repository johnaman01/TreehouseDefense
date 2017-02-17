using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Invader
    {
        //initialize fields before constructor is called
        private readonly Path _path;
        private int _pathStep = 0;
        
        //AUTOPROPERTY...changed to computed property => sugar
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        public int Health { get; private set; } = 2;

        //true if the invader has scored (reached the end of the path)
        //use computed property
        public bool HasScored => _pathStep >= _path.Length; 

        //true if the invader has been neutralized (health reduced to 0)
        public bool IsNeutralized
        {
            get
            {
                return Health <= 0;
            }
        }
        public bool IsActive
        {
            get
            {
                return !IsNeutralized;
            }
        }
        //constructor
        public Invader(Path path)
        {
            _path = path;        
        }
        
        //how the invader moves down the path
        public void Move()
        {
            _pathStep += 1;      
        }
        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
    }
}
