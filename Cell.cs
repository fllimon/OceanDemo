using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanDemoProj
{
    abstract class Cell
    {
        #region =====----- PRIVATE DATA -----=====

        protected readonly Ocean _owner;
        protected Coordinate _coordinate;

        #endregion


        #region =====----- CTOR -----=====

        public Cell(Ocean owner, Coordinate coordinate)
        {
            _coordinate = coordinate;
            _owner = owner;
        }

        public Cell(Ocean owner, int x, int y)
            : this(owner, new Coordinate(x, y))
        {

        }

        #endregion

        #region ======------ PROPERTIES ------======

        public Coordinate Position 
        {
            get
            {
                return new Coordinate(_coordinate);
            }  
        }

        public abstract char Image { get; }

        #endregion

    }
}
