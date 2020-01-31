using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanDemoProj
{
    class Coordinate
    {
        #region =====----- PRIVATE DATA -----=====

        private int _x;
        private int _y;

        #endregion

        #region ====---- PROPERTIES -----====

        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        #endregion

        #region =====----- CTOR -----=====

        public Coordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Coordinate(Coordinate source)    // ctor of copy
            : this(source._x, source._y)   
        {

        }

        #endregion
    }
}
