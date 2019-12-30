using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyOfGeometricShapes.ClosedFigures
{
    class Triangle : Polygon
    {
        #region ======----- PRIVATE DATA ----======

        private int _height = -1;

        #endregion

        #region =====----- CONSTRUCTORS -----======

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">Координата по X</param>
        /// <param name="y">Координата по Y</param>
        /// <param name="height">Высота</param>
        public Triangle(int x, int y, int height)
            : base(x, y)
        {
            _height = height;
        }

        #endregion

        #region =====----- PROPERTIES ----======

        public int Height
        {
            get 
            {
                return _height; 
            }
            set
            {
                _height = value; 
            }
        }

        #endregion

        ~Triangle()
        {

        }
    }
}
