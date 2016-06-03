using System;

namespace randomgen
{
    class main
    {
        static void Main(string[] args)
        {
            //RandomPRNG rand = new RandomPRNG();
            RandomGen randMT = new RandomGen();

            //Console.WriteLine(randMT.arrayToString());
            //Console.WriteLine(randMT.arrayToString(0));
            //Console.WriteLine(randMT.arrayToString(1));
            //Console.WriteLine(randMT.getNext());
            //Console.WriteLine(randMT.getNextDecimal());
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(randMT.getNext());
            }

            Console.ReadKey();
        }
    }
}
