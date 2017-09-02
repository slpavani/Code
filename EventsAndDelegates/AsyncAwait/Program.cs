using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main thread");
            Console.ReadLine();
        }

        public static async Task Method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("new Thread");

        }

        public static void LongTask()
        {
            Thread.Sleep(20000);
        }
    }
}
