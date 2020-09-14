using System;
using System.Collections;
using System.Collections.Generic;
namespace HashChain
{
    class MyHash
    {
        int bucket;
        List<LinkedList<int>> table;
        public MyHash(int bucket)
        {
            this.bucket = bucket;

            table = new List<LinkedList<int>>();
            for (int i = 0; i < bucket; i++)
            {
                table.Add(new LinkedList<int>());
            }


        }

       public void Insert(int key)
        {
            int index = key % bucket;
            table[index].AddLast(key);
        }

       public bool Search(int key)
        {
            int index = key % bucket;

            return table[index].Contains(key);
        }

       public bool Remove(int key)
        {
            int index = key % bucket;
            return table[index].Remove(key);
        }
        

    }

    
    public class DoubleHash
    {
        
        int[] table;
        int bucket;

        public DoubleHash(int b)
        {
            table = new int[b];
            this.bucket = b;
            for(int i = 0; i < table.Length; i++)
            {
                table[i] = -1;
            }
        }

        private int h1(int key)
        {
            return key % this.bucket;
        }

        private int h2(int key)
        {
            int h = this.bucket - 1;
            return h - (key % h);
        }

        private int hash(int key,int s)
        {
            return (h1(key) + (h2(key) * s)) % 7;
        }
        public bool Insert(int key)
        {
            int index = h1(key);
            int s = 0;
            int intialIndex = index;

            while (true)
            {
                s++;
                if (table[index] <= -1)
                {
                    table[index] = key;
                    return true;
                }
                else
                {
                    index = hash(key, s);
                    if (intialIndex == index) return false;
                }

            }
        }
            public bool Search(int key)
            {
                int index = h1(key);
                int intialIndex = index;
                int s = 0;

                

                while (true)
                {
                    s++;
                    if (table[index] == key)
                    {
                        return true;
                    }
                    else if (table[index] == -1)
                    {
                        return false;
                    }
                    else
                    {
                        index = hash(key, s);
                    if (index == intialIndex) return false;
                    }

                } 
            }

            public bool Remove(int key)
             {
            int index = h1(key);
            int s = 0;

            while (true)
            {
                s++;
                if (table[index] == key)
                {
                    table[index] = -2;
                    return true;
                }
                else if (table[index] == -1)
                {
                    return false;
                }
                else
                {
                    index = hash(key, s);
                }

            }
        }
        }
            
    public class Start{
        public static void Main()
    {
            //StartHash();
            StartDoubleHash();
    }
        static void StartDoubleHash()
        {
            DoubleHash hash = new DoubleHash(7);
            
            Console.WriteLine($"Insert 49 -- { hash.Insert(49)}");
            Console.WriteLine($"Insert 50 -- { hash.Insert(50)}");
            Console.WriteLine($"Insert 51 -- { hash.Insert(51)}");
            Console.WriteLine($"Insert 63 -- { hash.Insert(63)}");
            Console.WriteLine($"Insert 69 -- { hash.Insert(69)}");

            Console.WriteLine($"Search 51 -- { hash.Search(51)}");
            Console.WriteLine($"Remove 51 -- { hash.Remove(51)}");
            Console.WriteLine($"Search 51 -- { hash.Search(51)}");
            Console.WriteLine($"Search 64 -- { hash.Search(64)}");



        }
        static void StartHash()
        {
            MyHash hash = new MyHash(7);
            int[] d = { 70, 71, 9, 56, 72 };
            for (int i = 0; i < d.Length; i++)
                hash.Insert(d[i]);

            Console.WriteLine($" Search 56 {hash.Search(56)}");
            Console.WriteLine($" Search 45 {hash.Search(45)}");
            Console.WriteLine($" Search 9 {hash.Search(9)}");
            Console.WriteLine($" Search 711 {hash.Search(711)}");


            Console.WriteLine($" Remove 56 {hash.Remove(56)}");
            Console.WriteLine($" Search 56 {hash.Search(56)}");
            Console.WriteLine($" Remove 9 {hash.Remove(9)}");
            Console.WriteLine($" Search 9 {hash.Search(9)}");
        }

    }

    
}
