using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sheiyvanet raime teqsti: ");
            string t = Convert.ToString(Console.ReadLine());
            Console.WriteLine("The length of input text is: " + t.Length);
            Console.ReadKey();
        }
    }
}
