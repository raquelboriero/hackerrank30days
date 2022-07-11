using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.UnitTests
{
    public class UnitTestConsoleWrapper : IConsole
    {
        private Queue<object> inputMessages;

        public List<string> OutputMessages = new List<string>();

        public UnitTestConsoleWrapper(params object[] inputs)
        {
            this.inputMessages = new Queue<object>(inputs);
        }

        public void Write(string message)
        {
            //Console.Write(message);
            OutputMessages.Add(message);
        }

        public void WriteLine(string message)
        {
            //Console.WriteLine(message);
            OutputMessages.Add(message + "\r\n");
        }

        public string ReadLine()
        {
            return this.inputMessages.Dequeue().ToString();
        }
    }
}
