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
            Ocean oceanFirst = new Ocean();
            OceanRandomInitializer oceanRandomInitializer = new OceanRandomInitializer(oceanFirst);
            OceanConsoleViwer viewEntity = new OceanConsoleViwer(oceanFirst);
            Predator predator = new Predator(oceanFirst, coordinate);
            Obstacle obstacle = new Obstacle(oceanFirst, coordinate);
            Prey prey = new Prey(oceanFirst, coordinate);

            oceanRandomInitializer.Run();
            viewEntity.Show();
           

            Console.ReadKey();
        }
    }
}
