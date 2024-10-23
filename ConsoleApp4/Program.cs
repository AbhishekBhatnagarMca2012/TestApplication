using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] vs = new int[] { 2,7,11, 15 }; // need to sort
            vs = vs.OrderBy(i => i).ToArray();
            int target = 37;

            List<int> res = GetData(vs, target);

            if (res != null)
            {
                foreach (var item in res)
                {
                    Console.WriteLine(item);
                }
            }


        }


        public static List<int> GetData(int[] numbers, int target)
        { 
        
            List<int> list = new List<int>();
            int sum = 0; // check

            for (int i = 0; i < numbers.Length; i++)
            {
                list = new List<int>();
                sum = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    list.Add(numbers[j]);
                    sum += numbers[j];

                    if (sum == target)
                    {
                        return list;
                    }
                    if (sum > target)
                    {
                        break;
                    }

                }
            }
           

            return null;
        }
    }

}
