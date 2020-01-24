using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanDemoProj
{
    class Prey : Predator
    {
        #region =====----- PRIVATE DATA -----=====

        private int _numPrey = -1;
        private char _defaultPreyImage;
        private int _timeToReproduce = -1;
        private int _preyCount;

        #endregion

        #region ======----- PROPERTIES -----=====

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

        public char DefaultPreyImage
        {
            get
            {
                return _defaultPreyImage;
            }

            set
            {
                _defaultPreyImage = value;
            }
        }

        public int TimeToReproduce
        {
            get
            {
                return _timeToReproduce;
            }

            set
            {
                _timeToReproduce = value;
            }
        }

        public int PreyCount
        {
            get
            {
                return _preyCount;
            }

            set
            {
                _preyCount = value;
            }
        }

        #endregion

        #region =====----- CTOR -----=====

        public Prey(Ocean owner, Coordinate coordinate)
            : base(owner, coordinate)
        {
            _numPrey = DefaultSettings.DEFAULT_NUM_PREY;
            _defaultPreyImage = DefaultSettings.DEFAULT_PREY_IMAGE;
            _timeToReproduce = DefaultSettings.DEFAULT_TIME_TO_REPRODUCE;
            _preyCount = _numPrey;
        }

        #endregion

        public override void Move()
        {
            base.Move();
        }

        public void GetLiveLoop(Seaweed seaweed)
        {
            double avaliableFood = seaweed.SeaweedCount;
            double needFood = _preyCount * NeedFood;

            if (NeedFood > avaliableFood)
            {
                int countPreyFood = Convert.ToInt32(avaliableFood / NeedFood);
                _preyCount = countPreyFood;

                seaweed.SeaweedCount = 0;
            }
            else
            {
                _preyCount = Convert.ToInt32(_preyCount * (1 + TimeToFeed));

                seaweed.SeaweedCount = seaweed.SeaweedCount - needFood;
            }
        }
    }
}
