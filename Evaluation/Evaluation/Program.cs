using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Evaluation
{
    class SwordGame
    {
        private char[] persons;
        private int position;
        public SwordGame(char[] persons,int pos)
        {
            this.persons = persons;
            this.position = pos;
        }

        
        public char Play()
        {
            int lastPerson = JosepusProblem(this.persons.Length, this.position) ;
            return persons[lastPerson];
                
        }
        
       private  int JosepusProblem(int n,int k)
        {
            if (n == 0)
                return 0;
            
            return (JosepusProblem(n - 1, k) + k) % n;
        }
    }

    public class Evaluate
    {
        static void Main(string[] args)
        {
            char[] persons = { 'A', 'B', 'C', 'D', 'E', 'F' };
            SwordGame game = new SwordGame(persons, 4);
            Console.WriteLine($"Winner : {game.Play()}");

            Console.WriteLine("\n\n\n");
            PrintPyramid(10);
            int[] num = { 4, 6, 8, 15, 18 };
            PrintMissingNumbers(num);
            Console.ReadLine();
        }

        static void PrintPyramid(int rows)
        {

            int ctr = 1;
            for (int i = 1, l = rows; i < 10; i++, l--)
            {
                for (int k = l; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < ctr; j++)
                {
                    if (j % 2 == 0)
                        Console.Write('X');
                    else
                        Console.Write('O');
                }

                ctr = ctr + 2;
                Console.WriteLine();
            }
        }

        static void PrintMissingNumbers(int[] arr)
        {
            int expected = arr[0];
            Console.WriteLine("\n\nMissing Numbers\n");
            for (int i = 1; i < arr.Length; i++)
            {
                expected++;
                PrintNumber(arr[i], ref expected);
            }
        }

        private static void PrintNumber(int actual,ref int expected)
        {
            while (actual != expected)
            {
                Console.Write($" {expected++}");
            }
        }
    }
}
