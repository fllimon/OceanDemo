using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OceanDemoProj.Enum;

namespace OceanDemoProj
{
    class Ocean
    {
        #region ======----- PRIVATE DATA -----=====

        private int _numRows = -1;
        private int _numCols = -1;
        private int _numPrey = -1;
        private int _numPredator = -1;
        private int _numObstacle = -1;
        private int _timeToReproduce = -1;
        private int _timeToFeed = -1;
        //private int _size = -1;
        private Cell[,] _cells;

        #endregion

        #region ======------ PROPERTIES ------=======

        public int NumRows
        {
            get
            {
                return _numRows;
            }

            set
            {
                _numRows = value;
            }
        }

        public int NumCols
        {
            get
            {
                return _numCols;
            }

            set
            {
                _numCols = value;
            }
        }

        public int NumPrey
        {
            get
            {
                return _numPrey;
            }

            set
            {
                _numPrey = value;
            }
        }

        public int NumPredator
        {
            get
            {
                return _numPredator;
            }

            set
            {
                _numPredator = value;
            }
        }

        public int NumObstacle
        {
            get
            {
                return _numObstacle;
            }

            set
            {
                _numObstacle = value;
            }
        }

        #endregion

        #region =====----- INDEXER -----=====

        public char this[int firstIndex, int secondIndex]
        {
            get
            {
                char img = (char)DefaultImage.NoImage;

                if (_cells[firstIndex, secondIndex] != null)
                {
                    img = _cells[firstIndex, secondIndex].Image;
                }

                return img;
            }

        }

        #endregion

        #region =====----- CTOR -----=====

        public Ocean(int numRows = DefaultSettings.DEFAULT_NUM_ROWS,
                int numCols = DefaultSettings.DEFAULT_NUM_COLS,
                int numPrey = DefaultSettings.DEFAULT_NUM_PREY,
                int numPredator = DefaultSettings.DEFAULT_NUM_PREDATORS,
                int numObstacle = DefaultSettings.DEFAULT_NUM_OBSTACLE,
                int timeToReproduce = DefaultSettings.DEFAULT_TIME_TO_REPRODUCE,
                int timeToFeed = DefaultSettings.DEFAULT_TIME_TO_FEED)
        {
            _numRows = numRows;
            _numCols = numCols;
            _numPrey = numPrey;
            _numPredator = numPredator;
            _numObstacle = numObstacle;
            _timeToReproduce = timeToReproduce;
            _timeToFeed = timeToFeed;
            _cells = new Cell[_numRows, _numCols];
        }

        #endregion

        public Coordinate GetCoordEmptyCell()
        {
            Coordinate coordinate = null;
            Randomyzer random = Randomyzer.GetInstance();

            do
            {
                coordinate = random.GetRandomCoordinate(_numRows, _numCols);

                break;
            } while (_cells[coordinate.X, coordinate.Y] == null);

            return coordinate;
        }

        public void AddObstacle()
        {
            Coordinate coordinate;

            for (int i = 0; i < _numObstacle; i++)
            {
                coordinate = GetCoordEmptyCell();

                _cells[coordinate.X, coordinate.Y] = new Obstacle(this, coordinate);
            }
        }

        public void AddPredator()
        {
            Coordinate coordinate;

            for (int i = 0; i < _numPredator; i++)
            {
                coordinate = GetCoordEmptyCell();

                _cells[coordinate.X, coordinate.Y] = new Predator(this, coordinate);
            }
        }

        public void AddPrey()
        {
            Coordinate coordinate;

            for (int i = 0; i < _numPrey; i++)
            {
                coordinate = GetCoordEmptyCell();

                _cells[coordinate.X, coordinate.Y] = new Prey(this, coordinate);
            }
        }

        public void Run()
        {
            AddPrey();
            AddPredator();
            AddObstacle();
        }

        //public void AddSeaweed(Seaweed seaweed)    
        //{
        //    Coordinate coordinate;

        //    for (int i = 0; i < seaweed.SeaweedCount; i++)
        //    {
        //        coordinate = GetCoordEmptyCell();

        //        _cells[coordinate.X, coordinate.Y] = new Seaweed(this, coordinate);

        //    }
        //}

    }
}
