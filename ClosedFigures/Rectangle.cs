using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyOfGeometricShapes.ClosedFigures
{
    class Rectangle : Quadrangle
    {
        #region =====----- CONSTRUCTORS -----======

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">Координата по X</param>
        /// <param name="y">Координата по Y</param>
        /// <param name="firstSide">Первая длинна стороны фигуры</param>
        /// <param name="secondSide">Вторая длинна стороны фигуры</param>
        public Rectangle(int x, int y, int firstSide, int secondSide)
            : base(x, y, firstSide, secondSide)
        {

        }

        #endregion

        ~Rectangle()
        {

        }
    }
}
