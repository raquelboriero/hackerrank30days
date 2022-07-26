using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DaysCode
{
    public class Day10
    {

        private readonly IConsole console;

        //        Decimal to Binary
       // Print a single base-10 integer that denotes the maximum number of consecutive 1's in the binary representation of n.


        public Day10(IConsole console = null)
        {
            this.console = console ?? new ConsoleWrapper();
        }


        public void Run()
        {
            Case01();
        }

        public void Case01()
        {

            var numberBase10 = Convert.ToInt32(this.console.ReadLine().Trim());
            var numberBinary = Convert.ToString(numberBase10, 2);
            numberBinary = numberBinary.Substring(0, numberBinary.Length);


            var result = 0;

            for (int i = 0; i < numberBinary.Length; i++)
            {
                if (numberBinary[i] == 1)
                {
                    result += numberBinary[i];
                    continue;
                }

                else
                { 
                    break;
                }


            }




            this.console.WriteLine(result);


        }


    }
}
