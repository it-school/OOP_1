using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Quadrants
    {
        Quadrant[] quadrants;
        internal Quadrant[] Quadrants_ { get => quadrants; set => quadrants = value; }

        public Quadrants()
        { }



        public Quadrants(int N)
        {
            Quadrants_ = new Quadrant[N];
            Random r = new Random();

            for (int i = 0; i < Quadrants_.Length; i++)
            {
                Quadrants_[i] = new Quadrant();
                Quadrants_[i].Side = r.Next(2, 20);
            }
        }

        public void printQuadrants()
        {
            int i = 1;
            foreach (Quadrant quadrant in Quadrants_)
            {
                Console.WriteLine("Q" + i++ + ": " + quadrant.Side);
            }
        }

        public int findWithdMaxSquare()
        {
            int max = 0;

            if (Quadrants_.Length > 0)
            {
                for (int i = 1; i < Quadrants_.Length; i++)
                {
                    if (Quadrants_[max].getSquare() < Quadrants_[i].getSquare())
                        max = i;
                }
            }
            return max;
        }

        public void printAllWithSquare(double square)
        {
            
            for (int i = 0; i < quadrants.Length; i++)
            {
                if (quadrants[i].getSquare() == square)
                {
                    quadrants[i].printQuadrant();
                    Console.WriteLine($", [{i+1}]");
                }
            }
            /*
            foreach (Quadrant quadrant in Quadrants_)
            {
                if (quadrant.getSquare() == square)
                    quadrant.printQuadrant();
            }
            */
        }
    }
}