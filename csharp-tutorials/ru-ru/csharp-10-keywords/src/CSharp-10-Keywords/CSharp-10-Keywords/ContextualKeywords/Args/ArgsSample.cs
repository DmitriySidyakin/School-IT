using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_10_Keywords.ContextualKeywords.Args
{
    internal class ArgsSample
    {
        public static void PrintArgs(string[] args)
        {
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    Console.WriteLine($"Агрумент={arg}");
                }
            }
            else
            {
                Console.WriteLine("Без аргументов");
            }
        }
    }
}
