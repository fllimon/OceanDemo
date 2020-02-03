using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanDemoProj.Interface
{
    interface ICellContainer
    {
        #region =====----- PROPERTIES -----=====

        int NumRows { get; }

        int NumCols { get; }

        #endregion

        //#region =====----- INDEXER ------=====

        //char this[int firstIndex, int secondIndex] { get; }    // ToDo: ?????

        //#endregion

        bool IsEmptyCell(Coordinate someCordinate);

        void Add(Cell someEntity);
    }
}
