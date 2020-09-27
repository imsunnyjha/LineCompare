using System;

namespace LineCompare
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome To Line Comparison Computation Problem!");

            Console.WriteLine("Enter the X,Y co-ordinates of the line: ");

            double pointX1 = Convert.ToDouble(Console.ReadLine());
            double pointY1 = Convert.ToDouble(Console.ReadLine());
            double pointX2 = Convert.ToDouble(Console.ReadLine());
            double pointY2 = Convert.ToDouble(Console.ReadLine());

            //Power Calculation for Co-Ordinate Points
             double powerP = Math.Pow(pointX2 - pointX1, 2);
             double powerQ = Math.Pow(pointY2 - pointY1, 2);

             Console.WriteLine(Math.Sqrt(powerP + powerQ));
        }
    }
}


