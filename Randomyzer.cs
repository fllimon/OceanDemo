using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanDemoProj
{
    class Randomyzer
    {
        public static Random rndAction = new Random();

        #region =====----- PRIVATE DATA -----=====

        private Random _random;
        private static Randomyzer _instance = null;

        #endregion

        #region =====----- CTOR -----=====

        private Randomyzer()
        {
            _random = new Random();
        }

        #endregion

        public Coordinate GetRandomCoordinate(int numRows, int numCols)
        {
            int x = _random.Next(0, numRows);
            int y = _random.Next(0, numCols);

            return new Coordinate(x, y);
        }

        public static Randomyzer GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Randomyzer();
            }

            return _instance;
        }
    }
}
