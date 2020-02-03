using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OceanDemoProj.Interface;

namespace OceanDemoProj
{
    class OceanConsoleViwer
    {
        #region ======------ PRIVATE DATA -----======

        private readonly IOceanView _ocean;

        #endregion

        #region ======------ CTOR ------======

        public OceanConsoleViwer(Ocean ocean)
        {
            _ocean = ocean;
        }

        #endregion

        public void Show()
        {
            for (int i = 0; i < _ocean.NumRows; i++)
            {
                Console.Write("\n");

                for (int j = 0; j < _ocean.NumCols; j++)
                {
                    Console.Write($"{_ocean[i,j]}");
                }
            }

            Console.Write("\n");
        }
    }
}
