using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison
{
    class LineLength
    {
        public double GetLength()
        {
            Console.WriteLine("Enter first co-ordinate (x1,y1)");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n  First point ({x1},{y1})");

            Console.WriteLine("\nEnter second co-ordinates (x2,y2)");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n  Second point ({x2},{y2})");

            double length = CalculateLength(x1,y1,x2,y2);
            return length;
        }
        public static double CalculateLength(int x1, int y1, int x2, int y2)
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)));
            return length;
        }

   
    }
}
