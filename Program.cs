using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HierarchyOfGeometricShapes.ClosedFigures;

namespace HierarchyOfGeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(2, 2, 8, 8);
            Quadrangle quadrangle = new Quadrangle(14, 2, 8, 10);
            Triangle triangle = new Triangle(25, 2, 8);

            UI.Show(square);
            UI.Show(quadrangle);
            UI.Show(triangle);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            double result = BL.GetPerimetr(square.FirstSide);
            UI.ShowsSquarePerimetr(result);

            result = BL.GetPerimetr(quadrangle.FirstSide, quadrangle.SecondSide);
            UI.ShowsQuadranglePerimetr(result);

            Console.ReadLine();
        }

    }
}
