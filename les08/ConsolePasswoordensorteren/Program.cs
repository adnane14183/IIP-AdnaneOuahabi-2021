using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePasswoordensorteren
{
    class Program
    {
        static void Main(string[] args)
        {

            string nietOk = "";
            string Ok = "";
            int welkePoging = 1;

            List<string> codes = new List<string>();
            codes.Add("klepketoe");
            codes.Add("test"); 
            codes.Add("Azerty123"); 
            codes.Add("rogier@work");
            codes.Add("paswoord");
            codes.Add("MisterNasty12");
            codes.Add("pwnz0red");
            Console.WriteLine("volledige lijst:");
            foreach (string passw in codes)
            {
                Console.WriteLine($"{welkePoging++}. {passw}");
                if (passw == "paswoord")
                {
                    nietOk = nietOk + " " + passw;
                }
               

                else if (passw.Length < 9)
                {
                    nietOk = nietOk + " " + passw;
                }
                else if (passw.ToString().Contains("@"))
                {
                    nietOk = nietOk + " " + passw;
                }

                else
                {
                    Ok = Ok + " " + passw;
                } 
            }
            Console.Write("ok:" + Ok);
            Console.WriteLine();
            Console.Write("niet Ok: " + nietOk);
            Console.ReadKey();
        }
    }
}
