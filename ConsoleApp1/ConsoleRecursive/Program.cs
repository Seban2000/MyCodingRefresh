using System;

namespace ConsoleRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPyramid();
            PrintPyramid1();
            Console.WriteLine("Print N to 1");
            PrintN(5);
            Console.WriteLine("Print 1 to N");
            Print1toN(5);

            Console.WriteLine("Factorial");
            Console.WriteLine(Factorial(4));

            Console.WriteLine("Fibnoci");
            Console.WriteLine(Fibonacci(4));

            for(int i = 0; i < 5; i++)
            {
                Console.Write($"   {Fibonacci(i)},");
            }

            Console.WriteLine("");
            Console.WriteLine("Sum of Natural Numbers");
            Console.WriteLine(SumOfN(10));

            Console.WriteLine("Palindrome ");

            char[] pp = "malayalam".ToCharArray();
            Console.WriteLine(IsPalindrome(pp, 0, pp.Length - 1));

            
            Console.WriteLine($" Josea problem {Jos(5, 3)}");
            Console.WriteLine($"Josep Problem {Josp(5, 3)}");
            
            string abc ="ABC";
            string cde = "ABC";
            Console.WriteLine(abc.Equals(cde));

            int[] mm = { 4, 6, 8, 23, 34 };
            MissingNumber(mm);
        }
        
        static bool IsPalindrome(char[] str,int start,int end) {
            if (start > end) return true;

            return (str[start] == str[end] && IsPalindrome(str, ++start, --end));
        }
        //323
        static bool IsPalNumber(int n)
        {
            int rev = 0;
            int temp = n;
            while(temp != 0)
            {
                int ld = temp % 10;
                rev = rev * 10 + ld;
                temp = temp / 10;

            }
            return n == rev;
        }

        static bool IsPalNumber1(int n)
        {
            int temp = n;
            int rev=0;
            while(temp != 0)
            {
                int id = temp % 10;
                rev = rev * 10 + id;
                temp = temp / 10;

            }
            return rev == n;
        }

        static int SumOfN(int n)
        {
            if (n == 0) return 0;
            return n + SumOfN(n - 1);
        }
        static void PrintN(int n)
        {
            if (n == 0) return;
            Console.WriteLine(n);
            PrintN(n - 1);

        }

        static void Print1toN(int n)
        {
            if (n == 0) return;
            Print1toN(n - 1);
            Console.WriteLine(n);
        }

        static int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        static int Fibonacci(int num)
        {
            if (num == 0 || num == 1)
                return num;

            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }

        //JosephusProblem
        static int Jos(int n,int k)
        {
            if (n == 1) return 0;

            return (Jos(n - 1, k) + k) % n;
        }


        static void PrintPyramid()
        {
            char alpha = 'A';
            int ctr = 1;
            for (int i = 1, l=10 ; i < 10; i++,l--)
            {
                alpha = 'A';
                for(int k = l; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= (ctr/2); j++)
                {
                    
                    Console.Write(alpha++);
                }
                alpha--;
                alpha--;
                for (int j = 0; j < (ctr/2); j++)
                {

                    Console.Write(alpha--);
                }
                ctr = ctr + 2;
                Console.WriteLine();
            }
        }

        static int DecimalToBinary(int n)
        {
            if (n== 0)
                return 0;
            return (n % 2 + 10 * DecimalToBinary(n / 2));
        }
        
        static int Josp(int n,int k)
        {
            if (n == 1)
                return 0;
            return (Josp(n - 1, k) + k) % n;
        }

        static void PrintPyramid1()
        {
            
            int ctr = 1;

            char alpha = 'A';


            for(int i = 0,l=10 ; i < 10; i++,l--)
            {
                for(int k =l; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for(int j=0;j<= ctr/2;j++)
                {
                    Console.Write(alpha++);
                }
                alpha--;
                alpha--;
                for(int j = 0; j < ctr / 2; j++)
                {
                    Console.Write(alpha--);
                }
                ctr = ctr + 2;
                Console.WriteLine();
                alpha = 'A';
            }



        }

        static void MissingNumber(int[] num)
        {
            int actual = num[0];

            for(int i = 1; i < num.Length; i++)
            {
                actual++;
                printMissingNumber(num[i], actual);
            }
        }

        static void printMissingNumber(int expected, int actual)
        {
            while (actual != expected)
            {
                Console.WriteLine(++actual);
            }
        }
    }
}



