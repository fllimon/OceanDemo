using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanDemoProj
{
    class Predator : Cell
    {
        #region =====----- PRIVATE DATA -----=====

        private char _defaultPredatorImage;
        private int _timeToFeed = -1;
        private int _needFood = -1;
        private int _numPredators = -1;
        private int _predatorsCount = -1;

        #endregion

        #region =====----- PROPERTIES -----=====

        public int NumPredator
        {
            get
            {
                return _numPredators;
            }

            set
            {
                _numPredators = value;
            }
        }

        public char DefaultPredatorImages
        {
            get
            {
                return _defaultPredatorImage;
            }

            set
            {
                _defaultPredatorImage = value;
            }
        }

        public int PredatorsCount
        {
            get
            {
                return _predatorsCount;
            }

            set
            {
                _predatorsCount = value;
            }
        }

        public int TimeToFeed
        {
            get
            {
                return _timeToFeed;
            }

            set
            {
                _timeToFeed = value;
            }
        }

        public int NeedFood
        {
            get
            {
                return _needFood;
            }

            set
            {
                _needFood = value;
            }
        }

        #endregion

        public Predator(Ocean owner, Coordinate coordinate)
            : base(owner, coordinate)
        {
            _defaultPredatorImage = DefaultSettings.DEFAULT_PREDATOR_IMAGE;
            _timeToFeed = DefaultSettings.DEFAULT_TIME_TO_FEED;
            _needFood = DefaultSettings.DEFAULT_NEED_FOOD;
            _numPredators = DefaultSettings.DEFAULT_NUM_PREDATORS;
            _predatorsCount = _numPredators;
        }

        /// <summary>
        /// Жизненный цикл
        /// </summary>
        /// <param name="prey">Еда для Predators</param>
        public void GetLiveLoop(Prey prey)
        {
            int avaliableFood = prey.PreyCount;
            int needFood = PredatorsCount * _needFood;

            if (needFood > avaliableFood)
            {
                int fishIsFull = Convert.ToInt32(avaliableFood / _needFood);
                PredatorsCount = fishIsFull;    // Тот кто не есть тот не живет

                prey.NumPrey = 0;
            }
            else
            {
                PredatorsCount = Convert.ToInt32(PredatorsCount * (1 + _timeToFeed));

                prey.PreyCount = prey.PreyCount - needFood;    //Predators поели - остатки пищи.
            }

        }

        public virtual void Move()
        {
            for (int i = 0; i < DefaultSettings.DEFAULT_MAX_ITERATION; i++)
            {
                Coordinate coordinate = null;
                
                if ((coordinate.X >= DefaultSettings.DEFAULT_NUM_COLS) && (coordinate.Y >= DefaultSettings.DEFAULT_NUM_COLS) &&
                        (coordinate.X >= DefaultSettings.DEFAULT_NUM_ROWS) && (coordinate.Y >= DefaultSettings.DEFAULT_NUM_ROWS) )
                {
                    
                }
            }
        }
 
    }
}
