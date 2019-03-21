using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class JiSuan
    {
        public static void Simpleness()
        {
            Random rd = new Random();


            string[] item = new string[4] { "+", "-", "*", "/" };
            Random r = new Random();
            Double daan = -10000;
            for (int i = 0; i < 10; i++)
            {
                int s1 = rd.Next(0, 100);
                int s2 = rd.Next(0, 100);
                string fi1 = item[r.Next(item.Length)];
                if (fi1 == "+")
                {
                    daan = s1 + s2;
                }
                if (fi1 == "-")
                {
                    daan = s1 - s2;
                }
                if (fi1 == "*")
                {
                    daan = s1 * s2;
                }
                if (fi1 == "/")
                {
                    daan = s1 / s2;
                }
                Console.WriteLine("{0}{1}{2} = {3}", s1, fi1, s2, daan);
            }

        }
        
        //public static String yf(int a, int b)
        //{
        //    int y = 1;
        //    for (int i = a; i >= 1; i--)
        //    {
        //        if (a % i == 0 && b % i == 0)
        //        {
        //            y = i;
        //            break;
        //        }
        //    }
        //    int z = a / y;
        //    int m = b / y;
        //    if (z == 0)
        //    {
        //        return "0";
        //    }
        //    return "" + z + "/" + m;

        //}
      
    }
}