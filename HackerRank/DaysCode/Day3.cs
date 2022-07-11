using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DaysCode
{
    internal class Day3 : IExercicio
    {

        //        Task
        //Given an integer, n, perform the following conditional actions:

        //If n is odd, print Weird
        //If n is even and in the inclusive range of 2 to 5 , print Not Weird
        //If n is even and in the inclusive range of 6 to 20, print Weird
        //If n is even and greater than 20, print Not Weird
        //Complete the stub code provided in your editor to print whether or not n is weird.

        public void Run()
        {
            Case01();
        }

        public void Case01()
        {

            Console.WriteLine("digite um numero:");
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            Solve(N);   
        }


        //Mudar para cada exercicio, isso vai ser enviado para o Hacker Rank
        public void Solve(int n)
        {

            if (n % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if ((2 <= n && n <= 5) || n > 20)
            {
                Console.WriteLine("Not Weird");
            }
            else if (6 <= n && n <= 20)
            {
                Console.WriteLine("Weird");
            }
        }


    }
}
