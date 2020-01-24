using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanDemoProj
{
    class DefaultSettings
    {
        public const int DEFAULT_NUM_ROWS = 40;
        public const int DEFAULT_NUM_COLS = 100;
        public const int DEFAULT_NUM_PREY = 150;
        public const int DEFAULT_NUM_PREDATORS = 20;
        public const int DEFAULT_NUM_SEAWEED = 100;
        public const int DEFAULT_NUM_OBSTACLE = 75;
        public const int DEFAULT_MAX_ITERATION = 3000;
        public const int DEFAULT_TIME_TO_FEED = 6;
        public const int DEFAULT_NEED_FOOD = 3;
        public const int DEFAULT_TIME_TO_REPRODUCE = 6;
        public const int DEFAULT_COUNT_ON_AREA = 50;
        public const int DEFAULT_GROWTH_SPEED = 3;
        public const int DEFAULT_RND_ACTION = 4;
        public const int DEFAULT_COORD_X = 1;
        public const int DEFAULT_COORD_Y = 1;

        public const char DEFAULT_IMAGE = '■';
        public const char DEFAULT_OBSTACLE_IMAGE = '#';
        //public const char DEFAULT_BORDER_IMAGE = '▬';
        public const char DEFAULT_PREY_IMAGE = 'f';
        public const char DEFAULT_PREDATOR_IMAGE = 'S';
    }
}
