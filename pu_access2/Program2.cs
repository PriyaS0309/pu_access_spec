using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pu_access1;     //adding pu_access1 assembly

namespace pu_access2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Sample s1 = new Sample();                     // using public methods of one assembly into another
            s1.Example();

            Console.ReadLine();
        }
    }
}
