using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            int i;
            for (i = 1; i <= 5; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            //while loop
            int x = 1;
            while(x <= 5)
            {
                Console.Write("{0} ", x);
                x++;
            }
            Console.WriteLine();

            //do while loop
            int y = 1;
            do
            {
                Console.Write("{0} ", y);
                y++;
            } while (y <= 5);

            Console.WriteLine();
        }
    }
}
