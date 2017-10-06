using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            long f1 = 1, f2 = 2, f3 = 0,total=0;
            do
            {
                f3 = f1 + f2;
                if (f3 % 2 == 0)
                {
                    total += f3;
                }
                f1 = f2;
                f2 = f3;
            } while (f3 <= 4000000);
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
