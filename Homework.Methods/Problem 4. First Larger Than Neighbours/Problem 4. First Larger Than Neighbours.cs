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

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighopur(numbers));
            
        }
      
        public  static int GetIndexOfFirstElementLargerThanNeighopur(int[] numbers)
        {
            int index=-1;
            for (int i = 1; i < numbers.Length; i++)
            {
               
                if (numbers[i - 1] > numbers[i] && numbers[i - 1] > numbers[i - 2])
                {
                    index = i-1;
                    break;
                    
                }
                
            }
            return index;
        }
    }
}