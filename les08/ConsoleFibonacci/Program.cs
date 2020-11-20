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
            Console.Write("hoeveel fibonacci gettalen wil je? ");
            int reeks = Convert.ToInt32(Console.ReadLine());
            int[] fibonacci = new int[reeks];
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for(int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                
            }
           
            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine(fibonacci[i]);
            }
            Console.Read();
        }
    }
}
