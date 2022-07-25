using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pu_access1
{
    public class Sample
    {
        public void Example()
        {
            Console.WriteLine("This is the examplem of public access modifiers");
        }

    }

   

   

  
    class Program1
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.Example(); 

            Console.ReadLine();

        }
    }
}
