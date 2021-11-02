using System;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 23, 75, 89, 12, 45, 78,94,123,82,79 };
            //Array.Reverse(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            ////int[] arr = { 23, 75, 89, 12, 45, };
            ////int[] arr2 = { 35, 77, 90, 15, 60, };

            //int[] arr3 = arr.Concat(arr2).ToArray();
            //Array.Sort(arr3);
            //Array.Reverse(arr3);
            //foreach (var item in arr3)
            //{
            //    Console.WriteLine(item);
            //}
            int[] arr = { 23, 75, 89, 12, 45, };
            
            
            
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());


        }
    }
}
