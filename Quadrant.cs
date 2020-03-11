using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Quadrant
    {
        private double side;
        public double Side { get => side; set => side = value; }

        public double getDiagonal()
        {
            return Math.Sqrt(Side * Side * 2);
        }

        public double getPerimeter()
        {
            return Side * 4;
        }

        public double getSquare()
        {
            return Side * Side;
        }

        public void printQuadrant()
        {
            Console.Write($"Quadrant: side = {Side}, square = {String.Format("{0:0.00}", getSquare())}, diagonal = {String.Format("{0:0.00}", getDiagonal())}, perimeter = {String.Format("{0:0.00}", getPerimeter())}");
        }

    }
}
