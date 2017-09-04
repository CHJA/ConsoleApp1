using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ml = 0;
            int sp = 0;
            int len = 7000;
            int tlen = 2000;
            int step = 30;

            //ml = ((len + tlen) + sp + tlen - step) % (len + tlen);
            //sp = ml - tlen;

            // Timer timer = new Timer(100);

            ml = -2000;

            while (true)
            {
                ml = ((len + tlen) + sp + tlen - step) % (len + tlen);
                sp = ml - tlen;
                Console.WriteLine(ml + "<----->" + sp);
            }

        }
    }
}
