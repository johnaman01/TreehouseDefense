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
        //AUTOPROPERTY
        public MapLocation Location { get; private set; }
        //constructor
        public Invader(Path path)
        {
            _path = path;
            Location = path.GetLocationAt(_pathStep);
        }
        //how the invader moves down the path
        public void Move()
        {
            _pathStep += 1;
            Location = _path.GetLocationAt(_pathStep);
        }
    }
}
