using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Class2
    {
        public static void  Duplicate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }
            int count = 0;
            foreach (KeyValuePair<int, int> pair in dict)
            {
                if (pair.Value > 1)
                {
                    count++;
                }
            }
            Console.WriteLine("The total number of duplicate elements in the array is: " + count);
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Duplicate(array);
        }
    }
}
