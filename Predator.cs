using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OceanDemoProj.Enum;

namespace OceanDemoProj
{
    class Predator : Prey
    {
        #region =====----- PROPERTIES -----=====

        public override char Image
        {
            get
            {
                return (char)DefaultImage.PredatorImage;
            }
        }

        #endregion

        public Predator(Ocean owner, Coordinate coordinate)
            : base(owner, coordinate)
        {
            
        }

        /// <summary>
        /// Жизненный цикл
        /// </summary>
        /// <param name="prey">Еда для Predators</param>
        //public void GetLiveLoop(Prey prey)
        //{
        //    int avaliableFood = prey.PreyCount;
        //    int needFood = PredatorsCount * _needFood;

        //    if (needFood > avaliableFood)
        //    {
        //        int fishIsFull = Convert.ToInt32(avaliableFood / _needFood);
        //        PredatorsCount = fishIsFull;    // Тот кто не есть тот не живет

        //        prey.NumPrey = 0;
        //    }
        //    else
        //    {
        //        PredatorsCount = Convert.ToInt32(PredatorsCount * (1 + _timeToFeed));

        //        prey.PreyCount = prey.PreyCount - needFood;    //Predators поели - остатки пищи.
        //    }

        //}

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
