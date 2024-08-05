using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //integral numeric types
            byte var1 = 45;
            byte var2 = 56;
            int sum = var1+var2;
            Console.WriteLine(sum);
            var intMin = int.MinValue;
            var intMax = int.MaxValue;

            //floating point numbers
            float var3 = 5.2F;
            double var4 = 435.34D;

            double sum2 = var3+var4;
            Console.WriteLine(sum2);
            //boolean types
            bool var5 = (5>6) && (7<6);

            Console.WriteLine(var5);

            //char type
            char var6 = 'A';
            char var7 = 'B';
            var concat = var6.ToString()+var7.ToString();
            Console.WriteLine(concat);


            //sting
            string var10 = "A.l.m.a";
            Console.WriteLine(var10);
            Console.ReadLine();
        }
    }
}
