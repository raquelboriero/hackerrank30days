using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DaysCode
{
    internal class Day8
    {

        //        Task
        //Given n names and phone numbers, assemble a phone book that maps friends' names to their respective phone numbers. 
        //You will then be given an unknown number of names to query your phone book for. 
        //For each name queried, print the associated entry from your phone book on a new line in the form name=phoneNumber; 
        //if an entry for name is not found, print Not found instead.

        //Note: Your phone book should be a Dictionary/Map/HashMap data structure.


        public void Run()
        {
            Case01();
        }

        public void Case01()
        {
            Console.WriteLine("Number of entries in the phone book:");
            var numEntries = Convert.ToInt32(Console.ReadLine());

            var phoneBook = new Dictionary<string, string>();


            for (int i = 0; i < numEntries; i++)
            {
                Console.WriteLine("Name and phonenumber with 8 digits:");
                var nameAndPhone = Console.ReadLine().Split(" ");

                var name = nameAndPhone[0];
                var phone = nameAndPhone[1];

                phoneBook.Add(name, phone);
            }

            while (true)
            {
                Console.WriteLine("Names to check:");
                var nameToCheck = Console.ReadLine();

                if (string.IsNullOrEmpty(nameToCheck))
                {
                    break;
                }

                if (phoneBook.ContainsKey(nameToCheck))
                {
                    var phoneFromBook = phoneBook[nameToCheck];
                    Console.WriteLine($"{nameToCheck}={phoneFromBook}");

                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

           
        }


        //Mudar para cada exercicio, isso vai ser enviado para o Hacker Rank
        public void Solve(string[] listNames)
        {



        }

    }
}
