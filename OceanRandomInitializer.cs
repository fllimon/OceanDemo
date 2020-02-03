using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanDemoProj
{
    class OceanRandomInitializer
    {
        #region =====----- PRIVATE DATA -----=====

        private readonly Ocean _ocean = null;
        private readonly int _numPrey = -1;
        private readonly int _numPredator = -1;
        private readonly int _numObstacle = -1;

        #endregion

        #region =====----- CTOR -----======

        public OceanRandomInitializer(Ocean ocean, int numPrey = DefaultSettings.DEFAULT_NUM_PREY, 
                int numPredator = DefaultSettings.DEFAULT_NUM_PREDATORS,
                int numObstacle = DefaultSettings.DEFAULT_NUM_OBSTACLE)
        {
            _ocean = ocean;
            _numPrey = numPrey;
            _numPredator = numPredator;
            _numObstacle = numObstacle;
        }

        #endregion

        #region =====----- PROPERTIES -----=====

        public int NumPrey 
        {
            get
            {
                return _numPrey;
            } 
        }

        public int NumPredator
        {
            get
            {
                return _numPredator;
            }
        }

        public int NumObstacle
        {
            get
            {
                return _numObstacle;
            }
        }

        #endregion

        

        public Coordinate GetCoordEmptyCell()
        {
            Coordinate coordinate = null;
            Randomyzer random = Randomyzer.GetInstance();

            do
            {
                coordinate = random.GetRandomCoordinate(_ocean.NumRows, _ocean.NumCols);
            } while (!_ocean.IsEmptyCell(coordinate));

            return coordinate;
        }

        public void AddPrey()
        {
            for (int i = 0; i < _numObstacle; i++)
            {
                Coordinate someCordinate = GetCoordEmptyCell();

                _ocean.Add(new Prey(_ocean, someCordinate));
            }
        }

        public void AddPredator()
        {
            for (int i = 0; i < _numObstacle; i++)
            {
                Coordinate someCordinate = GetCoordEmptyCell();

                _ocean.Add(new Predator(_ocean, someCordinate));
            }
        }

        public void AddObstacle()
        {
            for (int i = 0; i < _numObstacle; i++)
            {
                Coordinate someCordinate = GetCoordEmptyCell();

                _ocean.Add(new Obstacle(_ocean, someCordinate));
            }
        }

        public void Run()
        {
            AddPrey();
            AddPredator();
            AddObstacle();
        }
    }
}
