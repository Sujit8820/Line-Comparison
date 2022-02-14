// See https://aka.ms/new-console-template for more information
using System;

namespace Line_Comparison
{
    class program
    {
        public static double UserInpur()
        {
            Console.WriteLine("Enter first co-ordinate of first point");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter second co-ordinate of first point");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n  First point ({x1},{y1})");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("\nEnter first co-ordinate of second point");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter second co-ordinate of second point");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n  Second point ({x2},{y2})");
            Console.WriteLine("===========================================");

            double lineLength = CalculateLength(x1, y1, x2, y2);
            return lineLength;
        }
        public static double CalculateLength(int x1, int y1, int x2, int y2)
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)));
            return length;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Line Comparison Program\n");
            Console.WriteLine("For first line\n");
            double firstLineLength = UserInpur();
            Console.WriteLine("\nFor Second line\n");
            double secondLineLength = UserInpur();

            Console.WriteLine($"\nFirst line length: {firstLineLength}\nSecond line length: {secondLineLength}\n");

            bool status = firstLineLength.Equals(secondLineLength);
            if (status == true)
            {
                Console.WriteLine("Two lines are equal");
            }
            else
            {
                Console.WriteLine("Two lines are not equal");
            }
        }

    }

}
