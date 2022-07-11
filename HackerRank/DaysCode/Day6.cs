using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.DaysCode
{
    internal class Day6
    {

        // Exemplos de List *********************************

        //        Task
        //Given a string, S, of length N that is indexed from 0 to N-1,
        //print its even-indexed and odd-indexed characters as 2 space-separated strings on a single line

        //Note:  is considered to be an even index.
        //        Note:  is considered to be an even index.
        //  Example
        //  s = adbecf
        //  Print abc def


        public void Run()
        {
            Case01();
        }

        public void Case01()
        {

            Console.WriteLine("Number of test cases:");
            var T = Convert.ToInt32(Console.ReadLine().Trim());

            string[] wordsUser = new string[T];
            
            var test = 1;
            while (test <= T)
            {
                Console.WriteLine("Write an word: ");
                wordsUser[test-1] = Console.ReadLine();
                test++;
            }

            Solve(wordsUser);

           
        }


        public void Solve(string[] wordsUser)
        {
            foreach (var word in wordsUser)
            {
                var lettersEvenBadWay = "";
                var lettersOddBadWay = "";
                var lettersEven = new StringBuilder("");
                var lettersOdd = new StringBuilder("");

                var i = 0;
                while (i < word.Length)
                {

                    if (i % 2 == 0)
                    {
                        lettersEvenBadWay += word[i];
                        lettersEven.Append(word[i]);
                    }
                    else
                    {
                        lettersOddBadWay += word[i];
                        lettersOdd.Append(word[i]);
                    }
                    i++;
                }
                
                var lettersWordBadWay = new StringBuilder();
                lettersWordBadWay.Append(lettersEven);
                lettersWordBadWay.Append(" ");
                lettersWordBadWay.Append(lettersOdd);

                Console.WriteLine($"{lettersEven} {lettersOdd}");
                Console.WriteLine(lettersWordBadWay);
            }
        }

        public void ListTest()
        {
            //Ler um pouco sobre Linq
            var emptyList = new List<string>();

            emptyList.Add("pedro");
            emptyList.Add("andré");            
            emptyList.Add("gabriel");

            var andre = emptyList.Where(x => x == "andre").ToList();
            var pedro = emptyList.FirstOrDefault(x => x == "pedro");
            var filhos = emptyList.Select(x => new Filho(x)).ToList();
            var gabriel = filhos.FirstOrDefault(x => x.Nome == "gabriel");
            var primeiroFilho = filhos.OrderBy(x => x.Nome).FirstOrDefault();

            var gabi = new Filho("gabriel");
            filhos.Contains(gabi);
            filhos.Any(x => x.Nome == "gabriel");
            filhos.All(x => x.Nome == "gabriel");

            var list = new List<string>()
            {
                "ricarod",
                "raquel"
            };


        }
    }

    public class Filho
    {
        public Filho(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Filho filho &&
                   Nome == filho.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }
    }
}
