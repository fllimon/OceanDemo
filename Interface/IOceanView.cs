using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanDemoProj.Interface
{
    interface IOceanView
    {
        #region =====----- PROPERTIES -----===== 

        int NumRows { get; }

        int NumCols { get; }

        #endregion

        #region ======----- INDEXER -----=====

        char this[int firstIndex, int secondIndex] { get; }

        #endregion
    }
}
