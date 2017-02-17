using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new TreehouseDefense.Map(8, 5);
            try
            {
                Path path = new Path(
                    new []
                    {
                         new MapLocation(0, 2),
                         new MapLocation(1, 2),
                         new MapLocation(2, 2),
                         new MapLocation(3, 2),
                         new MapLocation(4, 2),
                         new MapLocation(5, 2),
                         new MapLocation(6, 2),
                         new MapLocation(7, 2)
                    });
                Invader[] invaders =
                {
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                    new Invader(path)
                };
                Tower[] towers =
                {
                    new Tower(new MapLocation(1, 3)),
                    new Tower(new MapLocation(3, 3)),
                    new Tower(new MapLocation(5, 3))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
