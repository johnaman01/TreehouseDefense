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
               
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
