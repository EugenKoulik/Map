using System;

namespace Array_Csharp_1laba
{
    class Program
    {
        static void Main(string[] args)
        {

            Map<char, int> map = new Map<char, int>();


            map.Insert('b', 1);

            map.Insert('a', 7);

            Console.WriteLine(map.Find('a').Data);

        }

    }
}
