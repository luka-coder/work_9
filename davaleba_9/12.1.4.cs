using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sheiyvanet rame teqsi: ");
            string t = Convert.ToString(Console.ReadLine());
            string newString = string.Empty;
            int noOfPunctuation = 0;
            for(int i = 0; i < t.Length; i++)
            {
                if((t[i]>='a' && t[i]<='z')||(t[i]>='A' && t[i]<='Z')||t[i]==' '||(t[i]>='0' && t[i] <= '9'))
                {
                    newString += t[i];
                }
                else
                {
                    noOfPunctuation++;
                }
            }
            Console.WriteLine($"New string without punctuation: {newString}");
            Console.WriteLine($"{noOfPunctuation} Punctuation found.");
            Console.ReadKey();
        }
    }
}
