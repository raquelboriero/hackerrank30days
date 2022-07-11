using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DaysCode
{
    internal class Day4 : IExercicio
    {

        // já foi revisado
        //        Task
        //Write a Person class with an instance variable, age, and a constructor that takes an integer, initialAge, as a parameter.
        //The constructor must assign initialAge to age after confirming the argument passed as initialAge is not negative;
        //if a negative argument is passed as initialAge, the constructor should set age to 0 and print Age is not valid, setting age to 0.. In addition, you must write the following instance methods:

        //yearPasses() should increase the age instance variable by 1.
        //amIOld() should perform the following conditional actions:
        //If age < 13, print You are young..
        //If age >= 13 and age < 18, print You are a teenager..
        //Otherwise, print You are old..
        //To help you learn by example and complete this challenge, much of the code is provided for you, but you'll be writing everything in the future.
        //The code that creates each instance of your Person class is in the main method. Don't worry if you don't understand it all quite yet!



        public void Run()
        {
            Case01();
        }

        public void Case01()
        {
            Console.WriteLine("digite uma idade:");
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }


        //Mudar para cada exercicio, isso vai ser enviado para o Hacker Rank

        class Person
        {
            public int age;
            public Person(int initialAge)
            {
                if (initialAge > 0)
                {
                    age = initialAge;
                }
                else
                {
                    age = 0;
                    Console.WriteLine("Age is not valid, setting age to 0.");
                    
                }
                 
                // Add some more code to run some checks on initialAge
            }
            public void amIOld()
            {
                if (age < 13)
                {
                    Console.WriteLine("You are young.");
                }
                //else if (age >= 13 && age < 18)
                else if (13 <= age && age < 18)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else
                {
                    Console.WriteLine("You are old.");
                }

                // Do some computations in here and print out the correct statement to the console 
            }

            public void yearPasses()
            {
                age++;

                // Increment the age of the person in here
            }




            //static void Main(String[] args)
            //{
            //    int T = int.Parse(Console.In.ReadLine());
            //    for (int i = 0; i < T; i++)
            //    {
            //        int age = int.Parse(Console.In.ReadLine());
            //        Person p = new Person(age);
            //        p.amIOld();
            //        for (int j = 0; j < 3; j++)
            //        {
            //            p.yearPasses();
            //        }
            //        p.amIOld();
            //        Console.WriteLine();
            //    }
            //}
        }



    }
}
