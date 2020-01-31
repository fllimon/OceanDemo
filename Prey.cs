using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OceanDemoProj.Enum;

namespace OceanDemoProj
{
    class Prey : Cell
    {
        

        #region ======----- PROPERTIES -----=====

        public override char Image 
        {
            get
            {
                return (char)DefaultImage.PreyImage;
            }
        }

        #endregion

        #region =====----- CTOR -----=====

        public Prey(Ocean owner, Coordinate coordinate)
            : base(owner, coordinate)
        {
            
        }

        #endregion

    }
}
