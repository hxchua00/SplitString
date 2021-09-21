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
            //Q2 Start
            Console.WriteLine("Enter string here: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            string[] splitStr = input.Split(' ', '.', ',','?','!');

            Console.WriteLine("Number of words is " + splitStr.Length);
            Console.WriteLine();

            foreach (var s in splitStr)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            //Q2 End
            //Q3 start
            Console.WriteLine("Enter word to search: ");
            string find = Console.ReadLine();
            Console.WriteLine();
            int count = 0;
            foreach(string s in splitStr)
            {
                if(find == s)
                {
                    count++;
                }
            }

            if(count > 0)
            {
                Console.WriteLine(find + " has been found " + count + " times!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(find + " cannot be found anywhere");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
