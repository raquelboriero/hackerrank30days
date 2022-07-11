using System;
using System.Globalization;

namespace HackerRank.DaysCode
{
    public class Day1 : IExercicio
    {
        public void Run()
        {
            Case01();
        }

        public void Case01()
        {
         
            solve();
        }

        //Mudar para cada exercicio, isso vai ser enviado para o Hacker Rank


       
        public void solve()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            Console.WriteLine("digite um numero:");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite um numero:");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite uma string:");
            string s2 = Console.ReadLine();


            double d3 = d + d2;
            Console.WriteLine(i + j);
            Console.WriteLine(String.Format("{0:0.0} - {1:dd/MM}", d3, DateTime.Now, CultureInfo.InvariantCulture));
            Console.WriteLine(s + s2);


            // d3 = Math.Round(d3, 2);
            // Console.WriteLine(Math.Round(d + d2, 2));
            //Console.WriteLine(d3.ToString("0.0", CultureInfo.InvariantCulture));
            //Console.WriteLine(d3.ToString("000.00"));
            //Console.WriteLine(DateTime.Now.ToString("dd/MM"));
        }
    }
}
