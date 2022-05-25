using System;
using System.Collections;

namespace HanoiSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will solve the towers of Hanoi.

            //Console.WriteLine("Enter the amount of plates you want to use for the game.");
            //int plateAmount = Convert.ToInt32(Console.ReadLine());

            const int plateAmount = 3;


            Stack towerLeft = new Stack();
            Stack towerMiddle = new Stack();
            Stack towerRight = new Stack();

            Stack[] stackArray = new Stack[3]
            {
                towerLeft,
                towerMiddle,
                towerRight
            };

            for (int i = 0; i < plateAmount; i++)
            {
                towerLeft.Push(i + 1);
            }

            for (int i = 0; i < plateAmount; i++)
            {
                towerRight.Push(towerLeft.Peek());
                towerLeft.Pop();
            }


            // Sorting begins here:

            while (stackArray[stackArray.Length - 1].Count > 0)
            {
                if (stackArray[stackArray.Length - 2].Count == 0)
                {
                    towerMiddle.Push(towerRight.Peek());
                    towerRight.Pop();
                }
                else if ()
                {

                }










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


            //foreach (Stack item in stackArray)
            //{
            //    Console.WriteLine(Array.IndexOf(stackArray, item));
            //}


            Console.ReadKey();
        }
    }
}
