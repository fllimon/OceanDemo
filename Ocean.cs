using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OceanDemoProj.Enum;
using OceanDemoProj.Interface;

namespace OceanDemoProj
{
    class Ocean : ICellContainer, IOceanView
    {
        #region ======----- PRIVATE DATA -----=====

        private int _numRows = -1;
        private int _numCols = -1;
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
        }

        public int NumCols
        {
            get
            {
                return _numCols;
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
                int timeToReproduce = DefaultSettings.DEFAULT_TIME_TO_REPRODUCE,
                int timeToFeed = DefaultSettings.DEFAULT_TIME_TO_FEED)
        {
            _numRows = numRows;
            _numCols = numCols;
            _timeToReproduce = timeToReproduce;
            _timeToFeed = timeToFeed;
            _cells = new Cell[_numRows, _numCols];
        }

        #endregion

        public bool IsEmptyCell(Coordinate someCordinate)
        {
            return (_cells[someCordinate.X, someCordinate.Y] == null);
        }

        public void Add(Cell someEntity)
        {
            _cells[someEntity.Position.X, someEntity.Position.Y] = someEntity;
        }

        public int GetDeltaX(Ocean ocean, Cell someEntity)
        {
            return ocean.NumRows - someEntity.Position.X;
        }

        public int GetDeltaY(Ocean ocean, Cell someEntity)
        {
            return ocean.NumCols - someEntity.Position.Y;
        }

        public void SetPositionXY(Cell someEntity, ref int positionXY, string operation)
        {
            switch (operation)
            {
                case "+=":
                    if (someEntity.MoveSpeed == 1)
                    {
                        positionXY += someEntity.MoveSpeed;
                    }
                    else
                    {
                        positionXY += someEntity.MoveSpeed - 1;
                    }
                    break;
                case "-=":
                    if (someEntity.MoveSpeed == 1)
                    {
                        positionXY -= someEntity.MoveSpeed;
                    }
                    else
                    {
                        positionXY -= someEntity.MoveSpeed - 1;
                    }
                    break;
                default:
                    break;
            }
        }

        public void GetRandomDirection(ref RandomDirection randomDirection)
        {
            int someDiraction = Randomyzer.rndAction.Next(0, 3);

            switch (someDiraction)
            {
                case 0:
                    randomDirection = RandomDirection.Left;
                    break;
                case 1:
                    randomDirection = RandomDirection.Up;
                    break;
                case 2:
                    randomDirection = RandomDirection.Right;
                    break;
                case 3:
                    randomDirection = RandomDirection.Down;
                    break;
            }
        }
    }
}
