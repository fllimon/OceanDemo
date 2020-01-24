using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanDemoProj
{
    class Ocean //: Cell
    {
        #region ======----- PRIVATE DATA -----=====

        private char _defaultImage;
        private int _numRows = -1;
        private int _numCols = -1;
        private int _numObstacle = -1;
        //private int _size = -1;
        private Cell[,] _cells;


        #endregion

        #region ======------ PROPERTIES ------=======

        public char DefaultImage
        {
            get
            {
                return _defaultImage;
            }

            set
            {
                _defaultImage = value;
            }
        }

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

        public Cell this[int firstIndex, int secondIndex]
        {
            get
            {
                return _cells[firstIndex, secondIndex];
            }

            set
            {
                _cells[firstIndex, secondIndex] = value;
            }
        }

        #endregion

        #region =====----- CTOR -----=====

        public Ocean(char defaultImage = DefaultSettings.DEFAULT_IMAGE,
                int numRows = DefaultSettings.DEFAULT_NUM_ROWS,
                int numCols = DefaultSettings.DEFAULT_NUM_COLS,
                int numObstacle = DefaultSettings.DEFAULT_NUM_OBSTACLE)
        {
            _defaultImage = defaultImage;
            _numRows = numRows;
            _numCols = numCols;
            _numObstacle = numObstacle;
            _cells = new Cell[_numRows, _numCols];
            GetInitCells();
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

        public void AddObstacle(Obstacle obstacle)    
        {
            Coordinate coordinate;

            for (int i = 0; i < obstacle.CountObstacle; i++)
            {
                coordinate = GetCoordEmptyCell();

                _cells[coordinate.X, coordinate.Y] = new Obstacle(this, coordinate);
            }
        }

        public void AddPredator(Predator predator)    
        {
            Coordinate coordinate;
            
            for (int i = 0; i <= predator.NumPredator; i++)
            {
                coordinate = GetCoordEmptyCell();

                _cells[coordinate.X, coordinate.Y] = new Predator(this, coordinate);
                //if (coordinate.X == _defaultImage && coordinate.Y == _defaultImage)
                //{
                //    _defaultImage = predator.DefaultPredatorImages;
                //    Console.Write($"{_defaultImage}");
                //}
            }
        }

        public void AddPrey(Prey prey)    
        {
            Coordinate coordinate;

            for (int i = 0; i < prey.PreyCount; i++)
            {
                coordinate = GetCoordEmptyCell();

                _cells[coordinate.X, coordinate.Y] = new Prey(this, coordinate);
            }
        }

        public void AddSeaweed(Seaweed seaweed)    
        {
            Coordinate coordinate;

            for (int i = 0; i < seaweed.SeaweedCount; i++)
            {
                coordinate = GetCoordEmptyCell();

                _cells[coordinate.X, coordinate.Y] = new Seaweed(this, coordinate);
                
            }
        }

        private void GetInitCells()
        {
            for (int i = 0; i < _cells.GetLength(0); i++)
            {
                Console.Write("\n");

                for (int j = 0; j < _cells.GetLength(1); j++)
                {

                    //Console.Write($"{_defaultImage}");
                }
            }

            Console.Write("\n");
        }
    }
}
