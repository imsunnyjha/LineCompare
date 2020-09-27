using System;

namespace LineCompare
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome To Line Comparison Computation Problem!");

            //Input for firstLine
            Console.WriteLine("Enter the X,Y co-ordinates of the first line: ");

            double pointX1 = Convert.ToDouble(Console.ReadLine());
            double pointY1 = Convert.ToDouble(Console.ReadLine());
            double pointX2 = Convert.ToDouble(Console.ReadLine());
            double pointY2 = Convert.ToDouble(Console.ReadLine());

            //Input for secondLine
            Console.WriteLine("Enter the X,Y co-ordinates of the second line: ");

            double pointP1 = Convert.ToDouble(Console.ReadLine());
            double pointQ1 = Convert.ToDouble(Console.ReadLine());
            double pointP2 = Convert.ToDouble(Console.ReadLine());
            double pointQ2 = Convert.ToDouble(Console.ReadLine());

            //Power Calculation for Co-Ordinate Points
            double powerP = Math.Pow(pointX2 - pointX1, 2) + Math.Pow(pointY2 - pointY1, 2);
            double powerX = Math.Pow(pointP2 - pointP1, 2) + Math.Pow(pointQ2 - pointQ1, 2);
            
            //Length Calculation
            double firstLine = Math.Sqrt(powerP);
            double secondLine = Math.Sqrt(powerX);

            //Printing the length 
            Console.WriteLine(firstLine);
            Console.WriteLine(secondLine);

            //Passing double as string
            String line1 = Convert.ToString(firstLine);
            String line2 = Convert.ToString(secondLine);

            //Checking whether two lines are equal
            Console.WriteLine(line1.Equals(line2));

            //Comparing two lines
            Console.WriteLine(line1.CompareTo(line2));
        }
    }
}


