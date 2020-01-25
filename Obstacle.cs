using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OceanDemoProj.Enum;

namespace OceanDemoProj
{
    class Obstacle : Cell
    {
        #region =====----- PROPERTIES -----======

        public override char Image
        {
            get
            {
                return (char)DefaultImage.ObstacleImage;
            }
        }

        #endregion

        #region ======------ CTOR -----=====

        public Obstacle(Ocean owner, Coordinate coordinate)
            : base(owner, coordinate)
        {
            
        }

        #endregion

    }
}
