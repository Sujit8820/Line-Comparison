// See https://aka.ms/new-console-template for more information
using System;

namespace Line_Comparison
{
    class program
    {
        
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Line Comparison Program\n");
            Console.WriteLine("For first line\n");
            LineLength lineLength1 = new LineLength();
            double firstLineLength = lineLength1.GetLength();

            Console.WriteLine("\nFor Second line\n");
            LineLength lineLength2 = new LineLength();
            double secondLineLength = lineLength2.GetLength();

            Console.WriteLine($"\nFirst line length: {firstLineLength}\nSecond line length: {secondLineLength}\n");

            int compare = (firstLineLength.CompareTo(secondLineLength));
            if (compare == 0)
            {
                Console.WriteLine("Two lines are equal");
            }
            else if (compare == 1)
            {
                Console.WriteLine("First line is greater than second line");
            }
            else
                Console.WriteLine("First line is lesser than second line");

        }

    }

}
