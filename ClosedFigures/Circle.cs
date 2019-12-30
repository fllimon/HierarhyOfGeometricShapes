using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyOfGeometricShapes.ClosedFigures
{
    class Circle : Elipce
    {
        #region =====----- PRIVATE DATA ----====

        private int _circleRadius = -1;

        #endregion

        #region ======---- CONSTRUCTORS ----===== 

        public Circle(int x, int y)
            : base(x, y)
        {
           
        }

        public Circle(int x, int y, int radius)
            : this(x, y)
        {
            _circleRadius = radius;
        }

        #endregion

        #region =======------- PROPERTIES ------=======

        public int CircleRadius
        {
            get 
            {
                return _circleRadius; 
            }

            set 
            {
                _circleRadius = value; 
            }
        }


        #endregion
    }
}
