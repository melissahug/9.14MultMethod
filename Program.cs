using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            int b = 2;
            Console.WriteLine(a*b);    // the work is happening at this line and that is not correct. I'm not sure how to correct.
                                        //I thought I needed to have 'Double' in the WriteLine because that is the method needed to double user input.
        }
        static int Double(int a, int b)
                
        {
            int numb2 = a * b;
            return numb2;
        }
    }
}
