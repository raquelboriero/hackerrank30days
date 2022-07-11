using System;
using System.Globalization;

namespace HackerRank.DaysCode
{
    public class Day1Exercise2 : IExercicio
    {
        public class Carro
        {
            public Carro(string placa, string modelo)
            {
                Placa = placa;
                Modelo = modelo;
                DataRegistro = DateTime.Now;
            }

            public string Placa { get; set; }

            public string Modelo { get; set; }

            public DateTime DataRegistro { get; set; }

            public override string ToString()
            {
                return this.ToString(null);
            }

            public string ToString(string format)
            {
                if (format != null && format == "p")
                {
                    return Placa;
                }

                return $"{Placa} - {Modelo} - {DataRegistro:dd/MM}";
            }
        }



        public void Run()
        {
            Case01();
        }

        public void Case01()
        {
            solve();
        }

        public void solve()
        {
            Console.WriteLine(new Carro("PP-88-88", "Corolla").ToString());
            Console.WriteLine(new Carro("PP-88-88", "Corolla").ToString("p"));
            Console.WriteLine(string.Format("{0:p}", new Carro("PP-88-88", "Corolla"), CultureInfo.InvariantCulture));
            return;
        }
    }
}
