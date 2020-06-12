using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sheiyvanet rame teqsti: ");
            string t = Convert.ToString(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < t.Length; i++)
            {
                if ((t[i] >= 'a' && t[i] <= 'z') || (t[i] >= 'A' && t[i] <= 'Z'))
                {
                    if(t[i]=='a'||t[i]=='e'||t[i]=='o'||t[i]=='i'||t[i]=='u'|| t[i] == 'A' || t[i] == 'E' || t[i] == 'O' || t[i] == 'I' || t[i] == 'U')
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"points of vowels are: {count}");
            Console.ReadKey();
        }
    }
}
