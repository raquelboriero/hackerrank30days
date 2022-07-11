using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DaysCode
{
    public class Day2 : IExercicio
    {

        // Task
        // Given the meal price(base cost of a meal), tip percent(the percentage of the meal price being added as tip),
        // and tax percent(the percentage of the meal price being added as tax) for a meal, find and print the meal's total cost.
        // Round the result to the nearest integer.


        public void Run()
        {
            Case01();
        }

        public void Case01()
        {
            double meal_cost = Convert.ToDouble(50.00);

            int tip_percent = Convert.ToInt32(10);

            int tax_percent = Convert.ToInt32(4);

            Solve(meal_cost, tip_percent, tax_percent);
        }


        //Mudar para cada exercicio, isso vai ser enviado para o Hacker Rank
        public void Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            Double tip = Convert.ToDouble(tip_percent);
            Double tax = Convert.ToDouble(tax_percent);

            double myTip = (tip / 100) * meal_cost;
            double myTax = (tax / 100) * meal_cost;
            double result = meal_cost + myTip + myTax;
            result = Math.Round(result, 0);
            Console.WriteLine(result);
        }


    }
}
