/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Test4Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Thread th = new Thread(new ThreadStart(Counter));
                th.Start();
        }

        private static void Counter()
        {
            for (int i = 1; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
*/