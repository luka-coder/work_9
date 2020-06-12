using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sheiyvanet rame teqsi: ");
            string t = Convert.ToString(Console.ReadLine());
            int count = 0;
            foreach(char item in t)
            {
                if(item == 'i')
                {
                    count++;
                }
            }
            Console.WriteLine($"The number of i character are: {count}");
            Console.ReadKey();
        }
    }
}
