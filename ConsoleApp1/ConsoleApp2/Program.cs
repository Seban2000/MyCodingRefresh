using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] data = { "A", "B", "C", "D", "E", "F" };
            Console.WriteLine(GetIndex(data, "E"));
            int[] d = new int[5];
            int[] k = { 7, 20, 30, 25, 50 };
            int[] r = { 10, 5, 7, 30,22 };
            int[] x = { 10, 20, 20, 30, 30, 30, 30 };
            int[] a = { 10, 20, 20, 30, 30, 30, 30,40,50,50 };
            d[0] = 1;
            d[1] = 2;
            d[2] = 3;
            d[3] = 4;
            int[] y = { 4, 8, 11, 15 };
            int[] rr = {1,2,3,4,5,6 };
            int[] rn = { 1, 2, 3, 4, 5, 6 };
            int[] rnn = { 1, 2, 3, 4, 5, 6 };
            int[] l = { 7, 10, 4, 10, 6, 5, 2 };
            int[] f = { 10, 10, 10, 25, 30, 30 };
            int[] ss = { 8, 10, 10, 12 };
            int[] ss1 = { 100, 20, 200, 300, 400 };
            Console.WriteLine("***********");
            MissingNumbers(y);
            Display(d);
            Display(Move(d, 23, 1));
            Remove(d, 3);
           Display(d);
            Display(k);

            Console.WriteLine($"Is Sorted {IsSorted(k)}");

            Console.WriteLine($"Is Sorted1 {IsSorted1(k)}");
            Reverse(r);
            Display(r);
            var xx = RemoveDuplicate(x);
            Display(x);
            Display(xx);
            RemoveDuplicateWithoutTemp(a);
            Display(a);
            Console.WriteLine("Rotate Array");
            Rotate(rr);
            Display(rr);
            RotateNTimes(rn,3);
            Display(rn);

            Console.WriteLine("Rotate Array using temp array");
            RotateNTimesWithTempArray(rnn, 5);
            Display(rnn);

            Console.WriteLine("Leader");
            Leader(l);

            Console.WriteLine("Leader Optmize");
            LeaderOptmize(l);

            Console.WriteLine("Frequency");
            Frequency(f);

            Console.WriteLine("Sum of natural numbers");
            SumNumbers(10);

            Console.WriteLine("Sorting");
            IsSorted2(ss);
            IsSorted2(ss1);
        }

        static void SumNumbers(int num)
        {
            int i = 1;
            int sum = 0;
            do {
                sum = sum + i;
                i++;
            
            }
            while (i <= num);

            Console.WriteLine(sum);
        }
        static void LeaderOptmize(int[] arr)
        {
            int currentLeader = arr[arr.Length - 1];
            Console.WriteLine(currentLeader);
            for (int i = arr.Length - 2; i > -1; i--)
            {
                if (arr[i] > currentLeader)
                {
                    currentLeader = arr[i];
                    Console.WriteLine(currentLeader);
                }
            }
        }

        static void Leader(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++) {
                bool leader = true;
                for (int j = i + 1; j < arr.Length; j++) {
                    if (arr[i] <= arr[j]){
                        leader = false;
                        break;

                    }
                   }
                if (leader) Console.WriteLine(arr[i]);
              }
            Console.WriteLine(arr[arr.Length - 1]);
        }
        //int[] f = {10,10,10,25,30,30};
        static void Frequency(int[] arr)
        {
            int prev = 0;
            for(int i=0; i< arr.Length; i++)
            {
                int count = 1;
                if (prev == arr[i]) continue;
                for (int j=i+1;j<arr.Length; j++)
                {
                    
                    if (arr[i] == arr[j]) 
                        count++;
                    else
                        break;
                }
                prev = arr[i];
                Console.WriteLine($"  {arr[i]}  {count}");

            }

        }
        //1,2,3,4,5,6
        static void RotateNTimesWithTempArray(int[] arr, int n)
        {
            n = n % arr.Length;
            if (n == 0) return;
            int[] temp = new int[n];
            for (int i = 0; i < temp.Length; i++)
                temp[i] = arr[i];

            for (int i = n, j = 0; i < arr.Length; i++, j++)
                arr[j] = arr[i];

            for (int i = 0, j = arr.Length- n; i < temp.Length; i++, j++)
                arr[j] = temp[i];


        }

        static void RotateNTimes(int[] arr, int n)
        {
            int count = 0;
            while(count < n)
            {
                int temp = arr[0];
                for (int i = 1; i < arr.Length; i++)
                    arr[i-1] = arr[i];

                arr[arr.Length - 1] = temp;
                count++;
            }

             
        }
        static void Rotate(int[] arr)
        {
            int temp = arr[0];

            for(int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = temp;
        }
        static void PrintMissingNo(int expectno, int actualno) {
          while(actualno > expectno)
            {
                Console.WriteLine(expectno);
                expectno++;
            }
        }

        static void MissingNumbers(int[] arr)
        {
            int expectno = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == expectno)
                {
                    expectno++;
                }
                else
                {
                    PrintMissingNo(expectno, arr[i]);
                    expectno = ++arr[i];
                }
            }

        }
        static int[] RemoveDuplicate(int[] arr)
        {
            int[] temp = new int[arr.Length];
            temp[0] = arr[0];
            for (int i = 1, j = 0; i < arr.Length; i++)
            {
                if (temp[j] != arr[i])
                {
                    j++;
                    temp[j] = arr[i];


                }

            }
            return temp;
        }

        /*
         10,20,20,30,30,30,30
             */


        static void IsSorted2(int[] arr)
        {
            bool sorted = true;
            for(int i = 0; i < arr.Length-1; i++) { 
             if(arr[i]> arr[i + 1])
                {
                    sorted = false;
                    break;
                }
            }
            Console.WriteLine($" Sorted {sorted}");
        }
        static void RemoveDuplicateWithoutTemp(int[] arr)
        {
            for(int i = 0,j=0; i < arr.Length; i++)
            {
             
                if (arr[i] != arr[j])
                {
                    j++;
                    arr[j] = arr[i];
                   
                }
            }
        }
        static bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = i; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                        return false;

            return true;
        }

        static void Reverse(int[] arr)
        {
            for (int i = 0, j = arr.Length - 1; i <j; i++, j--)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        static bool IsSorted1(int[] arr)
        {

            for(int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void Remove(int[] arr,int item)
        {
            int index = GetIndex(arr, item);
            if (index == -1)
                return;
            for(int i=index;i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = 0;

        }
        static int[] Move(int[] arr,int insert,int pos)
        {
            int idx = pos - 1;
            for(int i = arr.Length - 2; i >= idx; i--)
            {
                arr[i+1] = arr[i];
            }

            arr[idx] = insert;
            return arr;

        }
        
        static int[] Move1(int[] arr, int insert, int pos)
        {
            int idx = pos - 1;
            for(int i = arr.Length - 2; i <= idx; i--)
            {
                arr[i + 1] = arr[i];
            }
            arr[idx] = insert;
            return arr;
        }

        static void Display(int[] arr)
        {
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxx");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }

        static int GetIndex(string[] arr,string a)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    return i;
                    ;
                }
            }
            return -1;
        }

        static int GetIndex(int[] arr, int a)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    return i;
                    ;
                }
            }
            return -1;
        }
    }
}
