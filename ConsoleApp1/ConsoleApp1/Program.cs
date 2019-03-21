using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("题数");
            int a = Console.Read();

            Random rd = new Random();
            
            string[] item = new string[4] { "+", "-", "*", "/" };
            
            for (int i = 0; i < a; i++)
            {
                int s1 = rd.Next(0, 100);
                int s2 = rd.Next(0, 100);
                int s3 = rd.Next(0, 100);
                int s4 = rd.Next(0, 100);
                string fi1 = item[rd.Next(item.Length)];
                string fi2 = item[rd.Next(item.Length)];
                string fi3 = item[rd.Next(item.Length)];
                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}=",s1,fi1,s2,fi2,s3,fi3,s4);
            }









        }
    }
}
