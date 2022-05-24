using System;
using System.Collections;

namespace HanoiSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will solve the towers of Hanoi.

            Console.WriteLine("Enter the amount of plates you want to use for the game.");
            int plateAmount = Convert.ToInt32(Console.ReadLine());
            Stack towerLeft = new Stack();
            Stack towerMiddle = new Stack();
            Stack towerRight = new Stack();

            for (int i = 0; i < plateAmount; i++)
            {
                towerLeft.Push(i + 1);
            }







            Console.WriteLine("---------");
            foreach (var item in towerLeft)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");
            foreach (var item in towerMiddle)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");
            foreach (var item in towerRight)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");


            Console.ReadKey();
        }
    }
}
