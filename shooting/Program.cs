using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shootingTime
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("You have 3 attempts to shoot! \n");
            Console.Write("You 1st shot, put x ");
            int firstX = int.Parse(Console.ReadLine());
            Console.Write("You 1st shot, put y ");
            int firstY = int.Parse(Console.ReadLine());
            Console.Write("You 2nd shot, put x ");
            int secondX = int.Parse(Console.ReadLine());
            Console.Write("You 2nd shot, put y ");
            int secondY = int.Parse(Console.ReadLine());
            Console.Write("You 3rd shot, put x ");
            int thirdX = int.Parse(Console.ReadLine());
            Console.Write("You 3rd shot, put y ");
            int thirdY = int.Parse(Console.ReadLine());

            int point1;

            if (firstX <= 1 && firstY <= 1)
            {
                point1 = 10;
            }
            else if ( (firstX <= 2 && firstX > 1) && (firstY <= 2 && firstY > 1) || (firstX <= 2 && firstX > 1) && (firstY <= 1) || (firstX <= 1 ) && (firstY <= 2 && firstY > 1))
            {
                point1 = 5;
            }
            else
            {
                point1 = 0;
            }
            int point2;
            
            if (secondX <= 1 && secondY <= 1)
            {
                point2 = 10;
            }
            else if ((secondX <= 2 && secondX > 1) && (secondY <= 2 && secondY > 1) || (secondX <= 2 && secondX > 1) && (secondY <= 1) || (secondX <= 1) && (secondY <= 2 && secondY > 1))
            {
                point2 = 5;
            }
            else
            {
                point2 = 0;
            }
            int point3; 

            if (thirdX <= 1 && thirdY <= 1)
            {
                point3 = 10;
            }
            else if ((thirdX <= 2 && thirdX > 1) && (thirdY <= 2 && thirdY > 1) || (thirdX <= 2 && thirdX > 1) && (thirdY <= 1) || (thirdX <= 1) && (thirdY <= 2 && thirdY > 1))
            {
                point3 = 5;
            }
            else
            {
                point3 = 0;
            }
            int sum = point1 + point2 + point3;
            Console.WriteLine("Your result is " + sum);
        }
    }
}
              