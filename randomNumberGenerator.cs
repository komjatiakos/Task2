using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotRepetetiveRandomNumberGeneratorAtLeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            while (count < 10)
            {
                var rand = new Random();
                List<int> possible = Enumerable.Range(1, 48).ToList();
                List<int> listNumbers = new List<int>();
                for (int i = 0; i < 10; i++)
                {
                    int index = rand.Next(0, possible.Count);
                    listNumbers.Add(possible[index]);
                    possible.RemoveAt(index);
                    Console.WriteLine(listNumbers[i]);
                    
                }
                count++;
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}