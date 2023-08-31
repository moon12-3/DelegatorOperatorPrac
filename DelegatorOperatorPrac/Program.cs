using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorOperatorPrac
{
    internal class Program
    {
        public delegate void SendString(string message);

        static void Main(string[] args)
        {
            SendString sayHello, sayGoodbye, multiDelegate;
            sayHello = Hello;
            sayGoodbye = Goodbye;
            multiDelegate = sayHello + sayGoodbye;
            multiDelegate("문채영");
            multiDelegate -= sayGoodbye;
            multiDelegate("문채영");
        }

        private static void Goodbye(string message)
        {
            Console.WriteLine("안녕히가세요, " + message + "님.");
        }

        private static void Hello(string message)
        {
            Console.WriteLine("안녕하세요, " + message + "님.");
        }
    }
}
