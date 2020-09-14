using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Ar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] r = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("Rotate");
            Display(r);
            Rotate(r, 3);
            Display(r);

            int[] d = { 15, 12, 13, 12, 13, 13, 18 };
            int[] dd = { 10, 10, 10 };
            Console.WriteLine("");
            Console.WriteLine($"Disitnct Elements {DistinctElements(d)}");
            Console.WriteLine($"Disitnct Elements {DistinctElements(dd)}");

            int[] f = {33,8,22000,8, 10, 12, 10, 15, 10, 20,22000, 12, 12 };
            Console.WriteLine("Frequency of ");
            Display(f);
            FrequencyOrdered(f);

            int[] a = { 10, 15, 20, 15, 30, 30, 5 };
            int[] b = { 30, 5, 30, 80 };

            Display(a);
            Display(b);
            InteresectionCount(a, b);

            int[] a1 = { 15, 20, 5, 15 };
            int[] b1 = { 15, 15, 15, 20, 10 };
            Console.WriteLine("Union of distinct elements");
            Display(a1);
            Display(b1);
            UnionUnSortedArray(a1, b1);

            int[] u = { 3, 2, 8, 13, -3 };
            SumOfGiven(u, 17);
            OptmizeSumOfGiven(u, 17);
        }

        static void SumOfGiven(int[] arr, int val)
        {
            bool found = false;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if(arr[i]+arr[j]==val)
                    {
                        found = true;
                        break;
                    }
                    if (found)
                        break;
                }
            }

            Console.WriteLine($" Pair found with in unsorted array {found}");
        }

        static void OptmizeSumOfGiven(int[] arr, int val)
        {
            HashSet<int> set = new HashSet<int>();
            bool found = false;
            for(int i = 0; i < arr.Length; i++)
            {
                int k = val - arr[i];
                if (set.Contains(k))
                {
                    found = true;
                    break;
                }
                else
                {
                    set.Add(arr[i]);
                }
            }

            Console.WriteLine($"Optimize Union of distinct element {found}");
        }
        static void UnionUnSortedArray(int[] arr, int[] brr)
        {
            HashSet<int> set = new HashSet<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                set.Add(arr[i]);
            }

            for(int i = 0; i < brr.Length; i++)
            {
                   set.Add(brr[i]);
            }

            Console.WriteLine($"Union of distinct element {set.Count}");
        }
        static void FrequencyOrdered(int[] arr)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            List<int> key = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hash.ContainsKey(arr[i]))
                {
                    int data = hash[arr[i]];
                    hash[arr[i]] = ++data;

                }
                else
                {
                    hash[arr[i]] = 1;
                    key.Add(arr[i]);
                }
            }

            foreach (KeyValuePair<int, int> entry in hash)
            {
                Console.WriteLine($" {entry.Key}  -- {entry.Value}");
            }

            Console.WriteLine("Ordered output");
            foreach(int i in key)
            {
                Console.WriteLine($" {i}  -- {hash[i]}");
            }

        }

        
        static void InteresectionCount(int[] arr,int[] secondArr)
        {
            HashSet<int> set = new HashSet<int>();
   
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                set.Add(arr[i]);

            }

            for(int i = 0; i < secondArr.Length; i++)
            {
                if (set.Contains(secondArr[i]))
                {
                    count++;
                    set.Remove(secondArr[i]);
                }
            }

           
           

            Console.WriteLine($"Matching Records {count}");
        }

        static int DistinctElements(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            int count = 0;
            for(int i=0;i<arr.Length;i++)
            {
                set.Add(arr[i]);
            }
            return set.Count;
        }
        static void Display(int[] arr)
        {
            Console.WriteLine("");
            foreach(int n in arr)
            {
                Console.Write($"  {n}");
            }
            Console.WriteLine("");
        }

        static void Rotate(int[] arr, int n)
        {
            int[] temp = new int[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = arr[i];
            }

            for (int i = n, j = 0; i < arr.Length; i++, j++)
            {
                arr[j] = arr[i];
            }

            for (int i = 0; i < temp.Length; i++)
            {
                arr[arr.Length - 1 - i] = temp[i];
            }
        }
    }
}
