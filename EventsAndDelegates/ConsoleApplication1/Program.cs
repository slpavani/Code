using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread obj = new Thread(RunMillionIterations);
            //obj.Start();
            Parallel.For(0, 10000, x => RunMillionIterations());
        }

        private static void RunMillionIterations()
        {

            string x = "";
            for (int i = 0; i < 10000; i++)
            {
                x = x + "s";
                Console.WriteLine(x);
            }
        }
    }
}
