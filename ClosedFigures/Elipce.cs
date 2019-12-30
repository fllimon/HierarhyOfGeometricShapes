using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyOfGeometricShapes.ClosedFigures
{
    class Elipce : ClosedFigure
    {
        #region =====----- PRIVATE DATA ----=====

        private int _radius = -1;

        #endregion

        #region =====----- CONSTRUCTORS ----=====

        public Elipce(int x, int y)
            : base(x, y)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">Координата по X</param>
        /// <param name="y">Координата по Y</param>
        /// <param name="radius">Радиус</param>
        public Elipce(int x, int y, int radius)
            : base(x, y)
        {
            _radius = radius;
        }

        #endregion

        #region =====----- PROPERTIES ----=====

        public int Radius
        {
            get 
            {
                return _radius; 
            }

            set
            {
                _radius = value; 
            }
        }


        #endregion
    }
}
