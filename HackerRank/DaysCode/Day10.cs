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

            //var result = 0;

            //foreach (var item in numberBinary)
            //{

            //    var binary1 = 1;
            //    switch (item)
            //    {
            //        case binary1:
            //            result =+ result;
            //            break;
            //        case 0:
            //            break;
            //    }

            //}

            var result = 0;

            for (int i = 0; i < numberBinary.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }

                while (i == 1)
                {
                    result = +result;
                }


            }

 



            this.console.WriteLine(result);


        }


    }
}
