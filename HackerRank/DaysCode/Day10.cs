using System;
using System.Collections.Generic;
using System.Linq;
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
            var binaryNumbers = Convert.ToString(numberBase10, 2);

            int final_result = ComputeOneSequences(binaryNumbers);

            //this.console.WriteLine(Math.Max(firstConsecultiveOnes, secondConsecutiveOnes));
            this.console.WriteLine(final_result);


        }

        public int ComputeOneSequences(string binaryNumbers)
        {
            var result = 0;
            var final_result = 0;

            foreach (var binaryNumberInChar in binaryNumbers)
            {
                var binaryNumber = Convert.ToInt32(binaryNumberInChar.ToString());

                if (binaryNumber == 1)
                {
                    result++;
                }
                else
                {
                    if (final_result < result)
                    {
                        final_result = result;
                    }

                    result = 0;
                }
            }

            if (final_result < result)
            {
                final_result = result;
            }

            return final_result;
        }
    }
}
