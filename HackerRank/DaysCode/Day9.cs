using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DaysCode
{
    public class Day9
    {
        private readonly IConsole console;

        //        Function Description
        //Complete the factorial function in the editor below.Be sure to use recursion.

        //factorial has the following paramter:

        //int n: an integer
        //Returns

        //int: the factorial of n
        //Note: If you fail to use recursion or fail to name your recursive function factorial or Factorial, you will get a score of 0.

        //Input Format

        //A single integer, n(the argument to pass to factorial).


        public Day9(IConsole console = null)
        {
            this.console = console ?? new ConsoleWrapper();
        }


        public void Run()
        {
            Case01();
        }

        public void Case01()
        {
            
            int n = Convert.ToInt32(this.console.ReadLine().Trim());

            int result = Day9.factorial(n);
            this.console.WriteLine(result);

        }


         public static int factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }

        }




    }
}
