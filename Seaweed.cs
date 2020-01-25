using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanDemoProj
{
    class Seaweed //: Prey
    {
        #region =====----- PRIVATE DATA -----===== 

        private int _numSeaweed = -1;
        private int _growthSpeed = -1;
        private double _countOnOceanArea = -1;
        private double _seaweedCount;

        #endregion

        #region =====----- PROPERTIES -----=====

        public int NumSeaweed
        {
            get
            {
                return _numSeaweed;
            }

            set
            {
                _numSeaweed = value;
            }
        }

        public double CountOnOceanArea
        {
            get
            {
                return _countOnOceanArea;
            }

            set
            {
                _countOnOceanArea = value;
            }
        }

        public int GrowthSpeed
        {
            get
            {
                return _growthSpeed;
            }

            set
            {
                _growthSpeed = value;
            }
        }

        public double SeaweedCount
        {
            get
            {
                return _seaweedCount;
            }

            set
            {
                _seaweedCount = value;
            }
        }

        #endregion

        #region =====----- CTOR ----=====

        public Seaweed(Ocean owner, Coordinate coordinate)
            //: base(owner, coordinate)
        {
            _numSeaweed = DefaultSettings.DEFAULT_NUM_SEAWEED;
            _growthSpeed = DefaultSettings.DEFAULT_GROWTH_SPEED;
            _countOnOceanArea = _numSeaweed;
            _seaweedCount = _numSeaweed;
        }

        #endregion

        public void GetGrow(int avaliableArea)
        {
            double totalCount = _seaweedCount + _growthSpeed;
            double totalArea = totalCount / _countOnOceanArea;

            if (totalArea > avaliableArea)
            {
                totalArea = avaliableArea;
            }
            _seaweedCount = totalArea * _countOnOceanArea;
        }
    }
}
