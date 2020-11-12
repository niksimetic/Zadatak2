using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimetic1Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Upisite znakove");
            string znakovi = Console.ReadLine();

            Console.WriteLine(znakovi.Replace(" ", "_"));
            Console.ReadKey();


        }
    }
}
