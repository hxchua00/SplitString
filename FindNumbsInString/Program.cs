using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string here: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            string[] splitStr = input.Split(' ', '.', ',');

            Console.WriteLine("Number of words is " + splitStr.Length);
            Console.WriteLine();

            foreach (var s in splitStr)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
