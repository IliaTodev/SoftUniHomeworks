using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Bigger_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] string1 = Console.ReadLine().Split();
            string[] string2 = Console.ReadLine().Split();
            decimal[] numbers = string1.Select(s => decimal.Parse(s)).ToArray();
            decimal variable = GetSum(numbers); //change the method name to GetMax,GetMin,GetAverage,GetProduct to see other calculations
           double[] numbers2 = string2.Select(s => double.Parse(s)).ToArray();
           double variable2 = GetSum(numbers2); //change the method name to GetMax,GetMin,GetAverage,GetProduct to see other calculations
           Console.WriteLine(variable);
            Console.WriteLine(variable2);
        }
        public static decimal GetMax(decimal[] a)
        {
            decimal maxValue=0;
            for (int i = 1; i <= a.Length-1; i++)
            {
                if (a[i-1]<a[i])
                {
                    maxValue = a[i ];

                }
            }
            return maxValue;
        }
        public static double GetMax(double[] a)
        {
           double maxValue = 0;
            for (int i = 1; i <= a.Length - 1; i++)
            {
                if (a[i - 1] < a[i])
                {
                    maxValue = a[i];

                }
            }
            return maxValue;
        }
        public static double GetMin(double[] a)
        {
            double minValue = 0;
            for (int i = 1; i <= a.Length - 1; i++)
            {
                if (a[i - 1] > a[i])
                {
                    minValue = a[i];

                }
            }
            return minValue;
        }
        public static decimal GetMin(decimal[] a)
        {
            decimal minValue = 0;
            for (int i = 1; i <= a.Length - 1; i++)
            {
                if (a[i - 1] > a[i])
                {
                    minValue = a[i];

                }
            }
            return minValue;
        }
        public static decimal GetAverage(decimal[] a)
        {
            decimal aver = 0;
            decimal sum = 0;
            for (int i = 0; i <a.Length; i++)
            {
                sum += a[i];
            }
            aver = sum / a.Length;
            return aver;
        }
        public static double GetAverage(double[] a)
        {
            double aver = 0;
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            aver = sum / a.Length;
            return aver;
        }
        public static decimal GetSum(decimal[] a)
        {
            
            decimal sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
           
            return sum;
        }
        public static double GetSum(double[] a)
        {
            
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        public static double GetProduct(double[] a)
        {

            double product = 1;
            for (int i = 0; i < a.Length; i++)
            {
                product *= a[i];
            }
            return product;
        }
        public static decimal GetProduct(decimal[] a)
        {

            decimal product =1;
            for (int i = 0; i < a.Length; i++)
            {
                product *= a[i];
            }
            return product;
        }
    }
}