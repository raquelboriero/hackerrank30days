using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DaysCode
{
    internal class Day5 : IExercicio
    {

        //        Task
        //Given an integer, n, print its first 10 multiples.
        //Each multiple n*i (where 1 <= i && i <= 10) should
        //be printed on a new line in the form: n x i = result.


        public void Run()
        {
            Case01();
        }

        public void Case01()
        {
            Console.WriteLine("digite um número:");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Solve(n);
        }


        public void Solve(int firstOperator)
        {

            for (int secondOperator = 1; secondOperator < 11; secondOperator++)
            {
                var result = firstOperator * secondOperator;
                Console.WriteLine($"{firstOperator} x {secondOperator} = {result}");
            }


            //var secondOperator = 1;

            //while (secondOperator <= 10)
            //{
            //    var result = firstOperator * secondOperator;
            //    Console.WriteLine($"{firstOperator} x {secondOperator} = {result}");
            //    secondOperator++;
            //}
             
        }



    }
}
