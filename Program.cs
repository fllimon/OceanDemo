using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanDemoProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate coordinate = new Coordinate(0, 0);
            Ocean ocean = new Ocean();
            Predator predator = new Predator(ocean, coordinate);
            Obstacle obstacle = new Obstacle(ocean, coordinate);
            Prey prey = new Prey(ocean, coordinate);
            ocean.AddPredator(predator);
            //ocean.AddObstacle(obstacle);
            //ocean.AddPrey(prey);
            Console.ReadKey();
        }
    }
}
