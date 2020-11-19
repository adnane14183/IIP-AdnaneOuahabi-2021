using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] fibonacci = new int[10];
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for(int i = 5; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                Console.WriteLine(fibonacci[i]);
            }
            Console.Read();
        }
    }
}
