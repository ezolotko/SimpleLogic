using System;
using static SimpleLogic.WordConverter;

namespace SimpleLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("c = " + FromWord(WordAdder.Add(ToWord(a), ToWord(b))));
        }
    }
}
