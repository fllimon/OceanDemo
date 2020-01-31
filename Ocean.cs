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

       
    }
}
