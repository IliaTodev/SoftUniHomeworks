using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            float n = float.Parse(Console.ReadLine());
            float reversed = GetReersednumber(n);
            Console.WriteLine(reversed);
        }
        static float GetReersednumber(float n)
        {
            
            string s = n.ToString();
            char[] number = s.ToCharArray();
            char[] revNumber = new char[number.Length];
            int j = 0;
            for (int i = number.Length-1; i >=0; i--)
            {
             
                revNumber[j] = number[i];
                j++;
            }
            String b = new String(revNumber);
            float reversed = float.Parse(b,
      System.Globalization.CultureInfo.InvariantCulture);
            Math.Round(reversed);
            return reversed;
        }
    }
}
