using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrant qudrant = new Quadrant();

            qudrant.Side = 4*Math.Sqrt(2);

            Console.WriteLine(qudrant.getDiagonal());
            Console.WriteLine(qudrant.getPerimeter());
            Console.WriteLine(qudrant.getSquare());

            Quadrants quadrants = new Quadrants(20);
            quadrants.printQuadrants();

            int maxN = quadrants.findWithdMaxSquare();
            //            Console.WriteLine($"Quadrant with max square: {maxN+1}");
            //            quadrants.Quadrants_[maxN].printQuadrant();
            Console.WriteLine("All max:");
            quadrants.printAllWithSquare(quadrants.Quadrants_[maxN].getSquare());
        }
    }


}
