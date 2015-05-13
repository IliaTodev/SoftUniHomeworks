using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ko staa manqk
namespace Problem_1.Bigger_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max= GetMax(a,b);
            Console.WriteLine(max);
        }
        public static int GetMax(int a,int b)
        {
            if (a>b)
            {
              return a;  
            }
            else
            {
                return b;
            }
        }
    }
}
