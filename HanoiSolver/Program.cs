using System;
using System.Collections;

namespace HanoiSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will solve the towers of Hanoi.

            Stack towerLeft = new Stack();
            Stack towerMiddle = new Stack();
            Stack towerRight = new Stack();

            Plate plateSmall = new Plate();
            plateSmall.plateSize = 1;
            Plate plateMedium = new Plate();
            plateSmall.plateSize = 2;
            Plate plateBig = new Plate();
            plateSmall.plateSize = 3;




            Console.ReadKey();
        }
    }

    class Plate
    {
        public int plateSize {
            get;
            set;
        }
    }
}
