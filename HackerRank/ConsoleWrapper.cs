using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public interface IConsole
    {
        void Write(object message);
        void WriteLine(object message);
        string ReadLine();
    }

    public class ConsoleWrapper : IConsole
    {
        public void Write(object message)
        {
            Console.Write(message);
        }

        public void WriteLine(object message)
        {
            Console.WriteLine(message);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
