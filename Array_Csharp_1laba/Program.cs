using System;

namespace Array_Csharp_1laba
{
    class Program
    {
        static void Main(string[] args)
        {

            Map<char, int> map = new Map<char, int>();

            map.Insert('a', 1);

            map.Insert('b', 2);

            map.Insert('c', 3);

            map.Insert('d', 4);

            map.Insert('e', 5);

            map.Insert('f', 6);

            map.Insert('g', 7);

            map.Print();

            Console.WriteLine("\nRemove 2 elements (b and c) \n");

            map.Remove('b');

            //map.Remove('z');

            map.Remove('c');

            map.Remove('a');

            map.Print();

            Console.WriteLine($"\nItem with key f has data {map.Find('f').Data}\n");

            Console.WriteLine($"Item with key g has data {map.Find('g').Data}\n");

            Console.WriteLine("After clear tree\n");

            map.Clear();

            map.Print();


        }

    }
}
