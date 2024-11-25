using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_singleton
{
     class Program
     { 
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Singelton si = Singelton.Initialize();

            Console.WriteLine(si.GetHashCode()); 

            Singelton s2 = Singelton.Initialize();

            Console.WriteLine(s2.GetHashCode());

            Console.Read();

        }
     }
   
}

