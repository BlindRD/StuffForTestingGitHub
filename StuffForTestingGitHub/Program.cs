using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffForTestingGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Program thing = new Program();

            Console.WriteLine("Square of 25 is >> "+thing.sqr(25));

            Console.WriteLine(thing.str("string"));            
        }

        int sqr(int a)
        {
            return a * a;
        }

        string str(string a)
        {
            return a + " << this is \"string\"";
        }

        // This method will be push into GitHub
        void hiGitHub()
        {
            Console.WriteLine();
            Console.WriteLine("=============");
            Console.WriteLine("Hello GitHub!");
        }
    }
}
