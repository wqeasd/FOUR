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
            //Console.WriteLine("选择年级 1/3/6");
            

            Console.Write("题数:");
            int a = int.Parse(Console.ReadLine());

            Random rd = new Random();
            
            string[] item = new string[4] { "+", "-", "*", "/" };
            string b;
            for (int i = 0; i < a; i++)
            {
                int s1 = rd.Next(0, 100);
                int s2 = rd.Next(0, 100);
                int s3 = rd.Next(0, 100);
                int s4 = rd.Next(0, 100);
                string fi1 = item[rd.Next(item.Length)];
                string fi2 = item[rd.Next(item.Length)];
                
                string fi3 = item[rd.Next(item.Length)];
                b = s1.ToString()+ fi1 + s2.ToString()+s3.ToString()+fi3+s4.ToString();
                var daan = new System.Data.DataTable().Compute(b,"");
                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}={7}",s1,fi1,s2,fi2,s3,fi3,s4,daan);


            }









        }
    }
}
