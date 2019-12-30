using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HierarchyOfGeometricShapes.ClosedFigures;

namespace HierarchyOfGeometricShapes
{
    class UI
    {
        public static void Show(Square square)
        {
            for (int i = 0; i < square.FirstSide; i++)
            {
                for (int j = 0; j < square.SecondSide; j++)
                {
                    Console.SetCursorPosition(square.X + i, square.Y + j);
                    Console.Write('#');
                }
            }
        }

        public static void Show(Quadrangle quadrangle)
        {
            for (int i = 0; i < quadrangle.FirstSide; i++)
            {
                for (int j = 0; j < quadrangle.SecondSide; j++)
                {
                    if (quadrangle.FirstSide == quadrangle.SecondSide)
                    {
                        Console.Write("У прямоугольника одна из сторон должна быть больше, введите размерность снова.");

                        return;
                    }
                    else
                    {
                        Console.SetCursorPosition(quadrangle.X + i, quadrangle.Y + j);
                        Console.Write('#');
                    }
                }
            }
        }

        public static void Show(Triangle triangle)
        {
            for (int i = 0; i < triangle.Height; i++)
            {
                for (int j = 0; j <= i; j++) 
                {
                    Console.SetCursorPosition(triangle.X + i, triangle.Y + j);
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }

        public static void ShowsSquarePerimetr(double value)
        {
            Console.WriteLine($"Периметр квадрата равен: {value} ");
        }

        public static void ShowsQuadranglePerimetr(double value)
        {
            Console.WriteLine($"Периметр прямоугольника равен: {value} ");
        }

    }
}
