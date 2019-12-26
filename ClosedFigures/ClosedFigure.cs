using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyOfGeometricShapes
{
    class ClosedFigure : Figure
    {
        #region ======----- PRIVATE DATA ------======

        private int _firstSide = -1;
        private int _secondSide = -1;

        #endregion

        #region =====----- CONSTRUCTORS ------======

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">Координата по X</param>
        /// <param name="y">Координата по Y</param>
        public ClosedFigure(int x, int y)
            : base(x, y)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">Координата по X</param>
        /// <param name="y">Координата по Y</param>
        /// <param name="firstSide">Первая длинна стороны фигуры</param>
        /// <param name="secondSide">Вторая длинна стороны фигуры</param>
        public ClosedFigure(int x, int y, int firstSide, int secondSide)
            : this(x, y)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
        }

        #endregion

        #region ======----- PROPERTIES -------======

        public int FirstSide
        {
            get
            { 
                return _firstSide; 
            }

            set
            {
                _firstSide = value; 
            }
        }

        public int SecondSide
        {
            get
            {
                return _secondSide;
            }

            set
            {
                _secondSide = value;
            }
        }

        #endregion

        ~ClosedFigure()
        {

        }
    }
}
