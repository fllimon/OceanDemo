using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanDemoProj
{
    class Obstacle : Cell
    {
        #region ======----- PRIVATE DATA -----=====

        private int _defaultNumObstacle = -1;
        private int _countObstacle;
        private char _defaultObstacleImage;

        #endregion

        #region =====----- PROPERTIES -----======

        public char DefaultObstacleImage
        {
            get
            {
                return _defaultObstacleImage;
            }

            set
            {
                _defaultObstacleImage = value;
            }
        }

        public int NumObstacle 
        {
            get
            {
                return _defaultNumObstacle;
            }

            set
            {
                _defaultNumObstacle = value;
            }
        }

        public int CountObstacle
        {
            get
            {
                return _countObstacle;
            }

            set
            {
                _countObstacle = value;
            }
        }

        #endregion

        #region ======------ CTOR -----=====

        public Obstacle(Ocean owner, Coordinate coordinate)
            : base(owner, coordinate)
        {
            _defaultObstacleImage = DefaultSettings.DEFAULT_OBSTACLE_IMAGE;
            _defaultNumObstacle = DefaultSettings.DEFAULT_NUM_OBSTACLE;
            _countObstacle = _defaultNumObstacle;
        }

        #endregion

    }
}
