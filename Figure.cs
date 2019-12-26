using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyOfGeometricShapes
{
    class Figure
    {
        #region ======------ PRIVATE DATA ------======

        private int _x = -1;
        private int _y = -1;

        #endregion

        #region ======------ CONSTRUCTORS -------======

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">Координата по X</param>
        /// <param name="y">Координата по Y</param>
        public Figure(int x, int y)
        {
            _x = x;
            _y = y;
        }

        #endregion

        #region =====----- PROPERTIES ------======

        

        public int X
        {
            get 
            {
                return _x;
            }

            set 
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        #endregion

        ~Figure()
        {

        }
    }
}
