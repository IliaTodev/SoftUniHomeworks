using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Larger_Than_Neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringa = Console.ReadLine().Split();
            int[] numbers = stringa.Select(s => int.Parse(s)).ToArray();
            for (int i = 1; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }
        }
        public static string IsLargerThanNeighbours(int[] numbers,int i)
        {

           while(i == numbers.Length-1 )
            {
                if (numbers[i] > numbers[i - 1])
                {
                    return "True";
                }
                else
                {
                    return "False";
                }
                
            }
                if (numbers[i-1] > numbers[i] && numbers[i-1] > numbers[i - 2])
                {
                    return "True";
                }
                else
                {
                    return "False";
                }
            
            
        }
    }
}
