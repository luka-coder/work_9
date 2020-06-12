using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sheiyvanet rame teqsti: ");
            string t = Convert.ToString(Console.ReadLine());
            for(int i = 0; i < t.Length; i++)
            {
                t.IndexOf('i');
            }
            Console.WriteLine($"points of vowels are: {t.IndexOf('i')}");
            Console.ReadKey();
        }
    }
}
