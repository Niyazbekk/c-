using System;

namespace LAB3
{
    class Program
    {
        class HashTable
        {
            string[] k = new string[100];
            string[] v = new string[100];
            int size;

            public HashTable(string[] k, string[] v)
            {
                this.k = k;
                this.v = v;
            }

            public int Size()
            {
                size = k.Length + v.Length;
                return size;
            }
            public void Clear()
            {
                Array.Clear(k, 0, k.Length);
                Array.Clear(v, 0, v.Length);

            }
            public void put(string a, string b)
            {
                k[k.Length - 1] = a;
                v[v.Length - 1] = b;
            }
            public string getvalue()
            {
                return k[k.Length];
            }
            public void values()
            {
                for (int i = 0; i < k.Length; i++)
                {
                    Console.WriteLine(k[i]);
                }
            }
            public void IsEmpty()
            {
                for (int i = 0; i < k.Length; i++)
                {
                    if (k[i] != null)
                    {
                        Console.WriteLine("FALSE NOT EMPTY");
                    }
                    else
                    {
                        Console.WriteLine("TRUE EMPTY");
                    }
                }
            }
            public void containsKey(string c)
            {
                int count = 0;
                for (int i = 0; i < k.Length; i++)
                {
                    if (k[i] == c)
                    {
                        count++;
                    }
                }
            }
            public void getKey(string w)
            {
                int q = Array.IndexOf(v, w);
                Console.WriteLine(k[q]);
            }
            public void translate(string z, int LANG)
            {
                if (LANG == 1)
                {
                    int t = Array.IndexOf(k, z);
                    Console.WriteLine(v[t]);
                }
                else
                {
                    int j = Array.IndexOf(v, z);
                    Console.WriteLine(k[j]);
                }


            }
            static void Main(string[] args)
            {
                Console.WriteLine("Choose the Language : English(1) or Russian(2)");
                int h = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the word:");
                string f = Console.ReadLine();
                HashTable.translate(f,h);
            }
        }
    }
}
