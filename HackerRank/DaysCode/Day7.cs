using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HackerRank.DaysCode
{
    internal class Day7
    {

        //        Task
        //Given an array, A, of N integers, print A's elements in reverse order as a single line of space-separated numbers.

        public void Run()
        {
            Case01();
        }

        public void Case01()
        {
            //Console.WriteLine("size of array:");
            //int n = Convert.ToInt32(Console.ReadLine().Trim());
            //Console.WriteLine("Array:");
            //int[] arr = Console.ReadLine().TrimEnd().Split(' ').ToArray().Select(arrTemp => Convert.ToInt32(arrTemp)).ToArray();
            
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Solve(arr);

        }


        //COMO ADICIONAR UM ELEMENTO NUMA ARRAY ?????????????????????????????????


        public void Solve(int[] arr)
        {
           // int[] reverseArr = new int[] { };
            var lenghtArr = arr.Length - 1;
            for (int i = lenghtArr; i >= 0; --i)
            {
             //  reverseArr.Append(arr[i]).ToArray();    
               Console.Write($"{arr[i]} ");
               
            }

            //Console.WriteLine($"{reverseArr} ");

        } 
    }
}
