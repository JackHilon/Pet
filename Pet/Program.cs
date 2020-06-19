using System;
using System.Collections.Generic;
using System.Linq;

namespace Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pet
            // https://open.kattis.com/problems/pet

            List<int> points = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                var contestant = EnterContestant();
                var contPoint = ArraySum(contestant);
                points.Add(contPoint);
            }
            
            var result = MaxItem(points);
            
            string str = $"{result[1]+1} {result[0]}";
            Console.WriteLine(str);
        }
        private static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static int[] MaxItem(List<int> list)
        {
            // return {max value, max value's index} in the list
            int maxVal = int.MinValue, maxIndex = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if(maxVal < list[i])
                {
                    maxVal = list[i];
                    maxIndex = i;
                }
            }
            int[] a = new int[2] { maxVal, maxIndex };
            return a;
        }

        private static int ArraySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }

        private static int[] EnterContestant()
        {
            string[] arr = new string[4] { "", "", "", "" };
            int[] cont = new int[4] { 0,0,0,0};

            try
            {

                arr = Console.ReadLine().Split(' ', 4);
                for (int i = 0; i < arr.Length; i++)
                {
                    cont[i] = int.Parse(arr[i]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterContestant();
            }
            return cont;
        }

    }
}
